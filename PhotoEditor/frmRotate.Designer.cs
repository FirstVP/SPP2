namespace PhotoEditor
{
    partial class frmRotate
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
            this.lblRotate = new System.Windows.Forms.Label();
            this.tbDegrees = new System.Windows.Forms.TextBox();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRotate
            // 
            this.lblRotate.AutoSize = true;
            this.lblRotate.Location = new System.Drawing.Point(21, 31);
            this.lblRotate.Name = "lblRotate";
            this.lblRotate.Size = new System.Drawing.Size(317, 17);
            this.lblRotate.TabIndex = 0;
            this.lblRotate.Text = "Повернуть на указанное количество градусов:";
            this.lblRotate.Click += new System.EventHandler(this.lblRotate_Click);
            // 
            // tbDegrees
            // 
            this.tbDegrees.Location = new System.Drawing.Point(24, 67);
            this.tbDegrees.Name = "tbDegrees";
            this.tbDegrees.ShortcutsEnabled = false;
            this.tbDegrees.Size = new System.Drawing.Size(137, 22);
            this.tbDegrees.TabIndex = 1;
            this.tbDegrees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDegrees_KeyPress);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(24, 114);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(137, 23);
            this.buttonRotate.TabIndex = 2;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // frmRotate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 180);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.tbDegrees);
            this.Controls.Add(this.lblRotate);
            this.Name = "frmRotate";
            this.Text = "frmRotate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRotate;
        private System.Windows.Forms.TextBox tbDegrees;
        private System.Windows.Forms.Button buttonRotate;
    }
}