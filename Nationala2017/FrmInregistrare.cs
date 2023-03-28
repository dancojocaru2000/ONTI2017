using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nationala2017 {
    public partial class FrmInregistrare : Form {
        private Random random = new Random();

        private string captcha = "";

        public FrmInregistrare() {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FrmInregistrare_Load(object sender, EventArgs e) {
            NewCaptcha();
        }

        private void NewCaptcha() {
            var files = Directory.EnumerateFiles("Resurse/Logare").ToArray();
            captcha = files[random.Next(files.Length)];
            captcha = Path.GetFileName(captcha);
            captcha = captcha.Substring(0, captcha.Length - 4);
            captchaPictureBox.ImageLocation = string.Format("Resurse/Logare/{0}.png", captcha);
            captchaTextBox.Text = "";
        }

        private void registerButton_Click(object sender, EventArgs e) {
            if (captchaTextBox.Text != captcha) {
                MessageBox.Show("Catpcha gresit!");
                NewCaptcha();
                return;
            }

            if (!emailTextBox.Text.Contains("@")) {
                MessageBox.Show("Adresa de email nu este valida!");
                emailTextBox.Text = "";
                return;
            }

            if (passwordTextBox.Text.Length < 3) {
                MessageBox.Show("Parola trebuie sa aiba minim 3 caractere!");
                passwordTextBox.Text = "";
                confirmPasswordTextBox.Text = "";
                return;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text) {
                MessageBox.Show("Parolele nu se potrivesc!");
                passwordTextBox.Text = "";
                confirmPasswordTextBox.Text = "";
                return;
            }

            // Verificam ca nu este deja inregistrat
            var utilizatori = utilizatoriTableAdapter.GetData();
            foreach (var utilizator in utilizatori) {
                if (utilizator.Email == emailTextBox.Text) {
                    MessageBox.Show("Utilizatorul este inregistrat deja!");
                    emailTextBox.Text = "";
                    return;
                }
            }

            // Inregistram in baza de date
            var utilizatorNou = utilizatoriTableAdapter.Insert(lastNameTextBox.Text, firstNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text, 1);
            MessageBox.Show("Utilizator creat cu succes!");
            this.Close();
        }
    }
}
