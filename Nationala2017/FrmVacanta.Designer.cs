namespace Nationala2017 {
    partial class FrmVacanta {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVacanta));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaAdminNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaVacanteNoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacanteleMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconectareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vacanteTableAdapter = new Nationala2017.DataSetTurismDBTableAdapters.VacanteTableAdapter();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.autoplayCheckBox = new System.Windows.Forms.CheckBox();
            this.autoplayTimer = new System.Windows.Forms.Timer(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.reserveButton = new System.Windows.Forms.Button();
            this.posterButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vacanteleMeleToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaAdminNouToolStripMenuItem,
            this.adaugaVacanteNoiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // adaugaAdminNouToolStripMenuItem
            // 
            this.adaugaAdminNouToolStripMenuItem.Name = "adaugaAdminNouToolStripMenuItem";
            this.adaugaAdminNouToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.adaugaAdminNouToolStripMenuItem.Text = "Adauga Admin Nou";
            // 
            // adaugaVacanteNoiToolStripMenuItem
            // 
            this.adaugaVacanteNoiToolStripMenuItem.Name = "adaugaVacanteNoiToolStripMenuItem";
            this.adaugaVacanteNoiToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.adaugaVacanteNoiToolStripMenuItem.Text = "Adauga Vacante Noi";
            // 
            // vacanteleMeleToolStripMenuItem
            // 
            this.vacanteleMeleToolStripMenuItem.Name = "vacanteleMeleToolStripMenuItem";
            this.vacanteleMeleToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.vacanteleMeleToolStripMenuItem.Text = "Vacantele Mele";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconectareToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // deconectareToolStripMenuItem
            // 
            this.deconectareToolStripMenuItem.Name = "deconectareToolStripMenuItem";
            this.deconectareToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.deconectareToolStripMenuItem.Text = "Deconectare";
            this.deconectareToolStripMenuItem.Click += new System.EventHandler(this.deconectareToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(82, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // vacanteTableAdapter
            // 
            this.vacanteTableAdapter.ClearBeforeFill = true;
            // 
            // nextButton
            // 
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextButton.Location = new System.Drawing.Point(724, 374);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(64, 64);
            this.nextButton.TabIndex = 2;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousButton.BackgroundImage")));
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousButton.Location = new System.Drawing.Point(12, 374);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(64, 64);
            this.previousButton.TabIndex = 3;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // autoplayCheckBox
            // 
            this.autoplayCheckBox.AutoSize = true;
            this.autoplayCheckBox.Location = new System.Drawing.Point(345, 414);
            this.autoplayCheckBox.Name = "autoplayCheckBox";
            this.autoplayCheckBox.Size = new System.Drawing.Size(98, 24);
            this.autoplayCheckBox.TabIndex = 4;
            this.autoplayCheckBox.Text = "AutoPlay";
            this.autoplayCheckBox.UseVisualStyleBackColor = true;
            this.autoplayCheckBox.CheckedChanged += new System.EventHandler(this.autoplayCheckBox_CheckedChanged);
            // 
            // autoplayTimer
            // 
            this.autoplayTimer.Interval = 2000;
            this.autoplayTimer.Tick += new System.EventHandler(this.autoplayTimer_Tick);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(82, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(636, 25);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Nume";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Location = new System.Drawing.Point(82, 109);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(636, 25);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Pret";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availableLabel
            // 
            this.availableLabel.BackColor = System.Drawing.Color.Transparent;
            this.availableLabel.Location = new System.Drawing.Point(82, 154);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(636, 25);
            this.availableLabel.TabIndex = 7;
            this.availableLabel.Text = "Locuri";
            this.availableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Location = new System.Drawing.Point(82, 195);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(636, 114);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Descriere";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(327, 312);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(137, 37);
            this.reserveButton.TabIndex = 9;
            this.reserveButton.Text = "Rezerva Acum";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // posterButton
            // 
            this.posterButton.Location = new System.Drawing.Point(327, 355);
            this.posterButton.Name = "posterButton";
            this.posterButton.Size = new System.Drawing.Size(137, 37);
            this.posterButton.TabIndex = 10;
            this.posterButton.Text = "Poster";
            this.posterButton.UseVisualStyleBackColor = true;
            // 
            // FrmVacanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.posterButton);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.autoplayCheckBox);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVacanta";
            this.Text = "FrmVacanta";
            this.Load += new System.EventHandler(this.FrmVacanta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaAdminNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaVacanteNoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacanteleMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconectareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSetTurismDBTableAdapters.VacanteTableAdapter vacanteTableAdapter;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.CheckBox autoplayCheckBox;
        private System.Windows.Forms.Timer autoplayTimer;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button posterButton;
    }
}