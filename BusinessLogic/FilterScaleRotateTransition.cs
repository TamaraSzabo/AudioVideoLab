using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProcessEventArgs : EventArgs
    {
        public Bitmap CurrentFrame { get; set; }

        public int CurrentFrameIndex { get; set; }
    }

    public class VideoReading
    {
        private readonly string videoFilename;
        public event EventHandler<ProcessEventArgs> FrameAppeared;
        public int TotalFrame { get; private set; }
        public double Fps { get; private set; }
        public int FrameNo { get; private set; }
        public VideoReading(string videoFilename)
        {
            this.videoFilename = videoFilename;
        }



        public async void ReadMovie()
        {

            var capture = new VideoCapture(videoFilename);
            TotalFrame = (int)capture.Get(CapProp.FrameCount);
            Fps = capture.Get(CapProp.Fps);
            FrameNo = 1;
            Mat m = new Mat();
            while (FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture.QueryFrame();
                if (mat != null)
                {
                    FrameAppeared?.Invoke(this,
                        new ProcessEventArgs() { CurrentFrame = mat.ToImage<Bgr, byte>().AsBitmap(), CurrentFrameIndex = FrameNo });
                }
                await Task.Delay(1000 / Convert.ToInt16(Fps));
            }
        }
    }
    public class FilterScaleRotateTransition
    {
        public Image<Bgr, byte> ExtractRedChannelOnly(Image<Bgr, byte> img) //filtru rosu
        {
            Image<Bgr, Byte> outputImage = new Image<Bgr, byte>(img.Size);
            img.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = 0;
                    data[j, i, 1] = 0;
                }
            }
            return outputImage;
        }


        public Image<Bgr, byte> scale(Image<Bgr, byte> img, float size) //scale
        {
            return img.Resize(size, Emgu.CV.CvEnum.Inter.Cubic);
        }
        public Image<Bgr, byte> rotate(Image<Bgr, byte> img, float rotate)  //rotate
        {
            Bgr sall = new Bgr();

            var temp = img.Rotate(rotate, sall, true);
            return temp;
        }

        public List<Image<Bgr, byte>> filesFromDirectory(String directory) //img transition
        {
            string[] FileNames = Directory.GetFiles(directory, "*.jpg");
            List<Image<Bgr, byte>> listImages = new List<Image<Bgr, byte>>();
            foreach (var file in FileNames)
            {
                listImages.Add(new Image<Bgr, byte>(file));
            }
            return listImages;
        }
        public List<Image<Bgr, byte>> ComputeBlendedImages(List<Image<Bgr, byte>> imglist) //img transition
        {
            List<Image<Bgr, byte>> computedImages = new List<Image<Bgr, byte>>();
            for (int i = 0; i < imglist.Count - 1; i++)
            {
                for (double alpha = 0.0; alpha <= 1.0; alpha += 0.01)
                {
                    computedImages.Add(imglist[i + 1].AddWeighted(imglist[i], alpha, 1 - alpha, 0));
                }
            }
            return computedImages;
        }
    }
}
