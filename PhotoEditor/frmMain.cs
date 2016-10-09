using System;
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
            try
            {
                if (imageWrapper.GetImage() == null)
                    throw new Exception("Не открыта картинка!");
                if (ModifierKeys.HasFlag(Keys.Control))
                {                
                    imageWrapper.SetImage(imageController.ResizeImage(imageWrapper, e.Delta), true);
                    ShowImage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        public void RotateImage(byte mode)
        {
            try
            {
                if (imageWrapper.GetImage() == null)
                    throw new Exception("Не открыта картинка!");
                imageController.RotateImage(imageWrapper, mode);
                ShowImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        public void RestoreImage()
        {
            imageWrapper.RestoreImage();
        }

        public void ShowImage()
        {
            try
            {
                if (imageWrapper.GetImage() == null)
                    throw new Exception("Не открыта картинка!");
                imageWrapper.Show(panel, pbImage, mainMenu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
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
            try
            {
                if (imageWrapper.GetImage() == null)
                    throw new Exception("Не открыта картинка!");
                ShowSaveDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {           
            try
            {             
                if (e.Button == MouseButtons.Right)
                {
                    if (imageWrapper.GetImage() == null)
                        throw new Exception("Не открыта картинка!");
                    Point mousePoint = new Point(e.X, e.Y);
                    imageController.Draw(imageWrapper.GetImage(), mousePoint);
                    pbImage.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            try
            {
                if (imageWrapper.GetImage() == null)
                    throw new Exception("Не открыта картинка!");
                frmBrightSettings.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void colorBalanseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imageWrapper.GetImage() == null)
                    throw new Exception("Не открыта картинка!");
                frmColor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
    }
}
