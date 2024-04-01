using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Mehanizam.Odabir
{
    class clsJediniceMere
    {
        public clsJediniceMere(ComboBox cmb)
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.InformacijeBaza);

            AccessBP.IzvrsiUpit("SELECT Skracenica FROM qryJediniceMerePregled");

            if (AccessBP.Greska == true) { return; }

            if (AccessBP.TabelaBP.Rows.Count == 0) { return; }

            string Skracenica;

            foreach (DataRow Red in AccessBP.TabelaBP.Rows)
            {
                if (!string.IsNullOrWhiteSpace(Convert.ToString(Red["Skracenica"])))
                {
                    Skracenica = Convert.ToString(Red["Skracenica"]);
                }
                else
                {
                    Skracenica = "";
                }

                if (!string.IsNullOrWhiteSpace(Skracenica))
                {
                    cmb.Items.Add(Skracenica);
                }
            }
        }
    }
}
