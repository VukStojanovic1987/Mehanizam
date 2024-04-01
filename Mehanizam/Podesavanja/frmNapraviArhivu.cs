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

namespace Mehanizam.Podesavanja
{
    public partial class frmNapraviArhivu : Form
    {
        //KONSTRUKTOR
        public frmNapraviArhivu()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void btnPutanja_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog();

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                txtPutanja.Text = Dialog.SelectedPath;
            }
        }

        private void btnNapravi_Click(object sender, EventArgs e)
        {
            if (ImaPromena() == true)
            {
                MessageBox.Show("Polja obeležena (*) moraju biti popunjena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            NapraviArhivu();

            Cursor.Current = Cursors.Default;
        }

        //PROCEDURE
        private void NapraviArhivu()
        {
            string Putanja = txtPutanja.Text;
            string Arhiva = Putanja + "\\" + txtNaziv.Text;

            if (!Directory.Exists(Putanja))
            {
                MessageBox.Show("Direktorijum pod nazivom '" + Putanja + "' je obrisan ili izmešten sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Directory.Exists(Arhiva))
            {
                MessageBox.Show("Direktorijum pod nazivom '" + Arhiva + "' već postoji.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Baze
            string InformacijeBaze = Arhiva + "\\Baze\\Informacije";
            string AdministracijaBaze = Arhiva + "\\Baze\\Administracija";
            string FinansijeBaze = Arhiva + "\\Baze\\Finansije";
            string ProjektovanjeBaze = Arhiva + "\\Baze\\Projektovanje";
            string PravaBaze = Arhiva + "\\Baze\\Prava";

            Directory.CreateDirectory(InformacijeBaze);
            Directory.CreateDirectory(AdministracijaBaze);
            Directory.CreateDirectory(FinansijeBaze);
            Directory.CreateDirectory(ProjektovanjeBaze);
            Directory.CreateDirectory(PravaBaze);

            File.WriteAllBytes(InformacijeBaze + "\\Informacije.accdb", Properties.Resources.Informacije);
            File.WriteAllBytes(AdministracijaBaze + "\\Delovodnik.accdb", Properties.Resources.Delovodnik);
            File.WriteAllBytes(FinansijeBaze + "\\Predračuni.accdb", Properties.Resources.Predracuni);
            File.WriteAllBytes(FinansijeBaze + "\\Računi.accdb", Properties.Resources.Racuni);
            File.WriteAllBytes(FinansijeBaze + "\\Priznanice.accdb", Properties.Resources.Priznanice);
            File.WriteAllBytes(FinansijeBaze + "\\Uplatnice.accdb", Properties.Resources.Uplatnice);
            File.WriteAllBytes(ProjektovanjeBaze + "\\CEOP.accdb", Properties.Resources.CEOP);
            File.WriteAllBytes(PravaBaze + "\\Ovlašćenja.accdb", Properties.Resources.Ovlascenja);

            //Piloti
            string LicaPiloti = Arhiva + "\\Piloti\\Informacije\\Lica";
            string FinansijePiloti = Arhiva + "\\Piloti\\Finansije";
            string ProjektovanjePiloti = Arhiva + "\\Piloti\\Projektovanje";
            string PravaPiloti = Arhiva + "\\Piloti\\Prava";
            
            Directory.CreateDirectory(LicaPiloti);
            Directory.CreateDirectory(FinansijePiloti);
            Directory.CreateDirectory(ProjektovanjePiloti);
            Directory.CreateDirectory(PravaPiloti);

            File.WriteAllBytes(LicaPiloti + "\\Pismo.oft", Properties.Resources.Pismo);
            File.WriteAllBytes(FinansijePiloti + "\\Predračun.xlsm", Properties.Resources.Predracun);
            File.WriteAllBytes(FinansijePiloti + "\\Račun.xlsm", Properties.Resources.Racun);
            File.WriteAllBytes(FinansijePiloti + "\\Priznanica.xlsm", Properties.Resources.Priznanica);
            File.WriteAllBytes(FinansijePiloti + "\\Uplatnica.xlsm", Properties.Resources.Uplatnica);
            File.WriteAllBytes(ProjektovanjePiloti + "\\Tablice za crteže.dwg", Properties.Resources.TabliceZaCrteze);
            File.WriteAllBytes(PravaPiloti + "\\Ovlašćenje.xlsm", Properties.Resources.Ovlascenje);

            //Potpisi i pečati
            string LicaPotpisPecat = Arhiva + "\\Potpisi i pečati\\Lica";
            string ProjektantPotpisPecatGP = Arhiva + "\\Potpisi i pečati\\Glavni projektanti";
            string ProjektantPotpisPecatA = Arhiva + "\\Potpisi i pečati\\Projektanti arhitekture";
            string ProjektantPotpisPecatK = Arhiva + "\\Potpisi i pečati\\Projektanti konstrukcije";
            string ProjektantPotpisPecatH = Arhiva + "\\Potpisi i pečati\\Projektanti hidrotehničkih instalacija";
            string ProjektantPotpisPecatE = Arhiva + "\\Potpisi i pečati\\Projektanti elektroenergetskih instalacija";
            string ProjektantPotpisPecatTS = Arhiva + "\\Potpisi i pečati\\Projektanti telekomunikacionih i signalnih instalacija";
            string ProjektantPotpisPecatM = Arhiva + "\\Potpisi i pečati\\Projektanti mašinskih instalacija";

            Directory.CreateDirectory(LicaPotpisPecat);
            Directory.CreateDirectory(ProjektantPotpisPecatGP);
            Directory.CreateDirectory(ProjektantPotpisPecatA);
            Directory.CreateDirectory(ProjektantPotpisPecatK);
            Directory.CreateDirectory(ProjektantPotpisPecatH);
            Directory.CreateDirectory(ProjektantPotpisPecatE);
            Directory.CreateDirectory(ProjektantPotpisPecatTS);
            Directory.CreateDirectory(ProjektantPotpisPecatM);

            //Finansije
            string PredracuniIzlazni = Arhiva + "\\Finansije\\Predračuni\\Izlazni";
            string PredracuniUlazni = Arhiva + "\\Finansije\\Predračuni\\Ulazni";
            string RacuniIzlazni = Arhiva + "\\Finansije\\Računi\\Izlazni";
            string RacuniUlazni = Arhiva + "\\Finansije\\Računi\\Ulazni";
            string Priznanice = Arhiva + "\\Finansije\\Priznanice";
            string Uplatnice = Arhiva + "\\Finansije\\Uplatnice";
            string SituacijeIzlazne = Arhiva + "\\Finansije\\Situacije\\Izlazne";
            string SituacijeUlazne = Arhiva + "\\Finansije\\Situacije\\Ulazne";
            string Izvodi = Arhiva + "\\Finansije\\Banka\\Izvodi";
            string PdvPrijave = Arhiva + "\\Finansije\\PDV\\Prijave";
            string PdvPotvrde = Arhiva + "\\Finansije\\PDV\\Potvrde";

            Directory.CreateDirectory(PredracuniIzlazni);
            Directory.CreateDirectory(PredracuniUlazni);
            Directory.CreateDirectory(RacuniIzlazni);
            Directory.CreateDirectory(RacuniUlazni);
            Directory.CreateDirectory(Priznanice);
            Directory.CreateDirectory(Uplatnice);
            Directory.CreateDirectory(Izvodi);
            Directory.CreateDirectory(PdvPrijave);
            Directory.CreateDirectory(PdvPotvrde);

            //Projektovanje
            string Ozakonjenja = Arhiva + "\\Projektovanje\\Ozakonjenja";
            string Katalozi = Arhiva + "\\Projektovanje\\Katalozi";
            string Projekti = Arhiva + "\\Projektovanje\\Projekti";
            string CEOP = Arhiva + "\\Projektovanje\\CEOP";
            string Revizije = Arhiva + "\\Projektovanje\\Tehničke kontrole projekata";
            string TehnickiPregledi = Arhiva + "\\Projektovanje\\Tehnički pregledi objekata";
            string PredmeriPredracuni = Arhiva + "\\Projektovanje\\Predmeri i predračuni radova";
            string SpecifikacijeMaterijala = Arhiva + "\\Projektovanje\\Specifikacije materijala";
            string EEE = Arhiva + "\\Projektovanje\\Elaborati energetske efikasnosti";

            Directory.CreateDirectory(Ozakonjenja);
            Directory.CreateDirectory(Katalozi);
            Directory.CreateDirectory(Projekti);
            Directory.CreateDirectory(CEOP);
            Directory.CreateDirectory(Revizije);
            Directory.CreateDirectory(TehnickiPregledi);
            Directory.CreateDirectory(PredmeriPredracuni);
            Directory.CreateDirectory(SpecifikacijeMaterijala);
            Directory.CreateDirectory(EEE);
            
            //Prava
            string Ovlascenja = Arhiva + "\\Prava\\Ovlašćenja";
            string Ugovori = Arhiva + "\\Prava\\Ugovori";

            Directory.CreateDirectory(Ovlascenja);
            Directory.CreateDirectory(Ugovori);

            //Licence
            string ProjektantLicenceProjektanskeA = Arhiva + "\\Licence\\Projektanti arhitekture\\Projektanske";
            string ProjektantLicenceIzvodjackeA = Arhiva + "\\Licence\\Projektanti arhitekture\\Izvođačke";
            string ProjektantLicenceProjektanskeK = Arhiva + "\\Licence\\Projektanti konstrukcije\\Projektanske";
            string ProjektantLicenceIzvodjackeK = Arhiva + "\\Licence\\Projektanti konstrukcije\\Izvođačke";
            string ProjektantLicenceProjektanskeH = Arhiva + "\\Licence\\Projektanti hidrotehničkih instalacija\\Projektanske";
            string ProjektantLicenceIzvodjackeH = Arhiva + "\\Licence\\Projektanti hidrotehničkih instalacija\\Izvođačke";
            string ProjektantLicenceProjektanskeE = Arhiva + "\\Licence\\Projektanti elektroenergetskih instalacija\\Projektanske";
            string ProjektantLicenceIzvodjackeE = Arhiva + "\\Licence\\Projektanti elektroenergetskih instalacija\\Izvođačke";
            string ProjektantLicenceProjektanskeTS = Arhiva + "\\Licence\\Projektanti telekomunikacionih i signalnih instalacija\\Projektanske";
            string ProjektantLicenceIzvodjackeTS = Arhiva + "\\Licence\\Projektanti telekomunikacionih i signalnih instalacija\\Izvođačke";
            string ProjektantLicenceProjektanskeM = Arhiva + "\\Licence\\Projektanti mašinskih instalacija\\Projektanske";
            string ProjektantLicenceIzvodjackeM = Arhiva + "\\Licence\\Projektanti mašinskih instalacija\\Izvođačke";

            Directory.CreateDirectory(ProjektantLicenceProjektanskeA);
            Directory.CreateDirectory(ProjektantLicenceIzvodjackeA);
            Directory.CreateDirectory(ProjektantLicenceProjektanskeK);
            Directory.CreateDirectory(ProjektantLicenceIzvodjackeK);
            Directory.CreateDirectory(ProjektantLicenceProjektanskeH);
            Directory.CreateDirectory(ProjektantLicenceIzvodjackeH);
            Directory.CreateDirectory(ProjektantLicenceProjektanskeE);
            Directory.CreateDirectory(ProjektantLicenceIzvodjackeE);
            Directory.CreateDirectory(ProjektantLicenceProjektanskeTS);
            Directory.CreateDirectory(ProjektantLicenceIzvodjackeTS);
            Directory.CreateDirectory(ProjektantLicenceProjektanskeM);
            Directory.CreateDirectory(ProjektantLicenceIzvodjackeM);

            //Lične karte
            string LicneKarte = Arhiva + "\\Lične karte";

            Directory.CreateDirectory(LicneKarte);

            //Izvođenje
            string Izvodjenje = Arhiva + "\\Izvođenje";

            Directory.CreateDirectory(Izvodjenje);

            //Nadzor
            string Nadzor = Arhiva + "\\Nadzor";

            Directory.CreateDirectory(Nadzor);

            //Ponude
            string PonudeIzlazne = Arhiva + "\\Ponude\\Izlazne";
            string PonudeUlazne = Arhiva + "\\Ponude\\Ulazne";

            Directory.CreateDirectory(PonudeIzlazne);
            Directory.CreateDirectory(PonudeUlazne);

            //Dopisi, pisma
            string DopisiPisma = Arhiva + "\\Dopisi i pisma";

            Directory.CreateDirectory(DopisiPisma);

            //Zakoni i pravilnici
            string ZakoniPravilnici = Arhiva + "\\Zakoni i pravilnici";

            Directory.CreateDirectory(ZakoniPravilnici);

            //Mehanizam (Literatura)
            string MehanaizamLiteratura = Arhiva + "\\Mehanizam (literatura)";

            Directory.CreateDirectory(MehanaizamLiteratura);

            MessageBox.Show("Arhiva je uspešno kreirana.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        //FUNKCIJE
        private bool ImaPromena()
        {
            if(string.IsNullOrWhiteSpace(txtPutanja.Text) || string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
