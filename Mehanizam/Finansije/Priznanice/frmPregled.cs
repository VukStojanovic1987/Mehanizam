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

namespace Mehanizam.Finansije.Priznanice
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
                else if (cmbKolona.Text == "Broj priznanice")
                {
                    return "Broj";
                }
                else if (cmbKolona.Text == "Datum izdavanja priznanice")
                {
                    return "Datum";
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
                    return "ZaUplatu";
                }
                else if (cmbKolona.Text == "Uplatio")
                {
                    return "Uplatio";
                }
                else if (cmbKolona.Text == "Ostalo za uplatu")
                {
                    return "OstaloZaUplatu";
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

            btnAccess.Enabled = Properties.Settings.Default.PriznanicePristupBazi;
            btnDirektorijum.Enabled = Properties.Settings.Default.PriznanicePristupDirektorijumu;
            cmbKolona.SelectedIndex = 3;
            PopuniTabeluBP();

            Cursor.Current = Cursors.Default;
        }

        private void frmPregled_Shown(object sender, EventArgs e)
        {
            if (Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DgvAzuriraj();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            frmIndexInstanca.Podnaslov = "";
            frmIndexInstanca.lblPriznanice.ForeColor = Color.Silver;
            Close();
            Dispose();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                MessageBox.Show(Poruke.ObradaZapisaRed, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(Poruke.BrisanjeZapisaRed, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(Poruke.BrisanjeZapisaPitanje, "Finansije - Priznanice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.PriznaniceBaza);

            AccessBP.DodajParametre("@ID", ID);
            AccessBP.IzvrsiUpit("DELETE FROM tblPriznanice WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OsveziTabelu();
        }

        private void btnPilot_Click(object sender, EventArgs e)
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show(Poruke.PilotZapisaRed, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(Poruke.PilotZapisaPitanje, "Finansije - Priznanice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            Cursor.Current = Cursors.WaitCursor;

            clsPilot Pilot = new clsPilot(ID);

            Cursor.Current = Cursors.Default;

            if (Pilot.Greska == true)
            {
                MessageBox.Show(Pilot.Izuzetak, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dgvPregled.Columns[1].HeaderText = "Broj priznanice";
                dgvPregled.Columns[2].HeaderText = "Datum izdavanja priznanice";
                dgvPregled.Columns[3].HeaderText = "Uplatioc";
                dgvPregled.Columns[4].HeaderText = "Vrsta robe ili usluge";
                dgvPregled.Columns[5].HeaderText = "Za uplatu";
                dgvPregled.Columns[6].HeaderText = "Uplatio";
                dgvPregled.Columns[7].HeaderText = "Ostalo za uplatu";

                dgvPregled.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPregled.ClearSelection();
            }
            catch
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopuniTabeluBP()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.PriznaniceBaza);

            AccessBP.IzvrsiUpit("SELECT * FROM qryPriznanicePregled");

            Izuzetak = AccessBP.Izuzetak;
            Greska = AccessBP.Greska;

            TabelaBP = new DataTable();
            TabelaBP = AccessBP.TabelaBP;

            dgvPregled.DataSource = null;
        }

        private void OtvoriDatotekuBaze()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.PriznaniceBaza))
            {
                MessageBox.Show(Poruke.PutanjaBazeNijePodesena, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(Properties.Settings.Default.PriznaniceBaza))
            {
                MessageBox.Show(Poruke.DatotekaNijePronadjena(Properties.Settings.Default.PriznaniceBaza), "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Properties.Settings.Default.PriznaniceBaza);

            Cursor.Current = Cursors.Default;
        }

        private void OtvoriDirektorijum()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.PriznaniceDirektorijum))
            {
                MessageBox.Show(Poruke.PutanjaDirektorijumaNijePodesena, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.PriznaniceDirektorijum))
            {
                MessageBox.Show(Poruke.DirektorijumNijePronadjen(Properties.Settings.Default.PriznaniceDirektorijum), "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Properties.Settings.Default.PriznaniceDirektorijum);

            Cursor.Current = Cursors.Default;
        }

        public void OsveziTabelu()
        {
            Cursor.Current = Cursors.WaitCursor;

            PopuniTabeluBP();

            Cursor.Current = Cursors.Default;

            if (Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtPretraga.Text = "";
            DgvAzuriraj();
        }
    }
}
