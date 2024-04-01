using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;
using System.Data;
using System.Windows.Forms;

namespace Mehanizam.Informacije.Lica
{
    class clsPismo
    {
        //PROMENLJIVE
        string PutanjaPilota = Properties.Settings.Default.PismoPilot;
        private string _Izuzetak = "";
        private long _ID;
        private string AdresaPoruke = "";

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

        //KONSTRUKTOR
        public clsPismo(long ID)
        {
            _ID = ID;

           ProveriPutanjuPilota();

            if (Greska == true) { return; }

            NadjiAdresuPoruke();

            if (Greska == true) { return; }

            if (string.IsNullOrWhiteSpace(AdresaPoruke))
            {
                if (MessageBox.Show("Odabrano lice ne sadrži email adresu, želite li da nastavite pa email adresu da upišete ručnu?", "Lice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            }

            OtvoriPilot();
        }

        //PROCEDURE
        private void ProveriPutanjuPilota()
        {
            _Izuzetak = "";

            if (string.IsNullOrWhiteSpace(PutanjaPilota))
            {
                _Izuzetak = "Putanja pilota nije podešena.";
            }

            if (!File.Exists(PutanjaPilota))
            {
                _Izuzetak = "Pilot ne postoje na podešenoj putanji.";
            }
        }

        private void NadjiAdresuPoruke()
        {
            _Izuzetak = "";

            if (_ID == 0)
            {
                _Izuzetak = "ID = 0.";
                return;
            }

            Baze.clsAccessBP AccessBP = new Baze.clsAccessBP(Properties.Settings.Default.InformacijeBaza);

            AccessBP.DodajParametre("@ID", _ID);
            AccessBP.IzvrsiUpit("SELECT * FROM qryLicaPregled WHERE ID=@ID");

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
                AdresaPoruke = Convert.ToString(Red["Email"]);
            }
            catch (Exception ex)
            {
                _Izuzetak = ex.Message;
            }
        }

        private void OtvoriPilot()
        {
            _Izuzetak = "";

            Outlook.Application oOutlook = null;
            Outlook.Folder oOutlookFolder = null;
            Outlook.MailItem Poruka = null;

            try
            {
                oOutlook = new Outlook.Application();
                oOutlookFolder = (Outlook.Folder)oOutlook.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts);
                Poruka = (Outlook.MailItem)oOutlook.CreateItemFromTemplate(PutanjaPilota, oOutlookFolder);

                Poruka.To = AdresaPoruke;
                Poruka.Display(true);
            }
            catch (Exception ex)
            {
                _Izuzetak = ex.Message;
            }
            finally
            {
                if ((oOutlook != null)) { Marshal.ReleaseComObject(oOutlook); }
                if ((oOutlookFolder != null)) { Marshal.ReleaseComObject(oOutlookFolder); }
                if ((Poruka != null)) { Marshal.ReleaseComObject(Poruka); }
            }
        }
    }
}
