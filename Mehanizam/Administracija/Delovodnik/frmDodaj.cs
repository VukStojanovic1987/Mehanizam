using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanizam.Administracija.Delovodnik
{
    public partial class frmDodaj : Form
    {
        //KLASE
        private Poruke.clsPoruke Poruke = new Poruke.clsPoruke();

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

        private void btnZavedi_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show(Poruke.ObaveznaPolja, "Administracija - Delovodnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ZavodniBrojPostoji() == true)
            {
                MessageBox.Show("Broj dnevnog zavođenja " + txtBroj.Text + ", pod datumom " + Datum(dtpDatum.Value).ToString("dd.MM.yyyy.") + " godine, već postoji.", "Administracija - Delovodnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Zavedi();
            Close();
        }

        //PROCEDURE
        private void Ucitaj()
        {
            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbMesto);
            Odabir.clsVrsteDokumenata VrsteDokumenta = new Odabir.clsVrsteDokumenata(cmbVrstaDokumenta);

            dtpDatum.Value = DateTime.Now;
            txtBroj.Text = "1";
            cmbMesto.Text = "";
            cmbVrstaDokumenta.Text = "";
            cmbIzlazUlaz.Text = "";
            txtOpisDokumenta.Text = "";
        }

        private void Zavedi()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.DelovodnikBaza);

            AccessBP.DodajParametre("@DatumZavodjenja", Datum(dtpDatum.Value));
            AccessBP.DodajParametre("@BrojDnevnogZavodjenja", txtBroj.Text);
            AccessBP.DodajParametre("@MestoZavodjenja", cmbMesto.Text);
            AccessBP.DodajParametre("@VrstaDokumenta", cmbVrstaDokumenta.Text);
            AccessBP.DodajParametre("@IzlazniUlazni", cmbIzlazUlaz.Text);
            AccessBP.DodajParametre("@OpisDokumenta", txtOpisDokumenta.Text);

            AccessBP.IzvrsiUpit("INSERT INTO tblDelovodnik (DatumZavodjenja, BrojDnevnogZavodjenja, MestoZavodjenja, VrstaDokumenta, IzlazniUlazni, OpisDokumenta) VALUES(@DatumZavodjenja, @BrojDnevnogZavodjenja, @MestoZavodjenja, @VrstaDokumenta, @IzlazniUlazni, @OpisDokumenta)");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Administracija - Delovodnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmPregledInstanca.OsveziTabelu();
        }

        //FUNKCIJE
        private bool ZavodniBrojPostoji()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.DelovodnikBaza);

            AccessBP.DodajParametre("@DatumZavodjenja", Datum(dtpDatum.Value));
            AccessBP.DodajParametre("@BrojDnevnogZavodjenja", txtBroj.Text);

            AccessBP.IzvrsiUpit("SELECT DatumZavodjenja, BrojDnevnogZavodjenja FROM tblDelovodnik WHERE DatumZavodjenja=@DatumZavodjenja AND BrojDnevnogZavodjenja=@BrojDnevnogZavodjenja");

            if(AccessBP.TabelaBP.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private bool PraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(txtBroj.Text) ||
                string.IsNullOrWhiteSpace(cmbMesto.Text) ||
                string.IsNullOrWhiteSpace(cmbVrstaDokumenta.Text) ||
                string.IsNullOrWhiteSpace(cmbIzlazUlaz.Text))
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
