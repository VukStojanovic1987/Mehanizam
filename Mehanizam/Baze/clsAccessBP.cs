using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Mehanizam.Baze
{
    class clsAccessBP
    {
        //PROMENLJIVE
        private string _PutanjaBaze;
        private List<OleDbParameter> Parametri = new List<OleDbParameter>();
        private string _Izuzetak;
        private DataTable _TabelaBP;

        //PODEŠAVANJA
        public DataTable TabelaBP
        {
            get { return _TabelaBP; }
        }
        public string Izuzetak
        {
            get
            {
                return _Izuzetak;
            }
        }
        public bool Greska
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(Izuzetak))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //KONSTRUKTOR
        public clsAccessBP(string PutanjaBaze)
        {
            _PutanjaBaze = PutanjaBaze;
        }

        //METODE
        public void IzvrsiUpit(string Upit)
        {
            _Izuzetak = "";

            OleDbConnection KonekcijaBP = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + _PutanjaBaze);
            OleDbCommand KomandaBP;
            OleDbDataAdapter AdapterBP;

            try
            {
                KonekcijaBP.Open();

                KomandaBP = new OleDbCommand(Upit, KonekcijaBP);

                foreach (OleDbParameter p in Parametri)
                {
                    KomandaBP.Parameters.Add(p);
                }

                Parametri.Clear();

                _TabelaBP = new DataTable();
                AdapterBP = new OleDbDataAdapter(KomandaBP);
                AdapterBP.Fill(TabelaBP);
            }
            catch(Exception ex)
            {
                _Izuzetak = ex.Message;
            }
            finally
            {
                if (KonekcijaBP.State == ConnectionState.Open) { KonekcijaBP.Close(); }
            }
        }

        public void DodajParametre(string Ime, object Vrednost)
        {
            OleDbParameter NoviParametri = new OleDbParameter(Ime, Vrednost);
            Parametri.Add(NoviParametri);
        }
    }
}
