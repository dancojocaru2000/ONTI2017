using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nationala2017 {
    public partial class FrmVacanta : Form {
        private DataSetTurismDB.UtilizatoriRow User { get; set; }
        private DataSetTurismDB.VacanteDataTable Vacante { get; set; }
        private int Index { get; set; } = 0;

        public FrmVacanta(DataSetTurismDB.UtilizatoriRow user) {
            InitializeComponent();
            User = user;
            if (user.TipCont != 0) {
                fileToolStripMenuItem.Visible = false;
            }
            emailToolStripMenuItem.Text = user.Email;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FrmVacanta_Load(object sender, EventArgs e) {
            InsertInDatabaseFromFile();
            RefreshSlideshow();
        }

        private void InsertInDatabaseFromFile() {
            // Incarcam in baza de date vacantele din fisierul text
            var linii = File.ReadAllLines("Resurse/Vacante.txt");
            var imaginiVacante = Directory.EnumerateFiles("Resurse/Imagini");
            var dateExistente = vacanteTableAdapter.GetData();
            foreach (var linie in linii) {
                var impartit = linie.Split('|');
                string fisier = "";
                foreach (var img in imaginiVacante) {
                    if (img.Contains(impartit[0])) {
                        fisier = img;
                        break;
                    }
                }
                bool exista = false;
                foreach (var data in dateExistente) {
                    if (data.NumeVacanta == impartit[0]) {
                        exista = true;
                        break;
                    }
                }
                if (!exista) {
                    vacanteTableAdapter.Insert(impartit[0], impartit[1], fisier, decimal.Parse(impartit[2]), int.Parse(impartit[3]));
                }
            }
            Vacante = vacanteTableAdapter.GetData();
        }

        private void RefreshSlideshow() {
            if (File.Exists(Vacante[Index].CaleFisier)) {
                pictureBox1.ImageLocation = Vacante[Index].CaleFisier;
            }
            else {
                pictureBox1.ImageLocation = "Resurse/Imagini/implicit.jpg";
            }
            nameLabel.Text = Vacante[Index].NumeVacanta;
            priceLabel.Text = string.Format("{0:00} Lei", Vacante[Index].Pret);
            availableLabel.Text = string.Format("{0} locuri", Vacante[Index].NrLocuri);
            descriptionLabel.Text = Vacante[Index].Descriere;
        }

        private void NextSlide() {
            Index++;
            if (Index >= Vacante.Count) {
                Index = 0;
            }
            RefreshSlideshow();
        }

        private void PreviousSlide() {
            Index--;
            if (Index < 0) {
                Index = Vacante.Count - 1;
            }
            RefreshSlideshow();
        }

        private void previousButton_Click(object sender, EventArgs e) {
            PreviousSlide();
        }

        private void nextButton_Click(object sender, EventArgs e) {
            NextSlide();
        }

        private void autoplayCheckBox_CheckedChanged(object sender, EventArgs e) {
            autoplayTimer.Enabled = autoplayCheckBox.Checked;
        }

        private void autoplayTimer_Tick(object sender, EventArgs e) {
            NextSlide();
        }

        private void reserveButton_Click(object sender, EventArgs e) {
            var formRezervare = new FrmRezervare(User, Vacante[Index]);
            formRezervare.ShowDialog();
        }

        private void adaugaAdminNouToolStripMenuItem_Click(object sender, EventArgs e) {
            new FrmAdaugaAdmin().Show();
        }
    }
}
