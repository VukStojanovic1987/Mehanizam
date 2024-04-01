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

namespace Mehanizam.Prava.Ovlascenja
{
    public partial class frmPregled : Form
    {
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
                else if (cmbKolona.Text == "Datum")
                {
                    return "Datum";
                }
                else if (cmbKolona.Text == "Lice/a koje/a daje/u ovlašćenje")
                {
                    return "OvlascenjeDao";
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

            btnAccess.Enabled = Properties.Settings.Default.OvlascenjaPristupBazi;
            btnDirektorijum.Enabled = Properties.Settings.Default.OvlascenjaPristupDirektorijumu;
            cmbKolona.SelectedIndex = 1;
            PopuniTabeluBP();

            Cursor.Current = Cursors.Default;
        }

        private void frmPregled_Shown(object sender, EventArgs e)
        {
            if (Greska == true)
            {
                MessageBox.Show(Izuzetak, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DgvAzuriraj();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            frmIndexInstanca.Podnaslov = "";
            frmIndexInstanca.lblOvlascenja.ForeColor = Color.Silver;
            Close();
            Dispose();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Greska == true)
            {
                MessageBox.Show(Izuzetak, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (frmDodaj frm = new frmDodaj())
            {
                frm.frmPregledInstanca = this;
                frm.ShowDialog();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show("Morate predhodno odabrati ovlašćenje koji želite da uredite.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            using (frmUredi frm = new frmUredi())
            {
                frm.frmPregledInstanca = this;
                frm.ID = ID;
                frm.ShowDialog();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show("Morate predhodno odabrati ovlašćenje koje želite da obrišete.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Želite li da obrišete odabrano ovlašćenje?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.OvlascenjaBaza);

            AccessBP.DodajParametre("@ID", ID);
            AccessBP.IzvrsiUpit("DELETE FROM tblOvlascenja WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(AccessBP.Izuzetak, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OsveziTabelu();
        }

        private void btnPilot_Click(object sender, EventArgs e)
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show("Morate predhodno odabrati ovlašćenje koji želite da otvorite kroz Excel.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Želite li da otvorite ovlašćenje kroz Excel?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            Cursor.Current = Cursors.WaitCursor;

            clsPilot Pilot = new clsPilot(ID);

            Cursor.Current = Cursors.Default;

            if (Pilot.Greska == true)
            {
                MessageBox.Show(Pilot.Izuzetak, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dgvPregled.Columns[1].HeaderText = "Datum";
                dgvPregled.Columns[2].HeaderText = "Lice/a koje/a daje/u ovlašćenje";
                dgvPregled.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvPregled.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopuniTabeluBP()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.OvlascenjaBaza);

            AccessBP.IzvrsiUpit("SELECT * FROM qryPregled");

            Izuzetak = AccessBP.Izuzetak;
            Greska = AccessBP.Greska;

            TabelaBP = new DataTable();
            TabelaBP = AccessBP.TabelaBP;

            dgvPregled.DataSource = null;
        }

        private void OtvoriDatotekuBaze()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.OvlascenjaBaza))
            {
                MessageBox.Show("Putanja baze nije podešena.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(Properties.Settings.Default.OvlascenjaBaza))
            {
                MessageBox.Show("Datoteka je izbrisana ili izmeštena sa postojeće putanje.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Properties.Settings.Default.OvlascenjaBaza);

            Cursor.Current = Cursors.Default;
        }

        private void OtvoriDirektorijum()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.OvlascenjaDirektorijum))
            {
                MessageBox.Show("Direktorijum za ovlašćenja nije podešen.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.OvlascenjaDirektorijum))
            {
                MessageBox.Show("Direktorijum '" + Properties.Settings.Default.OvlascenjaDirektorijum + "' je izmešten ili izbrisan.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Properties.Settings.Default.OvlascenjaDirektorijum);

            Cursor.Current = Cursors.Default;
        }

        public void OsveziTabelu()
        {
            Cursor.Current = Cursors.WaitCursor;

            PopuniTabeluBP();

            Cursor.Current = Cursors.Default;

            if (Greska == true)
            {
                MessageBox.Show(Izuzetak, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtPretraga.Text = "";
            DgvAzuriraj();
        }
    }
}
