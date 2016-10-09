using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class frmBrightSettings : Form
    {
        frmMain frmMain;
        int[,] currentImageMatrix;
        int chosenFilterIndex = 0;
        readonly Filter[] currentFilters = { new BrightFilter(), new ContrastFilter() } ;
        
        public frmBrightSettings(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            tbBright.Tag = "Яркость: ";
            tbContrast.Tag = "Контрастность: ";
        }

        private void UpdateAllScrolls()
        {
            UpdateScroll(tbBright, lblBright);
            UpdateScroll(tbContrast, lblContrast);
        }

        private void UpdateScroll(TrackBar sb, Label lbl)
        {
            lbl.Text = $"{(string)sb.Tag}{sb.Value.ToString()}";
        }

        private void FiltrateImage(int index, TrackBar tb, Label lbl, bool isSaved)
        {
            chosenFilterIndex = index;
            UpdateScroll(tb, lbl);
            Bitmap correctedImage = currentFilters[index].Filtrate(currentImageMatrix, tb.Value);
            frmMain.SetImage(correctedImage, isSaved);
            frmMain.ShowImage();
        }

        private void tbBright_Scroll(object sender, EventArgs e)
        {
            tbContrast.Value = 0;
            UpdateAllScrolls();
            FiltrateImage(0, tbBright, lblBright, false);
        }

        private void tbContrast_Scroll(object sender, EventArgs e)
        {
            tbBright.Value = 0;
            UpdateAllScrolls();
            FiltrateImage(1, tbContrast, lblContrast, false);
        }

        private void buttonBright_Click(object sender, EventArgs e)
        {
            tbContrast.Value = 0;
            FiltrateImage(0, tbBright, lblBright, true);
            tbBright.Value = 0;
            UpdateAllScrolls();
            currentImageMatrix = frmMain.GetBackupImageMatrix();
        }

        private void frmBrightSettings_Load(object sender, EventArgs e)
        {
            currentImageMatrix = frmMain.GetBackupImageMatrix();
            tbBright.Value = 0;
            tbContrast.Value = 0;
            UpdateScroll(tbBright, lblBright);
            UpdateScroll(tbContrast, lblContrast);
        }

        private void frmBrightSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.RestoreImage();
            frmMain.ShowImage();
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            tbBright.Value = 0;
            FiltrateImage(1, tbContrast, lblContrast, true);
            tbContrast.Value = 0;
            UpdateAllScrolls();
            currentImageMatrix = frmMain.GetBackupImageMatrix();
        }
    }
}
