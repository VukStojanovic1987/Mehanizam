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

namespace Mehanizam.Projektovanje.Ozakonjenja.Predmeti
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
            optOzakonjenje.Checked = true;
            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbKatastarskaOpstina); 
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.OzakonjenjaDirektorijum))
            {
                MessageBox.Show("Dirktorijum za ozakonjenja nije podešen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.OzakonjenjaDirektorijum))
            {
                MessageBox.Show("Podešeni dirktorijum '" + Properties.Settings.Default.OzakonjenjaDirektorijum + "' je obrisan ili izmešten sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja označena (*) moraju biti popunjena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NapraviPredmet();
        }

        //PROCEDURE
        private void NapraviPredmet()
        {
            string Naziv =  txtInvestitor.Text + ", k.p.br. " + txtBrojKatastarskeParcele.Text + " k.o. " + cmbKatastarskaOpstina.Text + ", " + cmbVrstaObjekta.Text + " " + txtBrojObjekta.Text;
            string Putanja = Properties.Settings.Default.OzakonjenjaDirektorijum + "\\" + Naziv;

            if (Directory.Exists(Putanja))
            {
                MessageBox.Show("Predmet pod nazivom '" + Naziv + "' već postoji.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (optOzakonjenje.Checked == true)
            {
                Ozakonjenje(Putanja);
            }

            if (optOzakonjenjeSkraceno.Checked == true)
            {
                OzakonjenjeSkraceno(Putanja);
            }

            FrmInstanca.OsveziTabelu();

            MessageBox.Show("Predmet je uspešno napravljen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void Ozakonjenje(string Putanja)
        {
            string TekstualnaDokumentacija = Putanja + "\\1 - Tekstualna dokumentacija";
            string GrafickaDokumentacija = Putanja + "\\2 - Graficka dokumentacija";
            string Fotografije = Putanja + "\\3 - Fotografije";
            string InvestitorovaDokumentacija = Putanja + "\\Investitorova dokumentacija";

            Directory.CreateDirectory(TekstualnaDokumentacija);
            Directory.CreateDirectory(GrafickaDokumentacija);
            Directory.CreateDirectory(Fotografije);
            Directory.CreateDirectory(InvestitorovaDokumentacija);

            File.WriteAllBytes(TekstualnaDokumentacija + "\\Tekstualna dokumentacija.xlsm", Properties.Resources.Ozakonjenje);
            File.WriteAllBytes(GrafickaDokumentacija + "\\Grafička dokumentacija.dwg", Properties.Resources.GrafickaDokumentacijaA);
            File.WriteAllBytes(Fotografije + "\\Fotografije.cdr", Properties.Resources.Fotografije);
        }

        private void OzakonjenjeSkraceno(string Putanja)
        {
            string TekstualnaDokumentacija = Putanja + "\\1 - Tekstualna dokumentacija";
            string Fotografije = Putanja + "\\2 - Fotografije";
            string InvestitorovaDokumentacija = Putanja + "\\Investitorova dokumentacija";

            Directory.CreateDirectory(TekstualnaDokumentacija);
            Directory.CreateDirectory(Fotografije);
            Directory.CreateDirectory(InvestitorovaDokumentacija);

            File.WriteAllBytes(TekstualnaDokumentacija + "\\Tekstualna dokumentacija.xlsm", Properties.Resources.OzakonjenjeSkraceno);
            File.WriteAllBytes(Fotografije + "\\Fotografije.cdr", Properties.Resources.Fotografije);
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
