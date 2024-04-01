﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanizam.Finansije.Predracuni
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
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar))
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
                }
            }

            for (i = 96; i <= 105; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                ZaUplatu();
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
                }
            }

            for (i = 96; i <= 105; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                ZaUplatu();
            }
        }

        private void txtCenaPoJediniciMere_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCenaPoJediniciMere.Text))
            {
                txtCenaPoJediniciMere.Text = "0";
            }
        }

        //Stopa PDV
        private void txtStopaPDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & e.KeyChar != Convert.ToChar(","))
            {
                e.Handled = true;
            }
        }

        private void txtStopaPDV_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;

            for (i = 48; i <= 57; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                }
            }

            for (i = 96; i <= 105; i++)
            {
                if (Convert.ToInt16(e.KeyCode) == i)
                {
                    ZaUplatu();
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                ZaUplatu();
            }
        }

        private void txtStopaPDV_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStopaPDV.Text))
            {
                txtStopaPDV.Text = "0";
            }
        }

        //Odabir uplatioca
        private void btnOdaberiUplatioca_Click(object sender, EventArgs e)
        {
            using(Odabir.frmLica Frm = new Odabir.frmLica())
            {
                Frm.txtPoljeZaUnos = txtUplatioc;
                Frm.ShowDialog();
            }
        }

        //Dodaj novi zapis
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show(Poruke.ObaveznaPolja, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            txtBroj.Text = "1";
            dtpDatumIzdavanja.Value = DateTime.Now;
            dtpDatumPrometaUsluge.Value = DateTime.Now;
            txtEvidencioniBroj.Text = "";
            cmbMesto.Text = "";
            txtUplatioc.Text = "";
            txtVrstaRobeUsluge.Text = "";
            cmbJedinicaMere.Text = "";
            txtKolicina.Text = "0";
            txtCenaPoJediniciMere.Text = "0";
            txtStopaPDV.Text = "0";
            txtZaUplatuSlovima.Text = "";
        }

        private void Dodaj()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.PredracuniBaza);

            AccessBP.DodajParametre("@Broj", txtBroj.Text);
            AccessBP.DodajParametre("@DatumIzdavanja", Datum(dtpDatumIzdavanja.Value));
            AccessBP.DodajParametre("@DatumPrometaUsluge", Datum(dtpDatumPrometaUsluge.Value));
            AccessBP.DodajParametre("@EvidencioniBroj", txtEvidencioniBroj.Text);
            AccessBP.DodajParametre("@Mesto", cmbMesto.Text);
            AccessBP.DodajParametre("@Uplatioc", txtUplatioc.Text);
            AccessBP.DodajParametre("@VrstaRobeUsluge", txtVrstaRobeUsluge.Text);
            AccessBP.DodajParametre("@JedinicaMere", cmbJedinicaMere.Text);
            AccessBP.DodajParametre("@Kolicina", txtKolicina.Text);
            AccessBP.DodajParametre("@CenaPoJediniciMere", txtCenaPoJediniciMere.Text);
            AccessBP.DodajParametre("@StopaPDV", txtStopaPDV.Text);
            AccessBP.DodajParametre("@ZaUplatuSlovima", txtZaUplatuSlovima.Text);

            AccessBP.IzvrsiUpit("INSERT INTO tblPredracuni (Broj, DatumIzdavanja, DatumPrometaUsluge, EvidencioniBroj, Mesto, Uplatioc, VrstaRobeUsluge, JedinicaMere, Kolicina, CenaPoJediniciMere, StopaPDV, ZaUplatuSlovima) VALUES (@Broj, @DatumIzdavanja, @DatumPrometaUsluge, @EvidencioniBroj, @Mesto, @Uplatioc, @VrstaRobeUsluge, @JedinicaMere, @Kolicina, @CenaPoJediniciMere, @StopaPDV, @ZaUplatuSlovima)");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Predračuni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FrmInstanca.OsveziTabelu();
        }

        private void ZaUplatu()
        {
            double Kolicina = 0;
            double CenaPoJediniciMere = 0;
            double StopaPDV = 0;
            double UkupnoBezPDVa = 0;
            double ObracunatPDV = 0;
            double UkupnoSaPDVom = 0;

            try
            {
                Kolicina = Convert.ToDouble(txtKolicina.Text);
                CenaPoJediniciMere = Convert.ToDouble(txtCenaPoJediniciMere.Text);
                StopaPDV = Convert.ToDouble(txtStopaPDV.Text);
                UkupnoBezPDVa = (Kolicina * CenaPoJediniciMere);
                ObracunatPDV = UkupnoBezPDVa / 100 * StopaPDV;
                UkupnoSaPDVom = UkupnoBezPDVa + ObracunatPDV;
                txtZaUplatu.Text = Convert.ToString(UkupnoSaPDVom);
            }
            catch
            {
                txtZaUplatu.Text = "0";
                return;
            }
        }
        
        //FUNKCIJE
        private bool PraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(txtBroj.Text) ||
                string.IsNullOrWhiteSpace(txtEvidencioniBroj.Text) ||
                string.IsNullOrWhiteSpace(cmbMesto.Text) ||
                string.IsNullOrWhiteSpace(txtUplatioc.Text) ||
                string.IsNullOrWhiteSpace(txtVrstaRobeUsluge.Text) ||
                string.IsNullOrWhiteSpace(cmbJedinicaMere.Text) ||
                txtKolicina.Text == "0" ||
                txtCenaPoJediniciMere.Text == "0" ||
                txtStopaPDV.Text == "0" ||
                string.IsNullOrWhiteSpace(txtZaUplatuSlovima.Text))
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
