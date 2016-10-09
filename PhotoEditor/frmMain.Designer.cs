namespace PhotoEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem90degrees = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem180degrees = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem270degrees = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кистьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseThicknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.colorBalanseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(75, 20);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(154, 131);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseDown);
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.изображениеToolStripMenuItem,
            this.кистьToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(838, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.saveAsToolStripMenuItem.Text = "Сохранить как...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // изображениеToolStripMenuItem
            // 
            this.изображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotate90ToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.colorBalanseToolStripMenuItem});
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            this.изображениеToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.изображениеToolStripMenuItem.Text = "Изображение";
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem90degrees,
            this.toolStripMenuItem180degrees,
            this.toolStripMenuItem270degrees});
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.rotate90ToolStripMenuItem.Text = "Повернуть на...";
            this.rotate90ToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem90degrees
            // 
            this.toolStripMenuItem90degrees.Name = "toolStripMenuItem90degrees";
            this.toolStripMenuItem90degrees.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem90degrees.Text = "90°";
            this.toolStripMenuItem90degrees.Click += new System.EventHandler(this.toolStripMenuItem90degrees_Click);
            // 
            // toolStripMenuItem180degrees
            // 
            this.toolStripMenuItem180degrees.Name = "toolStripMenuItem180degrees";
            this.toolStripMenuItem180degrees.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem180degrees.Text = "180°";
            this.toolStripMenuItem180degrees.Click += new System.EventHandler(this.toolStripMenuItem180degrees_Click);
            // 
            // toolStripMenuItem270degrees
            // 
            this.toolStripMenuItem270degrees.Name = "toolStripMenuItem270degrees";
            this.toolStripMenuItem270degrees.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem270degrees.Text = "270°";
            this.toolStripMenuItem270degrees.Click += new System.EventHandler(this.toolStripMenuItem270degrees_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.lightToolStripMenuItem.Text = "Свечение";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // кистьToolStripMenuItem
            // 
            this.кистьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseColorToolStripMenuItem,
            this.chooseThicknessToolStripMenuItem});
            this.кистьToolStripMenuItem.Name = "кистьToolStripMenuItem";
            this.кистьToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.кистьToolStripMenuItem.Text = "Кисть";
            // 
            // chooseColorToolStripMenuItem
            // 
            this.chooseColorToolStripMenuItem.Name = "chooseColorToolStripMenuItem";
            this.chooseColorToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.chooseColorToolStripMenuItem.Text = "Выбрать цвет...";
            this.chooseColorToolStripMenuItem.Click += new System.EventHandler(this.chooseColorToolStripMenuItem_Click);
            // 
            // chooseThicknessToolStripMenuItem
            // 
            this.chooseThicknessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallBrushToolStripMenuItem,
            this.averageBrushToolStripMenuItem,
            this.bigBrushToolStripMenuItem});
            this.chooseThicknessToolStripMenuItem.Name = "chooseThicknessToolStripMenuItem";
            this.chooseThicknessToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.chooseThicknessToolStripMenuItem.Text = "Выбрать размер";
            this.chooseThicknessToolStripMenuItem.Click += new System.EventHandler(this.chooseThicknessToolStripMenuItem_Click);
            // 
            // smallBrushToolStripMenuItem
            // 
            this.smallBrushToolStripMenuItem.Name = "smallBrushToolStripMenuItem";
            this.smallBrushToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.smallBrushToolStripMenuItem.Text = "Малая";
            this.smallBrushToolStripMenuItem.Click += new System.EventHandler(this.smallBrushToolStripMenuItem_Click);
            // 
            // averageBrushToolStripMenuItem
            // 
            this.averageBrushToolStripMenuItem.Name = "averageBrushToolStripMenuItem";
            this.averageBrushToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.averageBrushToolStripMenuItem.Text = "Средняя";
            this.averageBrushToolStripMenuItem.Click += new System.EventHandler(this.averageBrushToolStripMenuItem_Click);
            // 
            // bigBrushToolStripMenuItem
            // 
            this.bigBrushToolStripMenuItem.Name = "bigBrushToolStripMenuItem";
            this.bigBrushToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.bigBrushToolStripMenuItem.Text = "Большая";
            this.bigBrushToolStripMenuItem.Click += new System.EventHandler(this.bigBrushToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.pbImage);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(838, 372);
            this.panel.TabIndex = 2;
            // 
            // colorBalanseToolStripMenuItem
            // 
            this.colorBalanseToolStripMenuItem.Name = "colorBalanseToolStripMenuItem";
            this.colorBalanseToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.colorBalanseToolStripMenuItem.Text = "Баланс цвета...";
            this.colorBalanseToolStripMenuItem.Click += new System.EventHandler(this.colorBalanseToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(838, 400);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "Фоторедактор";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem90degrees;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem180degrees;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem270degrees;
        private System.Windows.Forms.ToolStripMenuItem кистьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseThicknessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBalanseToolStripMenuItem;
    }
}

