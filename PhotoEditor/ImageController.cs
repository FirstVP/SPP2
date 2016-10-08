using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PhotoEditor
{
    public class ImageController
    {
        const double resizePower = 0.01;
        const int circleDegrees = 360;
        public static double Orientation { get; set; } = 0;

        public Image ResizeImage(ImageWrapper imageWrapper, int direction)
        {
            Image image = imageWrapper.GetBackupImage();
            double scale = 1.0;
            scale += Math.Sign(direction) * resizePower;
            int width = Convert.ToInt32(Math.Round(image.Width * scale));
            int height = Convert.ToInt32(Math.Round(image.Height * scale));

            var resizedRect = new Rectangle(0, 0, width, height);
            var resizedImage = new Bitmap(width, height);

            resizedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, resizedRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return resizedImage;

        }

        public void ChangeImageAngle(double angle)
        {
            Orientation += angle;
            Orientation %= circleDegrees;
        }
        
    }
}
