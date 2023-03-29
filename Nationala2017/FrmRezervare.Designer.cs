namespace Nationala2017 {
    partial class FrmRezervare {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRezervare));
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nrPersoaneTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmReservationButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.rezervariTableAdapter = new Nationala2017.DataSetTurismDBTableAdapters.RezervariTableAdapter();
            this.notAvailableLabel = new System.Windows.Forms.Label();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printReservationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(345, 32);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nume";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(14, 41);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(343, 145);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Descriere";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numar persoane:";
            // 
            // nrPersoaneTextBox
            // 
            this.nrPersoaneTextBox.Location = new System.Drawing.Point(500, 18);
            this.nrPersoaneTextBox.Name = "nrPersoaneTextBox";
            this.nrPersoaneTextBox.Size = new System.Drawing.Size(288, 26);
            this.nrPersoaneTextBox.TabIndex = 4;
            this.nrPersoaneTextBox.Text = "0";
            this.nrPersoaneTextBox.TextChanged += new System.EventHandler(this.nrPersoaneTextBox_TextChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(500, 50);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(288, 26);
            this.startDateTimePicker.TabIndex = 5;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(500, 82);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(288, 26);
            this.endDateTimePicker.TabIndex = 6;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data inceput:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data sfarsit:";
            // 
            // confirmReservationButton
            // 
            this.confirmReservationButton.Enabled = false;
            this.confirmReservationButton.Location = new System.Drawing.Point(575, 394);
            this.confirmReservationButton.Name = "confirmReservationButton";
            this.confirmReservationButton.Size = new System.Drawing.Size(213, 44);
            this.confirmReservationButton.TabIndex = 9;
            this.confirmReservationButton.Text = "Confirma rezervarea";
            this.confirmReservationButton.UseVisualStyleBackColor = true;
            this.confirmReservationButton.Click += new System.EventHandler(this.confirmReservationButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(575, 371);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(213, 23);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Total de plata: 0,00 lei";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rezervariTableAdapter
            // 
            this.rezervariTableAdapter.ClearBeforeFill = true;
            // 
            // notAvailableLabel
            // 
            this.notAvailableLabel.AutoSize = true;
            this.notAvailableLabel.BackColor = System.Drawing.SystemColors.Control;
            this.notAvailableLabel.ForeColor = System.Drawing.Color.Red;
            this.notAvailableLabel.Location = new System.Drawing.Point(437, 351);
            this.notAvailableLabel.Name = "notAvailableLabel";
            this.notAvailableLabel.Size = new System.Drawing.Size(351, 20);
            this.notAvailableLabel.TabIndex = 11;
            this.notAvailableLabel.Text = "Rezervarea nu este disponibila intre datele alese";
            this.notAvailableLabel.Visible = false;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printReservationButton
            // 
            this.printReservationButton.Location = new System.Drawing.Point(363, 394);
            this.printReservationButton.Name = "printReservationButton";
            this.printReservationButton.Size = new System.Drawing.Size(206, 44);
            this.printReservationButton.TabIndex = 12;
            this.printReservationButton.Text = "Imprima rezervarea";
            this.printReservationButton.UseVisualStyleBackColor = true;
            this.printReservationButton.Visible = false;
            this.printReservationButton.Click += new System.EventHandler(this.printReservationButton_Click);
            // 
            // FrmRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printReservationButton);
            this.Controls.Add(this.notAvailableLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.confirmReservationButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.nrPersoaneTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "FrmRezervare";
            this.Text = "FrmRezervare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nrPersoaneTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmReservationButton;
        private System.Windows.Forms.Label priceLabel;
        private DataSetTurismDBTableAdapters.RezervariTableAdapter rezervariTableAdapter;
        private System.Windows.Forms.Label notAvailableLabel;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button printReservationButton;
    }
}