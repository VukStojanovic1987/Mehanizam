using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mehanizam.Projektovanje.Projekti.Projekat
{
    public partial class frmDodaj : Form
    {
        //PROMENLJIVE
        private Predmeti.frmUredi _frmUredi = null;
        private string _Direktorijum = "";
        private string Poruka = "";

        //PODEŠAVANJA
        public Predmeti.frmUredi frmUredi
        {
            set { _frmUredi = value; }
            get { return _frmUredi; }
        }

        public string Direktorijum
        {
            set { _Direktorijum = value; }
            get { return _Direktorijum; }
        }

        //KONSTRUKTOR
        public frmDodaj()
        {
            InitializeComponent();
        }

        private void frmDodaj_Load(object sender, EventArgs e)
        {
            optIdr_CheckedChanged(this, new EventArgs());
            optIdp_CheckedChanged(this, new EventArgs());
            optPgd_CheckedChanged(this, new EventArgs());
            optPzi_CheckedChanged(this, new EventArgs());
            optPio_CheckedChanged(this, new EventArgs());
        }

        //DOGAĐAJI
        private void optIdr_CheckedChanged(object sender, EventArgs e)
        {
            bool vrednost = optIdr.Checked;

            ckbIdr0.Enabled = vrednost;
            ckbIdrA.Enabled = vrednost;

            AktiviranoDugme(optIdr);
        }

        private void optIdp_CheckedChanged(object sender, EventArgs e)
        {
            bool vrednost = optIdp.Checked;

            ckbIdp0.Enabled = vrednost;
            ckbIdpA.Enabled = vrednost;

            AktiviranoDugme(optIdp);
        }

        private void optPgd_CheckedChanged(object sender, EventArgs e)
        {
            bool vrednost = optPgd.Checked;

            ckbPgd0.Enabled = vrednost;
            ckbPgdA.Enabled = vrednost;

            AktiviranoDugme(optPgd);
        }

        private void optPzi_CheckedChanged(object sender, EventArgs e)
        {
            bool vrednost = optPzi.Checked;

            ckbPzi0.Enabled = vrednost;
            ckbPziA.Enabled = vrednost;

            AktiviranoDugme(optPzi);
        }

        private void optPio_CheckedChanged(object sender, EventArgs e)
        {
            bool vrednost = optPio.Checked;

            ckbPio0.Enabled = vrednost;
            ckbPioA.Enabled = vrednost;

            AktiviranoDugme(optPio);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Direktorijum))
            {
                MessageBox.Show("Direktorijum predmeta '" + Direktorijum + "' je obrisan ili izmešten sa lokacije.", "Projektovanje - Projekti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            if (optIdr.Checked == true)
            {
                Idr();
            }

            if (optIdp.Checked == true)
            {
                Idp();
            }

            if (optPgd.Checked == true)
            {
                Pgd();
            }

            if (optPzi.Checked == true)
            {
                Pzi();
            }

            if (optPio.Checked == true)
            {
                Pio();
            }

            if (frmUredi != null)
            {
                frmUredi.Osvezi();
            }

            if (!string.IsNullOrWhiteSpace(Poruka))
            {
                MessageBox.Show("Desile su se sledeće promene u predmetu:" + Environment.NewLine + Poruka, "Projektovanje - Projekti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nema novih promena u predmetu.", "Projektovanje - Projekti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cursor.Current = Cursors.Default;

            Close();
        }

        //PROCEDURE
        private void Idr()
        {
            string Projekat = Direktorijum + "\\1 - IDR";

            if (!Directory.Exists(Projekat))
            {
                Directory.CreateDirectory(Projekat);
                Poruka = Environment.NewLine + " - Direktorijum je dodat (1 - IDR)";
            }

            if (ckbIdr0.Checked == true)
            {
                string GlavnaSveska = Projekat + "\\0 - Glavna sveska";

                if (!Directory.Exists(GlavnaSveska))
                {
                    Directory.CreateDirectory(GlavnaSveska);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (0 - Glavna sveska)";
                }

                if (!File.Exists(GlavnaSveska + "\\IDR, Tekstualna dokumentacija, 0.xlsm"))
                {
                    File.WriteAllBytes(GlavnaSveska + "\\IDR, Tekstualna dokumentacija, 0.xlsm", Properties.Resources.GlavnaSveskaIdr);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (IDR, Tekstualna dokumentacija, 0.xlsm)";
                }
            }

            if (ckbIdrA.Checked == true)
            {
                string TekstualnaDokumentacijaA = Projekat + "\\1 - Projekat arhitekture";

                if (!Directory.Exists(TekstualnaDokumentacijaA))
                {
                    Directory.CreateDirectory(TekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (1 - Projekat arhitekture)";
                }

                if (!File.Exists(TekstualnaDokumentacijaA + "\\IDR, Tekstualna dokumentacija, A.xlsm"))
                {
                    File.WriteAllBytes(TekstualnaDokumentacijaA + "\\IDR, Tekstualna dokumentacija, A.xlsm", Properties.Resources.IdrTekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (IDR, Tekstualna dokumentacija, A.xlsm)";
                }
            }

            string CdOmot = Projekat + "\\CD";

            if (!Directory.Exists(CdOmot))
            {
                Directory.CreateDirectory(CdOmot);
                Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (CD)";
            }

            if (!File.Exists(CdOmot + "\\IDR, CD omot.cdr"))
            {
                File.WriteAllBytes(CdOmot + "\\IDR, CD omot.cdr", Properties.Resources.CdOmotIdr);
                Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (IDR, CD omot.cdr)";
            }
        }

        private void Idp()
        {
            string Projekat = Direktorijum + "\\2 - IDP";

            if (!Directory.Exists(Projekat))
            {
                Directory.CreateDirectory(Projekat);
                Poruka = Environment.NewLine + " - Direktorijum je dodat (2 - IDP)";
            }

            if (ckbIdp0.Checked == true)
            {
                string GlavnaSveska = Projekat + "\\0 - Glavna sveska";

                if (!Directory.Exists(GlavnaSveska))
                {
                    Directory.CreateDirectory(GlavnaSveska);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (0 - Glavna sveska)";
                }

                if (!File.Exists(GlavnaSveska + "\\IDP, Tekstualna dokumentacija, 0.xlsm"))
                {
                    File.WriteAllBytes(GlavnaSveska + "\\IDP, Tekstualna dokumentacija, 0.xlsm", Properties.Resources.GlavnaSveskaIdp);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (IDP, Tekstualna dokumentacija, 0.xlsm)";
                }
            }

            if (ckbIdpA.Checked == true)
            {
                string TekstualnaDokumentacijaA = Projekat + "\\1 - Projekat arhitekture";

                if (!Directory.Exists(TekstualnaDokumentacijaA))
                {
                    Directory.CreateDirectory(TekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (1 - Projekat arhitekture)";
                }

                if (!File.Exists(TekstualnaDokumentacijaA + "\\IDP, Tekstualna dokumentacija, A.xlsm"))
                {
                    File.WriteAllBytes(TekstualnaDokumentacijaA + "\\IDP, Tekstualna dokumentacija, A.xlsm", Properties.Resources.IdpTekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (IDP, Tekstualna dokumentacija, A.xlsm)";
                }
            }

            string CdOmot = Projekat + "\\CD";

            if (!Directory.Exists(CdOmot))
            {
                Directory.CreateDirectory(CdOmot);
                Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (CD)";
            }

            if (!File.Exists(CdOmot + "\\IDP, CD omot.cdr"))
            {
                File.WriteAllBytes(CdOmot + "\\IDP, CD omot.cdr", Properties.Resources.CdOmotIdp);
                Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (IDP, CD omot.cdr)";
            }
        }

        private void Pgd()
        {
            string Projekat = Direktorijum + "\\3 - PGD";

            if (!Directory.Exists(Projekat))
            {
                Directory.CreateDirectory(Projekat);
                Poruka = Environment.NewLine + " - Direktorijum je dodat (3 - PGD)";
            }

            if (ckbPgd0.Checked == true)
            {
                string GlavnaSveska = Projekat + "\\0 - Glavna sveska";

                if (!Directory.Exists(GlavnaSveska))
                {
                    Directory.CreateDirectory(GlavnaSveska);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (0 - Glavna sveska)";
                }

                if (!File.Exists(GlavnaSveska + "\\PGD, Tekstualna dokumentacija, 0.xlsm"))
                {
                    File.WriteAllBytes(GlavnaSveska + "\\PGD, Tekstualna dokumentacija, 0.xlsm", Properties.Resources.GlavnaSveskaPgd);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (PGD, Tekstualna dokumentacija, 0.xlsm)";
                }
            }

            if (ckbPgdA.Checked == true)
            {
                string TekstualnaDokumentacijaA = Projekat + "\\1 - Projekat arhitekture";

                if (!Directory.Exists(TekstualnaDokumentacijaA))
                {
                    Directory.CreateDirectory(TekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (1 - Projekat arhitekture)";
                }

                if (!File.Exists(TekstualnaDokumentacijaA + "\\PGD, Tekstualna dokumentacija, A.xlsm"))
                {
                    File.WriteAllBytes(TekstualnaDokumentacijaA + "\\PGD, Tekstualna dokumentacija, A.xlsm", Properties.Resources.PgdTekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (PGD, Tekstualna dokumentacija, A.xlsm)";
                }
            }

            string IzvodIzProjekta = Projekat + "\\Izvod iz projekta";

            if (!Directory.Exists(IzvodIzProjekta))
            {
                Directory.CreateDirectory(IzvodIzProjekta);
                Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (Izvod iz projekta)";
            }

            if (!File.Exists(IzvodIzProjekta + "\\Izvod iz projekta.xlsm"))
            {
                File.WriteAllBytes(IzvodIzProjekta + "\\Izvod iz projekta.xlsm", Properties.Resources.IzvodIzProjektaPGD);
                Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (Izvod iz projekta.xlsm)";
            }

            string CdOmot = Projekat + "\\CD";

            if (!Directory.Exists(CdOmot))
            {
                Directory.CreateDirectory(CdOmot);
                Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (CD)";
            }

            if (!File.Exists(CdOmot + "\\PGD, CD omot.cdr"))
            {
                File.WriteAllBytes(CdOmot + "\\PGD, CD omot.cdr", Properties.Resources.CdOmotPgd);
                Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (PGD, CD omot.cdr)";
            }
        }

        private void Pzi()
        {
            string Projekat = Direktorijum + "\\4 - PZI";

            if (!Directory.Exists(Projekat))
            {
                Directory.CreateDirectory(Projekat);
                Poruka = Environment.NewLine + " - Direktorijum je dodat (4 - PZI)";
            }

            if (ckbPzi0.Checked == true)
            {
                string GlavnaSveska = Projekat + "\\0 - Glavna sveska";

                if (!Directory.Exists(GlavnaSveska))
                {
                    Directory.CreateDirectory(GlavnaSveska);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (0 - Glavna sveska)";
                }

                if (!File.Exists(GlavnaSveska + "\\PZI, Tekstualna dokumentacija, 0.xlsm"))
                {
                    File.WriteAllBytes(GlavnaSveska + "\\PZI, Tekstualna dokumentacija, 0.xlsm", Properties.Resources.GlavnaSveskaPzi);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (PGD, Tekstualna dokumentacija, 0.xlsm)";
                }
            }

            if (ckbPziA.Checked == true)
            {
                string TekstualnaDokumentacijaA = Projekat + "\\1 - Projekat arhitekture";

                if (!Directory.Exists(TekstualnaDokumentacijaA))
                {
                    Directory.CreateDirectory(TekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (1 - Projekat arhitekture)";
                }

                if (!File.Exists(TekstualnaDokumentacijaA + "\\PZI, Tekstualna dokumentacija, A.xlsm"))
                {
                    File.WriteAllBytes(TekstualnaDokumentacijaA + "\\PZI, Tekstualna dokumentacija, A.xlsm", Properties.Resources.PziTekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (PZI, Tekstualna dokumentacija, A.xlsm)";
                }
            }

            string CdOmot = Projekat + "\\CD";

            if (!Directory.Exists(CdOmot))
            {
                Directory.CreateDirectory(CdOmot);
                Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (CD)";
            }

            if (!File.Exists(CdOmot + "\\PZI, CD omot.cdr"))
            {
                File.WriteAllBytes(CdOmot + "\\PZI, CD omot.cdr", Properties.Resources.CdOmotPzi);
                Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (PZI, CD omot.cdr)";
            }
        }

        private void Pio()
        {
            string Projekat = Direktorijum + "\\5 - PIO";

            if (!Directory.Exists(Projekat))
            {
                Directory.CreateDirectory(Projekat);
                Poruka = Environment.NewLine + " - Direktorijum je dodat (5 - PIO)";
            }

            if (ckbPio0.Checked == true)
            {
                string GlavnaSveska = Projekat + "\\0 - Glavna sveska";

                if (!Directory.Exists(GlavnaSveska))
                {
                    Directory.CreateDirectory(GlavnaSveska);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (0 - Glavna sveska)";
                }

                if (!File.Exists(GlavnaSveska + "\\PIO, Tekstualna dokumentacija, 0.xlsm"))
                {
                    File.WriteAllBytes(GlavnaSveska + "\\PIO, Tekstualna dokumentacija, 0.xlsm", Properties.Resources.GlavnaSveskaPio);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (PIO, Tekstualna dokumentacija, 0.xlsm)";
                }
            }

            if (ckbPioA.Checked == true)
            {
                string TekstualnaDokumentacijaA = Projekat + "\\1 - Projekat arhitekture";

                if (!Directory.Exists(TekstualnaDokumentacijaA))
                {
                    Directory.CreateDirectory(TekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (1 - Projekat arhitekture)";
                }

                if (!File.Exists(TekstualnaDokumentacijaA + "\\PIO, Tekstualna dokumentacija, A.xlsm"))
                {
                    File.WriteAllBytes(TekstualnaDokumentacijaA + "\\PIO, Tekstualna dokumentacija, A.xlsm", Properties.Resources.PioTekstualnaDokumentacijaA);
                    Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (PIO, Tekstualna dokumentacija, A.xlsm)";
                }
            }

            string CdOmot = Projekat + "\\CD";

            if (!Directory.Exists(CdOmot))
            {
                Directory.CreateDirectory(CdOmot);
                Poruka = Poruka + Environment.NewLine + " - Direktorijum je dodat (CD)";
            }

            if (!File.Exists(CdOmot + "\\PIO, CD omot.cdr"))
            {
                File.WriteAllBytes(CdOmot + "\\PIO, CD omot.cdr", Properties.Resources.CdOmotPio);
                Poruka = Poruka + Environment.NewLine + " - Datoteka je dodata (PIO, CD omot.cdr)";
            }
        }

        private void AktiviranoDugme(RadioButton rdo)
        {
            if (rdo.Checked == true)
            {
                rdo.Font = new Font(rdo.Font, FontStyle.Bold);
            }
            else
            {
                rdo.Font = new Font(rdo.Font, FontStyle.Regular);
            }
        }
    }
}
