namespace PhotoEditor
{
    partial class frmColor
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
            this.tbG = new System.Windows.Forms.TrackBar();
            this.buttonG = new System.Windows.Forms.Button();
            this.lblG = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.buttonR = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.buttonB = new System.Windows.Forms.Button();
            this.lblB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            this.SuspendLayout();
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(211, 97);
            this.tbG.Maximum = 100;
            this.tbG.Minimum = -100;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(134, 56);
            this.tbG.TabIndex = 12;
            this.tbG.Scroll += new System.EventHandler(this.tbG_Scroll);
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(211, 169);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(137, 23);
            this.buttonG.TabIndex = 11;
            this.buttonG.Text = "Применить";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(228, 61);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(83, 17);
            this.lblG.TabIndex = 10;
            this.lblG.Text = "Зелёный: 0";
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(27, 97);
            this.tbR.Maximum = 100;
            this.tbR.Minimum = -100;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(134, 56);
            this.tbR.TabIndex = 9;
            this.tbR.Scroll += new System.EventHandler(this.tbR_Scroll);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(24, 169);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(137, 23);
            this.buttonR.TabIndex = 8;
            this.buttonR.Text = "Применить";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(50, 61);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(82, 17);
            this.lblR.TabIndex = 7;
            this.lblR.Text = "Красный: 0";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(400, 97);
            this.tbB.Maximum = 100;
            this.tbB.Minimum = -100;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(134, 56);
            this.tbB.TabIndex = 15;
            this.tbB.Scroll += new System.EventHandler(this.tbB_Scroll);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(400, 169);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(137, 23);
            this.buttonB.TabIndex = 14;
            this.buttonB.Text = "Применить";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(424, 61);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(65, 17);
            this.lblB.TabIndex = 13;
            this.lblB.Text = "Синий: 0";
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 253);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.lblR);
            this.Name = "frmColor";
            this.Text = "Изменение цветового баланса";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmColor_FormClosing);
            this.Load += new System.EventHandler(this.frmColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TrackBar tbR;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Label lblB;
    }
}