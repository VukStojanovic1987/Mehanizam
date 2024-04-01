using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Mehanizam.Odabir
{
    class clsVrsteDokumenata
    {
        public clsVrsteDokumenata(ComboBox cmb)
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.DelovodnikBaza);

            AccessBP.IzvrsiUpit("SELECT Naziv FROM tblVrsteDokumenata");

            if (AccessBP.Greska == true) { return; }

            if (AccessBP.TabelaBP.Rows.Count == 0) { return; }

            string Naziv;

            foreach (DataRow Red in AccessBP.TabelaBP.Rows)
            {
                if (!string.IsNullOrWhiteSpace(Convert.ToString(Red["Naziv"])))
                {
                    Naziv = Convert.ToString(Red["Naziv"]);
                }
                else
                {
                    Naziv = "";
                }

                if (!string.IsNullOrWhiteSpace(Naziv))
                {
                    cmb.Items.Add(Naziv);
                }
            }
        }
    }
}
