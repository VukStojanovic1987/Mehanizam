using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanizam.Odabir
{
    public partial class frmTekuciRacuni : Form
    {
        //KLASE
        Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.InformacijeBaza);

        //PROMENLJIVE
        private TextBox _txtUplatioc = null;
        private TextBox _txtPrimaoc = null;
        private TextBox _txtTekuciRacun = null;

        private DataTable TabelaBP;

        private string ImeNaziv = "";
        private string _Mesto = "";
        private string _PostanskiBroj = "";
        private string _UlicaBroj = "";
        private string Banka = "";
        private string TekuciRacun = "";

        //PODEŠAVANJA
        public TextBox txtUplatioc
        {
            set { _txtUplatioc = value; }
            get { return _txtUplatioc; }
        }
        public TextBox txtPrimaoc
        {
            set { _txtPrimaoc = value; }
            get { return _txtPrimaoc; }
        }
        public TextBox txtTekuciRacun
        {
            set { _txtTekuciRacun = value; }
            get { return _txtTekuciRacun; }
        }
        private string Kolona
        {
            get
            {
                if (cmbKolona.Text == "ID")
                {
                    return "ID";
                }
                else if (cmbKolona.Text == "Tip lica")
                {
                    return "TipLica";
                }
                else if (cmbKolona.Text == "Ime i prezime/Naziv privrednog društva")
                {
                    return "ImeNaziv";
                }
                else if (cmbKolona.Text == "Mesto")
                {
                    return "Mesto";
                }
                else if (cmbKolona.Text == "Poštanski broj")
                {
                    return "PostanskiBroj";
                }
                else if (cmbKolona.Text == "Ulica i broj")
                {
                    return "UlicaBroj";
                }
                else if (cmbKolona.Text == "Banka")
                {
                    return "Banka";
                }
                else if (cmbKolona.Text == "Tekući račun")
                {
                    return "TekuciRacun";
                }
                else
                {
                    return "";
                }
            }
        }
        private string Mesto
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_Mesto))
                {
                    return ", " + _Mesto;
                }
                else
                {
                    return "";
                }
            }
        }
        private string PostanskiBroj
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_PostanskiBroj))
                {
                    return " " + _PostanskiBroj;
                }
                else
                {
                    return "";
                }
            }
        }
        private string UlicaBroj
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_UlicaBroj))
                {
                    return ", " + _UlicaBroj;
                }
                else
                {
                    return "";
                }
            }
        }
        private string Lice
        {
            get { return ImeNaziv + Mesto + PostanskiBroj + UlicaBroj; }
        }

        //KONSTRUKTOR
        public frmTekuciRacuni()
        {
            InitializeComponent();
        }

        private void frmLica_Load(object sender, EventArgs e)
        {
            cmbKolona.SelectedIndex = 1;
            PopuniTabeluBP();
        }

        private void frmLica_Shown(object sender, EventArgs e)
        {
            if (AccessBP.Greska == true)
            {
                MessageBox.Show(AccessBP.Izuzetak, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DgvAzuriraj();
        }

        private void cmbKolona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtPretraga.Text))
            {
                txtPretraga.Text = "";
                DgvAzuriraj();
            }
        }

        private void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
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
            PrikupljanjePodataka();

            if (txtUplatioc != null)
            {
                txtUplatioc.Text = Lice;
            }

            if (txtPrimaoc != null)
            {
                txtPrimaoc.Text = Lice;
            }

            if (txtTekuciRacun != null)
            {
                txtTekuciRacun.Text = TekuciRacun;
            }

            Close();
        }

        //PROCEDURE
        private void DgvAzuriraj()
        {
            if (AccessBP.Greska == true) { return; }

            DataView Pregled = new DataView(TabelaBP);

            try
            {
                if (!string.IsNullOrWhiteSpace(Kolona) || !string.IsNullOrWhiteSpace(txtPretraga.Text))
                {
                    Pregled.RowFilter = "CONVERT(" + Kolona + ", 'System.String') LIKE '%" + txtPretraga.Text + "%'";
                }
                dgvPregled.DataSource = Pregled;

                dgvPregled.Columns[0].HeaderText = "ID";
                dgvPregled.Columns[1].HeaderText = "Ime i prezime/Naziv privrednog društva";
                dgvPregled.Columns[2].HeaderText = "Mesto";
                dgvPregled.Columns[3].HeaderText = "Poštanski broj";
                dgvPregled.Columns[4].HeaderText = "Ulica i broj";
                dgvPregled.Columns[5].HeaderText = "Banka";
                dgvPregled.Columns[6].HeaderText = "Tekući račun";

                dgvPregled.ClearSelection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopuniTabeluBP()
        {
            AccessBP.IzvrsiUpit("SELECT * FROM qryTekuciRacuniOdabiri");

            TabelaBP = new DataTable();
            TabelaBP = AccessBP.TabelaBP;
        }

        private void PrikupljanjePodataka()
        {
            DataGridViewRow Red = dgvPregled.CurrentRow;

            if (Red == null)
            {
                MessageBox.Show("Morate predhodno odabrati tekući račun koji želite da dodate uplatnici.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!DBNull.Value.Equals(Red.Cells[1].Value)) { ImeNaziv = Convert.ToString(Red.Cells[1].Value); }
            if (!DBNull.Value.Equals(Red.Cells[2].Value)) { _Mesto = Convert.ToString(Red.Cells[2].Value); }
            if (!DBNull.Value.Equals(Red.Cells[3].Value)) { _PostanskiBroj = Convert.ToString(Red.Cells[3].Value); }
            if (!DBNull.Value.Equals(Red.Cells[4].Value)) { _UlicaBroj = Convert.ToString(Red.Cells[4].Value); }
            if (!DBNull.Value.Equals(Red.Cells[5].Value)) { Banka = Convert.ToString(Red.Cells[5].Value); }
            if (!DBNull.Value.Equals(Red.Cells[6].Value)) { TekuciRacun = Convert.ToString(Red.Cells[6].Value); }
        }
    }
}
