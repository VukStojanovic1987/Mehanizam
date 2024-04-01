using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mehanizam.Finansije.Predracuni
{
    public partial class frmPregled : Form
    {
        //KLASE
        private Poruke.clsPoruke Poruke = new Poruke.clsPoruke();

        //PROMENLJIVE
        private frmIndex _frmIndexInstanca;

        private DataTable TabelaBP;

        private string Izuzetak = "";
        private bool Greska = false;

        //PODEŠAVANJA
        public frmIndex frmIndexInstanca
        {
            set { _frmIndexInstanca = value; }
            get { return _frmIndexInstanca; }
        }

        private string Kolona
        {
            get
            {
                if (cmbKolona.Text == "ID")
                {
                    return "ID";
                }
                else if (cmbKolona.Text == "Broj predračuna")
                {
                    return "Broj";
                }
                else if (cmbKolona.Text == "Datum izdavanja predračuna")
                {
                    return "DatumIzdavanja";
                }
                else if (cmbKolona.Text == "Uplatioc")
                {
                    return "Uplatioc";
                }
                else if (cmbKolona.Text == "Vrsta robe ili usluge")
                {
                    return "VrstaRobeUsluge";
                }
                else if (cmbKolona.Text == "Za uplatu")
                {
                    return "UkupnoSaPDVom";
                }
                else
                {
                    return "";
                }
            }
        }

        //KONSTRUKTOR
        public frmPregled()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmPregled_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            btnAccess.Enabled = Properties.Settings.Default.PredracuniPristupBazi;
            btnDirektorijum.Enabled = Properties.Settings.Default.PredracuniPristupDirektorijumu;
            cmbKolona.SelectedIndex = 1;
            PopuniTabeluBP();

            Cursor.Current = Cursors.Default;
        }

        private void frmPregled_Shown(object sender, EventArgs e)
        {
            if (Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Fiansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DgvAzuriraj();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            frmIndexInstanca.Podnaslov = "";
            frmIndexInstanca.lblPredracuni.ForeColor = Color.Silver;
            Close();
            Dispose();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (frmDodaj frm = new frmDodaj())
            {
                frm.FrmInstanca = this;
                frm.ShowDialog();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show(Poruke.ObradaZapisaRed, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            using (frmUredi frm = new frmUredi())
            {
                frm.FrmInstanca = this;
                frm.ID = ID;
                frm.ShowDialog();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show(Poruke.BrisanjeZapisaRed, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(Poruke.BrisanjeZapisaPitanje, "Finansije - Predračuni", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.PredracuniBaza);

            AccessBP.DodajParametre("@ID", ID);
            AccessBP.IzvrsiUpit("DELETE FROM tblPredracuni WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OsveziTabelu();
        }

        private void btnPilot_Click(object sender, EventArgs e)
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show(Poruke.PilotZapisaRed, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(Poruke.PilotZapisaPitanje, "Finansije - Predračuni", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            Cursor.Current = Cursors.WaitCursor;

            clsPilot Pilot = new clsPilot(ID);

            Cursor.Current = Cursors.Default;

            if (Pilot.Greska == true)
            {
                MessageBox.Show(Pilot.Izuzetak, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAccess_Click(object sender, EventArgs e)
        {
            OtvoriDatotekuBaze();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            OsveziTabelu();
        }

        private void btnDirektorijum_Click(object sender, EventArgs e)
        {
            OtvoriDirektorijum();
        }

        private void cmbKolona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Greska == true) { return; }

            if (!string.IsNullOrWhiteSpace(txtPretraga.Text))
            {
                txtPretraga.Text = "";
                DgvAzuriraj();
            }
        }

        private void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            if (Greska == true) { return; }

            int i = 0;

            for (i = Convert.ToInt16(Keys.A); i <= Convert.ToInt16(Keys.Z); i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    DgvAzuriraj();
                }
            }

            for (i = 48; i <= 57; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    DgvAzuriraj();
                }
            }

            for (i = 96; i <= 105; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    DgvAzuriraj();
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                DgvAzuriraj();
            }

            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                txtPretraga.Clear();
                txtPretraga.Focus();
                DgvAzuriraj();
            }
        }

        //PROCEDURE
        private void DgvAzuriraj()
        {
            DataView Pregled = new DataView(TabelaBP);

            try
            {
                if (!string.IsNullOrWhiteSpace(Kolona) || !string.IsNullOrWhiteSpace(txtPretraga.Text))
                {
                    Pregled.RowFilter = "CONVERT(" + Kolona + ", 'System.String') LIKE '%" + txtPretraga.Text + "%'";
                }
                dgvPregled.DataSource = Pregled;

                dgvPregled.Columns[0].HeaderText = "ID";
                dgvPregled.Columns[1].HeaderText = "Broj predračuna";
                dgvPregled.Columns[2].HeaderText = "Datum izdavanja predračuna";
                dgvPregled.Columns[3].HeaderText = "Uplatioc";
                dgvPregled.Columns[4].HeaderText = "Vrsta robe ili usluge";
                dgvPregled.Columns[5].HeaderText = "Za uplatu";

                dgvPregled.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPregled.ClearSelection();
            }
            catch
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopuniTabeluBP()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.PredracuniBaza);

            AccessBP.IzvrsiUpit("SELECT * FROM qryPregled");

            Izuzetak = AccessBP.Izuzetak;
            Greska = AccessBP.Greska;

            TabelaBP = new DataTable();
            TabelaBP = AccessBP.TabelaBP;

            dgvPregled.DataSource = null;
        }

        private void OtvoriDatotekuBaze()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.PredracuniBaza))
            {
                MessageBox.Show(Poruke.PutanjaBazeNijePodesena, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(Properties.Settings.Default.PredracuniBaza))
            {
                MessageBox.Show(Poruke.DatotekaNijePronadjena(Properties.Settings.Default.PredracuniBaza), "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Properties.Settings.Default.PredracuniBaza);

            Cursor.Current = Cursors.Default;
        }

        private void OtvoriDirektorijum()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.PredracuniDirektorijum))
            {
                MessageBox.Show(Poruke.PutanjaDirektorijumaNijePodesena, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.PredracuniDirektorijum))
            {
                MessageBox.Show(Poruke.DirektorijumNijePronadjen(Properties.Settings.Default.PredracuniDirektorijum), "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Properties.Settings.Default.PredracuniDirektorijum);

            Cursor.Current = Cursors.Default;
        }

        public void OsveziTabelu()
        {
            Cursor.Current = Cursors.WaitCursor;

            PopuniTabeluBP();

            Cursor.Current = Cursors.Default;

            if (Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtPretraga.Text = "";
            DgvAzuriraj();
        }
    }
}
