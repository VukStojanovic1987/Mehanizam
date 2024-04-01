using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanizam.Prava.Ovlascenja
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

        private void btnOdaberiDavaocaOvlascenja_Click(object sender, EventArgs e)
        {
            using (Odabir.frmLica frm = new Odabir.frmLica())
            {
                frm.txtPoljeZaUnos = txtDavaocOvlascenja;
                frm.ShowDialog();
            }
        }

        private void btnOdaberiPrimaocaOvlascenja_Click(object sender, EventArgs e)
        {
            using (Odabir.frmLica frm = new Odabir.frmLica())
            {
                frm.txtPoljeZaUnos = txtPrimaocOvlascenja;
                frm.ShowDialog();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja obeležena (*) moraju biti popunjena.", "Ovlašćenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Dodaj();
            Close();
        }

        //PROCEDURE
        private void Ucitaj()
        {
            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbMesto);

            if(MessageBox.Show("Želite li da započtne novo ovlašćenje sa predpostvljenim vrednostima?", "Ovlašćenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                dtpDatum.Value = DateTime.Now;
                txtEvidencioniBroj.Text = "";
                cmbMesto.Text = Properties.Settings.Default.PvOvlascenjaMesto;
                cmbJedninaMnozina1.Text = Properties.Settings.Default.PvOvlascenjaJedninaMnozina1;
                txtDavaocOvlascenja.Text = Properties.Settings.Default.PvOvlascenjaOvlascenjeDao;
                txtPrimaocOvlascenja.Text = Properties.Settings.Default.PvOvlascenjaOvlascenjePrimio;
                cmbJedninaMnozina2.Text = Properties.Settings.Default.PvOvlascenjaJedninaMnozina2;
                txtKontekst.Text = Properties.Settings.Default.PvOvlascenjaKontekst;
            }
            else
            {
                dtpDatum.Value = DateTime.Now;
                txtEvidencioniBroj.Text = "";
                cmbMesto.Text = "";
                cmbJedninaMnozina1.Text = "";
                txtDavaocOvlascenja.Text = "";
                txtPrimaocOvlascenja.Text = "";
                cmbJedninaMnozina2.Text = "";
                txtKontekst.Text = "";
            }
        }

        private void Dodaj()
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.OvlascenjaBaza);

            AccessBP.DodajParametre("@Datum", Datum(dtpDatum.Value));
            AccessBP.DodajParametre("@EvidencioniBroj", txtEvidencioniBroj.Text);
            AccessBP.DodajParametre("@Mesto", cmbMesto.Text);
            AccessBP.DodajParametre("@JedninaMnozina1", cmbJedninaMnozina1.Text);
            AccessBP.DodajParametre("@OvlascenjeDao", txtDavaocOvlascenja.Text);
            AccessBP.DodajParametre("@OvlascenoLice", txtPrimaocOvlascenja.Text);
            AccessBP.DodajParametre("@JedninaMnozina2", cmbJedninaMnozina2.Text);
            AccessBP.DodajParametre("@Kontekst", txtKontekst.Text);

            AccessBP.IzvrsiUpit("INSERT INTO tblOvlascenja (Datum, EvidencioniBroj, Mesto, JedninaMnozina1, OvlascenjeDao, OvlascenoLice, JedninaMnozina2, Kontekst) VALUES(@Datum, @EvidencioniBroj, @Mesto, @JedninaMnozina1, @OvlascenjeDao, @OvlascenoLice, @JedninaMnozina2, @Kontekst)");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(AccessBP.Izuzetak, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmPregledInstanca.OsveziTabelu();
        }

        //FUNKCIJE
        private bool PraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(txtEvidencioniBroj.Text) || 
                string.IsNullOrWhiteSpace(cmbMesto.Text) || 
                string.IsNullOrWhiteSpace(cmbJedninaMnozina1.Text) || 
                string.IsNullOrWhiteSpace(txtDavaocOvlascenja.Text) || 
                string.IsNullOrWhiteSpace(txtPrimaocOvlascenja.Text) || 
                string.IsNullOrWhiteSpace(cmbJedninaMnozina2.Text) || 
                string.IsNullOrWhiteSpace(txtKontekst.Text))
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
