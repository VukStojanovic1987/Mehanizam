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
    public partial class frmIzveziZahtev : Form
    {
        //PROMENLJIVE
        private string _BrojZahteva = "";
        private string _Projekat = "";
        private string _Revizija = "";
        private string _EEE = "";
        private string _TehnickiPregled = "";

        //PODEŠAVANJA
        public string BrojZahteva
        {
            set { _BrojZahteva = value; }
            get { return _BrojZahteva; }
        }

        public string Projekat
        {
            set { _Projekat = value; }
            get { return _Projekat; }
        }

        public string Revizija
        {
            set { _Revizija = value; }
            get { return _Revizija; }
        }

        public string EEE
        {
            set { _EEE = value; }
            get { return _EEE; }
        }

        public string TehnickiPregled
        {
            set { _TehnickiPregled = value; }
            get { return _TehnickiPregled; }
        }

        //KONSTRUKTOR
        public frmIzveziZahtev()
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

        private void btnIzvezi_Click(object sender, EventArgs e)
        {
            if (ImaPromena() == true)
            {
                MessageBox.Show("Polja obeležena (*) moraju biti popunjena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            IzveziZahtev();

            Cursor.Current = Cursors.Default;
        }

        //PROCEDURE
        private void IzveziZahtev()
        {
            if (!Directory.Exists(txtPutanja.Text))
            {
                MessageBox.Show("Direktorijum pod nazivom '" + txtPutanja.Text + "' je obrisan ili izmešten sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Directory.Exists(txtPutanja.Text + "\\" + txtNaziv.Text))
            {
                MessageBox.Show("Direktorijum pod nazivom '" + txtPutanja.Text + "\\" + txtNaziv.Text + "' već postoji.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (IspravnostCeopDirektorijuma() == false)
            {
                return;
            }

            string novaPutanjaZahteva = txtPutanja.Text + "\\" + txtNaziv.Text;

            Directory.CreateDirectory(novaPutanjaZahteva + "\\CEOP");
            Kopiraj(Properties.Settings.Default.CeopDirektorijum + "\\" + BrojZahteva, novaPutanjaZahteva + "\\CEOP");

            if(IspravnostDirektorijumaPredmeta(Properties.Settings.Default.ProjektiDirektorijum, Projekat) == true)
            {
                string novaPutanjaProjekta = novaPutanjaZahteva + "\\Galvni projekat";
                Directory.CreateDirectory(novaPutanjaProjekta);
                Kopiraj(Properties.Settings.Default.ProjektiDirektorijum + "\\" + Projekat, novaPutanjaProjekta);
            }

            if (IspravnostDirektorijumaPredmeta(Properties.Settings.Default.RevizijaDirektorijum, Revizija) == true)
            {
                string novaPutanjaRevizije = novaPutanjaZahteva + "\\Tehnička kontrola projekta";
                Directory.CreateDirectory(novaPutanjaRevizije);
                Kopiraj(Properties.Settings.Default.RevizijaDirektorijum + "\\" + Revizija, novaPutanjaRevizije);
            }

            if (IspravnostDirektorijumaPredmeta(Properties.Settings.Default.EeeDirektorijum, EEE) == true)
            {
                string novaPutanjaEEE = novaPutanjaZahteva + "\\Elaborat energetske efikasnosti";
                Directory.CreateDirectory(novaPutanjaEEE);
                Kopiraj(Properties.Settings.Default.EeeDirektorijum + "\\" + EEE, novaPutanjaEEE);
            }

            if (IspravnostDirektorijumaPredmeta(Properties.Settings.Default.TehnickiPregledDirektorijum, TehnickiPregled) == true)
            {
                string novaPutanjaTehnickiPregled = novaPutanjaZahteva + "\\Tehnicki pregled objekta";
                Directory.CreateDirectory(novaPutanjaTehnickiPregled);
                Kopiraj(Properties.Settings.Default.TehnickiPregledDirektorijum + "\\" + TehnickiPregled, novaPutanjaTehnickiPregled);
            }

            MessageBox.Show("Zahtev je uspešno izvežen na zadatu lokaciju.", "Zahtev", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void Kopiraj(string dirIzvor, string dirNovi)
        {
            try
            {
                foreach (string DirPutanja in Directory.GetDirectories(dirIzvor, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(DirPutanja.Replace(dirIzvor, dirNovi));
                }

                foreach (string NovaPutanja in Directory.GetFiles(dirIzvor, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(NovaPutanja, NovaPutanja.Replace(dirIzvor, dirNovi), true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //FUNKCIJE
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

        private bool IspravnostDirektorijumaPredmeta(string GlavniDirektorijum, string Predmet)
        {
            if (string.IsNullOrWhiteSpace(GlavniDirektorijum))
            {
                return false;
            }

            if (!Directory.Exists(GlavniDirektorijum))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(Predmet))
            {
                return false;
            }

            if (!Directory.Exists(GlavniDirektorijum + "\\" + Predmet))
            {
                return false;
            }

            return true;
        }

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
