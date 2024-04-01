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
    public partial class frmUredi : Form
    {
        //PROMENLJIVE
        private string _Direktorijum;
        private string _Naslov = "";

        //PODEŠAVANJA
        public string Direktorijum
        {
            set { _Direktorijum = value; }
            get { return _Direktorijum; }
        }

        public string Naslov
        {
            set { _Naslov = value; }
            get
            {
                if(_Naslov != "")
                {
                    return "Predmet '" +  _Naslov + "'";
                }
                else
                {
                    return "Predmet '...'";
                }
                
            }
        }

        //KONSTRUKTOR
        public frmUredi()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmPredmet_Load(object sender, EventArgs e)
        {
            btnOtvori.Enabled = Properties.Settings.Default.EeePredmetPristupDirektorijumu;
            lblNaslov.Text = Naslov;
            Osvezi();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Direktorijum);

            Cursor.Current = Cursors.Default;
        }

        private void trePredmet_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (PostojiEkstenzija(e.Node) == false)
            {
                return;
            }

            if (!File.Exists(Direktorijum + "\\" + e.Node.FullPath))
            {
                MessageBox.Show("Odabrana datoteka '" + Direktorijum + "\\" + e.Node.FullPath + "' je obrisana ili izmeštena sa lokacije.", "Projektovanje - Elaborati energetske efikasnosti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Process.Start(Direktorijum + "\\" + e.Node.FullPath);

            Cursor.Current = Cursors.Default;
        }

        //PROCEDURE
        private void Osvezi()
        {
            trePredmet.Nodes.Clear();

            Kontrole.clsTreeView TreeView = new Kontrole.clsTreeView();
            TreeView.PopuniListu(Direktorijum, trePredmet.Nodes);

            trePredmet.ExpandAll();
        }

        private bool PostojiEkstenzija(TreeNode TrenutniCvor)
        {
            string PutanjaCvora;
            PutanjaCvora = Direktorijum + @"\" + TrenutniCvor.FullPath;

            string Ekstenzija;
            Ekstenzija = Path.GetExtension(PutanjaCvora);

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
    }
}
