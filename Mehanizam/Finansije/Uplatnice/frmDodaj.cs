using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanizam.Finansije.Uplatnice
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

        private void btnPlatilac_Click(object sender, EventArgs e)
        {
            using(Odabir.frmLica frm = new Odabir.frmLica())
            {
                frm.txtPoljeZaUnos = txtPlatilac;
                frm.ShowDialog();
            }
        }

        private void btnPrimalac_Click(object sender, EventArgs e)
        {
            using (Odabir.frmTekuciRacuni frm = new Odabir.frmTekuciRacuni())
            {
                frm.txtUplatioc = null;
                frm.txtPrimaoc = txtPrimalac;
                frm.txtTekuciRacun = txtRacunPrimaoca;
                frm.ShowDialog();
            }
        }

        private void btnTekuciRacun_Click(object sender, EventArgs e)
        {
            using (Odabir.frmTekuciRacuni frm = new Odabir.frmTekuciRacuni())
            {
                frm.txtUplatioc = null;
                frm.txtPrimaoc = txtPrimalac;
                frm.txtTekuciRacun = txtRacunPrimaoca;
                frm.ShowDialog();
            }
        }

        //Dodaj novi zapis
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Uplatnice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Dodaj();
            Close();
        }

        //PROCEDURE
        private void Ucitaj()
        {
            Odabir.clsValute Valute = new Odabir.clsValute(cmbValuta);

            dtpDatum.Value = DateTime.Now;
            txtPlatilac.Text = "";
            txtSvrhaUplate.Text = "";
            txtPrimalac.Text = "";
            txtSifraPlacanja.Text = "";   
            cmbValuta.Text = "";
            txtIznos.Text = "0";
            txtRacunPrimaoca.Text = "";
            txtModel.Text = "";
            txtPozivNaBroj.Text = "";
        }

        private void Dodaj()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.UplatniceBaza);

            AccessBP.DodajParametre("@Datum", Datum(dtpDatum.Value));
            AccessBP.DodajParametre("@Platilac", txtPlatilac.Text);
            AccessBP.DodajParametre("@SvrhaUplate", txtSvrhaUplate.Text);
            AccessBP.DodajParametre("@Primalac", txtPrimalac.Text);
            AccessBP.DodajParametre("@SifraPlacanja", txtSifraPlacanja.Text);
            AccessBP.DodajParametre("@Valuta", cmbValuta.Text);
            AccessBP.DodajParametre("@Iznos", txtIznos.Text);
            AccessBP.DodajParametre("@RacunPrimaoca", txtRacunPrimaoca.Text);
            AccessBP.DodajParametre("@Model", txtModel.Text);
            AccessBP.DodajParametre("@PozivNaBroj", txtPozivNaBroj.Text);

            AccessBP.IzvrsiUpit("INSERT INTO tblUplatnice (Datum, Platilac, SvrhaUplate, Primalac, SifraPlacanja, Valuta, Iznos, RacunPrimaoca, Model, PozivNaBroj) VALUES (@Datum, @Platilac, @SvrhaUplate, @Primalac, @SifraPlacanja, @Valuta, @Iznos, @RacunPrimaoca, @Model, @PozivNaBroj)");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Računi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FrmInstanca.OsveziTabelu();
        }

        //FUNKCIJE
        private bool PraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(txtPlatilac.Text) ||
                string.IsNullOrWhiteSpace(txtSvrhaUplate.Text) ||
                string.IsNullOrWhiteSpace(txtPrimalac.Text) ||
                string.IsNullOrWhiteSpace(txtIznos.Text) ||
                string.IsNullOrWhiteSpace(txtRacunPrimaoca.Text))
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
