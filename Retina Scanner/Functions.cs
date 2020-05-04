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

        public Rectangle GetCenter(Bitmap bmp)
        {
            BlobCounter bl = new BlobCounter(bmp);
            int i = bl.ObjectsCount;
            ExtractBiggestBlob fil2 = new ExtractBiggestBlob();

            //get position
            int x = 0;
            int y = 0;
            int h = 0;
            if (i > 0)
            {
                fil2.Apply(bmp);
                x = fil2.BlobPosition.X;
                y = fil2.BlobPosition.Y;
                h = fil2.Apply(bmp).Height;
            }

            Rectangle section = new Rectangle(new Point(x - h, y - h), new Size(3 * h, 3 * h));

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


        public int[] ImageToData(Bitmap image)
        {
            Color c;
            int rgb;
            List<int> output = new List<int>();

            for (int x = 0; x < image.Height; x += 2)
            {
                for (int y = 0; y < image.Width; y += 2)
                {
                    try
                    {
                        Color firstPixel = image.GetPixel(x, y);
                        Color secondPixel = image.GetPixel(x + 1, y);
                        Color thirdPixel = image.GetPixel(x, y + 1);
                        Color fourthPixel = image.GetPixel(x + 1, y + 1);

                        rgb = (firstPixel.R + firstPixel.G + firstPixel.B + secondPixel.R + secondPixel.G + secondPixel.B + thirdPixel.R + thirdPixel.G + thirdPixel.B + fourthPixel.R + fourthPixel.G + fourthPixel.B) / 4;
                        output.Add(rgb);
                    }
                    catch
                    {

                    }
                    
                }
            }

            return output.ToArray();
        }

        public double Confidence(int[] original, int[] match)
        {
            int confidence = 0;

            for (int i = 0; i < match.Length; i++)
            {
                try
                {
                    if (isInRange(original[i], match[i]))
                    {
                        confidence++;
                    }
                }
                catch
                {
                    break;
                }
            }

            double result = (float) confidence / match.Length;
            return Math.Round(result * 100);

        }

        bool isInRange(int number, int secondNum)
        {
            if (Enumerable.Range(number-3, number + 3).Contains(secondNum))
            {
                return true;
            } else
            {
                return false;
            }

        }
    }
}
