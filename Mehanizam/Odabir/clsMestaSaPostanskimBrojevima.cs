using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Mehanizam.Odabir
{
    class clsMestaSaPostanskimBrojevima
    {
        public clsMestaSaPostanskimBrojevima(ComboBox cmb)
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.InformacijeBaza);

            AccessBP.IzvrsiUpit("SELECT Mesto, PostanskiBroj FROM qryMestaPregled");

            if (AccessBP.Greska == true) { return; }

            if (AccessBP.TabelaBP.Rows.Count == 0) { return; }

            string Mesto;
            string PostanskiBroj;

            foreach (DataRow Red in AccessBP.TabelaBP.Rows)
            {
                if (!string.IsNullOrWhiteSpace(Convert.ToString(Red["Mesto"])))
                {
                    Mesto = Convert.ToString(Red["Mesto"]);
                }
                else
                {
                    Mesto = "";
                }

                if (!string.IsNullOrWhiteSpace(Convert.ToString(Red["PostanskiBroj"])))
                {
                    PostanskiBroj = " " + Convert.ToString(Red["PostanskiBroj"]);
                }
                else
                {
                    PostanskiBroj = "";
                }

                if (!string.IsNullOrWhiteSpace(Mesto + PostanskiBroj))
                {
                    cmb.Items.Add(Mesto + PostanskiBroj);
                }
            }
        }
    }
}
