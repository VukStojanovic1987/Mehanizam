using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehanizam.Podesavanja
{
    public partial class frmLozinka : Form
    {
        //PROMENLJIVE
        private int _TipForma;
        private bool Zatvaranje = true;

        //PODEŠAVANJE PROMENLJIVIH
        public int TipForma
        {
            get { return _TipForma; }
            set { _TipForma = value; }
        }

        public frmLozinka()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                btnPotvrdi.Enabled = false;
            }
            else
            {
                btnPotvrdi.Enabled = true;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Zatvaranje = false;

            if (TipForma == 1)
            {
                Application.Exit();
            }
            else if (TipForma == 2)
            {
                Close();
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (TipForma == 1)
            {
                if(txtLozinka.Text == Properties.Settings.Default.LozinkaZaProgram)
                {
                    Zatvaranje = false;
                    Close();
                }
                else
                {
                    MessageBox.Show("Lozinka nije ispravna, milimo Vas pokušajte ponovo.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLozinka.Focus();
                    txtLozinka.SelectionStart = 0;
                    txtLozinka.SelectionLength = txtLozinka.Text.Length;
                }
            }
            else if (TipForma == 2)
            {
                if (txtLozinka.Text == Properties.Settings.Default.LozinkaZaPodesavanja)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    using(frmPodesavanja Frm = new frmPodesavanja())
                    {
                        Frm.ShowDialog();
                    }
                    Zatvaranje = false;
                    Close();

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Lozinka nije ispravna, milimo Vas pokušajte ponovo.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLozinka.Focus();
                    txtLozinka.SelectionStart = 0;
                    txtLozinka.SelectionLength = txtLozinka.Text.Length;
                }
            }
        }

        private void frmLozinka_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = Zatvaranje;
        }
    }
}
