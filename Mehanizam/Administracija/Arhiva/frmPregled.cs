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
using System.Reflection;
using Microsoft.VisualBasic.FileIO;

namespace Mehanizam.Administracija.Arhiva
{
    public partial class frmPregled : Form
    {   
        //PROMENLJIVE
        private frmIndex _frmIndexInstanca;
        private List<string> ListaDatoteka = new List<string>();

        //PODEŠAVANJA
        public frmIndex frmIndexInstanca
        {
            set { _frmIndexInstanca = value; }
            get { return _frmIndexInstanca; }
        }

        //KONSTRUKTOR
        public frmPregled()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmPregled_Load(object sender, EventArgs e)
        {
            
        }

        private void frmPregled_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.ArhivaDirektorijum))
            {
                MessageBox.Show("Direktorijum za arhivu nije podešen.", "Administracija - Arhiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.ArhivaDirektorijum))
            {
                MessageBox.Show("Podešeni dirketorijum '" + Properties.Settings.Default.ArhivaDirektorijum + "' je obrisan ili izmešten sa lokacije.", "Administracija - arhiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            treDirektorijumi.Nodes.Clear();
            lisDatoteke.Items.Clear();
            lblPutanjaOdabranogDirektorijum.Text = "...";

            UcitajDirektorijume(Properties.Settings.Default.ArhivaDirektorijum, treDirektorijumi.Nodes);
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.ArhivaDirektorijum))
            {
                MessageBox.Show("Direktorijum za arhivu nije podešen.", "Administracija - Arhiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.ArhivaDirektorijum))
            {
                MessageBox.Show("Podešeni dirketorijum '" + Properties.Settings.Default.ArhivaDirektorijum + "' je obrisan ili izmešten sa lokacije.", "Administracija - arhiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            treDirektorijumi.Nodes.Clear();
            lisDatoteke.Items.Clear();
            lblPutanjaOdabranogDirektorijum.Text = "...";

            UcitajDirektorijume(Properties.Settings.Default.ArhivaDirektorijum, treDirektorijumi.Nodes);
        }

        private void btnDirektorijum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.ArhivaDirektorijum))
            {
                MessageBox.Show("Direktorijum za arhivu nije podešen.", "Administracija - Arhiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.ArhivaDirektorijum))
            {
                MessageBox.Show("Podešeni dirketorijum '" + Properties.Settings.Default.ArhivaDirektorijum + "' je obrisan ili izmešten sa lokacije.", "Administracija - arhiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            System.Diagnostics.Process.Start(Properties.Settings.Default.ArhivaDirektorijum);
        }

        private void treDirektorijumi_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ListaDatoteka.Clear();
            lisDatoteke.Items.Clear();

            UcitajDatoteke();

            lblPutanjaOdabranogDirektorijum.Text = Properties.Settings.Default.ArhivaDirektorijum + "\\" +treDirektorijumi.SelectedNode.FullPath;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            frmIndexInstanca.Podnaslov = "";
            frmIndexInstanca.lblArhiva.ForeColor = Color.Silver;
            Close();
            Dispose();
        }

        private void lisDatoteke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lisDatoteke.FocusedItem != null)
            {
                System.Diagnostics.Process.Start(ListaDatoteka[lisDatoteke.FocusedItem.Index]);
            }
        }

        //PROCEDURE
        private void UcitajDirektorijume(string Dir, TreeNodeCollection Cvor)
        {
            DirectoryInfo Direktorijum = new DirectoryInfo(Dir);

            foreach (DirectoryInfo d in Direktorijum.GetDirectories())
            {
                TreeNode t = new TreeNode(d.Name);

                t.ImageIndex = 0;
                Cvor.Add(t);
                UcitajDirektorijume(d.FullName, t.Nodes);
            }
        }

        private void UcitajDatoteke()
        {
            lblPutanjaOdabranogDirektorijum.Text = "...";

            foreach (string stvar in Directory.GetFiles(Properties.Settings.Default.ArhivaDirektorijum + "\\" + treDirektorijumi.SelectedNode.FullPath))
            {
                imgDatoteke.Images.Add(Icon.ExtractAssociatedIcon(stvar));
                FileInfo datoteka = new FileInfo(stvar);
                ListaDatoteka.Add(datoteka.FullName);
                lisDatoteke.Items.Add(datoteka.Name, imgDatoteke.Images.Count - 1);
            }
        }
    }
}
