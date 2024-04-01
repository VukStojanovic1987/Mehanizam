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

namespace Mehanizam.Projektovanje.CEOP.Predmet
{
    public partial class frmDodaj : Form
    {
        //PROMENLJIVE
        private frmPregled _frmPregledInstanca;

        //PODEŠAVANJA
        public frmPregled frmPregledInstanca
        {
            set { _frmPregledInstanca = value; }
            get { return _frmPregledInstanca; }
        }

        //KONSTRUKTOR
        public frmDodaj()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmDodaj_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsLetterOrDigit(e.KeyChar) & e.KeyChar != Convert.ToChar("-"))
            {
                e.Handled = true;
            }
        }

        private void btnNazivPredmeta_Click(object sender, EventArgs e)
        {
            frmNazivPredmeta frm = new frmNazivPredmeta();
            frm.txtPoljeZaDodavanje = txtNazivPredmeta;
            frm.ShowDialog();
        }

        private void btnProjekat_Click(object sender, EventArgs e)
        {
            Odabir.frmProjektovanjePredmeti frm = new Odabir.frmProjektovanjePredmeti();
            frm.txtPoljeZaDodavanje = txtProjekat;
            frm.GlavniDirektorijum = Properties.Settings.Default.ProjektiDirektorijum;
            frm.Text = "Projektovanje - Objedinjena procedura";
            frm.ShowDialog();
        }

        private void btnRevizija_Click(object sender, EventArgs e)
        {
            Odabir.frmProjektovanjePredmeti frm = new Odabir.frmProjektovanjePredmeti();
            frm.txtPoljeZaDodavanje = txtRevizija;
            frm.GlavniDirektorijum = Properties.Settings.Default.RevizijaDirektorijum;
            frm.Text = "Projektovanje - Tehničke kontrole projekata";
            frm.ShowDialog();
        }

        private void btnEEE_Click(object sender, EventArgs e)
        {
            Odabir.frmProjektovanjePredmeti frm = new Odabir.frmProjektovanjePredmeti();
            frm.txtPoljeZaDodavanje = txtEEE;
            frm.GlavniDirektorijum = Properties.Settings.Default.EeeDirektorijum;
            frm.Text = "Projektovanje - Elaborati Energetske efikasnosti";
            frm.ShowDialog();
        }

        private void btnTehnickiPregled_Click(object sender, EventArgs e)
        {
            Odabir.frmProjektovanjePredmeti frm = new Odabir.frmProjektovanjePredmeti();
            frm.txtPoljeZaDodavanje = txtTehnickiPregled;
            frm.GlavniDirektorijum = Properties.Settings.Default.TehnickiPregledDirektorijum;
            frm.Text = "Projektovanje - Tehnički pregledi objekata";
            frm.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja obeležena (*) moraju biti popunjena.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Dodaj();
            Close();
        }

        //PROCEDURE
        private void Ucitaj()
        {
            Odabir.clsCeopVrsteZahteva Mesta = new Odabir.clsCeopVrsteZahteva(cmbVrstaZahteva);

            dtpDatum.Value = DateTime.Now;
            txtBroj.Text = "";
            cmbVrstaZahteva.Text = "";
            txtNazivPredmeta.Text = "";
            txtProjekat.Text = "";
            txtRevizija.Text = "";
            txtEEE.Text = "";
            txtTehnickiPregled.Text = "";
            txtZahtevWeb.Text = "";
            cmbStatusZahteva.Text = "";
        }

        private void Dodaj()
        {
            if(IspravnostPutanjeDirektorijuma() == false) { return; }

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.CeopBaza);

            AccessBP.DodajParametre("@Datum", Datum(dtpDatum.Value));
            AccessBP.DodajParametre("@BrojZahteva", txtBroj.Text);
            AccessBP.DodajParametre("@VrstaZahteva", cmbVrstaZahteva.Text);
            AccessBP.DodajParametre("@NazivPredmeta", txtNazivPredmeta.Text);
            AccessBP.DodajParametre("@Projekat", txtProjekat.Text);
            AccessBP.DodajParametre("@Revizija", txtRevizija.Text);
            AccessBP.DodajParametre("@EEE", txtEEE.Text);
            AccessBP.DodajParametre("@TehnickiPregled", txtTehnickiPregled.Text);
            AccessBP.DodajParametre("@ZahtevWeb", txtZahtevWeb.Text);
            AccessBP.DodajParametre("@StatusZahteva", cmbStatusZahteva.Text);

            AccessBP.IzvrsiUpit("INSERT INTO tblCeopZahtevi (Datum, BrojZahteva, VrstaZahteva, NazivPredmeta, Projekat, Revizija, EEE, TehnickiPregled, ZahtevWeb, StatusZahteva) VALUES(@Datum, @BrojZahteva, @VrstaZahteva, @NazivPredmeta, @Projekat, @Revizija, @EEE, @TehnickiPregled, @ZahtevWeb, @StatusZahteva)");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(AccessBP.Izuzetak, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string IzlaznaDokumentacija = Properties.Settings.Default.CeopDirektorijum + "\\" + txtBroj.Text + "\\1 - Izlazna dokumentacija";
            string UlaznaDokumentacija = Properties.Settings.Default.CeopDirektorijum + "\\" + txtBroj.Text + "\\2 - Ulazna dokumentacija";

            Directory.CreateDirectory(IzlaznaDokumentacija);
            Directory.CreateDirectory(UlaznaDokumentacija);

            frmPregledInstanca.OsveziTabelu();
        }

        //FUNKCIJE
        private bool PraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(txtBroj.Text) ||
                string.IsNullOrWhiteSpace(cmbVrstaZahteva.Text) ||
                string.IsNullOrWhiteSpace(txtNazivPredmeta.Text) ||
                string.IsNullOrWhiteSpace(cmbStatusZahteva.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IspravnostPutanjeDirektorijuma()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.CeopDirektorijum))
            {
                MessageBox.Show("Direktorijum za CEOP zahteve nije podešen.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!Directory.Exists(Properties.Settings.Default.CeopDirektorijum))
            {
                MessageBox.Show("Direktorijum '" + Properties.Settings.Default.CeopDirektorijum + "' je obrisan ili izmešten.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (Directory.Exists(Properties.Settings.Default.CeopDirektorijum + "\\" + txtBroj.Text))
            {
                MessageBox.Show("Zahtev pod brojem '" + Properties.Settings.Default.CeopDirektorijum + "\\" + txtBroj.Text + "' već postoji.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private DateTime Datum(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day);
        }
    }
}
