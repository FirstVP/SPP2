using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input.Manipulations;

namespace PhotoEditor
{
    public partial class frmMain : Form
    {
        ImageWrapper imageWrapper = new ImageWrapper();
        ImageController imageController = new ImageController();

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
            MouseWheel += Resize;
        }

        private new void Resize(object sender, MouseEventArgs e)
        {

            if (ModifierKeys.HasFlag(Keys.Control))
            {
                Image image = imageWrapper.GetImage();
                imageWrapper.SetImage(imageController.ResizeImage(imageWrapper, e.Delta), false);
                ShowImage();
            }
        }

        private void ShowImage()
        {
            imageWrapper.Show(this, pbImage, mainMenu);
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
                    Image image = new Bitmap(open_dialog.FileName);
                    imageController.Scale = 1;
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
    }
}
