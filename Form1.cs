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
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace AudioVideoLab
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

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
        //public EventHandler<StoppedEventArgs> OnPlaybackStopped { get; private set; }

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
            float alpha = float.Parse(this.alpha_textBox.Text);
            float beta = float.Parse(beta_textBox.Text); 
        
            pictureBox1.Image = brigthnessContrast.ChangeBrigthnessAndContrast(originalImageFilename, alpha, beta); 
        }

        private void Gamma_Click(object sender, EventArgs e) //BrigthnessContrast
        {
            pictureBox1.Image = brigthnessContrast.GammaCorrection(originalImageFilename);
           
        }

        private void RedFilter(object sender, EventArgs e)
        {
            pictureBox1.Image = auxFunc.ExtractRedChannelOnly(My_Image).AsBitmap();
        }

        private void Resize_Click(object sender, EventArgs e) //FilterScaleRotateTransition
        {
            float timesZoom = 2.0F;
            pictureBox1.Image = auxFunc.scale(My_Image, timesZoom).AsBitmap();
            
        }

        private void Rotate_Click(object sender, EventArgs e) //FilterScaleRotateTransition
        {
            float rotateAngle = 45.0F;
            pictureBox1.Image = auxFunc.rotate(My_Image, rotateAngle).AsBitmap();
          
        }

        private async void BlendingImage_Click(object sender, EventArgs e) //FilterScaleRotateTransition
        {
            String path = "D:\\University\\EditareAudioVideo\\AudioVideoLab";
            var imgList = auxFunc.filesFromDirectory(path);
            var computedImages = auxFunc.ComputeBlendedImages(imgList);
            foreach (var item in computedImages)
            {
                pictureBox1.Image = item.ToBitmap();
                await Task.Delay(25);
            }
         
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

            }

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

        private void btnPlayAudio(object sender, EventArgs e) //Play Audio
        {
            string path;
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                path = OpenFile.FileName;
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }
                if (audioFile == null)
                {
                    audioFile = new AudioFileReader(path);
                    outputDevice.Init(audioFile);
                }
                outputDevice.Play();
            }
        }

        private void btnMixAudioFiles(object sender, EventArgs e) //Mix Audio Files
        {
            using (var reader1 = new AudioFileReader(@"D:\University\EditareAudioVideo\AudioVideoLab\70_G_LowFlutes_01_732.wav"))
            using (var reader2 = new AudioFileReader(@"D:\University\EditareAudioVideo\AudioVideoLab\70_G_NostalgicKeys_02_732.wav"))
            //Stuff (mp3cut.net).mp3"
            {
                var mixer = new MixingSampleProvider(new[] { reader1, reader2 });
                WaveFileWriter.CreateWaveFile16(@"D:\University\EditareAudioVideo\AudioVideoLab\mixed.wav", mixer);
            }

        }

        private void btnConvertToMp3(object sender, EventArgs e) //Convert to Mp3
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string infile = OpenFile.FileName;
                using (var reader = new MediaFoundationReader(infile))
                {
                    WaveFileWriter.CreateWaveFile(@"D:\University\EditareAudioVideo\AudioVideoLab\convertedtomp3.mp3", reader);
                }
            }
        }

        private void btnConvertToWav(object sender, EventArgs e) //Convert to Waw
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string infile = OpenFile.FileName;
                using (var reader = new Mp3FileReader(infile))
                {
                    WaveFileWriter.CreateWaveFile(@"D:\University\EditareAudioVideo\AudioVideoLab\ConvertedToWAV.wav", reader);
                }
            }
        }

        private void btnMonoToStereo(object sender, EventArgs e) //Mono to Stereo
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                using (var inputReader = new AudioFileReader(OpenFile.FileName))
                {
                    var stereo = new MonoToStereoSampleProvider(inputReader);
                    stereo.LeftVolume = 0.0f; // silence in left channel
                    stereo.RightVolume = 1.0f; // full volume in right channel
                    WaveFileWriter.CreateWaveFile16(@"D:\University\EditareAudioVideo\AudioVideoLab\ConvertedToStereo.wav", stereo);
                }
            }
        }

        private void btnStereoToMono(object sender, EventArgs e) //Stereo to Mono
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                using (var inputReader = new AudioFileReader(OpenFile.FileName))
                {
                    var mono = new StereoToMonoSampleProvider(inputReader);
                    mono.LeftVolume = 0.0f; // discard the left channel
                    mono.RightVolume = 1.0f; // keep the right channel

                    WaveFileWriter.CreateWaveFile16(@"D:\University\EditareAudioVideo\AudioVideoLab\ConvertedToMono.wav", mono);
                }
            }
        }

        private void btnConcatenateAudioFiles(object sender, EventArgs e) //Concatenate Audio Files
        {
            var first = new AudioFileReader(@"D:\University\EditareAudioVideo\AudioVideoLab\70_G_LowFlutes_01_732.wav");
            var second = new AudioFileReader(@"D:\University\EditareAudioVideo\AudioVideoLab\70_G_NostalgicKeys_02_732.wav");
            var third = new AudioFileReader(@"D:\University\EditareAudioVideo\AudioVideoLab\85_F_DreamStateArp_732.wav");

            var playlist = new ConcatenatingSampleProvider(new[] { first, second, third });
            WaveFileWriter.CreateWaveFile16(@"D:\University\EditareAudioVideo\AudioVideoLab\playlist.wav", playlist);
        }

        private void btnResampler(object sender, EventArgs e)
        {
            int outRate = 16000;
            var outFile = @"D:\University\EditareAudioVideo\AudioVideoLab\test resampled MF.wav";
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new Mp3FileReader(OpenFile.FileName))
                {
                    var outFormat = new WaveFormat(outRate, reader.WaveFormat.Channels);
                    using (var resampler = new MediaFoundationResampler(reader, outFormat))
                    {
                        resampler.ResamplerQuality = 20;
                        WaveFileWriter.CreateWaveFile(outFile, resampler);
                    }
                }
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

    }
}
