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
    public class BrigthnessContrast
    {
        public Bitmap ChangeBrigthnessAndContrast(string filename, float alpha, float beta)
        {
            Image<Bgr, byte> img = new Image<Bgr, byte>(filename);
            return img.Mul((alpha) + beta).AsBitmap();
        }

        public Bitmap GammaCorrection(string filename, double value = 0.4)
        {
            Image<Bgr, byte> img = new Image<Bgr, byte>(filename);
            img._GammaCorrect(value);
            return img.AsBitmap();
        }
    }
}
