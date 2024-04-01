using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;

namespace Mehanizam.Finansije.Priznanice
{
    class clsPilot
    {
        //PROMENLJIVE
        private string _Izuzetak;

        private long _ID;
        private string Broj;
        private DateTime Datum;
        private string Mesto;
        private string Uplatioc;
        private string Primaoc;
        private string VrstaRobeUsluge;
        private string JedinicaMere;
        private string Kolicina;
        private string Valuta;
        private string CenaPoJediniciMere;
        private string Uplatio;
        private string OstaloZaUplatuSlovima;

        //PODEŠAVANJA
        public string Izuzetak
        {
            get { return _Izuzetak; }
        }
        public bool Greska
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_Izuzetak))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        //PROCEDURE
        public clsPilot(long ID)
        {
            _ID = ID;

            ProveriPilot();

            if (Greska == true) { return; }

            NadjiPredracun();

            if (Greska == true) { return; }

            PopuniDokument();
        }

        private void ProveriPilot()
        {
            string PutanjaPilota = Properties.Settings.Default.PriznanicaPilot;

            if (string.IsNullOrWhiteSpace(PutanjaPilota))
            {
                _Izuzetak = "Putanja pilota nije podešena.";
            }

            if (!File.Exists(PutanjaPilota))
            {
                _Izuzetak = "Pilot ne postoje na podešenoj putanji.";
            }
        }

        private void NadjiPredracun()
        {
            _Izuzetak = "";

            if (_ID == 0)
            {
                _Izuzetak = "ID = 0.";
                return;
            }

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.PriznaniceBaza);

            AccessBP.DodajParametre("@ID", _ID);
            AccessBP.IzvrsiUpit("SELECT * FROM tblPriznanice WHERE ID=@ID");

            if (AccessBP.Greska == true)
            {
                _Izuzetak = AccessBP.Izuzetak;
                return;
            }

            if (AccessBP.TabelaBP.Rows.Count != 1)
            {
                _Izuzetak = "Broj zapisa nije jednak 1.";
                return;
            }

            DataRow Red = AccessBP.TabelaBP.Rows[0];

            try
            {
                Broj = Convert.ToString(Red["Broj"]);
                Datum = Convert.ToDateTime(Red["Datum"]);
                Mesto = Convert.ToString(Red["Mesto"]);
                Uplatioc = Convert.ToString(Red["Uplatioc"]);
                Primaoc = Convert.ToString(Red["Primaoc"]);
                VrstaRobeUsluge = Convert.ToString(Red["VrstaRobeUsluge"]);
                JedinicaMere = Convert.ToString(Red["JedinicaMere"]);
                Kolicina = Convert.ToString(Red["Kolicina"]);
                Valuta = Convert.ToString(Red["Valuta"]);
                CenaPoJediniciMere = Convert.ToString(Red["CenaPoJediniciMere"]);
                Uplatio = Convert.ToString(Red["Uplatio"]);
                OstaloZaUplatuSlovima = Convert.ToString(Red["OstaloZaUplatuSlovima"]);
            }
            catch(Exception ex)
            {
                _Izuzetak = ex.Message;
            }
        }

        private void PopuniDokument()
        {
            _Izuzetak = "";

            Excel.Application oExcel = null;
            Excel.Workbook oWorkbook = null;
            Excel.Worksheet oWorksheet = null;

            try
            {
                oExcel = new Excel.Application();
                oWorkbook = oExcel.Workbooks.Open(Properties.Settings.Default.PriznanicaPilot);
                oWorksheet = oWorkbook.Worksheets["Podesavanja"];

                //oWorksheet.Range["InformacijePutanjaBaze"].Value = Properties.Settings.Default.InformacijeBaza;
                //oWorksheet.Range["PutanjaPotpisaPecata"].Value = Properties.Settings.Default.PutanjaPecataPotpisa;
                //oWorksheet.Range["LozinkaZaPodesavanja"].Value = Properties.Settings.Default.LozinkaZaPodesavanje;

                oWorksheet.Range["Broj"].Value = Broj;
                oWorksheet.Range["Datum"].Value = Datum.ToString("dd.MM.yyyy.");
                oWorksheet.Range["Mesto"].Value = Mesto;
                oWorksheet.Range["Uplatilac"].Value = Uplatioc;
                oWorksheet.Range["Primaoc"].Value = Primaoc;
                oWorksheet.Range["VrstaRobeUsluge"].Value = VrstaRobeUsluge;
                oWorksheet.Range["JedinicaMere"].Value = JedinicaMere;
                oWorksheet.Range["Kolicina"].Value = Kolicina;
                oWorksheet.Range["Valuta"].Value = Valuta;
                oWorksheet.Range["CenaPoJediniciMere"].Value = CenaPoJediniciMere;
                oWorksheet.Range["Uplatio"].Value = Uplatio;
                oWorksheet.Range["OstaloZaUplatuSlovima"].Value = OstaloZaUplatuSlovima;

                oExcel.WindowState = Excel.XlWindowState.xlMaximized;

                oExcel.Visible = true;
            }
            catch (Exception ex)
            {
                _Izuzetak = ex.Message;
            }

            if (oExcel != null) { Marshal.ReleaseComObject(oExcel); }
            if (oWorkbook != null) { Marshal.ReleaseComObject(oWorkbook); }
            if (oWorksheet != null) { Marshal.ReleaseComObject(oWorksheet); }
        }
    }
}
