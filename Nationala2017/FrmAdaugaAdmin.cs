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
    public partial class FrmAdaugaAdmin : Form {
        public FrmAdaugaAdmin() {
            InitializeComponent();
            RefreshUtilizatori();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e) {
            new FrmInregistrare().ShowDialog();
            RefreshUtilizatori();
        }

        private void transformButton_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedItem == null) {
                return;
            }
            var user = utilizatoriTableAdapter.GetData().First(u => u.Email == (string)comboBox1.SelectedItem);
            user.TipCont = 0;
            utilizatoriTableAdapter.Update(user);
            transformButton.Enabled = false;
            transformButton.Text = "Este deja admin";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.SelectedItem == null) {
                return;
            }
            var user = utilizatoriTableAdapter.GetData().First(u => u.Email == (string)comboBox1.SelectedItem);
            if (user.TipCont == 0) {
                transformButton.Enabled = false;
                transformButton.Text = "Este deja admin";
            }
            else {
                transformButton.Enabled = true;
                transformButton.Text = "Transforma in admin";
            }
        }

        private void RefreshUtilizatori() {
            var utilizatori = utilizatoriTableAdapter.GetData();
            comboBox1.Items.Clear();
            foreach (var user in utilizatori) {
                comboBox1.Items.Add(user.Email);
            }
        }
    }
}
