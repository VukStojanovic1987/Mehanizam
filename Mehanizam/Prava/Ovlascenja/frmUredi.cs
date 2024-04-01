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
    public partial class frmUredi : Form
    {
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

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja obeležena (*) moraju biti popunjena.", "Ovlašćenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Snimi();
            Close();
        }

        //PROCEDURE
        private void Ucitaj()
        {
            if (ID == 0)
            {
                MessageBox.Show("ID = 0.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.OvlascenjaBaza);

            AccessBP.DodajParametre("@ID", ID);
            AccessBP.IzvrsiUpit("SELECT * FROM tblOvlascenja WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(AccessBP.Izuzetak, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AccessBP.TabelaBP.Rows.Count != 1)
            {
                MessageBox.Show("Broj zapisa nije jednak 1.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbMesto);

            DataRow Red = AccessBP.TabelaBP.Rows[0];

            dtpDatum.Value = Convert.ToDateTime(Red["Datum"]);
            txtEvidencioniBroj.Text = Convert.ToString(Red["EvidencioniBroj"]);
            cmbMesto.Text = Convert.ToString(Red["Mesto"]);
            cmbJedninaMnozina1.Text = Convert.ToString(Red["JedninaMnozina1"]);
            txtDavaocOvlascenja.Text = Convert.ToString(Red["OvlascenjeDao"]);
            txtPrimaocOvlascenja.Text = Convert.ToString(Red["OvlascenoLice"]);
            cmbJedninaMnozina2.Text = Convert.ToString(Red["JedninaMnozina2"]);
            txtKontekst.Text = Convert.ToString(Red["Kontekst"]);
        }

        private void Snimi()
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
            AccessBP.DodajParametre("@ID", ID);

            AccessBP.IzvrsiUpit("UPDATE tblOvlascenja SET Datum=@Datum, EvidencioniBroj=@EvidencioniBroj, Mesto=@Mesto, JedninaMnozina1=@JedninaMnozina1, OvlascenjeDao=@OvlascenjeDao, OvlascenoLice=@OvlascenoLice, JedninaMnozina2=@JedninaMnozina2, Kontekst=@Kontekst WHERE ID=@ID");

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
