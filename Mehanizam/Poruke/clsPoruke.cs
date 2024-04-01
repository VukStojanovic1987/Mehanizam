using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehanizam.Poruke
{
    class clsPoruke
    {
        public string GreskaBaza
        {
            get {
                return "Povezivanje sa bazom nije uspešno." + Environment.NewLine + Environment.NewLine +
                       "Proverite adresu baze da li je uopšte podešena u podešavanjima." + Environment.NewLine + Environment.NewLine +
                       "Ako je adresa baze podešena proverite da li se stvarno nalazi na toj adresi ili je možda izbrisana ili izmeštena." + Environment.NewLine + Environment.NewLine +
                       "Proverite da li koristite ispravnu Access-ovu datoteku/bazu je baza je posebno podešena da bi radila sa programom." + Environment.NewLine + Environment.NewLine +
                       "Ne preporučuje se da ništa menjate direkto u bazi jer program možda neće moći da funkcioniše sa njom kako treba (naziv tabele, nazivi kolona, upite...), jer ako ste nešto promenili program neće raditi." + Environment.NewLine + Environment.NewLine +
                       "Ako niste sigurni da ste povezani sa pravom bazom uvek možete da napravite novu, koju znate da je sigurno ispravna.";
            }
        }

        public string GreskaPilot
        {
            get { return "Nesto nije dobro sa pilotom."; }
        }

        public string ObradaZapisaRed
        {
            get { return "Morate predhodno odabrati zapis koji želite da uredite."; }
        }

        public string BrisanjeZapisaRed
        {
            get { return "Morate predhodno odabrati zapis koji želite da obrišete."; }
        }

        public string BrisanjeZapisaPitanje
        {
            get { return "Želite li da obrišete odabrani zapis?"; }
        }

        public string PilotZapisaRed
        {
            get { return "Morate predhodno odabrati zapis koji želite da otvorite u pilotu."; }
        }

        public string PilotZapisaPitanje
        {
            get { return "Želite li da otvorite odabrani zapis u pilotu?"; }
        }

        public string PutanjaBazeNijePodesena
        {
            get { return "Putanja baze podataka nije podešena."; }
        }

        public string DatotekaNijePronadjena(string Datoteka)
        {
            if (!string.IsNullOrWhiteSpace(Datoteka))
            {
                return "Datoteka '" + Datoteka + "' je izmeštena ili izbrisana.";
            }
            else
            {
                return "Datoteka je izmeštena ili obrisana.";
            }
        }

        public string PutanjaDirektorijumaNijePodesena
        {
            get { return "Putanja direkorijuma za datoteke nije podešena."; }
        }

        public string DirektorijumNijePronadjen(string Direktorijum)
        {
            if (!string.IsNullOrWhiteSpace(Direktorijum))
            {
                return "Direktorijum '" + Direktorijum + "' je izmešten ili izbrisan.";
            }
            else
            {
                return "Direktorijum je izmešten ili obrisan.";
            }
        }

        public string ObaveznaPolja
        {
            get { return "Polja obeležena (*) moraju biti popunjena."; }
        }

        public string GreskaIdNula
        {
            get { return "Greška: ID = 0." + Environment.NewLine +
                         "Molimo Vas da obavestite osobu nadležnu za Mehanizam o ovoj grešci."; }
        }

        public string GreskaBrojZapisaNijeJedan
        {
            get { return "Greška: Broj zapisa nije jednak 1." + Environment.NewLine +
                         "Molimo Vas da obavestite osobu nadležnu za Mehanizam o ovoj grešci."; }
        }

        public string OdabirRed
        {
            get
            {
                return "Morate predhodno odabrati zapis koji želite da dodate formularu.";
            }
        }
    }
}
