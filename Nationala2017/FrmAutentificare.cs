using Nationala2017.DataSetTurismDBTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nationala2017 {
    public partial class FrmAutentificare : Form {
        public FrmAutentificare() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            emailTextBox.Text = Properties.Settings.Default.LastEmail;
        }

        private void loginButton_Click(object sender, EventArgs e) {
            var data = utilizatoriTableAdapter.GetData();
            DataSetTurismDB.UtilizatoriRow gasit = null;
            foreach (var utilizator in data) {
                if (utilizator.Email == emailTextBox.Text) {
                    if (utilizator.Parola != passwordTextBox.Text) {
                        MessageBox.Show("Parola este incorecta", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emailTextBox.Text = "";
                        passwordTextBox.Text = "";
                        return;
                    }
                    gasit = utilizator;
                    break;
                }
            }

            if (gasit  == null) {
                MessageBox.Show("Utilizatorul nu a fost gasit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Text = "";
                passwordTextBox.Text = "";
                return;
            }
            
            if (rememberEmailCheckbox.Checked) {
                var settings = Properties.Settings.Default;
                settings.LastEmail = emailTextBox.Text;
                settings.Save();
            }

            emailTextBox.Text = "";
            passwordTextBox.Text = "";

            var formVacanta = new FrmVacanta(gasit);
            formVacanta.Show();
            this.Hide();
            formVacanta.FormClosed += (sdr, args) => {
                this.Show();
            };
        }

        private void registerButton_Click(object sender, EventArgs e) {
            this.Hide();
            var registerForm = new FrmInregistrare();
            registerForm.Show();
            registerForm.FormClosed += (sdr, args) => {
                this.Show();
            };
        }
    }
}
