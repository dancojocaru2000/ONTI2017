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
    public partial class FrmVacanteleMele : Form {
        private DataSetTurismDB.UtilizatoriRow User { get; set; }
        private List<int> IdRezervariAfisate { get; set; }

        public FrmVacanteleMele(DataSetTurismDB.UtilizatoriRow user) {
            InitializeComponent();
            User = user;
            IdRezervariAfisate = new List<int>();
        }

        private void FrmVacanteleMele_Load(object sender, EventArgs e) {
            var rezervari = rezervariTableAdapter.GetData();
            IdRezervariAfisate.Clear();
            dataGridView1.Rows.Clear();
            foreach (var rezervare in rezervari) {
                if (rezervare.IdUtilizator != User.Id) {
                    continue;
                }
                IdRezervariAfisate.Add(rezervare.Id);
                dataGridView1.Rows.Add(new object[] { vacanteTableAdapter.GetData().FindById(rezervare.IdVacanta).NumeVacanta, rezervare.DataInceput, rezervare.DataSfarsit, rezervare.NrPersoane, string.Format("{0:0.00} lei", rezervare.PretTotal), "Sterge" });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 5) {
                var idToDelete = IdRezervariAfisate[e.RowIndex];
                var data = rezervariTableAdapter.GetData();
                var rezervare = data.FindById(idToDelete);
                rezervariTableAdapter.Delete(rezervare.Id, rezervare.IdVacanta, rezervare.IdUtilizator, rezervare.DataInceput, rezervare.DataSfarsit, rezervare.NrPersoane, rezervare.PretTotal);

                FrmVacanteleMele_Load(sender, e);
            }
        }
    }
}
