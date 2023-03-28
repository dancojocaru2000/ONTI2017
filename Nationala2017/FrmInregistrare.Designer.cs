namespace Nationala2017 {
    partial class FrmInregistrare {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInregistrare));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.captchaPictureBox = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.utilizatoriTableAdapter = new Nationala2017.DataSetTurismDBTableAdapters.UtilizatoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(157, 330);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(295, 26);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parola:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(157, 298);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(295, 26);
            this.emailTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(157, 230);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(295, 26);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nume:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(157, 262);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(295, 26);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prenume:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(157, 362);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(295, 26);
            this.confirmPasswordTextBox.TabIndex = 5;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Confirmare parola:";
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Location = new System.Drawing.Point(157, 502);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(295, 26);
            this.captchaTextBox.TabIndex = 6;
            this.captchaTextBox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Captcha:";
            // 
            // captchaPictureBox
            // 
            this.captchaPictureBox.Location = new System.Drawing.Point(157, 394);
            this.captchaPictureBox.Name = "captchaPictureBox";
            this.captchaPictureBox.Size = new System.Drawing.Size(295, 102);
            this.captchaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.captchaPictureBox.TabIndex = 17;
            this.captchaPictureBox.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 557);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(178, 48);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Renunta";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(270, 557);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(178, 48);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Inregistrare";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 617);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.captchaPictureBox);
            this.Controls.Add(this.captchaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInregistrare";
            this.Text = "FrmInregistrare";
            this.Load += new System.EventHandler(this.FrmInregistrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox captchaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox captchaPictureBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button registerButton;
        private DataSetTurismDBTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
    }
}