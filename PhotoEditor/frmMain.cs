﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input.Manipulations;

namespace PhotoEditor
{
    public partial class frmMain : Form
    {
        ImageWrapper imageWrapper = new ImageWrapper();
        ImageController imageController = new ImageController();
        frmBrightSettings frmBrightSettings;
        frmColor frmColor;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            WindowState = FormWindowState.Maximized;
            MinimumSize = Size;
            MaximumSize = Size;
            pbImage.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            BackColor = Color.Gray;
            panel.MouseWheel += Resize;
            frmBrightSettings = new frmBrightSettings(this);
            frmColor = new frmColor(this);
        }

        private new void Resize(object sender, MouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                imageWrapper.SetImage(imageController.ResizeImage(imageWrapper, e.Delta), true);
                ShowImage();               
            }
        }

        public void RotateImage(byte mode)
        {
            imageController.RotateImage(imageWrapper, mode);
            ShowImage();
        }

        public void RestoreImage()
        {
            imageWrapper.RestoreImage();
        }

        public void ShowImage()
        {
            imageWrapper.Show(panel, pbImage, mainMenu);
        }

        public void SetImage(Bitmap image, bool isNew)
        {
            imageWrapper.SetImage(image, isNew);
        }

        public int[,] GetBackupImageMatrix()
        {
            return imageWrapper.GetBackupImageMatrix();
        }

        private void ShowOpenDialog()
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Файлы изображений |*.bmp;*.jpg;*.gif;*.png";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap image = new Bitmap(open_dialog.FileName);
                    SetImage(image, true);
                    ShowImage();    
                }
                catch
                {         
                    DialogResult errorMessage = MessageBox.Show("Ошибка открытия файла",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOpenDialog();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Image image = imageWrapper.GetImage();
                imageWrapper.SetImage(imageController.ResizeImage(imageWrapper, 1), false);
                ShowImage();
            }
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmBrightSettings.ShowDialog();
        }

        private void toolStripMenuItem90degrees_Click(object sender, EventArgs e)
        {
            RotateImage(0);
        }

        private void toolStripMenuItem180degrees_Click(object sender, EventArgs e)
        {
            RotateImage(1);
        }

        private void toolStripMenuItem270degrees_Click(object sender, EventArgs e)
        {
            RotateImage(2);
        }

        private void ShowSaveDialog()
        {
            if (imageWrapper.GetImage() != null)
            {          
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Файлы изображений | *.bmp; *.jpg; *.gif; *.png";
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        imageWrapper.GetImage().Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка сохранения файла", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point mousePoint = new Point(e.X, e.Y);
                imageController.Draw(imageWrapper.GetImage(), mousePoint);
                pbImage.Invalidate();
            }           
        }

        private void chooseColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                imageController.Pen.Color = colorDialog.Color;
            }
        }

        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            imageController.previousPoint = new Point (0, 0);
        }

        private void chooseThicknessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void smallBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageController.ChooseBrushSize(0);
        }

        private void averageBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageController.ChooseBrushSize(1);
        }

        private void bigBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageController.ChooseBrushSize(2);
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrightSettings.ShowDialog();
        }

        private void colorBalanseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColor.ShowDialog();
        }
    }
}
