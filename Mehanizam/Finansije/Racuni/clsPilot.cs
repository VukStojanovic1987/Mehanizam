using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;

namespace Mehanizam.Finansije.Racuni
{
    class clsPilot
    {
        //PROMENLJIVE
        private string _Izuzetak;

        private long _ID;
        private string Broj;
        private DateTime DatumIzdavanja;
        private DateTime DatumPrometaUsluge;
        private string EvidencioniBroj;
        private string MestoIzdavanja;
        private string Uplatioc;
        private string VrstaRobeUsluge;
        private string Skracenica;
        private string Kolicina;
        private string CenaPoJediniciMere;
        private string StopaPDV;
        private string ZaUplatuSlovima;

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
            string PutanjaPilota = Properties.Settings.Default.RacunPilot;

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

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.RacuniBaza);

            AccessBP.DodajParametre("@ID", _ID);
            AccessBP.IzvrsiUpit("SELECT * FROM tblRacuni WHERE ID=@ID");

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
                DatumIzdavanja = Convert.ToDateTime(Red["DatumIzdavanja"]);
                DatumPrometaUsluge = Convert.ToDateTime(Red["DatumPrometaUsluge"]);
                EvidencioniBroj = Convert.ToString(Red["EvidencioniBroj"]);
                MestoIzdavanja = Convert.ToString(Red["Mesto"]);
                Uplatioc = Convert.ToString(Red["Uplatioc"]);
                VrstaRobeUsluge = Convert.ToString(Red["VrstaRobeUsluge"]);
                Skracenica = Convert.ToString(Red["JedinicaMere"]);
                Kolicina = Convert.ToString(Red["Kolicina"]);
                CenaPoJediniciMere = Convert.ToString(Red["CenaPoJediniciMere"]);
                StopaPDV = Convert.ToString(Red["StopaPDV"]);
                ZaUplatuSlovima = Convert.ToString(Red["ZaUplatuSlovima"]);
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
                oWorkbook = oExcel.Workbooks.Open(Properties.Settings.Default.RacunPilot);
                oWorksheet = oWorkbook.Worksheets["Podesavanja"];

                oWorksheet.Range["InformacijePutanjaBaze"].Value = Properties.Settings.Default.InformacijeBaza;
                //oWorksheet.Range["PutanjaPotpisaPecata"].Value = Properties.Settings.Default.PutanjaPecataPotpisa;
                //oWorksheet.Range["LozinkaZaPodesavanja"].Value = Properties.Settings.Default.LozinkaZaPodesavanje;

                oWorksheet.Range["Broj"].Value = Broj;
                oWorksheet.Range["EvidencioniBroj"].Value = EvidencioniBroj;
                oWorksheet.Range["DatumIzdavanja"].Value = DatumIzdavanja.ToString("dd.MM.yyyy.");
                oWorksheet.Range["DatumPrometaUsluge"].Value = DatumPrometaUsluge.ToString("dd.MM.yyyy.");
                oWorksheet.Range["Mesto"].Value = MestoIzdavanja;
                oWorksheet.Range["Uplatilac"].Value = Uplatioc;
                oWorksheet.Range["VrstaRobeUsluge"].Value = VrstaRobeUsluge;
                oWorksheet.Range["JedinicaMere"].Value = Skracenica;
                oWorksheet.Range["Kolicina"].Value = Kolicina;
                oWorksheet.Range["CenaPoJediniciMere"].Value = CenaPoJediniciMere;
                oWorksheet.Range["StopaPDV"].Value = StopaPDV;
                oWorksheet.Range["ZaUplatuSlovima"].Value = ZaUplatuSlovima;

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
