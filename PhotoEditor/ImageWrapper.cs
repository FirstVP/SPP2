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
        Bitmap currentImage;
        Bitmap backupImage;
        
        public void Show (Panel panel, PictureBox box, MenuStrip mainMenu)
        {
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

        public void SetImage(Bitmap img, bool isBackup)
        {
            currentImage = img;
            if (isBackup)
            {
                backupImage = (Bitmap)img.Clone();
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

        internal int[,] GetBackupImageMatrix()
        {
            int[,] result = new int[backupImage.Width,backupImage.Height];
            for (int i = 0; i < backupImage.Width; i++)
            {
                for (int j = 0; j < backupImage.Height; j++)
                {
                    result[i, j] = backupImage.GetPixel(i, j).ToArgb();
                }
            }
            return result;
        }

        internal void RestoreImage()
        {
            SetImage(backupImage, false);
        }
    }
}
