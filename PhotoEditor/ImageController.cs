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
        public double Scale { get; set; } = 1;

        public Image ResizeImage(ImageWrapper imageWrapper, int direction)
        {
            Image image = imageWrapper.GetBackupImage();
            Scale += Math.Sign(direction) * resizePower;
            int width = Convert.ToInt32(Math.Round(imageWrapper.InitialImageSize.Width * Scale));
            int height = Convert.ToInt32(Math.Round(imageWrapper.InitialImageSize.Height * Scale));

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
            
    }
}
