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

namespace Mehanizam.Odabir
{
    public partial class frmProjektovanjePredmeti : Form
    {
        //PROMENLJIVE
        private DataTable TabelaDir;
        private TextBox _txtPoljeZaDodavanje = null;
        private string _GlavniDirektorijum = "";

        private string Izuzetak = "";
        private bool Greska = false;

        //PODEŠAVANJA
        public TextBox txtPoljeZaDodavanje
        {
            set { _txtPoljeZaDodavanje = value; }
            get { return _txtPoljeZaDodavanje; }
        }

        public string GlavniDirektorijum
        {
            set { _GlavniDirektorijum = value; }
            get { return _GlavniDirektorijum; }
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
        public frmProjektovanjePredmeti()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmPregled_Load(object sender, EventArgs e)
        {
            cmbKolona.SelectedIndex = 0;
            PopuniTabeluDir();
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

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if(dgvPregled.CurrentRow == null)
            {
                MessageBox.Show("Morate predhodno odabrati predmet koji želite da učitate.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtPoljeZaDodavanje.Text = Convert.ToString(dgvPregled.CurrentRow.Cells[0].Value);

            Close();
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
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopuniTabeluDir()
        {
            Izuzetak = "";
            Greska = false;

            if(string.IsNullOrWhiteSpace(GlavniDirektorijum))
            {
                Izuzetak = "Direktorijum za predmete nije podešen.";
                Greska = true;
                return;
            }

            if (!Directory.Exists(GlavniDirektorijum))
            {
                Izuzetak = "Podešeni dirktorijum '" + GlavniDirektorijum + "' je obrisan ili izmešten sa lokacije.";
                Greska = true;
                return;
            }

            TabelaDir = new DataTable();

            TabelaDir.Columns.Add("Predmet", typeof(string));

            DirectoryInfo Direktorijum = new DirectoryInfo(GlavniDirektorijum);

            foreach (DirectoryInfo d in Direktorijum.GetDirectories())
            { 
                TabelaDir.Rows.Add(d.Name);
            }

            dgvPregled.DataSource = null;
        }

        public void OsveziTabelu()
        {
            PopuniTabeluDir();
            
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
