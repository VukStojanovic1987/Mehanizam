using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Mehanizam.Odabir
{
    class clsCeopVrsteZahteva
    {
        public clsCeopVrsteZahteva(ComboBox cmb)
        {
            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.CeopBaza);

            AccessBP.IzvrsiUpit("SELECT VrstaZahteva FROM tblVrsteZahteva");

            if (AccessBP.Greska == true) { return; }

            if (AccessBP.TabelaBP.Rows.Count == 0) { return; }

            string VrstaZahteva;

            foreach (DataRow Red in AccessBP.TabelaBP.Rows)
            {
                if (!string.IsNullOrWhiteSpace(Convert.ToString(Red["VrstaZahteva"])))
                {
                    VrstaZahteva = Convert.ToString(Red["VrstaZahteva"]);
                }
                else
                {
                    VrstaZahteva = "";
                }

                if (!string.IsNullOrWhiteSpace(VrstaZahteva))
                {
                    cmb.Items.Add(VrstaZahteva);
                }
            }
        }
    }
}
