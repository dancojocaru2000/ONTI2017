namespace Nationala2017 {
    partial class FrmVacanteleMele {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Vacanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInceput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrPersoane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sterge = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vacanteTableAdapter = new Nationala2017.DataSetTurismDBTableAdapters.VacanteTableAdapter();
            this.rezervariTableAdapter = new Nationala2017.DataSetTurismDBTableAdapters.RezervariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vacanta,
            this.DataInceput,
            this.DataFinal,
            this.NrPersoane,
            this.Pret,
            this.Sterge});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 575);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Vacanta
            // 
            this.Vacanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vacanta.HeaderText = "Vacanta";
            this.Vacanta.MinimumWidth = 8;
            this.Vacanta.Name = "Vacanta";
            this.Vacanta.ReadOnly = true;
            // 
            // DataInceput
            // 
            this.DataInceput.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataInceput.HeaderText = "Data inceput";
            this.DataInceput.MinimumWidth = 8;
            this.DataInceput.Name = "DataInceput";
            this.DataInceput.ReadOnly = true;
            this.DataInceput.Width = 136;
            // 
            // DataFinal
            // 
            this.DataFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataFinal.HeaderText = "Data final";
            this.DataFinal.MinimumWidth = 8;
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.ReadOnly = true;
            this.DataFinal.Width = 113;
            // 
            // NrPersoane
            // 
            this.NrPersoane.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NrPersoane.HeaderText = "Numar persoane";
            this.NrPersoane.MinimumWidth = 8;
            this.NrPersoane.Name = "NrPersoane";
            this.NrPersoane.ReadOnly = true;
            this.NrPersoane.Width = 150;
            // 
            // Pret
            // 
            this.Pret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pret.HeaderText = "Pret";
            this.Pret.MinimumWidth = 8;
            this.Pret.Name = "Pret";
            this.Pret.ReadOnly = true;
            this.Pret.Width = 74;
            // 
            // Sterge
            // 
            this.Sterge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sterge.HeaderText = "Sterge";
            this.Sterge.MinimumWidth = 8;
            this.Sterge.Name = "Sterge";
            this.Sterge.ReadOnly = true;
            this.Sterge.Width = 63;
            // 
            // vacanteTableAdapter
            // 
            this.vacanteTableAdapter.ClearBeforeFill = true;
            // 
            // rezervariTableAdapter
            // 
            this.rezervariTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVacanteleMele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 575);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVacanteleMele";
            this.Text = "FrmVacanteleMele";
            this.Load += new System.EventHandler(this.FrmVacanteleMele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInceput;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrPersoane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewButtonColumn Sterge;
        private DataSetTurismDBTableAdapters.VacanteTableAdapter vacanteTableAdapter;
        private DataSetTurismDBTableAdapters.RezervariTableAdapter rezervariTableAdapter;
    }
}