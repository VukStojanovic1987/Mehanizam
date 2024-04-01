using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Mehanizam.Kontrole
{
    class clsTreeView
    {
        public void PopuniListu(string Dir, TreeNodeCollection Cvor)
        {
            string Ekstenzija;
            DirectoryInfo Direktorijum = new DirectoryInfo(Dir);

            foreach (DirectoryInfo d in Direktorijum.GetDirectories())
            {
                TreeNode t = new TreeNode(d.Name);

                t.ImageIndex = 0;
                Cvor.Add(t);
                PopuniListu(d.FullName, t.Nodes);
            }

            foreach (FileInfo f in Direktorijum.GetFiles())
            {
                Ekstenzija = Path.GetExtension(f.FullName);

                TreeNode t = new TreeNode(f.Name);

                if (Ekstenzija == ".xlsm" || Ekstenzija == ".xlsx" || Ekstenzija == ".xls")
                {
                    t.ImageIndex = 1;
                    t.SelectedImageIndex = 1;
                }
                else if (Ekstenzija == ".png" || Ekstenzija == ".jpg")
                {
                    t.ImageIndex = 2;
                    t.SelectedImageIndex = 2;
                }
                else if (Ekstenzija == ".pdf")
                {
                    t.ImageIndex = 3;
                    t.SelectedImageIndex = 3;
                }
                else if (Ekstenzija == ".dwg")
                {
                    t.ImageIndex = 4;
                    t.SelectedImageIndex = 4;
                }
                else if (Ekstenzija == ".doc" || Ekstenzija == ".docx")
                {
                    t.ImageIndex = 5;
                    t.SelectedImageIndex = 5;
                }
                else
                {
                    t.ImageIndex = 6;
                    t.SelectedImageIndex = 6;
                }
                Cvor.Add(t);
            }
        }
    }
}
