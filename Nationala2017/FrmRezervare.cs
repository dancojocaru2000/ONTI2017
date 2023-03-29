using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nationala2017 {
    public partial class FrmRezervare : Form {
        private DataSetTurismDB.UtilizatoriRow User { get; set; }
        private DataSetTurismDB.VacanteRow Vacanta { get; set; }

        private decimal Pret { get; set; }

        public FrmRezervare(DataSetTurismDB.UtilizatoriRow user, DataSetTurismDB.VacanteRow vacanta) {
            InitializeComponent();
            User = user;
            Vacanta = vacanta;

            nameLabel.Text = Vacanta.NumeVacanta;
            descriptionLabel.Text = Vacanta.Descriere;
            if (File.Exists(Vacanta.CaleFisier)) {
                pictureBox1.ImageLocation = Vacanta.CaleFisier;
            }
            else {
                pictureBox1.ImageLocation = "Resurse/Imagini/implicit.jpg";
            }
            var now = DateTime.Now;
            now = now.AddHours(-now.Hour);
            now = now.AddMinutes(-now.Minute);
            now = now.AddSeconds(-now.Second);
            now = now.AddMilliseconds(-now.Millisecond);
            startDateTimePicker.MinDate = endDateTimePicker.MinDate = now;
        }

        private void RefreshPrice() {
            confirmReservationButton.Enabled = false;

            int nrPersoane;
            if (!int.TryParse(nrPersoaneTextBox.Text, out nrPersoane)) {
                return;
            }
            
            if (endDateTimePicker.Value < startDateTimePicker.Value) {
                endDateTimePicker.Value = startDateTimePicker.Value;
            }
            endDateTimePicker.MinDate = startDateTimePicker.Value;

            var rezervari = rezervariTableAdapter.GetData();
            int locuriDisponibile = Vacanta.NrLocuri;
            foreach (var rezervare in rezervari) {
                if (rezervare.IdVacanta != Vacanta.Id) {
                    continue;
                }
                if (rezervare.DataSfarsit >= startDateTimePicker.Value && rezervare.DataInceput <= endDateTimePicker.Value) {
                    locuriDisponibile -= rezervare.NrPersoane;
                }
            }
            if (locuriDisponibile < nrPersoane) {
                notAvailableLabel.Visible = true;
                return;
            }
            else {
                notAvailableLabel.Visible = false;
            }

            int nrZile = (int)(endDateTimePicker.Value.AddMinutes(1) - startDateTimePicker.Value).TotalDays + 1;

            Pret = Vacanta.Pret * nrPersoane * nrZile;
            priceLabel.Text = string.Format("Total de plata: {0:0.00} lei", Pret);
            confirmReservationButton.Enabled = Pret > 0;
        }

        private void nrPersoaneTextBox_TextChanged(object sender, EventArgs e) {
            RefreshPrice();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e) {
            RefreshPrice();
        }

        private void confirmReservationButton_Click(object sender, EventArgs e) {
            rezervariTableAdapter.Insert(Vacanta.Id, User.Id, startDateTimePicker.Value, endDateTimePicker.Value, int.Parse(nrPersoaneTextBox.Text), Pret);
            nrPersoaneTextBox.Enabled = false;
            startDateTimePicker.Enabled = false;
            endDateTimePicker.Enabled = false;
            confirmReservationButton.Enabled = false;
            confirmReservationButton.Text = "Rezervare confirmata";
            printReservationButton.Visible = true;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e) {
            float y = 8;
            e.Graphics.DrawString(Vacanta.NumeVacanta, new Font("Arial", 16), Brushes.Black, new PointF(8, y));
            y += e.Graphics.MeasureString(Vacanta.NumeVacanta, new Font("Arial", 16)).Height + 8;

            var stringPret = string.Format("{0:0.00} lei", Pret);
            e.Graphics.DrawString(stringPret, new Font("Arial", 12), Brushes.Black, new PointF(8, y));
            y += e.Graphics.MeasureString(stringPret, new Font("Arial", 12)).Height + 8;

            var stringStart = string.Format("Inceput: {0:00}.{1:00}.{2}", startDateTimePicker.Value.Day, startDateTimePicker.Value.Month, startDateTimePicker.Value.Year);
            e.Graphics.DrawString(stringStart, new Font("Arial", 12), Brushes.Black, new PointF(8, y));
            y += e.Graphics.MeasureString(stringStart, new Font("Arial", 12)).Height + 8;

            var stringEnd = string.Format("Sfarsit: {0:00}.{1:00}.{2}", endDateTimePicker.Value.Day, endDateTimePicker.Value.Month, endDateTimePicker.Value.Year);
            e.Graphics.DrawString(stringEnd, new Font("Arial", 12), Brushes.Black, new PointF(8, y));
            y += e.Graphics.MeasureString(stringEnd, new Font("Arial", 12)).Height + 8;

            y += 16;

            var stringName = string.Format("Rezervare realizata pentru {0} {1}", User.Nume, User.Prenume);
            e.Graphics.DrawString(stringName, new Font("Arial", 14), Brushes.Black, new PointF(8, y));
            y += e.Graphics.MeasureString(stringName, new Font("Arial", 14)).Height + 8;

            var stringEmail = string.Format("Email: {0}", User.Email);
            e.Graphics.DrawString(stringEmail, new Font("Arial", 12), Brushes.Black, new PointF(8, y));
            y += e.Graphics.MeasureString(stringEmail, new Font("Arial", 12)).Height + 8;

            e.Graphics.DrawImage(pictureBox1.Image, new PointF(8, y));
        }

        private void printReservationButton_Click(object sender, EventArgs e) {
            printPreviewDialog.ShowDialog();
        }
    }
}
