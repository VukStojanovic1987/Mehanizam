using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanizam
{
    public partial class frmIndex : Form
    {
        //PROMENLJIVE
        private string _Naslov = "";
        private string _Podnaslov = "";

        //PODESAVANJA
        public string Naslov
        {
            set { _Naslov = value; }
            get { return _Naslov; }
        }
        public string Podnaslov
        {
            set { _Podnaslov = value; }
            get { return _Podnaslov; }
        }

        //KONSTRUKTOR
        public frmIndex()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmIndex_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.LozinkaZaProgram))
            {
                using (Podesavanja.frmLozinka Frm = new Podesavanja.frmLozinka())
                {
                    Frm.TipForma = 1;
                    Frm.ShowDialog();
                }
            }
        }

        //Meni - Click
        private void lblInformacije_Click(object sender, EventArgs e)
        {
            NaslovNavigacija("Informacije", lblInformacije, panInformacijePodmeni);
        }

        private void lblAdministracija_Click(object sender, EventArgs e)
        {
            NaslovNavigacija("Administracija", lblAdministracija, panAdministracijaPodmeni);
        }

        private void lblFinansije_Click(object sender, EventArgs e)
        {
            NaslovNavigacija("Finansije", lblFinansije, panFinansijePodmeni);
        }

        private void lblProjektovanje_Click(object sender, EventArgs e)
        {
            NaslovNavigacija("Projektovanje", lblProjektovanje, panProjektovanjePodmeni);
        }

        private void lblPrava_Click(object sender, EventArgs e)
        {
            NaslovNavigacija("Prava", lblPrava, panPravaPodmeni);
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPodesavanja_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.LozinkaZaPodesavanja))
            {
                using (Podesavanja.frmLozinka Frm = new Podesavanja.frmLozinka())
                {
                    Frm.TipForma = 2;
                    Frm.ShowDialog();
                }
            }
            else
            {
                using (Podesavanja.frmPodesavanja Frm = new Podesavanja.frmPodesavanja())
                {
                    Frm.ShowDialog();
                }
            }

            Cursor.Current = Cursors.Default;
        }

        //Podmeni - Click
        private void lblDrzave_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Drzave") { return; }
            PodnaslovNavigacija("Drzave", lblDrzave);
            Drzave();
        }

        private void lblOkruzi_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Okruzi") { return; }
            PodnaslovNavigacija("Okruzi", lblOkruzi);
            Okruzi();
        }

        private void lblOpstine_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Opstine") { return; }
            PodnaslovNavigacija("Opstine", lblOpstine);
            Opstine();
        }

        private void lblMesta_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Mesta") { return; }
            PodnaslovNavigacija("Mesta", lblMesta);
            Mesta();
        }

        private void lblBanke_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Banke") { return; }
            PodnaslovNavigacija("Banke", lblBanke);
            Banke();
        }

        private void lblTekuciRacuni_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Tekuci racuni") { return; }
            PodnaslovNavigacija("Tekuci racuni", lblTekuciRacuni);
            TekuciRacuni();
        }

        private void lblJediniceMere_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Jedinice mere") { return; }
            PodnaslovNavigacija("Jedinice mere", lblJediniceMere);
            JediniceMere();
        }

        private void lblValute_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Valute") { return; }
            PodnaslovNavigacija("Valute", lblValute);
            Valute();
        }

        private void lblZvanja_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Zvanja") { return; }
            PodnaslovNavigacija("Zvanja", lblZvanja);
            Zvanja();
        }

        private void lblLica_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Lica") { return; }
            PodnaslovNavigacija("Lica", lblLica);
            Lica();
        }

        private void lblProjektanti_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Projektanti") { return; }
            PodnaslovNavigacija("Projektanti", lblProjektanti);
            Projektanti();
        }

        private void lblMaterijali_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Materijali") { return; }
            PodnaslovNavigacija("Materijali", lblMaterijali);
            Materijali();
        }

        private void lblNameneProstorija_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Namene prostorija") { return; }
            PodnaslovNavigacija("Namene prostorija", lblNameneProstorija);
            NameneProstorija();
        }

        private void lblVrsteRadova_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Vrste radova") { return; }
            PodnaslovNavigacija("Vrste radova", lblVrsteRadova);
            VrsteRadova();
        }

        private void lblPrikljuciNaVodovod_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Prikljuci na vodovod") { return; }
            PodnaslovNavigacija("Prikljuci na vodovod", lblPrikljuciNaVodovod);
            PrikljuciNaVodovod();
        }

        private void lblPrikljuciNaKanalizaciju_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Prikljuci na kanalizaciju") { return; }
            PodnaslovNavigacija("Prikljuci na kanalizaciju", lblPrikljuciNaKanalizaciju);
            PrikljuciNaKanalizaciju();
        }

        private void lblPrikljuciNaElektro_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Prikljuci na elektro") { return; }
            PodnaslovNavigacija("Prikljuci na elektro", lblPrikljuciNaElektro);
            PrikljuciNaElektro();
        }

        private void lblPravilnikKlasifikacija_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Pravilnik o klasifikaciji objekata") { return; }
            PodnaslovNavigacija("Pravilnik o klasifikaciji objekata", lblPravilnikKlasifikacija);
            PravilnikKlasifikacija();
        }

        private void lblListaObjekataPoPravilnikuKlasifikacija_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Lista po pravilniku o klasifikaciji objekata") { return; }
            PodnaslovNavigacija("Lista po pravilniku o klasifikaciji objekata", lblListaObjekataPoPravilnikuKlasifikacija);
            ListaObjekataPoPravilnikuKlasifikacija();
        }

        private void lblInformacijePredmeriPredracuni_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Informacije - Predmer i predracun radova") { return; }
            PodnaslovNavigacija("Informacije - Predmer i predracun radova", lblInformacijePredmeriPredracuni);
            InformacijePredmerPredracun();
        }

        private void lblArhiva_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Arhiva") { return; }
            PodnaslovNavigacija("Arhiva", lblArhiva);
            Arhiva();
        }

        private void lblDelovodnik_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Delovodnik") { return; }
            PodnaslovNavigacija("Delovodnik", lblDelovodnik);
            Delovodnik();
        }

        private void lblPredracuni_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Predracuni") { return; }
            PodnaslovNavigacija("Predracuni", lblPredracuni);
            Predracuni();
        }

        private void lblRacuni_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Racuni") { return; }
            PodnaslovNavigacija("Racuni", lblRacuni);
            Racuni();
        }

        private void lblPriznanice_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Priznanice") { return; }
            PodnaslovNavigacija("Priznanice", lblPriznanice);
            Priznanice();
        }

        private void lblUplatnice_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Uplatnice") { return; }
            PodnaslovNavigacija("Uplatnice", lblUplatnice);
            Uplatnice();
        }

        private void lblOzakonjenja_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Ozakonjenja") { return; }
            PodnaslovNavigacija("Ozakonjenja", lblOzakonjenja);
            Ozakonjenja();
        }

        private void lblKatalozi_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Katalozi") { return; }
            PodnaslovNavigacija("Katalozi", lblKatalozi);
            Katalozi();
        }

        private void lblProjekti_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Projekti") { return; }
            PodnaslovNavigacija("Projekti", lblProjekti);
            ObjedinjenaProcedura();
        }

        private void lblCeop_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "CEOP") { return; }
            PodnaslovNavigacija("CEOP", lblCeop);
            CEOP();
        }

        private void lblRevizije_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Revizije") { return; }
            PodnaslovNavigacija("Revizije", lblRevizije);
            Revizije();
        }

        private void lblTehnickiPregledi_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Tehnicki pregledi") { return; }
            PodnaslovNavigacija("Tehnicki pregledi", lblTehnickiPregledi);
            TehnickiPregled();
        }

        private void lblPredmeriPredracuni_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Predmer i predracun radova") { return; }
            PodnaslovNavigacija("Predmer i predracun radova", lblPredmeriPredracuni);
            PredmerPredracun();
        }

        private void lblSpecifikacijeMaterijala_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Specifikacije materijala") { return; }
            PodnaslovNavigacija("Specifikacije materijala", lblSpecifikacijeMaterijala);
            SpecifikacijeMaterijala();
        }

        private void lblEEE_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "EEE") { return; }
            PodnaslovNavigacija("EEE", lblEEE);
            EEE();
        }

        private void lblOvlascenja_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Ovlascenja") { return; }
            PodnaslovNavigacija("Ovlascenja", lblOvlascenja);
            Ovlascenja();
        }

        private void lblUgovori_Click(object sender, EventArgs e)
        {
            if (Podnaslov == "Ugovori") { return; }
            PodnaslovNavigacija("Ugovori", lblUgovori);
            Ugovori();
        }

        //Podmeni, zatvori - click
        private void lblInfromacijePodMeniZatvori_Click(object sender, EventArgs e)
        {
            Naslov = "";
            panInformacijePodmeni.Visible = false;
            lblInformacije.ForeColor = Color.Gray;
        }

        private void lblAdministracijaPodmeniZatvori_Click(object sender, EventArgs e)
        {
            Naslov = "";
            panAdministracijaPodmeni.Visible = false;
            lblAdministracija.ForeColor = Color.Gray;
        }

        private void lblFinansijePodmeniZatvori_Click(object sender, EventArgs e)
        {
            Naslov = "";
            panFinansijePodmeni.Visible = false;
            lblFinansije.ForeColor = Color.Gray;
        }

        private void lblProjektovanjePodmeniZatvori_Click(object sender, EventArgs e)
        {
            Naslov = "";
            panProjektovanjePodmeni.Visible = false;
            lblProjektovanje.ForeColor = Color.Gray;
        }

        private void lblPravaPodmeniZatvori_Click(object sender, EventArgs e)
        {
            Naslov = "";
            panPravaPodmeni.Visible = false;
            lblPrava.ForeColor = Color.Gray;
        }

        //Meni - MauseEnter
        private void lblInformacije_MouseEnter(object sender, EventArgs e)
        {
            if(Naslov == "Informacije") { return; }

            lblInformacije.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblAdministracija_MouseEnter(object sender, EventArgs e)
        {
            if (Naslov == "Administracija") { return; }

            lblAdministracija.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblFinansije_MouseEnter(object sender, EventArgs e)
        {
            if (Naslov == "Finansije") { return; }

            lblFinansije.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblProjektovanje_MouseEnter(object sender, EventArgs e)
        {
            if (Naslov == "Projektovanje") { return; }

            lblProjektovanje.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblPrava_MouseEnter(object sender, EventArgs e)
        {
            if (Naslov == "Prava") { return; }

            lblPrava.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblPomoc_MouseEnter(object sender, EventArgs e)
        {
            if (Naslov == "Pomoc") { return; }

            lblPomoc.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblPodesavanja_MouseEnter(object sender, EventArgs e)
        {
            if (Naslov == "Podesavanja") { return; }

            lblPodesavanja.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        //Podmeni - MauseEnter
        private void lblDrzave_MouseEnter(object sender, EventArgs e)
        {
            if (_Podnaslov == "Drzave") { return; }

            lblDrzave.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblOkruzi_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Okruzi") { return; }

            lblOkruzi.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblOpstine_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Opstine") { return; }

            lblOpstine.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblMesta_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Mesta") { return; }

            lblMesta.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblBanke_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Banke") { return; }

            lblBanke.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblTekuciRacuni_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Tekuci racuni") { return; }

            lblTekuciRacuni.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblJediniceMere_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Jedinice mere") { return; }

            lblJediniceMere.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblValute_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Valute") { return; }

            lblValute.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblZvanja_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Zvanja") { return; }

            lblZvanja.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblLica_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Lica") { return; }

            lblLica.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblProjektanti_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Projektanti") { return; }

            lblProjektanti.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblMaterijali_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Materijali") { return; }

            lblMaterijali.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblNameneProstorija_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Namene prostorija") { return; }

            lblNameneProstorija.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblVrsteRadova_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Vrste radova") { return; }

            lblVrsteRadova.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblPrikljuciNaVodovod_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Prikljuci na vodovod") { return; }

            lblPrikljuciNaVodovod.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblPrikljuciNaKanalizaciju_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Prikljuci na kanalizaciju") { return; }

            lblPrikljuciNaKanalizaciju.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblPrikljuciNaElektro_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Prikljuci na elektro") { return; }

            lblPrikljuciNaElektro.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblInformacijePredmeriPredracuni_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Informacije - Predmer i predracun radova") { return; }

            lblInformacijePredmeriPredracuni.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblPravilnikKlasifikacija_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Pravilnik o klasifikaciji objekata") { return; }

            lblPravilnikKlasifikacija.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblListaObjekataPoPravilnikuKlasifikacija_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Lista po pravilniku o klasifikaciji objekata") { return; }

            lblListaObjekataPoPravilnikuKlasifikacija.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblArhiva_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Arhiva") { return; }

            lblArhiva.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblDelovodnik_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Delovodnik") { return; }

            lblDelovodnik.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblPredracuni_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Predracuni") { return; }

            lblPredracuni.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblRacuni_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Racuni") { return; }

            lblRacuni.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblPriznanice_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Priznanice") { return; }

            lblPriznanice.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblUplatnice_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Uplatnice") { return; }

            lblUplatnice.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblOzakonjenja_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Ozakonjenja") { return; }

            lblOzakonjenja.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblKatalozi_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Katalozi") { return; }

            lblKatalozi.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblProjekti_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Projekti") { return; }

            lblProjekti.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblCeop_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "CEOP") { return; }

            lblCeop.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblRevizije_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Revizije") { return; }

            lblRevizije.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblTehnickiPregledi_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Tehnicki pregledi") { return; }

            lblTehnickiPregledi.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblPredmeriPredracuni_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Predmer i predracun radova") { return; }

            lblPredmeriPredracuni.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblSpecifikacijeMaterijala_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Specifikacije materijala") { return; }

            lblSpecifikacijeMaterijala.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblEEE_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "EEE") { return; }

            lblEEE.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblOvlascenja_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Ovlascenja") { return; }

            lblOvlascenja.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblUgovori_MouseEnter(object sender, EventArgs e)
        {
            if (Podnaslov == "Ugovori") { return; }

            lblUgovori.ForeColor = ForeColor = Color.FromArgb(224, 224, 224);
        }

        //Podmeni, zatvori - MauseEnter
        private void lblInfromacijePodMeniZatvori_MouseEnter(object sender, EventArgs e)
        {
            lblInfromacijePodMeniZatvori.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblAdministracijaPodmeniZatvori_MouseEnter(object sender, EventArgs e)
        {
            lblAdministracijaPodmeniZatvori.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblFinansijePodmeniZatvori_MouseEnter(object sender, EventArgs e)
        {
            lblFinansijePodmeniZatvori.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblProjektovanjePodmeniZatvori_MouseEnter(object sender, EventArgs e)
        {
            lblProjektovanjePodmeniZatvori.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void lblPravaPodmeniZatvori_MouseEnter(object sender, EventArgs e)
        {
            lblPravaPodmeniZatvori.ForeColor = Color.FromArgb(224, 224, 224);
        }

        //Meni - MauseLeave
        private void lblInformacije_MouseLeave(object sender, EventArgs e)
        {
            if (Naslov == "Informacije") { return; }

            lblInformacije.ForeColor = Color.Gray;
        }

        private void lblAdministracija_MouseLeave(object sender, EventArgs e)
        {
            if (Naslov == "Administracija") { return; }

            lblAdministracija.ForeColor = Color.Gray;
        }

        private void lblFinansije_MouseLeave(object sender, EventArgs e)
        {
            if (Naslov == "Finansije") { return; }

            lblFinansije.ForeColor = Color.Gray;
        }

        private void lblProjektovanje_MouseLeave(object sender, EventArgs e)
        {
            if (Naslov == "Projektovanje") { return; }

            lblProjektovanje.ForeColor = Color.Gray;
        }

        private void lblPrava_MouseLeave(object sender, EventArgs e)
        {
            if (Naslov == "Prava") { return; }

            lblPrava.ForeColor = Color.Gray;
        }

        private void lblPomoc_MouseLeave(object sender, EventArgs e)
        {
            if (Naslov == "Pomoc") { return; }

            lblPomoc.ForeColor = Color.Gray;
        }

        private void lblPodesavanja_MouseLeave(object sender, EventArgs e)
        {
            if (Naslov == "Podesavanja") { return; }

            lblPodesavanja.ForeColor = Color.Gray;
        }

        //Podmeni - MauseLeave
        private void lblDrzave_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Drzave") { return; }

            lblDrzave.ForeColor = Color.Silver;
        }

        private void lblOkruzi_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Okruzi") { return; }

            lblOkruzi.ForeColor = Color.Silver;
        }

        private void lblOpstine_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Opstine") { return; }

            lblOpstine.ForeColor = Color.Silver;
        }

        private void lblMesta_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Mesta") { return; }

            lblMesta.ForeColor = Color.Silver;
        }

        private void lblBanke_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Banke") { return; }

            lblBanke.ForeColor = Color.Silver;
        }

        private void lblTekuciRacuni_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Tekuci racuni") { return; }

            lblTekuciRacuni.ForeColor = Color.Silver;
        }

        private void lblJediniceMere_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Jedinice mere") { return; }

            lblJediniceMere.ForeColor = Color.Silver;
        }

        private void lblValute_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Valute") { return; }

            lblValute.ForeColor = Color.Silver;
        }

        private void lblZvanja_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Zvanja") { return; }

            lblZvanja.ForeColor = Color.Silver;
        }

        private void lblLica_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Lica") { return; }

            lblLica.ForeColor = Color.Silver;
        }

        private void lblProjektanti_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Projektanti") { return; }

            lblProjektanti.ForeColor = Color.Silver;
        }

        private void lblMaterijali_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Materijali") { return; }

            lblMaterijali.ForeColor = Color.Silver;
        }

        private void lblNameneProstorija_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Namene prostorija") { return; }

            lblNameneProstorija.ForeColor = Color.Silver;
        }

        private void lblVrsteRadova_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Vrste radova") { return; }

            lblVrsteRadova.ForeColor = Color.Silver;
        }

        private void lblPrikljuciNaVodovod_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Prikljuci na vodovod") { return; }

            lblPrikljuciNaVodovod.ForeColor = Color.Silver;
        }

        private void lblPrikljuciNaKanalizaciju_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Prikljuci na kanalizaciju") { return; }

            lblPrikljuciNaKanalizaciju.ForeColor = Color.Silver;
        }

        private void lblPrikljuciNaElektro_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Prikljuci na elektro") { return; }

            lblPrikljuciNaElektro.ForeColor = Color.Silver;
        }

        private void lblInformacijePredmeriPredracuni_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Informacije - Predmer i predracun radova") { return; }

            lblInformacijePredmeriPredracuni.ForeColor = Color.Silver;
        }

        private void lblPravilnikKlasifikacija_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Pravilnik o klasifikaciji objekata") { return; }

            lblPravilnikKlasifikacija.ForeColor = Color.Silver;
        }

        private void lblListaObjekataPoPravilnikuKlasifikacija_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Lista po pravilniku o klasifikaciji objekata") { return; }

            lblListaObjekataPoPravilnikuKlasifikacija.ForeColor = Color.Silver;
        }

        private void lblArhiva_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Arhiva") { return; }

            lblArhiva.ForeColor = Color.Silver;
        }

        private void lblDelovodnik_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Delovodnik") { return; }

            lblDelovodnik.ForeColor = Color.Silver;
        }

        private void lblPredracuni_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Predracuni") { return; }

            lblPredracuni.ForeColor = Color.Silver;
        }

        private void lblRacuni_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Racuni") { return; }

            lblRacuni.ForeColor = Color.Silver;
        }

        private void lblPriznanice_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Priznanice") { return; }

            lblPriznanice.ForeColor = Color.Silver;
        }

        private void lblUplatnice_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Uplatnice") { return; }

            lblUplatnice.ForeColor = Color.Silver;
        }

        private void lblOzakonjenja_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Ozakonjenja") { return; }

            lblOzakonjenja.ForeColor = Color.Silver;
        }

        private void lblKatalozi_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Katalozi") { return; }

            lblKatalozi.ForeColor = Color.Silver;
        }

        private void lblProjekti_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Projekti") { return; }

            lblProjekti.ForeColor = Color.Silver;
        }

        private void lblCeop_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "CEOP") { return; }

            lblCeop.ForeColor = Color.Silver;
        }

        private void lblRevizije_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Revizije") { return; }

            lblRevizije.ForeColor = Color.Silver;
        }

        private void lblTehnickiPregledi_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Tehnicki pregledi") { return; }

            lblTehnickiPregledi.ForeColor = Color.Silver;
        }

        private void lblPredmeriPredracuni_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Predmer i predracun radova") { return; }

            lblPredmeriPredracuni.ForeColor = Color.Silver;
        }

        private void lblSpecifikacijeMaterijala_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Specifikacije materijala") { return; }

            lblSpecifikacijeMaterijala.ForeColor = Color.Silver;
        }

        private void lblEEE_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "EEE") { return; }

            lblEEE.ForeColor = Color.Silver;
        }

        private void lblOvlascenja_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Ovlascenja") { return; }

            lblOvlascenja.ForeColor = Color.Silver;
        }

        private void lblUgovori_MouseLeave(object sender, EventArgs e)
        {
            if (Podnaslov == "Ugovori") { return; }

            lblUgovori.ForeColor = Color.Silver;
        }

        //Podmeni, zatvori - MauseLeave
        private void lblInfromacijePodMeniZatvori_MouseLeave(object sender, EventArgs e)
        {
            lblInfromacijePodMeniZatvori.ForeColor = Color.Silver;
        }

        private void lblAdministracijaPodmeniZatvori_MouseLeave(object sender, EventArgs e)
        {
            lblAdministracijaPodmeniZatvori.ForeColor = Color.Silver;
        }

        private void lblFinansijePodmeniZatvori_MouseLeave(object sender, EventArgs e)
        {
            lblFinansijePodmeniZatvori.ForeColor = Color.Silver;
        }

        private void lblProjektovanjePodmeniZatvori_MouseLeave(object sender, EventArgs e)
        {
            lblProjektovanjePodmeniZatvori.ForeColor = Color.Silver;
        }

        private void lblPravaPodmeniZatvori_MouseLeave(object sender, EventArgs e)
        {
            lblPravaPodmeniZatvori.ForeColor = Color.Silver;
        }

        //PROCEDURE
        private void NaslovNavigacija(string parNaslov, Label lbl, Panel pan)
        {
            if (Naslov == parNaslov)
            {
                return;
            }

            foreach (Control con in panGlavniMeni.Controls)
            {
                if(con is Label)
                {
                    con.ForeColor = Color.Gray;
                }
            }

            Naslov = parNaslov;

            lbl.ForeColor = Color.FromArgb(64, 64, 64);

            panInformacijePodmeni.Visible = false;
            panAdministracijaPodmeni.Visible = false;
            panFinansijePodmeni.Visible = false;
            panProjektovanjePodmeni.Visible = false;
            panPravaPodmeni.Visible = false;

            pan.Visible = true;
        }

        private void PodnaslovNavigacija(string parPodnaslov, Label lbl)
        {
            if (Podnaslov == parPodnaslov)
            {
                return;
            }

            foreach (Control con in panInformacijePodmeni.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = Color.Silver;
                }
            }

            foreach (Control con in panAdministracijaPodmeni.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = Color.Silver;
                }
            }

            foreach (Control con in panFinansijePodmeni.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = Color.Silver;
                }
            }

            foreach (Control con in panProjektovanjePodmeni.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = Color.Silver;
                }
            }

            foreach (Control con in panPravaPodmeni.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = Color.Silver;
                }
            }

            Podnaslov = parPodnaslov;

            lbl.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void Drzave()
        {
            panPregled.Controls.Clear();

            Informacije.Drzave.frmPregled Frm = new Informacije.Drzave.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Okruzi()
        {
            panPregled.Controls.Clear();

            Informacije.Okruzi.frmPregled Frm = new Informacije.Okruzi.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Opstine()
        {
            panPregled.Controls.Clear();

            Informacije.Opstine.frmPregled Frm = new Informacije.Opstine.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Mesta()
        {
            panPregled.Controls.Clear();

            Informacije.Mesta.frmPregled Frm = new Informacije.Mesta.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Banke()
        {
            panPregled.Controls.Clear();

            Informacije.Banke.frmPregled Frm = new Informacije.Banke.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void TekuciRacuni()
        {
            panPregled.Controls.Clear();

            Informacije.TekuciRacuni.frmPregled Frm = new Informacije.TekuciRacuni.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void JediniceMere()
        {
            panPregled.Controls.Clear();

            Informacije.JediniceMere.frmPregled Frm = new Informacije.JediniceMere.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Valute()
        {
            panPregled.Controls.Clear();

            Informacije.Valute.frmPregled Frm = new Informacije.Valute.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Zvanja()
        {
            panPregled.Controls.Clear();

            Informacije.Zvanja.frmPregled Frm = new Informacije.Zvanja.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Lica()
        {
            panPregled.Controls.Clear();

            Informacije.Lica.frmPregled Frm = new Informacije.Lica.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Projektanti()
        {
            panPregled.Controls.Clear();

            Informacije.Projektanti.frmPregled Frm = new Informacije.Projektanti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Materijali()
        {
            panPregled.Controls.Clear();

            Informacije.Materijali.frmPregled Frm = new Informacije.Materijali.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void NameneProstorija()
        {
            panPregled.Controls.Clear();

            Informacije.NameneProstorija.frmPregled Frm = new Informacije.NameneProstorija.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void VrsteRadova()
        {
            panPregled.Controls.Clear();

            Informacije.VrsteRadova.frmPregled Frm = new Informacije.VrsteRadova.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void PrikljuciNaVodovod()
        {
            panPregled.Controls.Clear();

            Informacije.PrikljuciNaInfrastrukturu.PrikljuciNaVodovod.frmPregled Frm = new Informacije.PrikljuciNaInfrastrukturu.PrikljuciNaVodovod.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void PrikljuciNaKanalizaciju()
        {
            panPregled.Controls.Clear();

            Informacije.PrikljuciNaInfrastrukturu.PrikljuciNaKanalizaciju.frmPregled Frm = new Informacije.PrikljuciNaInfrastrukturu.PrikljuciNaKanalizaciju.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void PrikljuciNaElektro()
        {
            panPregled.Controls.Clear();

            Informacije.PrikljuciNaInfrastrukturu.PrikljuciNaElektro.frmPregled Frm = new Informacije.PrikljuciNaInfrastrukturu.PrikljuciNaElektro.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void InformacijePredmerPredracun()
        {
            panPregled.Controls.Clear();

            Informacije.PredmerPredracun.frmPregled Frm = new Informacije.PredmerPredracun.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void PravilnikKlasifikacija()
        {
            panPregled.Controls.Clear();

            Informacije.KlasifikacijaObjekata.Pravilnik.frmPregled Frm = new Informacije.KlasifikacijaObjekata.Pravilnik.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void ListaObjekataPoPravilnikuKlasifikacija()
        {
            panPregled.Controls.Clear();

            Informacije.KlasifikacijaObjekata.Lista.frmPregled Frm = new Informacije.KlasifikacijaObjekata.Lista.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Predracuni()
        {
            panPregled.Controls.Clear();

            Finansije.Predracuni.frmPregled Frm = new Finansije.Predracuni.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Racuni()
        {
            panPregled.Controls.Clear();

            Finansije.Racuni.frmPregled Frm = new Finansije.Racuni.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Priznanice()
        {
            panPregled.Controls.Clear();

            Finansije.Priznanice.frmPregled Frm = new Finansije.Priznanice.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Uplatnice()
        {
            panPregled.Controls.Clear();

            Finansije.Uplatnice.frmPregled Frm = new Finansije.Uplatnice.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Arhiva()
        {
            panPregled.Controls.Clear();

            Administracija.Arhiva.frmPregled Frm = new Administracija.Arhiva.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Delovodnik()
        {
            panPregled.Controls.Clear();

            Administracija.Delovodnik.frmPregled Frm = new Administracija.Delovodnik.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Ovlascenja()
        {
            panPregled.Controls.Clear();

            Prava.Ovlascenja.frmPregled Frm = new Prava.Ovlascenja.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Ugovori()
        {
            panPregled.Controls.Clear();

            Prava.Ugovori.Predmeti.frmPregled Frm = new Prava.Ugovori.Predmeti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Ozakonjenja()
        {
            panPregled.Controls.Clear();

            Projektovanje.Ozakonjenja.Predmeti.frmPregled Frm = new Projektovanje.Ozakonjenja.Predmeti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Katalozi()
        {
            panPregled.Controls.Clear();

            Projektovanje.Katalozi.Predmeti.frmPregled Frm = new Projektovanje.Katalozi.Predmeti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void ObjedinjenaProcedura()
        {
            panPregled.Controls.Clear();

            Projektovanje.Projekti.Predmeti.frmPregled Frm = new Projektovanje.Projekti.Predmeti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void CEOP()
        {
            panPregled.Controls.Clear();

            Projektovanje.CEOP.Predmet.frmPregled Frm = new Projektovanje.CEOP.Predmet.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void Revizije()
        {
            panPregled.Controls.Clear();

            Projektovanje.TehnickaKontrola.Predmeti.frmPregled Frm = new Projektovanje.TehnickaKontrola.Predmeti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void TehnickiPregled()
        {
            panPregled.Controls.Clear();

            Projektovanje.TehnickiPregled.Predmeti.frmPregled Frm = new Projektovanje.TehnickiPregled.Predmeti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void PredmerPredracun()
        {
            panPregled.Controls.Clear();

            Projektovanje.PredmerPredracun.Predmeti.frmPregled Frm = new Projektovanje.PredmerPredracun.Predmeti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void SpecifikacijeMaterijala()
        {
            panPregled.Controls.Clear();

            Projektovanje.SpecifikacijaMaterijala.Predmeti.frmPregled Frm = new Projektovanje.SpecifikacijaMaterijala.Predmeti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }

        private void EEE()
        {
            panPregled.Controls.Clear();

            Projektovanje.EEE.Predmeti.frmPregled Frm = new Projektovanje.EEE.Predmeti.frmPregled();
            Frm.frmIndexInstanca = this;
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panPregled.Controls.Add(Frm);
        }
    }
}
