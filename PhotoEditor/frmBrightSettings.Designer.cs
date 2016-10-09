namespace PhotoEditor
{
    partial class frmBrightSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBright = new System.Windows.Forms.Label();
            this.buttonBright = new System.Windows.Forms.Button();
            this.tbBright = new System.Windows.Forms.TrackBar();
            this.tbContrast = new System.Windows.Forms.TrackBar();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.lblContrast = new System.Windows.Forms.Label();
            this.buttonBW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbBright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBright
            // 
            this.lblBright.AutoSize = true;
            this.lblBright.Location = new System.Drawing.Point(82, 35);
            this.lblBright.Name = "lblBright";
            this.lblBright.Size = new System.Drawing.Size(78, 17);
            this.lblBright.TabIndex = 0;
            this.lblBright.Text = "Яркость: 0";
            // 
            // buttonBright
            // 
            this.buttonBright.Location = new System.Drawing.Point(56, 143);
            this.buttonBright.Name = "buttonBright";
            this.buttonBright.Size = new System.Drawing.Size(137, 23);
            this.buttonBright.TabIndex = 2;
            this.buttonBright.Text = "Применить";
            this.buttonBright.UseVisualStyleBackColor = true;
            this.buttonBright.Click += new System.EventHandler(this.buttonBright_Click);
            // 
            // tbBright
            // 
            this.tbBright.Location = new System.Drawing.Point(59, 71);
            this.tbBright.Maximum = 100;
            this.tbBright.Minimum = -100;
            this.tbBright.Name = "tbBright";
            this.tbBright.Size = new System.Drawing.Size(134, 56);
            this.tbBright.TabIndex = 3;
            this.tbBright.Scroll += new System.EventHandler(this.tbBright_Scroll);
            // 
            // tbContrast
            // 
            this.tbContrast.Location = new System.Drawing.Point(315, 71);
            this.tbContrast.Maximum = 100;
            this.tbContrast.Minimum = -100;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(134, 56);
            this.tbContrast.TabIndex = 6;
            this.tbContrast.Scroll += new System.EventHandler(this.tbContrast_Scroll);
            // 
            // buttonContrast
            // 
            this.buttonContrast.Location = new System.Drawing.Point(315, 143);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(137, 23);
            this.buttonContrast.TabIndex = 5;
            this.buttonContrast.Text = "Применить";
            this.buttonContrast.UseVisualStyleBackColor = true;
            this.buttonContrast.Click += new System.EventHandler(this.buttonContrast_Click);
            // 
            // lblContrast
            // 
            this.lblContrast.AutoSize = true;
            this.lblContrast.Location = new System.Drawing.Point(326, 35);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(123, 17);
            this.lblContrast.TabIndex = 4;
            this.lblContrast.Text = "Контрастность: 0";
            // 
            // buttonBW
            // 
            this.buttonBW.Location = new System.Drawing.Point(140, 198);
            this.buttonBW.Name = "buttonBW";
            this.buttonBW.Size = new System.Drawing.Size(232, 23);
            this.buttonBW.TabIndex = 7;
            this.buttonBW.Text = "Сделать черно-белым";
            this.buttonBW.UseVisualStyleBackColor = true;
            this.buttonBW.Click += new System.EventHandler(this.buttonBW_Click);
            // 
            // frmBrightSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 249);
            this.Controls.Add(this.buttonBW);
            this.Controls.Add(this.tbContrast);
            this.Controls.Add(this.buttonContrast);
            this.Controls.Add(this.lblContrast);
            this.Controls.Add(this.tbBright);
            this.Controls.Add(this.buttonBright);
            this.Controls.Add(this.lblBright);
            this.Name = "frmBrightSettings";
            this.Text = "frmRotate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBrightSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmBrightSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBright;
        private System.Windows.Forms.Button buttonBright;
        private System.Windows.Forms.TrackBar tbBright;
        private System.Windows.Forms.TrackBar tbContrast;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.Button buttonBW;
    }
}