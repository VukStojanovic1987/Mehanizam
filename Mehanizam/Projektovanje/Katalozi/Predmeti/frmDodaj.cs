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

namespace Mehanizam.Projektovanje.Katalozi.Predmeti
{
    public partial class frmDodaj : Form
    {
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
        private void frmDodaj_Load(object sender, EventArgs e)
        {
            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbKatastarskaOpstina);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.KataloziDirektorijum))
            {
                MessageBox.Show("Dirktorijum za kataloge nije podešen.", "Projektovanje - Katalozi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.KataloziDirektorijum))
            {
                MessageBox.Show("Podešeni dirktorijum '" + Properties.Settings.Default.KataloziDirektorijum + "' je obrisan ili izmešten sa lokacije.", "Projektovanje - Katalozi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja označena (*) moraju biti popunjena.", "Projektovanje - Katalozi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NapraviPredmet();
        }

        //PROCEDURE
        private void NapraviPredmet()
        {
            string Naziv =  txtInvestitor.Text + ", k.p.br. " + txtBrojKatastarskeParcele.Text + " k.o. " + cmbKatastarskaOpstina.Text + ", " + cmbVrstaObjekta.Text + " " + txtBrojObjekta.Text;
            string Putanja = Properties.Settings.Default.KataloziDirektorijum + "\\" + Naziv;

            if (Directory.Exists(Putanja))
            {
                MessageBox.Show("Predmet pod nazivom '" + Naziv + "' već postoji.", "Projektovanje - Katalozi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            string Katalog = Putanja + "\\1 - Katalog";
            string GrafickaDokumentacija = Putanja + "\\2 - Grafička dokumentacija";
            string Model = Putanja + "\\3 - Model";
            string SlikeNaslovna = Putanja + "\\4 - Slike\\1 - Naslovna strana";
            string SlikePrilozi = Putanja + "\\4 - Slike\\2 - Prilozi";
            string InvestitorovaDokumentacija = Putanja + "\\Investitorova dokumentacija";

            Directory.CreateDirectory(Katalog);
            Directory.CreateDirectory(GrafickaDokumentacija);
            Directory.CreateDirectory(Model);
            Directory.CreateDirectory(SlikeNaslovna);
            Directory.CreateDirectory(SlikePrilozi);
            Directory.CreateDirectory(InvestitorovaDokumentacija);

            File.WriteAllBytes(Katalog + "\\Katalog.xlsm", Properties.Resources.Katalog);

            FrmInstanca.OsveziTabelu();

            MessageBox.Show("Predmet je uspešno napravljen.", "Projektovanje - Katalozi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
