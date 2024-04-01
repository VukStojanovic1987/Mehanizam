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

namespace Mehanizam.Prava.Ugovori.Predmeti
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
            Godine();
        }

        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsLetterOrDigit(e.KeyChar) & !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.UgovoriDirektorijum))
            {
                MessageBox.Show("Dirktorijum za ugovore nije podešen.", "Prava - Ugovori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.UgovoriDirektorijum))
            {
                MessageBox.Show("Podešeni dirktorijum '" + Properties.Settings.Default.UgovoriDirektorijum + "' je obrisan ili izmešten sa lokacije.", "Prava - Ugovori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja označena (*) moraju biti popunjena.", "Prava - Ugovori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NapraviPredmet();
        }

        //PROCEDURE
        private void NapraviPredmet()
        {
            string vrstaUgovora = "";

            if(cmbVrstaUgovora.Text == "Ništa od ponuđenog")
            {
                vrstaUgovora = "";
            }
            else
            {
                vrstaUgovora = ", " + cmbVrstaUgovora.Text;
            }

            string Naziv = txtBroj.Text + "-" + cmbGodina.Text + " - " + txtLice.Text + vrstaUgovora;
            string Putanja = Properties.Settings.Default.UgovoriDirektorijum + "\\" + Naziv;

            if (Directory.Exists(Putanja))
            {
                MessageBox.Show("Predmet pod nazivom '" + Naziv + "' već postoji.", "Prava - Ugovori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Directory.CreateDirectory(Putanja);
            
            if(cmbVrstaUgovora.Text == "Ugovor i kratkoročnoj pozajmici")
            {
                File.WriteAllBytes(Putanja + "\\Ugovor o kratkoročnoj pozajmici.xlsm", Properties.Resources.UgovorKratkorocnePozajmice);
            }
            
            FrmInstanca.OsveziTabelu();

            MessageBox.Show("Predmet je uspešno napravljen.", "Prava - Ugovori", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void Godine()
        {
            for (int i = 2011; i <= DateTime.Now.Year; i++)
            {
                cmbGodina.Items.Add(i);
            }

            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //FUNKCIJE
        private bool PraznaPolja()
        {
            if(string.IsNullOrWhiteSpace(txtBroj.Text) || 
               string.IsNullOrWhiteSpace(cmbGodina.Text) ||
               string.IsNullOrWhiteSpace(txtLice.Text) ||
               string.IsNullOrWhiteSpace(cmbVrstaUgovora.Text))
            {
                return true;
            }

            return false;
        }
    }
}
