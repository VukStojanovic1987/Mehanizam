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
    public partial class frmPodesavanja : Form
    {

        public frmPodesavanja()
        {
            InitializeComponent();
        }

        private void frmPodesavanja_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }

        //Meni - Click
        private void lblArhiva_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpArhiva);
        }

        private void lblDirektorijumi_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpDirektorijumi);
        }

        private void lblBaze_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpBaze);
        }

        private void lblPiloti_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpPiloti);
        }

        private void lblPotpisiPecati_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpPotpisiPecati);
        }

        private void lblPretpostavljeneVrednosti_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpPretpostavljeneVrednosti);
        }

        private void lblOgranicenja_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpOgranicenja);
        }

        private void lblBezbednost_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpBezbednost);
        }

        //Meni - MauseEnter
        private void lblArhiva_MouseEnter(object sender, EventArgs e)
        {
            lblArhiva.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblDirektorijumi_MouseEnter(object sender, EventArgs e)
        {
            lblDirektorijumi.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblBaze_MouseEnter(object sender, EventArgs e)
        {
            lblBaze.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblPiloti_MouseEnter(object sender, EventArgs e)
        {
            lblPiloti.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblPotpisiPecati_MouseEnter(object sender, EventArgs e)
        {
            lblPotpisiPecati.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblPretpostavljeneVrednosti_MouseEnter(object sender, EventArgs e)
        {
            lblPretpostavljeneVrednosti.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblOgranicenja_MouseEnter(object sender, EventArgs e)
        {
            lblOgranicenja.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblBezbednost_MouseEnter(object sender, EventArgs e)
        {
            lblBezbednost.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        //Meni - MauseLeave
        private void lblArhiva_MouseLeave(object sender, EventArgs e)
        {
            lblArhiva.ForeColor = Color.Gray;
        }

        private void lblDirektorijumi_MouseLeave(object sender, EventArgs e)
        {
            lblDirektorijumi.ForeColor = Color.Gray;
        }

        private void lblBaze_MouseLeave(object sender, EventArgs e)
        {
            lblBaze.ForeColor = Color.Gray;
        }

        private void lblPiloti_MouseLeave(object sender, EventArgs e)
        {
            lblPiloti.ForeColor = Color.Gray;
        }

        private void lblPotpisiPecati_MouseLeave(object sender, EventArgs e)
        {
            lblPotpisiPecati.ForeColor = Color.Gray;
        }

        private void lblPretpostavljeneVrednosti_MouseLeave(object sender, EventArgs e)
        {
            lblPretpostavljeneVrednosti.ForeColor = Color.Gray;
        }

        private void lblOgranicenja_MouseLeave(object sender, EventArgs e)
        {
            lblOgranicenja.ForeColor = Color.Gray;
        }

        private void lblBezbednost_MouseLeave(object sender, EventArgs e)
        {
            lblBezbednost.ForeColor = Color.Gray;
        }

        //Arhiva
        private void btnArhivaDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtArhivaDirektorijum);
        }

        private void btnArhivaKopijeDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtArhivaKopijeDirektorijum);
        }

        private void btnNapraviArhivu_Click(object sender, EventArgs e)
        {
            using (frmNapraviArhivu frm = new frmNapraviArhivu())
            {
                frm.ShowDialog();
            }
        }

        private void btnNapraviKopijuArhive_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            NapraviKopijuArhive();

            Cursor.Current = Cursors.Default;
        }

        //Direktorijumi
        private void btnPredracuniDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPredracuniDirektorijum);
        }

        private void btnRacuniDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtRacuniDirektorijum);
        }

        private void btnPriznaniceDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPriznaniceDirektorijum);
        }

        private void btnUplatniceDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtUplatniceDirektorijum);
        }

        private void btnOzakonjenjaDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtOzakonjenjaDirektorijum);
        }

        private void btnKataloziDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtKataloziDirektorijum);
        }

        private void btnObjedinjenaProceduraDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtProjektiDirektorijum);
        }

        private void btnCeopDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtCeopDirektorijum);
        }

        private void btnRevizijaDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtRevizijaDirektorijum);
        }

        private void btnTehnickiPregledDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtTehnickiPregledDirektorijum);
        }

        private void btnPredmerPredracunDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPredmerPredracunDirektorijum);
        }

        private void btnSpecifikacijaMaterijalaDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtSpecifikacijaMaterijalaDirektorijum);
        }

        private void btnEeeDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtEeeDirektorijum);
        }

        private void btnOvlascenjaDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtOvlascenjaDirektorijum);
        }

        private void btnUgovoriDirektorijum_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtUgovoriDirektorijum);
        }

        //Baze
        private void btnInformacijeBaza_Click(object sender, EventArgs e)
        {
            OdabirDatotekeAccess(txtInformacijeBaza);
        }

        private void btnDelovodnikBaza_Click(object sender, EventArgs e)
        {
            OdabirDatotekeAccess(txtDelovodnikBaza);
        }

        private void btnPredracuniBaza_Click(object sender, EventArgs e)
        {
            OdabirDatotekeAccess(txtPredracuniBaza);
        }

        private void btnRacuniBaza_Click(object sender, EventArgs e)
        {
            OdabirDatotekeAccess(txtRacuniBaza);
        }

        private void btnPriznaniceBaza_Click(object sender, EventArgs e)
        {
            OdabirDatotekeAccess(txtPriznaniceBaza);
        }

        private void btnUplatniceBaza_Click(object sender, EventArgs e)
        {
            OdabirDatotekeAccess(txtUplatniceBaza);
        }

        private void btnCeopBaza_Click(object sender, EventArgs e)
        {
            OdabirDatotekeAccess(txtCeopBaza);
        }

        private void btnOvlascenjaBaza_Click(object sender, EventArgs e)
        {
            OdabirDatotekeAccess(txtOvlascenjaBaza);
        }

        private void btnNapraviBazuInformacije_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuAccess();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Informacije);
                MessageBox.Show("Baza je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapraviBazuDelovodnik_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuAccess();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Delovodnik);
                MessageBox.Show("Baza je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapraviteBazuPredracuni_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuAccess();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Predracuni);
                MessageBox.Show("Baza je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapraviteBazuRacuni_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuAccess();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Racuni);
                MessageBox.Show("Baza je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapraviteBazuPriznanice_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuAccess();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Priznanice);
                MessageBox.Show("Datoteka je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapraviteBazuUplatnice_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuAccess();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Uplatnice);
                MessageBox.Show("Datoteka je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapraviteBazuCeop_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuAccess();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.CEOP);
                MessageBox.Show("Datoteka je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapraviteBazuOvlascenja_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuAccess();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Ovlascenja);
                MessageBox.Show("Baza je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Piloti
        private void btnPismoPilot_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();

            Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Dialog.Title = "Odaberite pilot";
            Dialog.Filter = "Outlook Item Template (*.oft)|*.oft";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                txtPismoPilot.Text = Dialog.FileName;
            }
        }

        private void btnlblNapravitePilotPismo_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dialog = new SaveFileDialog();

            Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Dialog.Title = "Napravite pilot";
            Dialog.DefaultExt = "oft";
            Dialog.Filter = "Outlook Item Template (*.oft)|*.oft";
            Dialog.FilterIndex = 2;
            Dialog.AddExtension = true;
            //Dialog.CheckFileExists = true;
            Dialog.CheckPathExists = true;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(Dialog.FileName, Properties.Resources.Pismo);
                MessageBox.Show("Datoteka je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPredracunPilot_Click(object sender, EventArgs e)
        {
            OdabirDatotekeExcel(txtPredracunPilot);
        }

        private void btnRacunPilot_Click(object sender, EventArgs e)
        {
            OdabirDatotekeExcel(txtRacunPilot);
        }

        private void btnPriznanicaPilot_Click(object sender, EventArgs e)
        {
            OdabirDatotekeExcel(txtPriznanicaPilot);
        }

        private void btnUplatnicaPilot_Click(object sender, EventArgs e)
        {
            OdabirDatotekeExcel(txtUplatnicaPilot);
        }

        private void btnOvlascenjePilot_Click(object sender, EventArgs e)
        {
            OdabirDatotekeExcel(txtOvlascenjePilot);
        }

        private void btnNapravitePilotPredracun_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuExcel();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Predracun);
                MessageBox.Show("Pilot je uspešno napravljen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapravitePilotRacun_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuExcel();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Racun);
                MessageBox.Show("Pilot je uspešno napravljen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapravitePilotPriznanica_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuExcel();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Priznanica);
                MessageBox.Show("Pilot je uspešno napravljen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapravitePilotUplatnica_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuExcel();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Uplatnica);
                MessageBox.Show("Pilot je uspešno napravljen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNapravitePilotOvlascenje_Click(object sender, EventArgs e)
        {
            string Putanja = NapraviDatotekuExcel();

            if (Putanja != "")
            {
                File.WriteAllBytes(Putanja, Properties.Resources.Ovlascenje);
                MessageBox.Show("Pilot je uspešno napravljen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Potpisi i pečati
        private void btnPotpisiPecatiLica_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPotpisiPecatiLica);
        }

        private void btnPotpisiPecatiGP_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPotpisiPecatiGP);
        }

        private void btnPotpisiPecatiA_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPotpisiPecatiA);
        }

        private void btntxtPotpisiPecatiK_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPotpisiPecatiK);
        }

        private void btnPotpisiPecatiH_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPotpisiPecatiH);
        }

        private void btnPotpisiPecatiE_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPotpisiPecatiE);
        }

        private void btnPotpisiPecatiTS_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPotpisiPecatiTS);
        }

        private void btnPotpisiPecatiM_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPotpisiPecatiM);
        }

        private void btnPotpisiPecatiEEE_Click(object sender, EventArgs e)
        {
            OdabirDirektorijuma(txtPotpisiPecatiEEE);
        }

        //Pretpostavljene vrednosti
        private void btnPvOvlascenjaDavaocOvlascenja_Click(object sender, EventArgs e)
        {
            using(Odabir.frmLica frm = new Odabir.frmLica())
            {
                frm.txtPoljeZaUnos = txtPvOvlascenjaDavaocOvlascenja;
                frm.ShowDialog();
            }
        }

        private void btnPvOvlascenjaPrimaocOvlascenja_Click(object sender, EventArgs e)
        {
            using (Odabir.frmLica frm = new Odabir.frmLica())
            {
                frm.txtPoljeZaUnos = txtPvOvlascenjaPrimaocOvlascenja;
                frm.ShowDialog();
            }
        }
        
        private void btnSnimi_Click(object sender, EventArgs e)
        {
            Snimi();
            Close();
        }

        //PROCEDURE
        private void Ucitaj()
        {
            //Arhiva
            txtArhivaDirektorijum.Text = Properties.Settings.Default.ArhivaDirektorijum;
            txtArhivaKopijeDirektorijum.Text = Properties.Settings.Default.ArhivaKopijaDirektrijum;

            //Direktorijumi
            txtPredracuniDirektorijum.Text = Properties.Settings.Default.PredracuniDirektorijum;
            txtRacuniDirektorijum.Text = Properties.Settings.Default.RacuniDirektorijum;
            txtPriznaniceDirektorijum.Text = Properties.Settings.Default.PriznaniceDirektorijum;
            txtUplatniceDirektorijum.Text = Properties.Settings.Default.UplatniceDirektorijum;
            txtOzakonjenjaDirektorijum.Text = Properties.Settings.Default.OzakonjenjaDirektorijum;
            txtKataloziDirektorijum.Text = Properties.Settings.Default.KataloziDirektorijum;
            txtProjektiDirektorijum.Text = Properties.Settings.Default.ProjektiDirektorijum;
            txtCeopDirektorijum.Text = Properties.Settings.Default.CeopDirektorijum;
            txtRevizijaDirektorijum.Text = Properties.Settings.Default.RevizijaDirektorijum;
            txtTehnickiPregledDirektorijum.Text = Properties.Settings.Default.TehnickiPregledDirektorijum;
            txtPredmerPredracunDirektorijum.Text = Properties.Settings.Default.PredmerPredracunDirektorijum;
            txtSpecifikacijaMaterijalaDirektorijum.Text = Properties.Settings.Default.SpecifikacijeMaterijalaDirektorijum;
            txtEeeDirektorijum.Text = Properties.Settings.Default.EeeDirektorijum;
            txtOvlascenjaDirektorijum.Text = Properties.Settings.Default.OvlascenjaDirektorijum;
            txtUgovoriDirektorijum.Text = Properties.Settings.Default.UgovoriDirektorijum;

            //Baze
            txtInformacijeBaza.Text = Properties.Settings.Default.InformacijeBaza;
            txtDelovodnikBaza.Text = Properties.Settings.Default.DelovodnikBaza;
            txtPredracuniBaza.Text = Properties.Settings.Default.PredracuniBaza;
            txtRacuniBaza.Text = Properties.Settings.Default.RacuniBaza;
            txtPriznaniceBaza.Text = Properties.Settings.Default.PriznaniceBaza;
            txtUplatniceBaza.Text = Properties.Settings.Default.UplatniceBaza;
            txtCeopBaza.Text = Properties.Settings.Default.CeopBaza;
            txtOvlascenjaBaza.Text = Properties.Settings.Default.OvlascenjaBaza;

            //Piloti
            txtPismoPilot.Text = Properties.Settings.Default.PismoPilot;
            txtPredracunPilot.Text = Properties.Settings.Default.PredracunPilot;
            txtRacunPilot.Text = Properties.Settings.Default.RacunPilot;
            txtPriznanicaPilot.Text = Properties.Settings.Default.PriznanicaPilot;
            txtUplatnicaPilot.Text = Properties.Settings.Default.UplatnicaPilot;
            txtOvlascenjePilot.Text = Properties.Settings.Default.OvlascenjePilot;

            //Potpisi i pečati
            txtPotpisiPecatiLica.Text = Properties.Settings.Default.PotpisiPecatiLica;
            txtPotpisiPecatiGP.Text = Properties.Settings.Default.PotpisiPecatiGP;
            txtPotpisiPecatiA.Text = Properties.Settings.Default.PotpisiPecatiA;
            txtPotpisiPecatiK.Text = Properties.Settings.Default.PotpisiPecatiK;
            txtPotpisiPecatiH.Text = Properties.Settings.Default.PotpisiPecatiH;
            txtPotpisiPecatiE.Text = Properties.Settings.Default.PotpisiPecatiE;
            txtPotpisiPecatiTS.Text = Properties.Settings.Default.PotpisiPecatiTS;
            txtPotpisiPecatiEEE.Text = Properties.Settings.Default.PotpisiPecatiEEE;

            //Pretpostavljene vrednosti
            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbPvOvlascenjaMesto);

            cmbPvOvlascenjaMesto.Text = Properties.Settings.Default.PvOvlascenjaMesto;
            cmbPvOvlascenjaJedninaMnozina1.Text = Properties.Settings.Default.PvOvlascenjaJedninaMnozina1;
            txtPvOvlascenjaDavaocOvlascenja.Text = Properties.Settings.Default.PvOvlascenjaOvlascenjeDao;
            txtPvOvlascenjaPrimaocOvlascenja.Text = Properties.Settings.Default.PvOvlascenjaOvlascenjePrimio;
            cmbPvOvlascenjaJedninaMnozina2.Text = Properties.Settings.Default.PvOvlascenjaJedninaMnozina2;
            txtPvOvlascenjaKontekst.Text = Properties.Settings.Default.PvOvlascenjaKontekst;

            //Ogranicenja
            ckbPristupDirektorijumuPredracuni.Checked = Properties.Settings.Default.PredracuniPristupDirektorijumu;
            ckbPristupDirektorijumuRacuni.Checked = Properties.Settings.Default.RacuniPristupDirektorijumu;
            ckbPristupDirektorijumuPriznanice.Checked = Properties.Settings.Default.PriznanicePristupDirektorijumu;
            ckbPristupDirektorijumuUplatnice.Checked = Properties.Settings.Default.UplatnicePristupDirektorijumu;
            ckbPristupDirektorijumuOvlascenja.Checked = Properties.Settings.Default.OvlascenjaPristupDirektorijumu;

            ckbPristupBaziInformacije.Checked = Properties.Settings.Default.InformacijePristupBazi;
            ckbPristupBaziDelovodnik.Checked = Properties.Settings.Default.DelovodnikPristupBazi;
            ckbPristupBaziPredracuni.Checked = Properties.Settings.Default.PredracuniPristupBazi;
            ckbPristupBaziRacuni.Checked = Properties.Settings.Default.RacuniPristupBazi;
            ckbPristupBaziPriznanice.Checked = Properties.Settings.Default.PriznanicePristupBazi;
            ckbPristupBaziUplatnice.Checked = Properties.Settings.Default.UplatnicePristupBazi;
            ckbPristupBaziCEOP.Checked = Properties.Settings.Default.CeopPristupBazi;
            ckbPristupBaziOvlascenja.Checked = Properties.Settings.Default.OvlascenjaPristupBazi;
            ckbPristupDirektorijumuOzakonjenja.Checked = Properties.Settings.Default.OzakonjenjePristupDirektorijumu;
            ckbPristupDirektorijumuOzakonjenjePredmet.Checked = Properties.Settings.Default.OzakonjenjePredmetPristupDirektorijumu;
            ckbPristupDirektorijumuKatalozi.Checked = Properties.Settings.Default.KatalogPristupDirektorijumu;
            ckbPristupDirektorijumuKatalogPredmet.Checked = Properties.Settings.Default.KatalogPredmetPristupDirektorijumu;
            ckbPristupDirektorijumuObjedinjeneProcedure.Checked = Properties.Settings.Default.ProjektiPristupDirektorijumu;
            ckbPristupDirektorijumuObjedinjenaProceduraPredmet.Checked = Properties.Settings.Default.ProjektiPredmetPristupDirektorijumu;
            ckbPristupDirektorijumuCeop.Checked = Properties.Settings.Default.CeopPristupDirektorijumu;
            ckbPristupDirektorijumuCeopPredmet.Checked = Properties.Settings.Default.CeopPredmetPristupDirektorijumu;
            ckbPristupDirektorijumuRevizije.Checked = Properties.Settings.Default.RevizijaPristupDirektorijumu;
            ckbPristupDirektorijumuRevizijaPredmet.Checked = Properties.Settings.Default.RevizijaPredmetPristupDirektorijumu;
            ckbPristupDirektorijumuTehnickiPregledi.Checked = Properties.Settings.Default.TehnickiPregledPristupDirektorijumu;
            ckbPristupDirektorijumuTehnickiPregledPredmet.Checked = Properties.Settings.Default.TehnickiPregledPredmetPristupDirektorijumu;
            ckbPristupDirektorijumuPredmeriPredracuni.Checked = Properties.Settings.Default.PredmerPredracunPristupDirektorijumu;
            ckbPristupDirektorijumuPredmerPredracunPredmet.Checked = Properties.Settings.Default.PredmerPredracunPredmetPristupDirektorijumu;
            ckbPristupDirektorijumuSpecifikacijeMaterijala.Checked = Properties.Settings.Default.SpecifikacijaMaterijalaPristupDirektorijumu;
            ckbPristupDirektorijumuSpecifikacijaMaterijalaPredmet.Checked = Properties.Settings.Default.SpecifikacijaMaterijalaPredmetPristupDirektorijumu;
            ckbPristupDirektorijumuEee.Checked = Properties.Settings.Default.EeePristupDirektorijumu;
            ckbPristupDirektorijumuEeePredmet.Checked = Properties.Settings.Default.EeePredmetPristupDirektorijumu;
            ckbPristupDirektorijumuUgovora.Checked = Properties.Settings.Default.UgovoriPristupDirektorijumu;
            ckbPristupDirektorijumuUgovorPredmet.Checked = Properties.Settings.Default.UgovorPredmetPristupDirektorijumu;

            //Bezbednost
            txtLozinkaZaProgram.Text = Properties.Settings.Default.LozinkaZaProgram;
            txtLozinkaZaPodesavanja.Text = Properties.Settings.Default.LozinkaZaPodesavanja;
        }

        private void Snimi()
        {
            //Arhiva
            Properties.Settings.Default.ArhivaDirektorijum = txtArhivaDirektorijum.Text;
            Properties.Settings.Default.ArhivaKopijaDirektrijum = txtArhivaKopijeDirektorijum.Text;

            //Direktorijumi
            Properties.Settings.Default.PredracuniDirektorijum = txtPredracuniDirektorijum.Text;
            Properties.Settings.Default.RacuniDirektorijum = txtRacuniDirektorijum.Text;
            Properties.Settings.Default.PriznaniceDirektorijum = txtPriznaniceDirektorijum.Text;
            Properties.Settings.Default.UplatniceDirektorijum = txtUplatniceDirektorijum.Text;
            Properties.Settings.Default.OzakonjenjaDirektorijum = txtOzakonjenjaDirektorijum.Text;
            Properties.Settings.Default.KataloziDirektorijum = txtKataloziDirektorijum.Text;
            Properties.Settings.Default.ProjektiDirektorijum = txtProjektiDirektorijum.Text;
            Properties.Settings.Default.CeopDirektorijum = txtCeopDirektorijum.Text;
            Properties.Settings.Default.RevizijaDirektorijum = txtRevizijaDirektorijum.Text;
            Properties.Settings.Default.TehnickiPregledDirektorijum = txtTehnickiPregledDirektorijum.Text;
            Properties.Settings.Default.PredmerPredracunDirektorijum = txtPredmerPredracunDirektorijum.Text;
            Properties.Settings.Default.SpecifikacijeMaterijalaDirektorijum = txtSpecifikacijaMaterijalaDirektorijum.Text;
            Properties.Settings.Default.EeeDirektorijum = txtEeeDirektorijum.Text;
            Properties.Settings.Default.OvlascenjaDirektorijum = txtOvlascenjaDirektorijum.Text;
            Properties.Settings.Default.UgovoriDirektorijum = txtUgovoriDirektorijum.Text;

            //Baze
            Properties.Settings.Default.InformacijeBaza = txtInformacijeBaza.Text;
            Properties.Settings.Default.DelovodnikBaza = txtDelovodnikBaza.Text;
            Properties.Settings.Default.PredracuniBaza = txtPredracuniBaza.Text;
            Properties.Settings.Default.RacuniBaza = txtRacuniBaza.Text;
            Properties.Settings.Default.PriznaniceBaza = txtPriznaniceBaza.Text;
            Properties.Settings.Default.UplatniceBaza = txtUplatniceBaza.Text;
            Properties.Settings.Default.CeopBaza = txtCeopBaza.Text;
            Properties.Settings.Default.OvlascenjaBaza = txtOvlascenjaBaza.Text;

            //Piloti
            Properties.Settings.Default.PismoPilot = txtPismoPilot.Text;
            Properties.Settings.Default.PredracunPilot = txtPredracunPilot.Text;
            Properties.Settings.Default.RacunPilot = txtRacunPilot.Text;
            Properties.Settings.Default.PriznanicaPilot = txtPriznanicaPilot.Text;
            Properties.Settings.Default.UplatnicaPilot = txtUplatnicaPilot.Text;
            Properties.Settings.Default.OvlascenjePilot = txtOvlascenjePilot.Text;

            //Potpisi i pečati
            Properties.Settings.Default.PotpisiPecatiLica = txtPotpisiPecatiLica.Text;
            Properties.Settings.Default.PotpisiPecatiGP = txtPotpisiPecatiGP.Text;
            Properties.Settings.Default.PotpisiPecatiA = txtPotpisiPecatiA.Text;
            Properties.Settings.Default.PotpisiPecatiK = txtPotpisiPecatiK.Text;
            Properties.Settings.Default.PotpisiPecatiH = txtPotpisiPecatiH.Text;
            Properties.Settings.Default.PotpisiPecatiE = txtPotpisiPecatiE.Text;
            Properties.Settings.Default.PotpisiPecatiTS = txtPotpisiPecatiTS.Text;
            Properties.Settings.Default.PotpisiPecatiEEE = txtPotpisiPecatiEEE.Text;

            //Pretpostavljene vrednosti
            Properties.Settings.Default.PvOvlascenjaMesto = cmbPvOvlascenjaMesto.Text;
            Properties.Settings.Default.PvOvlascenjaJedninaMnozina1 = cmbPvOvlascenjaJedninaMnozina1.Text;
            Properties.Settings.Default.PvOvlascenjaOvlascenjeDao = txtPvOvlascenjaDavaocOvlascenja.Text;
            Properties.Settings.Default.PvOvlascenjaOvlascenjePrimio = txtPvOvlascenjaPrimaocOvlascenja.Text;
            Properties.Settings.Default.PvOvlascenjaJedninaMnozina2 = cmbPvOvlascenjaJedninaMnozina2.Text;
            Properties.Settings.Default.PvOvlascenjaKontekst = txtPvOvlascenjaKontekst.Text;

            //Ogranicenja
            Properties.Settings.Default.PredracuniPristupDirektorijumu = ckbPristupDirektorijumuPredracuni.Checked;
            Properties.Settings.Default.RacuniPristupDirektorijumu = ckbPristupDirektorijumuRacuni.Checked;
            Properties.Settings.Default.PriznanicePristupDirektorijumu = ckbPristupDirektorijumuPriznanice.Checked;
            Properties.Settings.Default.UplatnicePristupDirektorijumu = ckbPristupDirektorijumuUplatnice.Checked;
            Properties.Settings.Default.OvlascenjaPristupDirektorijumu = ckbPristupDirektorijumuOvlascenja.Checked;

            Properties.Settings.Default.InformacijePristupBazi = ckbPristupBaziInformacije.Checked;
            Properties.Settings.Default.DelovodnikPristupBazi = ckbPristupBaziDelovodnik.Checked;
            Properties.Settings.Default.PredracuniPristupBazi = ckbPristupBaziPredracuni.Checked;
            Properties.Settings.Default.RacuniPristupBazi = ckbPristupBaziRacuni.Checked;
            Properties.Settings.Default.PriznanicePristupBazi = ckbPristupBaziPriznanice.Checked;
            Properties.Settings.Default.UplatnicePristupBazi = ckbPristupBaziUplatnice.Checked;
            Properties.Settings.Default.CeopPristupBazi = ckbPristupBaziCEOP.Checked;
            Properties.Settings.Default.OvlascenjaPristupBazi = ckbPristupBaziOvlascenja.Checked;
            Properties.Settings.Default.OzakonjenjePristupDirektorijumu = ckbPristupDirektorijumuOzakonjenja.Checked;
            Properties.Settings.Default.OzakonjenjePredmetPristupDirektorijumu = ckbPristupDirektorijumuOzakonjenjePredmet.Checked;
            Properties.Settings.Default.KatalogPristupDirektorijumu = ckbPristupDirektorijumuKatalozi.Checked;
            Properties.Settings.Default.KatalogPredmetPristupDirektorijumu = ckbPristupDirektorijumuKatalogPredmet.Checked;
            Properties.Settings.Default.ProjektiPristupDirektorijumu = ckbPristupDirektorijumuObjedinjeneProcedure.Checked;
            Properties.Settings.Default.ProjektiPredmetPristupDirektorijumu = ckbPristupDirektorijumuObjedinjenaProceduraPredmet.Checked;
            Properties.Settings.Default.CeopPristupDirektorijumu = ckbPristupDirektorijumuCeop.Checked;
            Properties.Settings.Default.CeopPredmetPristupDirektorijumu = ckbPristupDirektorijumuCeopPredmet.Checked;
            Properties.Settings.Default.RevizijaPristupDirektorijumu = ckbPristupDirektorijumuRevizije.Checked;
            Properties.Settings.Default.RevizijaPredmetPristupDirektorijumu = ckbPristupDirektorijumuRevizijaPredmet.Checked;
            Properties.Settings.Default.TehnickiPregledPristupDirektorijumu = ckbPristupDirektorijumuTehnickiPregledi.Checked;
            Properties.Settings.Default.TehnickiPregledPredmetPristupDirektorijumu = ckbPristupDirektorijumuTehnickiPregledPredmet.Checked;
            Properties.Settings.Default.PredmerPredracunPristupDirektorijumu = ckbPristupDirektorijumuPredmeriPredracuni.Checked;
            Properties.Settings.Default.PredmerPredracunPredmetPristupDirektorijumu = ckbPristupDirektorijumuPredmerPredracunPredmet.Checked;
            Properties.Settings.Default.SpecifikacijaMaterijalaPristupDirektorijumu = ckbPristupDirektorijumuSpecifikacijeMaterijala.Checked;
            Properties.Settings.Default.SpecifikacijaMaterijalaPredmetPristupDirektorijumu = ckbPristupDirektorijumuSpecifikacijaMaterijalaPredmet.Checked;
            Properties.Settings.Default.EeePristupDirektorijumu = ckbPristupDirektorijumuEee.Checked;
            Properties.Settings.Default.EeePredmetPristupDirektorijumu = ckbPristupDirektorijumuEeePredmet.Checked;
            Properties.Settings.Default.UgovoriPristupDirektorijumu = ckbPristupDirektorijumuUgovora.Checked;
            Properties.Settings.Default.UgovorPredmetPristupDirektorijumu = ckbPristupDirektorijumuUgovorPredmet.Checked;

            //Bezbednost
            Properties.Settings.Default.LozinkaZaProgram = txtLozinkaZaProgram.Text;
            Properties.Settings.Default.LozinkaZaPodesavanja = txtLozinkaZaPodesavanja.Text;

            Properties.Settings.Default.Save();
        }

        private void OdabirDirektorijuma(TextBox txt)
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog();

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                txt.Text = Dialog.SelectedPath;
            }
        }
       
        private void OdabirDatotekeAccess(TextBox txt)
        {
            OpenFileDialog Dialog = new OpenFileDialog();

            Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Dialog.Title = "Odaberite bazu";
            Dialog.Filter = "Access files (*.accdb)|*.accdb";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                txt.Text = Dialog.FileName;
            }
        }

        private void OdabirDatotekeExcel(TextBox txt)
        {
            OpenFileDialog Dialog = new OpenFileDialog();

            Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Dialog.Title = "Odaberite pilot";
            Dialog.Filter = "Excel files (*.xlsm)|*.xlsm";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                txt.Text = Dialog.FileName;
            }
        }

        //FUNKCIJE
        private string NapraviDatotekuAccess()
        {
            SaveFileDialog Dialog = new SaveFileDialog();

            Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Dialog.Title = "Napravite bazu";
            Dialog.DefaultExt = "accdb";
            Dialog.Filter = "Access files (*.accdb)|*.accdb";
            Dialog.FilterIndex = 2;
            Dialog.AddExtension = true;
            //Dialog.CheckFileExists = true;
            Dialog.CheckPathExists = true;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                return Dialog.FileName;
            }

            return "";
        }

        private string NapraviDatotekuExcel()
        {
            SaveFileDialog Dialog = new SaveFileDialog();

            Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Dialog.Title = "Napravite pilot";
            Dialog.DefaultExt = "xlsm";
            Dialog.Filter = "Excel files (*.xlsm)|*.xlsm";
            Dialog.FilterIndex = 2;
            Dialog.AddExtension = true;
            //Dialog.CheckFileExists = true;
            Dialog.CheckPathExists = true;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                return Dialog.FileName;
            }

            return "";
        }

        private void NapraviKopijuArhive()
        {
            string PutanjaArhive = txtArhivaDirektorijum.Text;
            string PutanjaKopijaArhive = txtArhivaKopijeDirektorijum.Text;

            if (string.IsNullOrWhiteSpace(PutanjaArhive))
            {
                MessageBox.Show("Putanja direktorijuma arhive nije podešena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(PutanjaKopijaArhive))
            {
                MessageBox.Show("Putanja direktorijuma za kopije arhive nije podešena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(PutanjaArhive))
            {
                MessageBox.Show("Podešeni dirketorijum '" + PutanjaArhive + "' je obrisan ili izmešten sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(PutanjaKopijaArhive))
            {
                MessageBox.Show("Podešeni dirketorijum '" + PutanjaKopijaArhive + "' je obrisan ili izmešten sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Želite li da napravite kopiju arhive?", "Mehanizam", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            DirectoryInfo dir = new DirectoryInfo(PutanjaArhive);

            string Vreme = Convert.ToString(DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second);
            string Datum = Convert.ToString(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);

            string NazivKopijeArhive = dir.Name + "_kopija_vreme_" + Vreme + "_datum_" + Datum;

            if (Directory.Exists(PutanjaKopijaArhive + "\\" + NazivKopijeArhive))
            {
                MessageBox.Show("Kopija arhive pod nazivom '" + NazivKopijeArhive + "' već postoji.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Directory.CreateDirectory(PutanjaKopijaArhive + "\\" + NazivKopijeArhive);

            try
            {
                foreach (string DirPutanja in Directory.GetDirectories(PutanjaArhive, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(DirPutanja.Replace(PutanjaArhive, PutanjaKopijaArhive + "\\" + NazivKopijeArhive));
                }

                foreach (string NovaPutanja in Directory.GetFiles(PutanjaArhive, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(NovaPutanja, NovaPutanja.Replace(PutanjaArhive, PutanjaKopijaArhive + "\\" + NazivKopijeArhive), true);
                }

                MessageBox.Show("Kopija arhive '" + NazivKopijeArhive + "' je uspešno napravljena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
