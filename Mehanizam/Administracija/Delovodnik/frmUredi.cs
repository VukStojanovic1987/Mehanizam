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
    public partial class frmUredi : Form
    {
        //KLASE
        private Poruke.clsPoruke Poruke = new Poruke.clsPoruke();

        //PROMENLJIVE
        private frmPregled _frmPregledInstanca;
        private long _ID = 0;

        //PODEŠAVANJA
        public frmPregled frmPregledInstanca
        {
            set { _frmPregledInstanca = value; }
            get { return _frmPregledInstanca; }
        }

        public long ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        //KONSTRUKTOR
        public frmUredi()
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

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show(Poruke.ObaveznaPolja, "Administracija - Delovodnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Dodaj();
            Close();
        }

        //PROCEDURE
        private void Ucitaj()
        {
            if (ID == 0)
            {
                MessageBox.Show(Poruke.GreskaIdNula, "Administracija - Delovodnik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.DelovodnikBaza);

            AccessBP.DodajParametre("@ID", ID);
            AccessBP.IzvrsiUpit("SELECT * FROM tblDelovodnik WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(AccessBP.Izuzetak, "Administracija - Delovodnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (AccessBP.TabelaBP.Rows.Count != 1)
            {
                MessageBox.Show(Poruke.GreskaBrojZapisaNijeJedan, "Administracija - Delovodnik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbMesto);
            Odabir.clsVrsteDokumenata VrsteDokumenta = new Odabir.clsVrsteDokumenata(cmbVrstaDokumenta);

            DataRow Red = AccessBP.TabelaBP.Rows[0];

            dtpDatum.Value = Convert.ToDateTime(Red["DatumZavodjenja"]);
            txtBroj.Text = Convert.ToString(Red["BrojDnevnogZavodjenja"]);
            cmbMesto.Text = Convert.ToString(Red["MestoZavodjenja"]);
            cmbVrstaDokumenta.Text = Convert.ToString(Red["VrstaDokumenta"]);
            cmbIzlazniUlazni.Text = Convert.ToString(Red["IzlazniUlazni"]);
            txtOpisDokumenta.Text = Convert.ToString(Red["OpisDokumenta"]);
        }

        private void Dodaj()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.DelovodnikBaza);

            AccessBP.DodajParametre("@DatumZavodjenja", Datum(dtpDatum.Value));
            AccessBP.DodajParametre("@BrojDnevnogZavodjenja", txtBroj.Text);
            AccessBP.DodajParametre("@MestoZavodjenja", cmbMesto.Text);
            AccessBP.DodajParametre("@VrstaDokumenta", cmbVrstaDokumenta.Text);
            AccessBP.DodajParametre("@IzlazniUlazni", cmbIzlazniUlazni.Text);
            AccessBP.DodajParametre("@OpisDokumenta", txtOpisDokumenta.Text);
            AccessBP.DodajParametre("@ID", ID);

            AccessBP.IzvrsiUpit("UPDATE tblDelovodnik Set DatumZavodjenja=@DatumZavodjenja, BrojDnevnogZavodjenja=@BrojDnevnogZavodjenja, MestoZavodjenja=@MestoZavodjenja, VrstaDokumenta=@VrstaDokumenta, IzlazniUlazni=@IzlazniUlazni, OpisDokumenta=@OpisDokumenta WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Administracija - Delovodnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmPregledInstanca.OsveziTabelu();
        }

        //FUNKCIJE
        private bool PraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(txtBroj.Text) ||
                string.IsNullOrWhiteSpace(cmbMesto.Text) ||
                string.IsNullOrWhiteSpace(cmbVrstaDokumenta.Text) ||
                string.IsNullOrWhiteSpace(cmbIzlazniUlazni.Text))
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
