﻿using System;
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
        public Size InitialImageSize { get; private set; }
        
        public void Show (Form form, PictureBox box, MenuStrip mainMenu)
        {
            Point loadPoint = new Point(form.ClientSize.Width / 2 - currentImage.Width / 2, form.ClientSize.Height / 2 - currentImage.Height / 2);
            if (loadPoint.X < 0) loadPoint.X = 0;
            if (loadPoint.Y < mainMenu.Size.Height) loadPoint.Y = mainMenu.Size.Height;
            //loadPoint.X = 10;
            //loadPoint.Y = 10;
            box.Location = loadPoint;
            box.Size = currentImage.Size;
            box.Image = currentImage;
            box.Invalidate();
        }

        public void SetImage(Image img, bool isNew)
        {
            currentImage = img;
            if (isNew)
            {
                InitialImageSize = img.Size;
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
    }
}