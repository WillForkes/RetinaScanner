using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using AForge.Imaging.Filters;
using AForge.Imaging;
using System.Runtime.InteropServices;
using System.IO;

namespace Retina_Scanner
{
    class Functions
    {
        public Bitmap CropImage(Bitmap source, Rectangle section)
        {

            Bitmap bmp = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
            return bmp;
        }

        public Rectangle GetCenter(Bitmap bmp, Globals g)
        {


            BlobCounter bl = new BlobCounter(bmp);
            int i = bl.ObjectsCount;
            ExtractBiggestBlob fil2 = new ExtractBiggestBlob();

            //get position
            int x = 0;
            int y = 0;
            int h = 0;
            int width=0;
            int height=0;
            if (i > 0)
            {
                h = fil2.Apply(bmp).Height;
                x = fil2.BlobPosition.X;
                y = fil2.BlobPosition.Y;

                width = h * 2;
                height = h * 2;
                g.eyefound = true;
            }
            else
            {
                g.eyefound = false;
            }

            Rectangle section = new Rectangle(new Point((x + 50) - h, (y +50) - h), new Size(width, height));
            return section;
        }

        public Bitmap BinaryFilter(Bitmap bmp)
        {
            Threshold th = new Threshold(220);
            return th.Apply(bmp);
        }


        public Bitmap Invert(Bitmap Bmp)
        {
            Invert a = new Invert();
            Bmp = a.Apply(Bmp);
            AForge.Imaging.Image.FormatImage(ref Bmp);

            return Bmp;
        }

        public Bitmap GrayScale(Bitmap bmp)
        {
            return Grayscale.CommonAlgorithms.BT709.Apply(bmp);
        }

        public Bitmap ResizeImage(Bitmap image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        public List<float> GetHash(Bitmap img)
        {
            List<float> lResult = new List<float>();

            img = (Bitmap)img.Clone();
            for (var y = 0; y < img.Height; y++)
            {
                for (var x = 0; x < img.Width; x++)
                {
                    float hue = img.GetPixel(x, y).GetHue();

                    lResult.Add(hue);
                }

            }

            return lResult;
        }

        public double Confidence(float[] original, float[] match)
        {
            //determine the number of equal pixel (x of 256)
            int equalElements = original.Zip(match, (i, j) => isInRange(j, i-25, i+25, true)).Count(eq => eq);

            double result = (float)equalElements / 4096;
            result = Math.Round(result * 100);
            return result;

        }


        //THIS IS TO INACCURATE!

        //bool isInRange(float number, float secondNum)
        //{
        //    int num1 = Convert.ToInt32(number * 10);
        //    int num2 = Convert.ToInt32(secondNum * 10);

        //    if (Enumerable.Range(num1, num1).Contains(num2))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool isInRange(float num, float lower, float upper, bool inclusive = false)
        {
            return inclusive
                ? lower <= num && num <= upper
                : lower < num && num < upper;
        }

        public string[] subdirectories()
        {
            return Directory.GetDirectories("Data");
        }
    }
}
