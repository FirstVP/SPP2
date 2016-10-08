using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoEditor
{
    public class ImageWrapper
    {
        Image currentImage;
        Image backupImage;
        
        public void Show (Panel panel, PictureBox box, MenuStrip mainMenu)
        {
            currentImage = RotateImage();
            Point loadPoint = new Point(panel.ClientSize.Width / 2 - currentImage.Width / 2, panel.ClientSize.Height / 2 - currentImage.Height / 2);
            if (loadPoint.X < 0) loadPoint.X = 0;
            if (loadPoint.Y < mainMenu.Size.Height) loadPoint.Y = mainMenu.Size.Height;
            loadPoint.X -= panel.HorizontalScroll.Value;
            loadPoint.Y -= panel.VerticalScroll.Value;
            box.Location = loadPoint;     
            box.Size = currentImage.Size;
            box.Image = currentImage;
            box.Invalidate();
        }

        public void SetImage(Image img, bool isBackup)
        {
            currentImage = img;
            if (isBackup)
            {
                backupImage = (Image)img.Clone();
            }          
           GC.Collect();
        } 

        public Image GetImage()
        {
            return currentImage;
        }

        public Image GetBackupImage()
        {
            return backupImage;
        }

        public Image RotateImage()
        {
            Image image = GetBackupImage();

            const double pi2 = Math.PI / 2.0;

            double oldWidth = image.Width;
            double oldHeight = image.Height;

            double theta = (ImageController.Orientation) * Math.PI / 180.0;
            double locked_theta = theta;

            double newWidth, newHeight;
            int nWidth, nHeight;

            double adjacentTop, oppositeTop;
            double adjacentBottom, oppositeBottom;

            if ((locked_theta >= 0.0 && locked_theta < pi2) ||
                (locked_theta >= Math.PI && locked_theta < (Math.PI + pi2)))
            {
                adjacentTop = Math.Abs(Math.Cos(locked_theta)) * oldWidth;
                oppositeTop = Math.Abs(Math.Sin(locked_theta)) * oldWidth;

                adjacentBottom = Math.Abs(Math.Cos(locked_theta)) * oldHeight;
                oppositeBottom = Math.Abs(Math.Sin(locked_theta)) * oldHeight;
            }
            else
            {
                adjacentTop = Math.Abs(Math.Sin(locked_theta)) * oldHeight;
                oppositeTop = Math.Abs(Math.Cos(locked_theta)) * oldHeight;

                adjacentBottom = Math.Abs(Math.Sin(locked_theta)) * oldWidth;
                oppositeBottom = Math.Abs(Math.Cos(locked_theta)) * oldWidth;
            }

            newWidth = adjacentTop + oppositeBottom;
            newHeight = adjacentBottom + oppositeTop;

            nWidth = (int)Math.Ceiling(newWidth);
            nHeight = (int)Math.Ceiling(newHeight);

            Bitmap rotatedBmp = new Bitmap(nWidth, nHeight);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {

                Point[] points;

                if (locked_theta >= 0.0 && locked_theta < pi2)
                {
                    points = new Point[] {
                                             new Point( (int) oppositeBottom, 0 ),
                                             new Point( nWidth, (int) oppositeTop ),
                                             new Point( 0, (int) adjacentBottom )
                                         };

                }
                else if (locked_theta >= pi2 && locked_theta < Math.PI)
                {
                    points = new Point[] {
                                             new Point( nWidth, (int) oppositeTop ),
                                             new Point( (int) adjacentTop, nHeight ),
                                             new Point( (int) oppositeBottom, 0 )
                                         };
                }
                else if (locked_theta >= Math.PI && locked_theta < (Math.PI + pi2))
                {
                    points = new Point[] {
                                             new Point( (int) adjacentTop, nHeight ),
                                             new Point( 0, (int) adjacentBottom ),
                                             new Point( nWidth, (int) oppositeTop )
                                         };
                }
                else
                {
                    points = new Point[] {
                                             new Point( 0, (int) adjacentBottom ),
                                             new Point( (int) oppositeBottom, 0 ),
                                             new Point( (int) adjacentTop, nHeight )
                                         };
                }

                g.DrawImage(image, points);
            }

            return rotatedBmp;
        }
    }
}
