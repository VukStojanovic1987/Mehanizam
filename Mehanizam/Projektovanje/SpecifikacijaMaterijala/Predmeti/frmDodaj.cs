﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mehanizam.Projektovanje.SpecifikacijaMaterijala.Predmeti
{
    public partial class frmDodaj : Form
    {
        //PROMENLJIVE
        private frmPregled _FrmInstanca;

        //PODEŠAVANJA
        public frmPregled FrmInstanca
        {
            set { _FrmInstanca = value; }
            get { return _FrmInstanca; }
        }

        //KONSTRUKTOR
        public frmDodaj()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmDodaj_Load(object sender, EventArgs e)
        {
            Odabir.clsMestaSaPostanskimBrojevima Mesta = new Odabir.clsMestaSaPostanskimBrojevima(cmbKatastarskaOpstina);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SpecifikacijeMaterijalaDirektorijum))
            {
                MessageBox.Show("Dirktorijum za specifikacije materijala nije podešen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(Properties.Settings.Default.SpecifikacijeMaterijalaDirektorijum))
            {
                MessageBox.Show("Podešeni dirktorijum '" + Properties.Settings.Default.SpecifikacijeMaterijalaDirektorijum + "' je obrisan ili izmešten sa lokacije.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (PraznaPolja() == true)
            {
                MessageBox.Show("Polja označena (*) moraju biti popunjena.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NapraviPredmet();
        }

        //PROCEDURE
        private void NapraviPredmet()
        {
            string Naziv =  txtInvestitor.Text + ", k.p.br. " + txtBrojKatastarskeParcele.Text + " k.o. " + cmbKatastarskaOpstina.Text + ", " + cmbVrstaObjekta.Text + " " + txtBrojObjekta.Text;
            string Putanja = Properties.Settings.Default.SpecifikacijeMaterijalaDirektorijum + "\\" + Naziv;

            if (Directory.Exists(Putanja))
            {
                MessageBox.Show("Predmet pod nazivom '" + Naziv + "' već postoji.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Directory.CreateDirectory(Putanja);

            File.WriteAllBytes(Putanja + "\\Specifikacija materijala.xlsm", Properties.Resources.SpecifikacijaMaterijala);

            FrmInstanca.OsveziTabelu();

            MessageBox.Show("Predmet je uspešno napravljen.", "Mehanizam", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        //FUNKCIJE
        private bool PraznaPolja()
        {
            if(string.IsNullOrWhiteSpace(txtInvestitor.Text) || 
               string.IsNullOrWhiteSpace(cmbKatastarskaOpstina.Text) ||
               string.IsNullOrWhiteSpace(txtBrojKatastarskeParcele.Text) ||
               string.IsNullOrWhiteSpace(cmbVrstaObjekta.Text) ||
               string.IsNullOrWhiteSpace(txtBrojObjekta.Text))
            {
                return true;
            }

            return false;
        }
    }
}
