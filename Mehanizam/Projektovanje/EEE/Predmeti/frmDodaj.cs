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

namespace Mehanizam.Projektovanje.EEE.Predmeti
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
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.EeeDirektorijum))
            {
                MessageBox.Show("Dirktorijum za elaborate energetske efikasnosti nije podešen.", "Projektovanje - Elaborati energetske efikasnosti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.EeeDirektorijum))
            {
                MessageBox.Show("Podešeni dirktorijum '" + Properties.Settings.Default.EeeDirektorijum + "' je obrisan ili izmešten sa lokacije.", "Projektovanje - Elaborati energetske efikasnosti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja označena (*) moraju biti popunjena.", "Projektovanje - Elaborati energetske efikasnosti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NapraviPredmet();
        }

        //PROCEDURE
        private void NapraviPredmet()
        {
            string Naziv =  txtInvestitor.Text + ", k.p.br. " + txtBrojKatastarskeParcele.Text + " k.o. " + cmbKatastarskaOpstina.Text + ", " + cmbVrstaObjekta.Text + " " + txtBrojObjekta.Text;
            string Putanja = Properties.Settings.Default.EeeDirektorijum + "\\" + Naziv;

            if (Directory.Exists(Putanja))
            {
                MessageBox.Show("Predmet pod nazivom '" + Naziv + "' već postoji.", "Projektovanje - Elaborati energetske efikasnosti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            string TekstualnaDokumentacija = Putanja + "\\1 - Tekstualna dokumentacija";
            string GrafickaDokumentacija = Putanja + "\\2 - Graficka dokumentacija";
            string InvestitorovaDokumentacija = Putanja + "\\Investitorova dokumentacija";

            Directory.CreateDirectory(TekstualnaDokumentacija);
            Directory.CreateDirectory(GrafickaDokumentacija);
            Directory.CreateDirectory(InvestitorovaDokumentacija);

            File.WriteAllBytes(TekstualnaDokumentacija + "\\Tekstualna dokumentacija, EEE.xlsm", Properties.Resources.EEE);
            File.WriteAllBytes(GrafickaDokumentacija + "\\Graficka dokumentacija, EEE.dwg", Properties.Resources.GrafickaDokumentacijaEEE);

            FrmInstanca.OsveziTabelu();

            MessageBox.Show("Predmet je uspešno napravljen.", "Projektovanje - Elaborati energetske efikasnosti", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
