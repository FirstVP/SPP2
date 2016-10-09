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
    public partial class frmColor : Form
    {
        frmMain frmMain;
        int[,] currentImageMatrix;
        int chosenFilterIndex = 0;
        readonly Filter[] currentFilters = { new RedFilter(), new GreenFilter(), new BlueFilter() };

        public frmColor(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            tbR.Tag = "Красный: ";
            tbG.Tag = "Зелёный: ";
            tbB.Tag = "Синий: ";
        }

        private void UpdateAllScrolls()
        {
            UpdateScroll(tbR, lblR);
            UpdateScroll(tbG, lblG);
            UpdateScroll(tbB, lblB);
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

        private void frmColor_Load(object sender, EventArgs e)
        {
            currentImageMatrix = frmMain.GetBackupImageMatrix();
            tbR.Value = 0;
            tbG.Value = 0;
            tbB.Value = 0;
            UpdateAllScrolls();
        }

        private void tbR_Scroll(object sender, EventArgs e)
        {
            tbG.Value = 0;
            tbB.Value = 0;
            UpdateAllScrolls();
            FiltrateImage(0, tbR, lblR, false);
        }

        private void tbG_Scroll(object sender, EventArgs e)
        {
            tbR.Value = 0;
            tbB.Value = 0;
            UpdateAllScrolls();
            FiltrateImage(1, tbG, lblG, false);
        }

        private void tbB_Scroll(object sender, EventArgs e)
        {
            tbR.Value = 0;
            tbG.Value = 0;
            UpdateAllScrolls();
            FiltrateImage(2, tbB, lblB, false);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            tbG.Value = 0;
            tbB.Value = 0;
            FiltrateImage(0, tbR, lblR, true);
            tbR.Value = 0;
            UpdateAllScrolls();
            currentImageMatrix = frmMain.GetBackupImageMatrix();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            tbR.Value = 0;
            tbB.Value = 0;
            FiltrateImage(1, tbG, lblG, true);
            tbG.Value = 0;
            UpdateAllScrolls();
            currentImageMatrix = frmMain.GetBackupImageMatrix();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            tbR.Value = 0;
            tbG.Value = 0;
            FiltrateImage(2, tbB, lblB, true);
            tbB.Value = 0;
            UpdateAllScrolls();
            currentImageMatrix = frmMain.GetBackupImageMatrix();
        }

        private void frmColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.RestoreImage();
            frmMain.ShowImage();
        }
    }
}
