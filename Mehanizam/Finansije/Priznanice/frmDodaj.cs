using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanizam.Finansije.Priznanice
{
    public partial class frmDodaj : Form
    {
        //KLASE
        private Poruke.clsPoruke Poruke = new Poruke.clsPoruke();

        //PROMENLJIVE
        private frmPregled _FrmInstanca;

        //PODEŠAVANJA
        public frmPregled FrmInstanca
        {
            set { _FrmInstanca = value; }
            get { return _FrmInstanca; }
        } 

        //KONSTRUKTOR
        public frmDodaj()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        //frmDodaj
        private void frmDodaj_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }

        //Broj
        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBroj_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBroj.Text))
            {
                txtBroj.Text = "1";
            }
        }

        //Kolicina
        private void txtKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKolicina_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;

            for (i = 48; i <= 57; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                    OstaloZaUplatu();
                }
            }

            for (i = 96; i <= 105; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                    OstaloZaUplatu();
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                ZaUplatu();
                OstaloZaUplatu();
            }
        }

        private void txtKolicina_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                txtKolicina.Text = "0";
            }
        }

        //Cena po jedinici mere
        private void txtCenaPoJediniciMere_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & e.KeyChar != Convert.ToChar(","))
            {
                e.Handled = true;
            }
        }

        private void txtCenaPoJediniciMere_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;

            for (i = 48; i <= 57; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                    OstaloZaUplatu();
                }
            }

            for (i = 96; i <= 105; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                    OstaloZaUplatu();
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                ZaUplatu();
                OstaloZaUplatu();
            }
        }

        private void txtCenaPoJediniciMere_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCenaPoJediniciMere.Text))
            {
                txtCenaPoJediniciMere.Text = "0";
            }
        }

        //Uplatio
        private void txtUplatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & e.KeyChar != Convert.ToChar(","))
            {
                e.Handled = true;
            }
        }

        private void txtUplatio_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;

            for (i = 48; i <= 57; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                    OstaloZaUplatu();
                }
            }

            for (i = 96; i <= 105; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                    OstaloZaUplatu();
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                ZaUplatu();
                OstaloZaUplatu();
            }
        }

        private void txtUplatio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUplatio.Text))
            {
                txtCenaPoJediniciMere.Text = "0";
            }
        }

        //Odabir
        private void btnUplatioc_Click(object sender, EventArgs e)
        {
            using (Odabir.frmLica frm = new Odabir.frmLica())
            {
                frm.txtPoljeZaUnos = txtUplatioc;
                frm.ShowDialog();
            }
        }

        private void btnPrimaoc_Click(object sender, EventArgs e)
        {
            using (Odabir.frmLica frm = new Odabir.frmLica())
            {
                frm.txtPoljeZaUnos = txtPrimaoc;
                frm.ShowDialog();
            }
        }

        //Dodaj novi zapis
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show(Poruke.ObaveznaPolja, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Dodaj();
            Close();
        }

        //PROCEDURE
        private void Ucitaj()
        {
            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbMesto);
            Odabir.clsJediniceMere JediniceMere = new Odabir.clsJediniceMere(cmbJedinicaMere);
            Odabir.clsValute Valute = new Odabir.clsValute(cmbValuta);

            txtBroj.Text = "1";
            dtpDatum.Value = DateTime.Now;
            cmbMesto.Text = "";
            txtUplatioc.Text = "";
            txtPrimaoc.Text = "";
            txtVrstaRobeUsluge.Text = "";
            cmbJedinicaMere.Text = "";
            txtKolicina.Text = "0";
            cmbValuta.Text = "";
            txtCenaPoJediniciMere.Text = "0";
            txtUplatio.Text = "0";
            txtOstaloZaUplatuSlovima.Text = "";
        }

        private void Dodaj()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.PriznaniceBaza);

            AccessBP.DodajParametre("@Broj", txtBroj.Text);
            AccessBP.DodajParametre("@Datum", Datum(dtpDatum.Value));
            AccessBP.DodajParametre("@Mesto", cmbMesto.Text);
            AccessBP.DodajParametre("@Uplatioc", txtUplatioc.Text);
            AccessBP.DodajParametre("@Primaoc", txtPrimaoc.Text);
            AccessBP.DodajParametre("@VrstaRobeUsluge", txtVrstaRobeUsluge.Text);
            AccessBP.DodajParametre("@JedinicaMere", cmbJedinicaMere.Text);
            AccessBP.DodajParametre("@Kolicina", txtKolicina.Text);
            AccessBP.DodajParametre("@Valuta", cmbValuta.Text);
            AccessBP.DodajParametre("@CenaPoJediniciMere", txtCenaPoJediniciMere.Text);
            AccessBP.DodajParametre("@Uplatio", txtUplatio.Text);
            AccessBP.DodajParametre("@OstaloZaUplatuSlovima", txtOstaloZaUplatuSlovima.Text);

            AccessBP.IzvrsiUpit("INSERT INTO tblPriznanice (Broj, Datum, Mesto, Uplatioc, Primaoc, VrstaRobeUsluge, JedinicaMere, Kolicina, Valuta, CenaPoJediniciMere, Uplatio, OstaloZaUplatuSlovima) VALUES (@Broj, @Datum, @Mesto, @Uplatioc, @Primaoc, @VrstaRobeUsluge, @JedinicaMere, @Kolicina, @Valuta, @CenaPoJediniciMere, @Uplatio, @OstaloZaUplatuSlovima)");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Priznanice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmInstanca.OsveziTabelu();
        }

        private void ZaUplatu()
        {
            double Kolicina = 0;
            double CenaPoJediniciMere = 0;
            double ZaUpalatu = 0;

            try
            {
                Kolicina = Convert.ToDouble(txtKolicina.Text);
                CenaPoJediniciMere = Convert.ToDouble(txtCenaPoJediniciMere.Text);
                ZaUpalatu = Kolicina * CenaPoJediniciMere;
                txtZaUplatu.Text = Convert.ToString(ZaUpalatu);
            }
            catch
            {
                txtZaUplatu.Text = "0";
            }
        }

        private void OstaloZaUplatu()
        {
            double ZaUpalatu = 0;
            double Uplatio = 0;
            double OstaloZaUplatu = 0;

            try
            {
                ZaUpalatu = Convert.ToDouble(txtZaUplatu.Text);
                Uplatio = Convert.ToDouble(txtUplatio.Text);
                OstaloZaUplatu = ZaUpalatu - Uplatio;
                txtOstaloZaUplatu.Text = Convert.ToString(OstaloZaUplatu);
            }
            catch
            {
                txtOstaloZaUplatu.Text = "0";
            }
        }

        //FUNKCIJE
        private bool PraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(txtBroj.Text) ||
                string.IsNullOrWhiteSpace(cmbMesto.Text) ||
                string.IsNullOrWhiteSpace(txtUplatioc.Text) ||
                string.IsNullOrWhiteSpace(txtPrimaoc.Text) ||
                string.IsNullOrWhiteSpace(txtVrstaRobeUsluge.Text) ||
                string.IsNullOrWhiteSpace(cmbJedinicaMere.Text) ||
                txtKolicina.Text == "0" ||
                string.IsNullOrWhiteSpace(cmbValuta.Text) ||
                txtCenaPoJediniciMere.Text == "0" ||
                string.IsNullOrWhiteSpace(txtOstaloZaUplatuSlovima.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private DateTime Datum(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day);
        }
    }
}
