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
    public partial class frmNazivPredmeta : Form
    {
        //PROMENLJIVE
        private TextBox _txtPoljeZaDodavanje = null;

        //PODEŠAVANJA
        public TextBox txtPoljeZaDodavanje
        {
            set { _txtPoljeZaDodavanje = value; }
            get { return _txtPoljeZaDodavanje; }
        }

        //KONSTRUKTOR
        public frmNazivPredmeta()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmNazivPredmeta_Load(object sender, EventArgs e)
        {
            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbKatastarskaOpstina);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja označena (*) moraju biti popunjena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtPoljeZaDodavanje.Text = txtInvestitor.Text + ", k.p.br. " + txtBrojKatastarskeParcele.Text + " k.o. " + cmbKatastarskaOpstina.Text + ", " + cmbVrstaObjekta.Text + " " + txtBrojObjekta.Text;

            Close();
        }

        //FUNKCIJE
        private bool PraznaPolja()
        {
            if(string.IsNullOrWhiteSpace(txtInvestitor.Text) || 
               string.IsNullOrWhiteSpace(cmbKatastarskaOpstina.Text) ||
               string.IsNullOrWhiteSpace(txtBrojKatastarskeParcele.Text) ||
               string.IsNullOrWhiteSpace(cmbVrstaObjekta.Text) ||
               string.IsNullOrWhiteSpace(txtBrojObjekta.Text))
            {
                return true;
            }

            return false;
        }
    }
}
