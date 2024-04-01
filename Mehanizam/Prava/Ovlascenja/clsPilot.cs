using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;

namespace Mehanizam.Prava.Ovlascenja
{
    class clsPilot
    {
        //PROMENLJIVE
        private string _Izuzetak;

        private long _ID;
        private DateTime Datum;
        private string EvidencioniBroj;
        private string Mesto;
        private string JedninaMnozina1;
        private string OvlascenjeDao;
        private string OvlascenoLice;
        private string JedninaMnozina2;
        private string Kontekst;

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

            NadjiOvlascenje();

            if (Greska == true) { return; }

            PopuniPilot();
        }

        private void ProveriPilot()
        {
            _Izuzetak = "";

            string PutanjaPilota = Properties.Settings.Default.OvlascenjePilot;

            if (string.IsNullOrWhiteSpace(PutanjaPilota))
            {
                _Izuzetak = "Putanja pilota nije podešena.";
            }

            if (!File.Exists(PutanjaPilota))
            {
                _Izuzetak = "Pilot ne postoje na podešenoj putanji.";
            }
        }

        private void NadjiOvlascenje()
        {
            _Izuzetak = "";

            if (_ID == 0)
            {
                _Izuzetak = "ID = 0.";
                return;
            }

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.OvlascenjaBaza);

            AccessBP.DodajParametre("@ID", _ID);
            AccessBP.IzvrsiUpit("SELECT * FROM tblOvlascenja WHERE ID=@ID");

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
                Datum = Convert.ToDateTime(Red["Datum"]);
                EvidencioniBroj = Convert.ToString(Red["EvidencioniBroj"]);
                Mesto = Convert.ToString(Red["Mesto"]);
                JedninaMnozina1 = Convert.ToString(Red["JedninaMnozina1"]);
                OvlascenjeDao = Convert.ToString(Red["OvlascenjeDao"]);
                OvlascenoLice = Convert.ToString(Red["OvlascenoLice"]);
                JedninaMnozina2 = Convert.ToString(Red["JedninaMnozina2"]);
                Kontekst = Convert.ToString(Red["Kontekst"]);
            }
            catch(Exception ex)
            {
                _Izuzetak = ex.Message;
            }
        }

        private void PopuniPilot()
        {
            _Izuzetak = "";

            Excel.Application oExcel = null;
            Excel.Workbook oWorkbook = null;
            Excel.Worksheet oWorksheet = null;

            try
            {
                oExcel = new Excel.Application();
                oWorkbook = oExcel.Workbooks.Open(Properties.Settings.Default.OvlascenjePilot);
                oWorksheet = oWorkbook.Worksheets["Podesavanja"];

                //oWorksheet.Range["InformacijePutanjaBaze"].Value = Properties.Settings.Default.InformacijeBaza;
                //oWorksheet.Range["PutanjaPotpisaPecata"].Value = Properties.Settings.Default.PutanjaPecataPotpisa;
                //oWorksheet.Range["LozinkaZaPodesavanja"].Value = Properties.Settings.Default.LozinkaZaPodesavanje;

                oWorksheet.Range["Datum"].Value = Datum.ToString("dd.MM.yyyy.");
                oWorksheet.Range["EvidencioniBroj"].Value = EvidencioniBroj;
                oWorksheet.Range["Mesto"].Value = Mesto;
                oWorksheet.Range["JedninaMnozina1"].Value = JedninaMnozina1;
                oWorksheet.Range["OvlascenjeDao"].Value = OvlascenjeDao;
                oWorksheet.Range["OvlascenoLice"].Value = OvlascenoLice;
                oWorksheet.Range["JedninaMnozina2"].Value = JedninaMnozina2;
                oWorksheet.Range["Kontekst"].Value = Kontekst;

                oExcel.WindowState = Excel.XlWindowState.xlMaximized;

                oExcel.Visible = true;
            }
            catch (Exception ex)
            {
                _Izuzetak = ex.Message;
            }
            finally
            {
                if (oExcel != null) { Marshal.ReleaseComObject(oExcel); }
                if (oWorkbook != null) { Marshal.ReleaseComObject(oWorkbook); }
                if (oWorksheet != null) { Marshal.ReleaseComObject(oWorksheet); }
            }
        }
    }
}
