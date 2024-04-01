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
    public partial class frmUredi : Form
    {
        //PROMENLJIVE
        private frmPregled _frmPregledInstanca = null;
        private long _ID;
        private string BrojZahteva;

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
        private void frmUredi_Load(object sender, EventArgs e)
        {
            btnZahtevDirektorijum.Enabled = Properties.Settings.Default.CeopPredmetPristupDirektorijumu;
            btnProjekatDirektorijum.Enabled = Properties.Settings.Default.ProjektiPredmetPristupDirektorijumu;
            btnRevizijaDirektorijum.Enabled = Properties.Settings.Default.RevizijaPredmetPristupDirektorijumu;
            btnEeeDirektorijum.Enabled = Properties.Settings.Default.EeePredmetPristupDirektorijumu;
            btnTehnickiPregledDirektorijum.Enabled = Properties.Settings.Default.TehnickiPregledPredmetPristupDirektorijumu;

            Ucitaj();

            OsveziZahtev();
            OsveziProjekat();
            OsveziReviziju();
            OsveziEEE();
            OsveziTehnickiPregled();
        }

        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsLetterOrDigit(e.KeyChar) & e.KeyChar != Convert.ToChar("-"))
            {
                e.Handled = true;
            }
        }

        //Meni - Click
        private void lblPodaciNavigacija_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpPodaci);
        }

        private void lblZahtevNavigacija_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpZahtev);
        }

        private void lblProjekatNavigacija_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpProjekat);
        }

        private void lblRevizijaNavigacija_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpRevizija);
        }

        private void lblEeeNavigacija_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpEEE);
        }

        private void lblTehnickiPregledNavigacija_Click(object sender, EventArgs e)
        {
            panKontekst.ScrollControlIntoView(grpTehnickiPregled);
        }

        //Meni - MauseEnter
        private void lblPodaciNavigacija_MouseEnter(object sender, EventArgs e)
        {
            lblPodaciNavigacija.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblZahtevNavigacija_MouseEnter(object sender, EventArgs e)
        {
            lblZahtevNavigacija.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblProjekatNavigacija_MouseEnter(object sender, EventArgs e)
        {
            lblProjekatNavigacija.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblRevizijaNavigacija_MouseEnter(object sender, EventArgs e)
        {
            lblRevizijaNavigacija.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblEeeNavigacija_MouseEnter(object sender, EventArgs e)
        {
            lblEeeNavigacija.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblTehnickiPregledNavigacija_MouseEnter(object sender, EventArgs e)
        {
            lblTehnickiPregledNavigacija.ForeColor = ForeColor = Color.FromArgb(64, 64, 64);
        }

        //Meni - MauseLeave
        private void lblPodaciNavigacija_MouseLeave(object sender, EventArgs e)
        {
            lblPodaciNavigacija.ForeColor = Color.Gray;
        }

        private void lblZahtevNavigacija_MouseLeave(object sender, EventArgs e)
        {
            lblZahtevNavigacija.ForeColor = Color.Gray;
        }

        private void lblProjekatNavigacija_MouseLeave(object sender, EventArgs e)
        {
            lblProjekatNavigacija.ForeColor = Color.Gray;
        }

        private void lblRevizijaNavigacija_MouseLeave(object sender, EventArgs e)
        {
            lblRevizijaNavigacija.ForeColor = Color.Gray;
        }

        private void lblEeeNavigacija_MouseLeave(object sender, EventArgs e)
        {
            lblEeeNavigacija.ForeColor = Color.Gray;
        }

        private void lblTehnickiPregledNavigacija_MouseLeave(object sender, EventArgs e)
        {
            lblTehnickiPregledNavigacija.ForeColor = Color.Gray;
        }

        //Osvezi TreeView - TextChanged
        private void txtProjekat_TextChanged(object sender, EventArgs e)
        {
            OsveziProjekat();
        }

        private void txtRevizija_TextChanged(object sender, EventArgs e)
        {
            OsveziReviziju();
        }

        private void txtEEE_TextChanged(object sender, EventArgs e)
        {
            OsveziEEE();
        }

        private void txtTehnickiPregled_TextChanged(object sender, EventArgs e)
        {
            OsveziTehnickiPregled();
        }

        //Dodaj dokumentaciju - Click
        private void btnProjekat_Click(object sender, EventArgs e)
        {
            Odabir.frmProjektovanjePredmeti frm = new Odabir.frmProjektovanjePredmeti();
            frm.txtPoljeZaDodavanje = txtProjekat;
            frm.GlavniDirektorijum = Properties.Settings.Default.ProjektiDirektorijum;
            frm.Text = "Projektovanje - Objedinjena procedura";
            frm.ShowDialog();
        }

        private void btnRevizija_Click(object sender, EventArgs e)
        {
            Odabir.frmProjektovanjePredmeti frm = new Odabir.frmProjektovanjePredmeti();
            frm.txtPoljeZaDodavanje = txtRevizija;
            frm.GlavniDirektorijum = Properties.Settings.Default.RevizijaDirektorijum;
            frm.Text = "Projektovanje - Tehničke kontrole projekata";
            frm.ShowDialog();
        }

        private void btnEEE_Click(object sender, EventArgs e)
        {
            Odabir.frmProjektovanjePredmeti frm = new Odabir.frmProjektovanjePredmeti();
            frm.txtPoljeZaDodavanje = txtEEE;
            frm.GlavniDirektorijum = Properties.Settings.Default.EeeDirektorijum;
            frm.Text = "Projektovanje - Elaborati Energetske efikasnosti";
            frm.ShowDialog();
        }

        private void btnTehnickiPregled_Click(object sender, EventArgs e)
        {
            Odabir.frmProjektovanjePredmeti frm = new Odabir.frmProjektovanjePredmeti();
            frm.txtPoljeZaDodavanje = txtTehnickiPregled;
            frm.GlavniDirektorijum = Properties.Settings.Default.TehnickiPregledDirektorijum;
            frm.Text = "Projektovanje - Tehnički pregledi objekata";
            frm.ShowDialog();
        }

        private void btnZahtevWeb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZahtevWeb.Text))
            {
                MessageBox.Show("Polje ne sadrži URL.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(txtZahtevWeb.Text);
            }
            catch
            {
                MessageBox.Show("Datototeka nije pronađena ili URL.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Osvezi TreeView - Click
        private void btnZahtevOsvezi_Click(object sender, EventArgs e)
        {
            OsveziZahtev();
        }

        private void btnProjekatOsvezi_Click(object sender, EventArgs e)
        {
            OsveziProjekat();
        }

        private void btnRevizijaOsvezi_Click(object sender, EventArgs e)
        {
            OsveziReviziju();
        }

        private void btnEeeOsvezi_Click(object sender, EventArgs e)
        {
            OsveziEEE();
        }

        private void btnTehnickiPregledOsvezi_Click(object sender, EventArgs e)
        {
            OsveziTehnickiPregled();
        }

        //Otvori direktorijum - Click
        private void btnZahtevDirektorijum_Click(object sender, EventArgs e)
        {
            if (IspravnostDirektorijumaPredmeta(Properties.Settings.Default.CeopDirektorijum, BrojZahteva, "Projektovanje - CEOP") == false) { return; }

            System.Diagnostics.Process.Start(Properties.Settings.Default.CeopDirektorijum + "\\" + BrojZahteva);
        }

        private void btnProjekatDirektorijum_Click(object sender, EventArgs e)
        {
            if (IspravnostDirektorijumaPredmeta(Properties.Settings.Default.ProjektiDirektorijum, txtProjekat.Text, "Projektovanje - Objedinjena procedura") == false) { return; }

            System.Diagnostics.Process.Start(Properties.Settings.Default.ProjektiDirektorijum + "\\" + txtProjekat.Text);
        }

        private void btnRevizijaDirektorijum_Click(object sender, EventArgs e)
        {
            if (IspravnostDirektorijumaPredmeta(Properties.Settings.Default.RevizijaDirektorijum, txtRevizija.Text, "Projektovanje - Tehnička kontrola projekta") == false) { return; }

            System.Diagnostics.Process.Start(Properties.Settings.Default.RevizijaDirektorijum + "\\" + txtRevizija.Text);
        }

        private void btnEeeDirektorijum_Click(object sender, EventArgs e)
        {
            if (IspravnostDirektorijumaPredmeta(Properties.Settings.Default.EeeDirektorijum, txtEEE.Text, "Projektovanje - Elaborat energetske efikasnosti") == false) { return; }

            System.Diagnostics.Process.Start(Properties.Settings.Default.EeeDirektorijum + "\\" + txtEEE.Text);
        }

        private void btnTehnickiPregledDirektorijum_Click(object sender, EventArgs e)
        {
            if (IspravnostDirektorijumaPredmeta(Properties.Settings.Default.TehnickiPregledDirektorijum, txtTehnickiPregled.Text, "Projektovanje - Tehnički pregled objekta") == false) { return; }

            System.Diagnostics.Process.Start(Properties.Settings.Default.TehnickiPregledDirektorijum + "\\" + txtTehnickiPregled.Text);
        }

        //Otvori datoteku - NudeMauseDoubleClick
        private void treZahtev_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OtvoriDatoteku(Properties.Settings.Default.CeopDirektorijum + "\\" + txtBroj.Text + "\\" + e.Node.FullPath);
        }

        private void treProjekat_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OtvoriDatoteku(Properties.Settings.Default.ProjektiDirektorijum + "\\" + txtProjekat.Text + "\\" + e.Node.FullPath);
        }

        private void treRevizija_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OtvoriDatoteku(Properties.Settings.Default.RevizijaDirektorijum + "\\" + txtRevizija.Text + "\\" + e.Node.FullPath);
        }

        private void treEEE_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OtvoriDatoteku(Properties.Settings.Default.EeeDirektorijum + "\\" + txtEEE.Text + "\\" + e.Node.FullPath);
        }

        private void treTehnickiPregled_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OtvoriDatoteku(Properties.Settings.Default.TehnickiPregledDirektorijum + "\\" + txtTehnickiPregled.Text + "\\" + e.Node.FullPath);
        }

        //Izvezi - Click
        private void btnIzvezi_Click(object sender, EventArgs e)
        {
            frmIzveziZahtev frm = new frmIzveziZahtev();
            frm.BrojZahteva = BrojZahteva;
            frm.Projekat = txtProjekat.Text;
            frm.Revizija = txtRevizija.Text;
            frm.EEE = txtEEE.Text;
            frm.TehnickiPregled = txtTehnickiPregled.Text;
            frm.ShowDialog();
        }

        //Snimi - Click
        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja obeležena (*) moraju biti popunjena.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.CeopBaza);

            AccessBP.DodajParametre("@ID", ID);
            AccessBP.IzvrsiUpit("SELECT * FROM tblCeopZahtevi WHERE ID=@ID");

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

            Odabir.clsCeopVrsteZahteva Mesta = new Odabir.clsCeopVrsteZahteva(cmbVrstaZahteva);

            DataRow Red = AccessBP.TabelaBP.Rows[0];

            dtpDatum.Value = Convert.ToDateTime(Red["Datum"]);
            BrojZahteva = Convert.ToString(Red["BrojZahteva"]);
            txtBroj.Text = BrojZahteva;
            cmbVrstaZahteva.Text = Convert.ToString(Red["VrstaZahteva"]);
            txtNazivPredmeta.Text = Convert.ToString(Red["NazivPredmeta"]);
            txtProjekat.Text = Convert.ToString(Red["Projekat"]);
            txtRevizija.Text = Convert.ToString(Red["Revizija"]);
            txtEEE.Text = Convert.ToString(Red["EEE"]);
            txtTehnickiPregled.Text = Convert.ToString(Red["TehnickiPregled"]);
            txtZahtevWeb.Text = Convert.ToString(Red["ZahtevWeb"]);
            cmbStatusZahteva.Text = Convert.ToString(Red["StatusZahteva"]);
        }

        private void Snimi()
        {
            //if (IspravnostCeopDirektorijuma() == false) { return; }

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.CeopBaza);

            AccessBP.DodajParametre("@Datum", Datum(dtpDatum.Value));
            AccessBP.DodajParametre("@BrojZahteva", txtBroj.Text);
            AccessBP.DodajParametre("@VrstaZahteva", cmbVrstaZahteva.Text);
            AccessBP.DodajParametre("@NazivPredmeta", txtNazivPredmeta.Text);
            AccessBP.DodajParametre("@Projekat", txtProjekat.Text);
            AccessBP.DodajParametre("@Revizija", txtRevizija.Text);
            AccessBP.DodajParametre("@EEE", txtEEE.Text);
            AccessBP.DodajParametre("@TehnickiPregled", txtTehnickiPregled.Text);
            AccessBP.DodajParametre("@ZahtevWeb", txtZahtevWeb.Text);
            AccessBP.DodajParametre("@StatusZahteva", cmbStatusZahteva.Text);
            AccessBP.DodajParametre("@ID", ID);

            AccessBP.IzvrsiUpit("UPDATE tblCeopZahtevi Set Datum=@Datum, BrojZahteva=@BrojZahteva, VrstaZahteva=@VrstaZahteva, NazivPredmeta=@NazivPredmeta, Projekat=@Projekat, Revizija=@Revizija, EEE=@EEE, TehnickiPregled=@TehnickiPregled, ZahtevWeb=@ZahtevWeb, StatusZahteva=@StatusZahteva WHERE ID=@ID");

            //if (AccessBP.Greska == true)
            //{
            //    MessageBox.Show(AccessBP.Izuzetak, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //try
            //{
            //    if (BrojZahteva != txtBroj.Text)
            //    {
            //        Directory.Move(Properties.Settings.Default.CeopDirektorijum + "\\" + BrojZahteva, Properties.Settings.Default.CeopDirektorijum + "\\" + txtBroj.Text);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            frmPregledInstanca.OsveziTabelu();
        }

        //Osvezi
        private void Osvezi(string GlavniDirektorijum, string Predmet, Label lblPoruka, TreeView trePregled)
        {
            trePregled.Nodes.Clear();

            if (string.IsNullOrWhiteSpace(GlavniDirektorijum))
            {
                lblPoruka.Text = "Direktorijum za predmete nije podešen.";
                lblPoruka.Visible = true;
                return;
            }

            if (!Directory.Exists(GlavniDirektorijum))
            {
                lblPoruka.Text = "Direktorijum '" + GlavniDirektorijum + "' je obrisan ili izmešten.";
                lblPoruka.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(Predmet))
            {
                lblPoruka.Text = "Tekstualno polje za ovaj pregled je prazno.";
                lblPoruka.Visible = true;
                return;
            }

            if (!Directory.Exists(GlavniDirektorijum + "\\" + Predmet))
            {
                lblPoruka.Text = "Direktorijum '" + GlavniDirektorijum + "\\" + Predmet + "' nije pronađen.";
                lblPoruka.Visible = true;
                return;
            }

            lblPoruka.Text = "";
            lblPoruka.Visible = false;

            Kontrole.clsTreeView TreeView = new Kontrole.clsTreeView();
            TreeView.PopuniListu(GlavniDirektorijum + "\\" + Predmet, trePregled.Nodes);

            trePregled.ExpandAll();
        }

        private void OsveziZahtev()
        {
            Osvezi(Properties.Settings.Default.CeopDirektorijum, BrojZahteva, lblZahtevPoruka, treZahtev);

            if (lblZahtevPoruka.Visible == true)
            {
                lblZahtevNaslov.Text = "Zahtev '...'";
            }
            else
            {
                lblZahtevNaslov.Text = "Zahtev '" + BrojZahteva + "'";
            }
        }

        private void OsveziProjekat()
        {
            Osvezi(Properties.Settings.Default.ProjektiDirektorijum, txtProjekat.Text, lblProjekatPoruka, treProjekat);

            if (lblProjekatPoruka.Visible == true)
            {
                lblProjekatNaslov.Text = "Projekat '...'";
            }
            else
            {
                lblProjekatNaslov.Text = "Projekat '" + txtProjekat.Text + "'";
            }
        }

        private void OsveziReviziju()
        {
            Osvezi(Properties.Settings.Default.RevizijaDirektorijum, txtRevizija.Text, lblRevizijaPoruka, treRevizija);

            if (lblRevizijaPoruka.Visible == true)
            {
                lblRevizijaNaslov.Text = "Tehnička kontrola projekta '...'";
            }
            else
            {
                lblRevizijaNaslov.Text = "Tehnička kontrola projekta '" + txtRevizija.Text + "'";
            }
        }

        private void OsveziEEE()
        {
            Osvezi(Properties.Settings.Default.EeeDirektorijum, txtEEE.Text, lblEeePoruka, treEEE);

            if (lblEeePoruka.Visible == true)
            {
                lblEeeNaslov.Text = "Elaborat energetske efikasnosti '...'";
            }
            else
            {
                lblEeeNaslov.Text = "Elaborat energetske efikasnosti '" + txtEEE.Text + "'";
            }
        }

        private void OsveziTehnickiPregled()
        {
            Osvezi(Properties.Settings.Default.TehnickiPregledDirektorijum, txtTehnickiPregled.Text, lblTehnickiPregledPoruka, treTehnickiPregled);

            if (lblTehnickiPregledPoruka.Visible == true)
            {
                lblTehnickiPregledNaslov.Text = "Tehnički pregled objekta '...'";
            }
            else
            {
                lblTehnickiPregledNaslov.Text = "Tehnički pregled objekta '" + txtTehnickiPregled.Text + "'";
            }
        }

        //FUNKCIJE
        private bool PraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(txtBroj.Text) ||
                string.IsNullOrWhiteSpace(cmbVrstaZahteva.Text) ||
                string.IsNullOrWhiteSpace(txtNazivPredmeta.Text) ||
                string.IsNullOrWhiteSpace(cmbStatusZahteva.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Ispravnost direktorijuma, putanja
        private bool IspravnostCeopDirektorijuma()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.CeopDirektorijum))
            {
                MessageBox.Show("Direktorijum za CEOP zahteve nije podešen.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!Directory.Exists(Properties.Settings.Default.CeopDirektorijum))
            {
                MessageBox.Show("Direktorijum '" + Properties.Settings.Default.CeopDirektorijum + "' je obrisan ili izmešten.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!Directory.Exists(Properties.Settings.Default.CeopDirektorijum + "\\" + BrojZahteva))
            {
                MessageBox.Show("Direktorijum zahteva '" + Properties.Settings.Default.CeopDirektorijum + "\\" + BrojZahteva + "' nije pronađen.", "Projektovanje - CEOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool IspravnostDirektorijumaPredmeta(string GlavniDirektorijum, string Predmet, string NaslovPoruke)
        {
            if (string.IsNullOrWhiteSpace(GlavniDirektorijum))
            {
                MessageBox.Show("Direktorijum za ovaj program nije podešen.", NaslovPoruke, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!Directory.Exists(GlavniDirektorijum))
            {
                MessageBox.Show("Direktorijum '" + Properties.Settings.Default.CeopDirektorijum + "' je obrisan ili izmešten.", NaslovPoruke, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Predmet))
            {
                MessageBox.Show("Tekstualno polje za ovaj pregled je prazno.", NaslovPoruke, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!Directory.Exists(GlavniDirektorijum + "\\" + Predmet))
            {
                MessageBox.Show("Direktorijum '" + GlavniDirektorijum + "\\" + Predmet + "' nije pronađen.", NaslovPoruke, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void OtvoriDatoteku(string Datoteka)
        {
            if (PostojiEkstenzija(Datoteka) == false)
            {
                return;
            }

            if (!File.Exists(Datoteka))
            {
                MessageBox.Show("Odabrana datoteka '" + Datoteka + "' je obrisana ili izmeštena sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Datoteka);

            Cursor.Current = Cursors.Default;
        }

        private bool PostojiEkstenzija(string Datoteka)
        {
            string Ekstenzija = Path.GetExtension(Datoteka);

            try
            {
                if (Ekstenzija == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
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
