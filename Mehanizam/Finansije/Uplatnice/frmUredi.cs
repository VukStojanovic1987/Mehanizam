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
    public partial class frmUredi : Form
    {
        //KLASE
        private Poruke.clsPoruke Poruke = new Poruke.clsPoruke();

        //PROMENLJIVE
        private frmPregled _FrmInstanca;
        private long _ID = 0;

        //PODEŠAVANJA
        public frmPregled FrmInstanca
        {
            set { _FrmInstanca = value; }
            get { return _FrmInstanca; }
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
        //frmUredi
        private void frmUredi_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void txtIznos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & e.KeyChar != Convert.ToChar(","))
            {
                e.Handled = true;
            }
        }

        private void txtIznos_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIznos.Text))
            {
                txtIznos.Text = "0";
            }
        }

        private void btnPlatilac_Click(object sender, EventArgs e)
        {
            using (Odabir.frmLica frm = new Odabir.frmLica())
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
        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show(Poruke.ObaveznaPolja, "Finansije - Uplatnice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(Poruke.GreskaIdNula, "Finansije - Uplatnice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.UplatniceBaza);

            AccessBP.DodajParametre("@ID", ID);
            AccessBP.IzvrsiUpit("SELECT * FROM tblUplatnice WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Uplatnice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AccessBP.TabelaBP.Rows.Count != 1)
            {
                MessageBox.Show(Poruke.GreskaBrojZapisaNijeJedan, "Finansije - Uplatnice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Odabir.clsValute Valute = new Odabir.clsValute(cmbValuta);

            DataRow Red = AccessBP.TabelaBP.Rows[0];

            dtpDatum.Value = Convert.ToDateTime(Red["Datum"]);
            txtPlatilac.Text = Convert.ToString(Red["Platilac"]);
            txtSvrhaUplate.Text = Convert.ToString(Red["SvrhaUplate"]);
            txtPrimalac.Text = Convert.ToString(Red["Primalac"]);
            txtSifraPlacanja.Text = Convert.ToString(Red["SifraPlacanja"]);
            cmbValuta.Text = Convert.ToString(Red["Valuta"]);
            txtIznos.Text = Convert.ToString(Red["Iznos"]);
            txtRacunPrimaoca.Text = Convert.ToString(Red["RacunPrimaoca"]);
            txtModel.Text = Convert.ToString(Red["Model"]);
            txtPozivNaBroj.Text = Convert.ToString(Red["PozivNaBroj"]);
        }

        private void Snimi()
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
            AccessBP.DodajParametre("@ID", ID);

            AccessBP.IzvrsiUpit("UPDATE tblUplatnice Set Datum=@Datum, Platilac=@Platilac, SvrhaUplate=@SvrhaUplate, Primalac=@Primalac, SifraPlacanja=@SifraPlacanja, Valuta=@Valuta, Iznos=@Iznos, RacunPrimaoca=@RacunPrimaoca, Model=@Model, PozivNaBroj=@PozivNaBroj WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                MessageBox.Show(Poruke.GreskaBaza, "Finansije - Uplatnice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
