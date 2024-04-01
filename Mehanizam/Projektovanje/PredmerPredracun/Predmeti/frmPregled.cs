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
using System.Reflection;
using Microsoft.VisualBasic.FileIO;

namespace Mehanizam.Projektovanje.PredmerPredracun.Predmeti
{
    public partial class frmPregled : Form
    {
        //PROMENLJIVE
        private frmIndex _frmIndexInstanca;

        private DataTable TabelaDir;

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
                if (cmbKolona.Text == "Predmet")
                {
                    return "Predmet";
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
            btnDirektorijum.Enabled = Properties.Settings.Default.PredmerPredracunPristupDirektorijumu;
            cmbKolona.SelectedIndex = 0;
            PopuniTabeluDir();
        }

        private void frmPregled_Shown(object sender, EventArgs e)
        {
            if (Greska == true)
            {
                MessageBox.Show(Izuzetak, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DgvAzuriraj();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            frmIndexInstanca.Podnaslov = "";
            frmIndexInstanca.lblPredmeriPredracuni.ForeColor = Color.Silver;
            Close();
            Dispose();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodaj frm = new frmDodaj();
            frm.FrmInstanca = this;
            frm.ShowDialog();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            UrediPredmet();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ObrisiPredmet();
        }

        private void btnDirektorijum_Click(object sender, EventArgs e)
        {
            OtvoriDirektorijum();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            OsveziTabelu();
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
            DataView Pregled = new DataView(TabelaDir);

            try
            {
                if (!string.IsNullOrWhiteSpace(Kolona) || !string.IsNullOrWhiteSpace(txtPretraga.Text))
                {
                    Pregled.RowFilter = "CONVERT(" + Kolona + ", 'System.String') LIKE '%" + txtPretraga.Text + "%'";
                }
                dgvPregled.DataSource = Pregled;
                dgvPregled.Columns[0].HeaderText = "Predmet";
                dgvPregled.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvPregled.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopuniTabeluDir()
        {
            Izuzetak = "";
            Greska = false;

            if(string.IsNullOrWhiteSpace(Properties.Settings.Default.PredmerPredracunDirektorijum))
            {
                Izuzetak = "Direktorijum za predmer i predračun radova nije podešen.";
                Greska = true;
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.PredmerPredracunDirektorijum))
            {
                Izuzetak = "Podešeni dirktorijum '" + Properties.Settings.Default.PredmerPredracunDirektorijum + "' je obrisan ili izmešten sa lokacije.";
                Greska = true;
                return;
            }

            TabelaDir = new DataTable();

            TabelaDir.Columns.Add("Predmet", typeof(string));

            DirectoryInfo Direktorijum = new DirectoryInfo(Properties.Settings.Default.PredmerPredracunDirektorijum);

            foreach (DirectoryInfo d in Direktorijum.GetDirectories())
            { 
                TabelaDir.Rows.Add(d.Name);
            }

            dgvPregled.DataSource = null;
        }

        private void UrediPredmet()
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show("Morate predhodno odabrati predmet koji želite da otvorite.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Predmet = Convert.ToString(dgvPregled.CurrentRow.Cells[0].Value);

            if (!Directory.Exists(Properties.Settings.Default.PredmerPredracunDirektorijum + "\\" + Predmet))
            {
                MessageBox.Show("Odabrani direktorijum '" + Properties.Settings.Default.PredmerPredracunDirektorijum + "\\" + Predmet + "' je obrisan ili izmešten sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Form Frm in Application.OpenForms)
            {
                if (Frm is frmUredi)
                {
                    PropertyInfo prop = Frm.GetType().GetProperty("Direktorijum");
                    if (Convert.ToString(prop.GetValue(Frm, null)) == Properties.Settings.Default.PredmerPredracunDirektorijum + "\\" + Predmet)
                    {
                        Frm.WindowState = FormWindowState.Normal;
                        Frm.Activate();
                        return;
                    }
                }
            }

            frmUredi NoviFrm = new frmUredi();
            NoviFrm.Direktorijum = Properties.Settings.Default.PredmerPredracunDirektorijum + "\\" + Predmet;
            NoviFrm.Naslov = Predmet;
            NoviFrm.Show();
        }

        private void ObrisiPredmet()
        {
            if (dgvPregled.CurrentRow == null)
            {
                MessageBox.Show("Morate predhodno odabrati predmet koji želite da obrišete.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Predmet = Convert.ToString(dgvPregled.CurrentRow.Cells[0].Value);

            foreach (Form Frm in Application.OpenForms)
            {
                if (Frm is frmUredi)
                {
                    PropertyInfo prop = Frm.GetType().GetProperty("Direktorijum");
                    if (Convert.ToString(prop.GetValue(Frm, null)) == Properties.Settings.Default.PredmerPredracunDirektorijum + "\\" + Predmet)
                    {
                        Frm.WindowState = FormWindowState.Normal;
                        Frm.Activate();
                        MessageBox.Show("Morate predhodno zatvoriti predmet koji želite da obrišete.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            if (!Directory.Exists(Properties.Settings.Default.PredmerPredracunDirektorijum + "\\" + Predmet))
            {
                MessageBox.Show("Odabrani direktorijum '" + Properties.Settings.Default.PredmerPredracunDirektorijum + "\\" + Predmet + "' je obrisan ili izmešten sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(MessageBox.Show("Želite li da obrišete odabrani predmet?", "Mehanizam", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            FileSystem.DeleteDirectory(Properties.Settings.Default.PredmerPredracunDirektorijum + "\\" + Predmet, UIOption.AllDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);

            OsveziTabelu();
        }

        private void OtvoriDirektorijum()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.PredmerPredracunDirektorijum))
            {
                MessageBox.Show("Direktorijum za predmer i predračun radova nije podešen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.PredmerPredracunDirektorijum))
            {
                MessageBox.Show("Podešeni dirketorijum '" + Properties.Settings.Default.PredmerPredracunDirektorijum + "' je obrisan ili izmešten sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            System.Diagnostics.Process.Start(Properties.Settings.Default.PredmerPredracunDirektorijum);
        }

        public void OsveziTabelu()
        {
            PopuniTabeluDir();
            
            if (Greska == true)
            {
                MessageBox.Show(Izuzetak, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtPretraga.Text = "";
            DgvAzuriraj();
        }
    }
}
