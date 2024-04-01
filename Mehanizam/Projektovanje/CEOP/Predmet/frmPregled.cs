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
using Microsoft.VisualBasic.FileIO;
using System.Reflection;

namespace Mehanizam.Projektovanje.CEOP.Predmet
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
                else if (cmbKolona.Text == "Broj zahteva")
                {
                    return "BrojZahteva";
                }
                else if (cmbKolona.Text == "Vrsta zahteva")
                {
                    return "VrstaZahteva";
                }
                else if (cmbKolona.Text == "Naziv predmeta")
                {
                    return "NazivPredmeta";
                }
                else if (cmbKolona.Text == "Status zahteva")
                {
                    return "StatusZahteva";
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

            btnAccess.Enabled = Properties.Settings.Default.CeopPristupBazi;
            btnDirektorijum.Enabled = Properties.Settings.Default.CeopPristupDirektorijumu;
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
            frmIndexInstanca.lblCeop.ForeColor = Color.Silver;
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
                MessageBox.Show("Morate predhodno odabrati zahtev koji želite da uredite.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            foreach (Form Frm in Application.OpenForms)
            {
                if (Frm is frmUredi)
                {
                    PropertyInfo prop = Frm.GetType().GetProperty("ID");
                    if (Convert.ToInt64(prop.GetValue(Frm, null)) == ID)
                    {
                        Frm.WindowState = FormWindowState.Normal;
                        Frm.Activate();
                        return;
                    }
                }
            }

            Cursor.Current = Cursors.WaitCursor;

            frmUredi NoviFrm = new frmUredi();
            NoviFrm.frmPregledInstanca = this;
            NoviFrm.ID = ID;
            NoviFrm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show("Morate predhodno odabrati zahtev koji želite da obrišete.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string BrojZahteva = Convert.ToString(dgvPregled.CurrentRow.Cells[2].Value);
            if (IspravnostCeopDirektorijuma(BrojZahteva) == false) { return; }

            long ID = Convert.ToInt64(dgvPregled.CurrentRow.Cells[0].Value);

            foreach (Form Frm in Application.OpenForms)
            {
                if (Frm is frmUredi)
                {
                    PropertyInfo prop = Frm.GetType().GetProperty("ID");
                    if (Convert.ToInt64(prop.GetValue(Frm, null)) == ID)
                    {
                        Frm.WindowState = FormWindowState.Normal;
                        Frm.Activate();
                        MessageBox.Show("Morate predhodno zatvoriri zahtev koji želite da obrišete.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            if (MessageBox.Show("Želite li da obrišete odabrani zahtev?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.CeopBaza);

            AccessBP.DodajParametre("@ID", ID);
            AccessBP.IzvrsiUpit("DELETE FROM tblCeopZahtevi WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(AccessBP.Izuzetak, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FileSystem.DeleteDirectory(Properties.Settings.Default.CeopDirektorijum + "\\" + BrojZahteva, UIOption.AllDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);

            OsveziTabelu();
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
                dgvPregled.Columns[2].HeaderText = "Broj zahteva";
                dgvPregled.Columns[3].HeaderText = "Vrsta zahteva";
                dgvPregled.Columns[4].HeaderText = "Naziv predmeta";
                dgvPregled.Columns[5].HeaderText = "Status zahteva";

                dgvPregled.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvPregled.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopuniTabeluBP()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.CeopBaza);

            AccessBP.IzvrsiUpit("SELECT * FROM qryCeopZahteviPregled");

            Izuzetak = AccessBP.Izuzetak;
            Greska = AccessBP.Greska;

            TabelaBP = new DataTable();
            TabelaBP = AccessBP.TabelaBP;

            dgvPregled.DataSource = null;
        }

        private void OtvoriDatotekuBaze()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.CeopBaza))
            {
                MessageBox.Show("Putanja baze podataka nije podešena.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(Properties.Settings.Default.PredracuniBaza))
            {
                MessageBox.Show("Datoteka je izbrisana ili izmeštena sa postojeće putanje.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Properties.Settings.Default.CeopBaza);

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

        private void OtvoriDirektorijum()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.CeopDirektorijum))
            {
                MessageBox.Show("Direktorijum za CEOP zahteve nije podešen.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.CeopDirektorijum))
            {
                MessageBox.Show("Podešeni direktorijum '" + Properties.Settings.Default.CeopDirektorijum + "' je obrisan ili izmešten sa lokacije.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            System.Diagnostics.Process.Start(Properties.Settings.Default.CeopDirektorijum);
        }

        //FUNKCIJE
        private bool IspravnostCeopDirektorijuma(string BrojZahteva)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.CeopDirektorijum))
            {
                MessageBox.Show("Direktorijum za CEOP zahteve nije podešen.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!Directory.Exists(Properties.Settings.Default.CeopDirektorijum))
            {
                MessageBox.Show("Direktorijum '" + Properties.Settings.Default.CeopDirektorijum + "' je obrisan ili izmešten sa lokacije.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!Directory.Exists(Properties.Settings.Default.CeopDirektorijum + "\\" + BrojZahteva))
            {
                MessageBox.Show("Direktorijum zahteva '" + Properties.Settings.Default.CeopDirektorijum + "\\" + BrojZahteva + "' nije pronađen.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}
