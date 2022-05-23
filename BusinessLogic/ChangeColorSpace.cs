using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ChangeColorSpace
    {
        public Bitmap ConvertToGrayScale(string filename)
        {
            var myImage = new Image<Bgr, byte>(filename);
            return myImage.Convert<Gray, byte>().AsBitmap();
        }

        public Bitmap ConvertToYCbCr(string filename)
        {
            return null;
        }
    }
}
