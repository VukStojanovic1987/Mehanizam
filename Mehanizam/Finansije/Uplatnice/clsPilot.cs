using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;

namespace Mehanizam.Finansije.Uplatnice
{
    class clsPilot
    {
        //PROMENLJIVE
        private string _Izuzetak;

        private long _ID;
        private DateTime Datum;
        private string Platilac;
        private string SvrhaUplate;
        private string Primalac;
        private string SifraPlacanja;
        private string Valuta;
        private string Iznos;
        private string RacunPrimaoca;
        private string Model;
        private string PozivNaBroj;

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
            _Izuzetak = "";

            string PutanjaPilota = Properties.Settings.Default.UplatnicaPilot;

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

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.UplatniceBaza);

            AccessBP.DodajParametre("@ID", _ID);
            AccessBP.IzvrsiUpit("SELECT * FROM tblUplatnice WHERE ID=@ID");

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
                Platilac = Convert.ToString(Red["Platilac"]);
                SvrhaUplate = Convert.ToString(Red["SvrhaUplate"]);
                Primalac = Convert.ToString(Red["Primalac"]);
                SifraPlacanja = Convert.ToString(Red["SifraPlacanja"]);
                Valuta = Convert.ToString(Red["Valuta"]);
                Iznos = Convert.ToString(Red["Iznos"]);
                RacunPrimaoca = Convert.ToString(Red["RacunPrimaoca"]);
                Model = Convert.ToString(Red["Model"]);
                PozivNaBroj = Convert.ToString(Red["PozivNaBroj"]);
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
                oWorkbook = oExcel.Workbooks.Open(Properties.Settings.Default.UplatnicaPilot);
                oWorksheet = oWorkbook.Worksheets["Uplatnica"];

                //oWorksheet.Range["InformacijePutanjaBaze"].Value = Properties.Settings.Default.InformacijeBaza;
                //oWorksheet.Range["PutanjaPotpisaPecata"].Value = Properties.Settings.Default.PutanjaPecataPotpisa;
                //oWorksheet.Range["LozinkaZaPodesavanja"].Value = Properties.Settings.Default.LozinkaZaPodesavanje;

                //oWorksheet.Range["Datum"].Value = Datum.ToString("dd.MM.yyyy.");
                oWorksheet.Range["Platilac"].Value = Platilac;
                oWorksheet.Range["SvrhaUplate"].Value = SvrhaUplate;
                oWorksheet.Range["Primalac"].Value = Primalac;
                oWorksheet.Range["Sifra"].Value = SifraPlacanja;
                oWorksheet.Range["Valuta"].Value = Valuta;
                oWorksheet.Range["Iznos"].Value = Iznos;
                oWorksheet.Range["RacunPrimaoca"].Value = RacunPrimaoca;
                oWorksheet.Range["Model"].Value = Model;
                oWorksheet.Range["PozivNaBroj"].Value = PozivNaBroj;

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
