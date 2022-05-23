using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;


namespace AudioVideoLab
{
    public partial class Form1 : Form
    {
        private string originalImageFilename;
        private readonly BrigthnessContrast brigthnessContrast = new BrigthnessContrast();
        BusinessLogic.FilterScaleRotateTransition auxFunc = new BusinessLogic.FilterScaleRotateTransition();

        private Image<Gray, byte> imgOutput;
        private Image<Bgr, Byte> My_Image;
        private Image<Gray, byte> gray_image;
        private Image<Bgr, Byte> gamma__Picture;
        private Image<Bgr, Byte> resized_image;
        private Image<Bgr, Byte> rotate_image;
        Rectangle rect; Point StartROI;
        new bool MouseDown;

        private static VideoCapture cameraCapture;
        private static Image<Bgr, Byte> newBackgroundImage;
        private static IBackgroundSubtractor fgDetector;
        public Form1()
        {
            InitializeComponent();
        }

        public object Openfile { get; private set; }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                originalImageFilename = Openfile.FileName;
                My_Image = new Image<Bgr, byte>(Openfile.FileName);
                Image image = pictureBox1.Image = My_Image.ToBitmap();

            }
        }

        private void GreyImage_Click(object sender, EventArgs e) //ChangeColorSpace
        {

            // gray_image = My_Image.Convert<Gray, byte>();
            // pictureBox1.Image = gray_image.AsBitmap();
            //gray_image[0, 0] = new Gray(200);
            var colorSpace = new ChangeColorSpace();
            pictureBox1.Image = colorSpace.ConvertToGrayScale(originalImageFilename);

        }

        private void Histogram_Click(object sender, EventArgs e)
        {
            HistogramViewer v = new HistogramViewer();
            v.HistogramCtrl.GenerateHistograms(My_Image, 255);
            v.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Brightness_Click(object sender, EventArgs e) //BrigthnessContrast
        {
            float alpha = float.Parse(this.alpha_textBox.Text);//keep
            float beta = float.Parse(beta_textBox.Text); //keep
            //imgOutput = new Image<Gray, Byte>(gray_image.Width, gray_image.Height);
            //for (int i = 0; i < gray_image.Height; i++)
            //    for (int j = 0; j < gray_image.Width; j++)
            //    {
            //        var formula = gray_image[i, j].Intensity * alpha + beta;
            //        imgOutput[i, j] = new Gray(formula);
            //    }
            pictureBox1.Image = brigthnessContrast.ChangeBrigthnessAndContrast(originalImageFilename, alpha, beta); //keep
        }

        private void Gamma_Click(object sender, EventArgs e) //BrigthnessContrast
        {
            pictureBox1.Image = brigthnessContrast.GammaCorrection(originalImageFilename);
            //float gamma = float.Parse(gamma_textBox.Text);
            //gamma__Picture = My_Image;
            //gamma__Picture._GammaCorrect(gamma);
            //pictureBox1.Image = gamma__Picture.AsBitmap();

        }

        private void RedFilter(object sender, EventArgs e)
        {
            pictureBox1.Image = auxFunc.ExtractRedChannelOnly(My_Image).AsBitmap();
        }

        private void Resize_Click(object sender, EventArgs e) //FilterScaleRotateTransition
        {
            float timesZoom = 2.0F;
            pictureBox1.Image = auxFunc.scale(My_Image, timesZoom).AsBitmap();
            //resized_image = new Image<Bgr, Byte>(My_Image.Width, My_Image.Height);
            //resized_image = My_Image.Resize(256, 128, Emgu.CV.CvEnum.Inter.Nearest);
            //pictureBox1.Image = resized_image.AsBitmap();
        }

        private void Rotate_Click(object sender, EventArgs e) //FilterScaleRotateTransition
        {
            float rotateAngle = 45.0F;
            pictureBox1.Image = auxFunc.rotate(My_Image, rotateAngle).AsBitmap();
            //rotate_image = new Image<Bgr, Byte>(My_Image.Width, My_Image.Height);
            //rotate_image = My_Image.Rotate(90, new Bgr(255, 255, 255));
            //pictureBox1.Image = rotate_image.AsBitmap();
        }

        private async void BlendingImage_Click(object sender, EventArgs e) //FilterScaleRotateTransition
        {
            String path = "C:\\Users\\asus\\Documents\\GitHub\\EditareAudioVideo\\EditareAudioVideo";
            var imgList = auxFunc.filesFromDirectory(path);
            var computedImages = auxFunc.ComputeBlendedImages(imgList);
            foreach (var item in computedImages)
            {
                pictureBox1.Image = item.ToBitmap();
                await Task.Delay(25);
            }
            //string[] FileNames = Directory.GetFiles(@"C:\Users\asus\Documents\GitHub\EditareAudioVideo\EditareAudioVideo", "*.png");
            //List<Image<Bgr, byte>> listImages = new List<Image<Bgr, byte>>();
            //foreach (var file in FileNames)
            //{
            //    listImages.Add(new Image<Bgr, byte>(file));
            //}
            //for (int i = 0; i < listImages.Count - 1; i++)
            //{
            //    for (double alpha = 0.0; alpha <= 1.0; alpha += 0.01)
            //    {
            //        pictureBox1.Image = listImages[i + 1].AddWeighted(listImages[i], alpha, 1 - alpha, 0).AsBitmap();
            //        await Task.Delay(25);
            //    }
            //}

        }

        private void ChangeColorSpace_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> outputImage = new Image<Bgr, byte>(My_Image.Size);
            My_Image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = 0;
                    data[j, i, 1] = 0;
                }
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
            int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
            rect = new Rectangle(Math.Min(StartROI.X, e.X),
            Math.Min(StartROI.Y, e.Y), width, height);
            Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            if (pictureBox1.Image == null || rect == Rectangle.Empty)
            {
                return;
            }
            var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
            img.ROI = rect;
            var imgROI = img.Copy();
            pictureBox1.Image = imgROI.ToBitmap();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            StartROI = e.Location;
        }

        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;

        private void VideoCapture_Click(object sender, EventArgs e) //FilterScaleRotateTransition
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                VideoReading videoReading = new VideoReading(ofd.FileName);
                videoReading.FrameAppeared += videoReading_FrameAppeared;
                videoReading.ReadMovie();

                //capture = new VideoCapture(ofd.FileName);
                //Mat m = new Mat();
                //capture.Read(m);
                //pictureBox1.Image = m.ToBitmap();

                //TotalFrame = (int)capture.Get(CapProp.FrameCount);
                //Fps = capture.Get(CapProp.Fps);
                //FrameNo = 1;
                //NumericUpDown numericUpDown1 = new NumericUpDown();

                //numericUpDown1.Value = FrameNo;
                //numericUpDown1.Minimum = 0;
                //numericUpDown1.Maximum = TotalFrame;

            }

            //if (capture == null)
            //{
            //    return;
            //}
            //IsReadingFrame = true;
            //ReadAllFrames();

        }

        private void videoReading_FrameAppeared(object sender, ProcessEventArgs e)
        {
            pictureBox1.Image = e.CurrentFrame;
        }

        private void WritingToVideo_Click(object sender, EventArgs e)
        {
            VideoCapture capture = new VideoCapture(@"D:\University\Editare si Productie Audio-Video\AudioVideoLab\Do. Or do not. There is no try.mpg");

            int Fourcc = Convert.ToInt32(capture.Get(CapProp.FourCC));
            int Width = Convert.ToInt32(capture.Get(CapProp.FrameWidth));
            int Height = Convert.ToInt32(capture.Get(CapProp.FrameHeight));
            var Fps = capture.Get(CapProp.Fps);
            var TotalFrame = capture.Get(CapProp.FrameCount);

            string destionpath = @"D:\University\Editare si Productie Audio-Video\AudioVideoLab\ceva.mpg";
            using (VideoWriter writer = new VideoWriter(destionpath, Fourcc, Fps, new Size(480, 320), true))
            {
                Image<Bgr, byte> logo = new Image<Bgr, byte>(@"D:\University\Editare si Productie Audio-Video\AudioVideoLab\logo.png");
                Mat m = new Mat();

                var FrameNo = 1;
                while (FrameNo < TotalFrame)
                {
                    capture.Read(m);
                    Image<Bgr, byte> img = m.ToImage<Bgr, byte>();
                    img.ROI = new Rectangle(Width - logo.Width - 30, 10, logo.Width, logo.Height);
                    logo.CopyTo(img);

                    img.ROI = Rectangle.Empty;

                    writer.Write(img.Mat);
                    FrameNo++;
                }
            }
        }



        private void ProcessFrames(object e, EventArgs i)
        {
            if (newBackgroundImage == null) return;
            Mat frame = cameraCapture.QueryFrame();
            Image<Bgr, byte> frameImage = frame.ToImage<Bgr, Byte>();

            Mat foregroundMask = new Mat();
            fgDetector.Apply(frame, foregroundMask);
            var foregroundMaskImage = foregroundMask.ToImage<Gray, Byte>();
            foregroundMaskImage = foregroundMaskImage.Not();
            //newBackgroundImage = frame.ToImage<Bgr, Byte>();

            var copyOfNewBackgroundImage = newBackgroundImage.Resize(foregroundMaskImage.Width, foregroundMaskImage.Height, Inter.Lanczos4);
            copyOfNewBackgroundImage = copyOfNewBackgroundImage.Copy(foregroundMaskImage);

            foregroundMaskImage = foregroundMaskImage.Not();
            frameImage = frameImage.Copy(foregroundMaskImage);
            frameImage = frameImage.Or(copyOfNewBackgroundImage);

            pictureBox1.Image = frameImage.ToBitmap();
        }

        private void BackgroundSubstraction(object sender, EventArgs e)
        {
            try
            {
                cameraCapture = new VideoCapture();
                fgDetector = new BackgroundSubtractorMOG2();
                Application.Idle += ProcessFrames;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private async void ReadAllFrames()
        {

            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture.QueryFrame();
                pictureBox1.Image = mat.ToBitmap();
                await Task.Delay(1000 / Convert.ToInt16(Fps));
                label3.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
            }
        }
    }
}
