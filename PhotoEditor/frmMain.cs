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
        frmRotate frmRotate;
        
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
            frmRotate = new frmRotate(this);
        }

        private new void Resize(object sender, MouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                Image image = imageWrapper.GetImage();
                imageWrapper.SetImage(imageController.ResizeImage(imageWrapper, e.Delta), true);
                ShowImage();               
            }
        }

        public void RotateImage(float angle)
        {
            Image image = imageWrapper.GetImage();
            imageWrapper.SetImage(imageController.RotateImage(imageWrapper, angle), false);
            ShowImage();
        }

        public void ShowImage()
        {
            imageWrapper.Show(panel, pbImage, mainMenu);
        }

        private void SetImage(Image image, bool isNew)
        {
            imageWrapper.SetImage(image, isNew);
        }

        private void ShowOpenDialog()
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Файлы изображений |*.bmp;*.jpg;*.gif;*.png";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageController.Orientation = 0.0;
                    Image image = new Bitmap(open_dialog.FileName);
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
                frmRotate.ShowDialog();
        }

    }
}
