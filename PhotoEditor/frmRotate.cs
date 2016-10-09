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
    public partial class frmRotate : Form
    {
        frmMain frmMain;

        public frmRotate(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void lblRotate_Click(object sender, EventArgs e)
        {

        }

        private void tbDegrees_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '-')))
                    e.Handled = true;  
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
                   
        }
    }
}
