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
    public partial class frmLica : Form
    {
        //KLASE
        Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.InformacijeBaza);
        private Poruke.clsPoruke Poruke = new Poruke.clsPoruke();

        //PROMENLJIVE
        private TextBox _txtPoljeZaUnos = null;

        private DataTable TabelaBP;

        private string TipLica = "";
        private string ImeNaziv = "";
        private string _JmbgMaticniBroj = "";
        private string _Pib = "";
        private string _Mesto = "";
        private string _PostanskiBroj = "";
        private string _UlicaBroj = "";

        //PODEŠAVANJA
        public TextBox txtPoljeZaUnos
        {
            set { _txtPoljeZaUnos = value; }
            get { return _txtPoljeZaUnos; }
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
                else if (cmbKolona.Text == "Jmbg/Matični broj")
                {
                    return "JmbgMaticniBroj";
                }
                else if (cmbKolona.Text == "PIB")
                {
                    return "Pib";
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
                else if (cmbKolona.Text == "Odgovorno lice")
                {
                    return "OdgovornoLice";
                }
                else if (cmbKolona.Text == "Email")
                {
                    return "Email";
                }
                else
                {
                    return "";
                }
            }
        }

        private string JmbgMaticniBroj
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_JmbgMaticniBroj))
                {
                    if(TipLica == "Fizičko lice")
                    {
                        return ", JMBG " + _JmbgMaticniBroj;
                    }
                    else if (TipLica == "Pravno lice")
                    {
                        return ", Matični broj " + _JmbgMaticniBroj;
                    }
                    else
                    {
                        return ", " + _JmbgMaticniBroj;
                    }
                }
                else
                {
                    return "";
                }
            }
        }
        private string Pib
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_Pib))
                {
                    return ", PIB " + _Pib; 
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
        private string Uplatioc
        {
            get { return ImeNaziv + JmbgMaticniBroj + Pib + Mesto + PostanskiBroj + UlicaBroj; }
        }

        //KONSTRUKTOR
        public frmLica()
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
                MessageBox.Show(Poruke.GreskaBaza, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (!string.IsNullOrWhiteSpace(txtPoljeZaUnos.Text))
            {
                txtPoljeZaUnos.Text = txtPoljeZaUnos.Text + ", " + Uplatioc;
            }
            else
            {
                txtPoljeZaUnos.Text = Uplatioc;
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
                if (!String.IsNullOrWhiteSpace(Kolona) || !String.IsNullOrWhiteSpace(txtPretraga.Text))
                {
                    Pregled.RowFilter = "CONVERT(" + Kolona + ", 'System.String') LIKE '%" + txtPretraga.Text + "%'";
                }
                dgvPregled.DataSource = Pregled;
                dgvPregled.Columns[0].HeaderText = "ID";
                dgvPregled.Columns[1].HeaderText = "Tip lica";
                dgvPregled.Columns[2].HeaderText = "Ime i prezime/Naziv privrednog društva";
                dgvPregled.Columns[3].HeaderText = "Jmbg/Matični broj";
                dgvPregled.Columns[4].HeaderText = "PIB";
                dgvPregled.Columns[5].HeaderText = "Mesto";
                dgvPregled.Columns[6].HeaderText = "Poštanski broj";
                dgvPregled.Columns[7].HeaderText = "Ulica i broj";
                dgvPregled.Columns[8].HeaderText = "Odgovorno lice";
                dgvPregled.ClearSelection();
            }
            catch
            {
                MessageBox.Show(Poruke.GreskaBaza, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopuniTabeluBP()
        {
            AccessBP.IzvrsiUpit("SELECT * FROM qryLicaOdabir");

            TabelaBP = new DataTable();
            TabelaBP = AccessBP.TabelaBP;
        }

        private void PrikupljanjePodataka()
        {
            DataGridViewRow Red = dgvPregled.CurrentRow;

            if (Red == null)
            {
                MessageBox.Show(Poruke.OdabirRed, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!DBNull.Value.Equals(Red.Cells[1].Value)) { TipLica = Convert.ToString(Red.Cells[1].Value); }
            if (!DBNull.Value.Equals(Red.Cells[2].Value)) { ImeNaziv = Convert.ToString(Red.Cells[2].Value); }
            if (!DBNull.Value.Equals(Red.Cells[3].Value)) { _JmbgMaticniBroj = Convert.ToString(Red.Cells[3].Value); }
            if (!DBNull.Value.Equals(Red.Cells[4].Value)) { _Pib = Convert.ToString(Red.Cells[4].Value); }
            if (!DBNull.Value.Equals(Red.Cells[5].Value)) { _Mesto = Convert.ToString(Red.Cells[5].Value); }
            if (!DBNull.Value.Equals(Red.Cells[6].Value)) { _PostanskiBroj = Convert.ToString(Red.Cells[6].Value); }
            if (!DBNull.Value.Equals(Red.Cells[7].Value)) { _UlicaBroj = Convert.ToString(Red.Cells[7].Value); }
        }
    }
}
