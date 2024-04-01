namespace Mehanizam.Projektovanje.CEOP.Predmet
{
    partial class frmDodaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodaj));
            this.pan1 = new System.Windows.Forms.Panel();
            this.btnNazivPredmeta = new System.Windows.Forms.Button();
            this.imgDodaj = new System.Windows.Forms.ImageList(this.components);
            this.lblNazivPredmeta = new System.Windows.Forms.Label();
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.btnTehnickiPregled = new System.Windows.Forms.Button();
            this.btnEEE = new System.Windows.Forms.Button();
            this.btnRevizija = new System.Windows.Forms.Button();
            this.btnProjekat = new System.Windows.Forms.Button();
            this.cmbStatusZahteva = new System.Windows.Forms.ComboBox();
            this.lblStatusZahteva = new System.Windows.Forms.Label();
            this.lblZahtevWeb = new System.Windows.Forms.Label();
            this.txtZahtevWeb = new System.Windows.Forms.TextBox();
            this.lblTehnickiPregled = new System.Windows.Forms.Label();
            this.txtTehnickiPregled = new System.Windows.Forms.TextBox();
            this.lblEEE = new System.Windows.Forms.Label();
            this.txtEEE = new System.Windows.Forms.TextBox();
            this.lblRevizija = new System.Windows.Forms.Label();
            this.txtRevizija = new System.Windows.Forms.TextBox();
            this.lblProjekat = new System.Windows.Forms.Label();
            this.txtProjekat = new System.Windows.Forms.TextBox();
            this.cmbVrstaZahteva = new System.Windows.Forms.ComboBox();
            this.lblVrstaZahteva = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tipDodaj = new System.Windows.Forms.ToolTip(this.components);
            this.pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.Controls.Add(this.btnNazivPredmeta);
            this.pan1.Controls.Add(this.lblNazivPredmeta);
            this.pan1.Controls.Add(this.txtNazivPredmeta);
            this.pan1.Controls.Add(this.btnTehnickiPregled);
            this.pan1.Controls.Add(this.btnEEE);
            this.pan1.Controls.Add(this.btnRevizija);
            this.pan1.Controls.Add(this.btnProjekat);
            this.pan1.Controls.Add(this.cmbStatusZahteva);
            this.pan1.Controls.Add(this.lblStatusZahteva);
            this.pan1.Controls.Add(this.lblZahtevWeb);
            this.pan1.Controls.Add(this.txtZahtevWeb);
            this.pan1.Controls.Add(this.lblTehnickiPregled);
            this.pan1.Controls.Add(this.txtTehnickiPregled);
            this.pan1.Controls.Add(this.lblEEE);
            this.pan1.Controls.Add(this.txtEEE);
            this.pan1.Controls.Add(this.lblRevizija);
            this.pan1.Controls.Add(this.txtRevizija);
            this.pan1.Controls.Add(this.lblProjekat);
            this.pan1.Controls.Add(this.txtProjekat);
            this.pan1.Controls.Add(this.cmbVrstaZahteva);
            this.pan1.Controls.Add(this.lblVrstaZahteva);
            this.pan1.Controls.Add(this.lblBroj);
            this.pan1.Controls.Add(this.txtBroj);
            this.pan1.Controls.Add(this.dtpDatum);
            this.pan1.Controls.Add(this.lblDatum);
            this.pan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan1.Location = new System.Drawing.Point(0, 0);
            this.pan1.Margin = new System.Windows.Forms.Padding(0);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(464, 533);
            this.pan1.TabIndex = 0;
            // 
            // btnNazivPredmeta
            // 
            this.btnNazivPredmeta.AutoSize = true;
            this.btnNazivPredmeta.FlatAppearance.BorderSize = 0;
            this.btnNazivPredmeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazivPredmeta.ImageIndex = 0;
            this.btnNazivPredmeta.ImageList = this.imgDodaj;
            this.btnNazivPredmeta.Location = new System.Drawing.Point(401, 205);
            this.btnNazivPredmeta.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.btnNazivPredmeta.Name = "btnNazivPredmeta";
            this.btnNazivPredmeta.Size = new System.Drawing.Size(26, 26);
            this.btnNazivPredmeta.TabIndex = 50;
            this.tipDodaj.SetToolTip(this.btnNazivPredmeta, "Otvorite formular kako biste\r\nformirali naziv predmeta.");
            this.btnNazivPredmeta.UseVisualStyleBackColor = true;
            this.btnNazivPredmeta.Click += new System.EventHandler(this.btnNazivPredmeta_Click);
            // 
            // imgDodaj
            // 
            this.imgDodaj.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDodaj.ImageStream")));
            this.imgDodaj.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDodaj.Images.SetKeyName(0, "Edit_grey_16x.png");
            this.imgDodaj.Images.SetKeyName(1, "OtvoriFasciklu_16x.png");
            // 
            // lblNazivPredmeta
            // 
            this.lblNazivPredmeta.AutoSize = true;
            this.lblNazivPredmeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNazivPredmeta.Location = new System.Drawing.Point(17, 232);
            this.lblNazivPredmeta.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblNazivPredmeta.Name = "lblNazivPredmeta";
            this.lblNazivPredmeta.Size = new System.Drawing.Size(102, 16);
            this.lblNazivPredmeta.TabIndex = 32;
            this.lblNazivPredmeta.Text = "Naziv predmeta*";
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.BackColor = System.Drawing.Color.White;
            this.txtNazivPredmeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNazivPredmeta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazivPredmeta.ForeColor = System.Drawing.Color.Black;
            this.txtNazivPredmeta.Location = new System.Drawing.Point(20, 208);
            this.txtNazivPredmeta.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(378, 22);
            this.txtNazivPredmeta.TabIndex = 31;
            // 
            // btnTehnickiPregled
            // 
            this.btnTehnickiPregled.AutoSize = true;
            this.btnTehnickiPregled.FlatAppearance.BorderSize = 0;
            this.btnTehnickiPregled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTehnickiPregled.ImageIndex = 1;
            this.btnTehnickiPregled.ImageList = this.imgDodaj;
            this.btnTehnickiPregled.Location = new System.Drawing.Point(401, 519);
            this.btnTehnickiPregled.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.btnTehnickiPregled.Name = "btnTehnickiPregled";
            this.btnTehnickiPregled.Size = new System.Drawing.Size(26, 26);
            this.btnTehnickiPregled.TabIndex = 45;
            this.tipDodaj.SetToolTip(this.btnTehnickiPregled, "Otvorite listu direktorijuma kako \r\nbiste odabrali tehnički pregled.");
            this.btnTehnickiPregled.UseVisualStyleBackColor = true;
            this.btnTehnickiPregled.Click += new System.EventHandler(this.btnTehnickiPregled_Click);
            // 
            // btnEEE
            // 
            this.btnEEE.AutoSize = true;
            this.btnEEE.FlatAppearance.BorderSize = 0;
            this.btnEEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEEE.ImageIndex = 1;
            this.btnEEE.ImageList = this.imgDodaj;
            this.btnEEE.Location = new System.Drawing.Point(401, 456);
            this.btnEEE.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.btnEEE.Name = "btnEEE";
            this.btnEEE.Size = new System.Drawing.Size(26, 26);
            this.btnEEE.TabIndex = 42;
            this.tipDodaj.SetToolTip(this.btnEEE, "Otvorite listu direktorijuma kako \r\nbiste odabrali ekaborat energteske\r\nefikasnos" +
        "ti.");
            this.btnEEE.UseVisualStyleBackColor = true;
            this.btnEEE.Click += new System.EventHandler(this.btnEEE_Click);
            // 
            // btnRevizija
            // 
            this.btnRevizija.AutoSize = true;
            this.btnRevizija.FlatAppearance.BorderSize = 0;
            this.btnRevizija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevizija.ImageIndex = 1;
            this.btnRevizija.ImageList = this.imgDodaj;
            this.btnRevizija.Location = new System.Drawing.Point(401, 393);
            this.btnRevizija.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.btnRevizija.Name = "btnRevizija";
            this.btnRevizija.Size = new System.Drawing.Size(26, 26);
            this.btnRevizija.TabIndex = 39;
            this.tipDodaj.SetToolTip(this.btnRevizija, "Otvorite listu direktorijuma kako \r\nbiste odabrali tehničku kontrolu\r\nprojekta.");
            this.btnRevizija.UseVisualStyleBackColor = true;
            this.btnRevizija.Click += new System.EventHandler(this.btnRevizija_Click);
            // 
            // btnProjekat
            // 
            this.btnProjekat.AutoSize = true;
            this.btnProjekat.FlatAppearance.BorderSize = 0;
            this.btnProjekat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjekat.ImageIndex = 1;
            this.btnProjekat.ImageList = this.imgDodaj;
            this.btnProjekat.Location = new System.Drawing.Point(401, 330);
            this.btnProjekat.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.btnProjekat.Name = "btnProjekat";
            this.btnProjekat.Size = new System.Drawing.Size(26, 26);
            this.btnProjekat.TabIndex = 36;
            this.tipDodaj.SetToolTip(this.btnProjekat, "Otvorite listu direktorijuma kako \r\nbiste odabrali projekat.");
            this.btnProjekat.UseVisualStyleBackColor = true;
            this.btnProjekat.Click += new System.EventHandler(this.btnProjekat_Click);
            // 
            // cmbStatusZahteva
            // 
            this.cmbStatusZahteva.BackColor = System.Drawing.Color.White;
            this.cmbStatusZahteva.FormattingEnabled = true;
            this.cmbStatusZahteva.Items.AddRange(new object[] {
            "U toku",
            "Usvojen",
            "Odbačen"});
            this.cmbStatusZahteva.Location = new System.Drawing.Point(20, 268);
            this.cmbStatusZahteva.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbStatusZahteva.Name = "cmbStatusZahteva";
            this.cmbStatusZahteva.Size = new System.Drawing.Size(407, 24);
            this.cmbStatusZahteva.TabIndex = 33;
            // 
            // lblStatusZahteva
            // 
            this.lblStatusZahteva.AutoSize = true;
            this.lblStatusZahteva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatusZahteva.Location = new System.Drawing.Point(17, 294);
            this.lblStatusZahteva.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblStatusZahteva.Name = "lblStatusZahteva";
            this.lblStatusZahteva.Size = new System.Drawing.Size(99, 16);
            this.lblStatusZahteva.TabIndex = 34;
            this.lblStatusZahteva.Text = "Status zahteva*";
            // 
            // lblZahtevWeb
            // 
            this.lblZahtevWeb.AutoSize = true;
            this.lblZahtevWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblZahtevWeb.Location = new System.Drawing.Point(17, 612);
            this.lblZahtevWeb.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblZahtevWeb.Name = "lblZahtevWeb";
            this.lblZahtevWeb.Size = new System.Drawing.Size(35, 16);
            this.lblZahtevWeb.TabIndex = 49;
            this.lblZahtevWeb.Text = "Web";
            // 
            // txtZahtevWeb
            // 
            this.txtZahtevWeb.BackColor = System.Drawing.Color.White;
            this.txtZahtevWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZahtevWeb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZahtevWeb.ForeColor = System.Drawing.Color.Black;
            this.txtZahtevWeb.Location = new System.Drawing.Point(20, 585);
            this.txtZahtevWeb.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtZahtevWeb.Name = "txtZahtevWeb";
            this.txtZahtevWeb.Size = new System.Drawing.Size(407, 22);
            this.txtZahtevWeb.TabIndex = 47;
            // 
            // lblTehnickiPregled
            // 
            this.lblTehnickiPregled.AutoSize = true;
            this.lblTehnickiPregled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTehnickiPregled.Location = new System.Drawing.Point(17, 546);
            this.lblTehnickiPregled.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTehnickiPregled.Name = "lblTehnickiPregled";
            this.lblTehnickiPregled.Size = new System.Drawing.Size(101, 16);
            this.lblTehnickiPregled.TabIndex = 46;
            this.lblTehnickiPregled.Text = "Tehnički pregled";
            // 
            // txtTehnickiPregled
            // 
            this.txtTehnickiPregled.BackColor = System.Drawing.Color.White;
            this.txtTehnickiPregled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTehnickiPregled.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTehnickiPregled.ForeColor = System.Drawing.Color.Black;
            this.txtTehnickiPregled.Location = new System.Drawing.Point(20, 522);
            this.txtTehnickiPregled.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtTehnickiPregled.Name = "txtTehnickiPregled";
            this.txtTehnickiPregled.Size = new System.Drawing.Size(378, 22);
            this.txtTehnickiPregled.TabIndex = 44;
            // 
            // lblEEE
            // 
            this.lblEEE.AutoSize = true;
            this.lblEEE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEEE.Location = new System.Drawing.Point(17, 483);
            this.lblEEE.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblEEE.Name = "lblEEE";
            this.lblEEE.Size = new System.Drawing.Size(190, 16);
            this.lblEEE.TabIndex = 43;
            this.lblEEE.Text = "Elaborat energetske efikasnosti";
            // 
            // txtEEE
            // 
            this.txtEEE.BackColor = System.Drawing.Color.White;
            this.txtEEE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEEE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEEE.ForeColor = System.Drawing.Color.Black;
            this.txtEEE.Location = new System.Drawing.Point(20, 459);
            this.txtEEE.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtEEE.Name = "txtEEE";
            this.txtEEE.Size = new System.Drawing.Size(378, 22);
            this.txtEEE.TabIndex = 41;
            // 
            // lblRevizija
            // 
            this.lblRevizija.AutoSize = true;
            this.lblRevizija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRevizija.Location = new System.Drawing.Point(17, 420);
            this.lblRevizija.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblRevizija.Name = "lblRevizija";
            this.lblRevizija.Size = new System.Drawing.Size(159, 16);
            this.lblRevizija.TabIndex = 40;
            this.lblRevizija.Text = "Tehnička kontrola projekta";
            // 
            // txtRevizija
            // 
            this.txtRevizija.BackColor = System.Drawing.Color.White;
            this.txtRevizija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRevizija.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRevizija.ForeColor = System.Drawing.Color.Black;
            this.txtRevizija.Location = new System.Drawing.Point(20, 396);
            this.txtRevizija.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtRevizija.Name = "txtRevizija";
            this.txtRevizija.Size = new System.Drawing.Size(378, 22);
            this.txtRevizija.TabIndex = 38;
            // 
            // lblProjekat
            // 
            this.lblProjekat.AutoSize = true;
            this.lblProjekat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProjekat.Location = new System.Drawing.Point(17, 357);
            this.lblProjekat.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblProjekat.Name = "lblProjekat";
            this.lblProjekat.Size = new System.Drawing.Size(56, 16);
            this.lblProjekat.TabIndex = 37;
            this.lblProjekat.Text = "Projekat";
            // 
            // txtProjekat
            // 
            this.txtProjekat.BackColor = System.Drawing.Color.White;
            this.txtProjekat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjekat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProjekat.ForeColor = System.Drawing.Color.Black;
            this.txtProjekat.Location = new System.Drawing.Point(20, 333);
            this.txtProjekat.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtProjekat.Name = "txtProjekat";
            this.txtProjekat.Size = new System.Drawing.Size(378, 22);
            this.txtProjekat.TabIndex = 35;
            // 
            // cmbVrstaZahteva
            // 
            this.cmbVrstaZahteva.BackColor = System.Drawing.Color.White;
            this.cmbVrstaZahteva.FormattingEnabled = true;
            this.cmbVrstaZahteva.Location = new System.Drawing.Point(20, 146);
            this.cmbVrstaZahteva.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbVrstaZahteva.Name = "cmbVrstaZahteva";
            this.cmbVrstaZahteva.Size = new System.Drawing.Size(407, 24);
            this.cmbVrstaZahteva.TabIndex = 29;
            // 
            // lblVrstaZahteva
            // 
            this.lblVrstaZahteva.AutoSize = true;
            this.lblVrstaZahteva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVrstaZahteva.Location = new System.Drawing.Point(17, 172);
            this.lblVrstaZahteva.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblVrstaZahteva.Name = "lblVrstaZahteva";
            this.lblVrstaZahteva.Size = new System.Drawing.Size(92, 16);
            this.lblVrstaZahteva.TabIndex = 30;
            this.lblVrstaZahteva.Text = "Vrsta zahteva*";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBroj.Location = new System.Drawing.Point(17, 107);
            this.lblBroj.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(84, 16);
            this.lblBroj.TabIndex = 28;
            this.lblBroj.Text = "Broj zahteva*";
            // 
            // txtBroj
            // 
            this.txtBroj.BackColor = System.Drawing.Color.White;
            this.txtBroj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBroj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBroj.ForeColor = System.Drawing.Color.Black;
            this.txtBroj.Location = new System.Drawing.Point(20, 83);
            this.txtBroj.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(407, 22);
            this.txtBroj.TabIndex = 27;
            this.txtBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBroj_KeyPress);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(20, 20);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(407, 22);
            this.dtpDatum.TabIndex = 25;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDatum.Location = new System.Drawing.Point(17, 44);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(51, 16);
            this.lblDatum.TabIndex = 26;
            this.lblDatum.Text = "Datum*";
            // 
            // btnDodaj
            // 
            this.btnDodaj.AutoSize = true;
            this.btnDodaj.BackColor = System.Drawing.Color.Gray;
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDodaj.Location = new System.Drawing.Point(369, 553);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(0, 20, 11, 11);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 28);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.tipDodaj.SetToolTip(this.btnDodaj, "Dodajte novi zahtev.");
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tipDodaj
            // 
            this.tipDodaj.ToolTipTitle = "Projektovanje - CEOP";
            // 
            // frmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.btnDodaj);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projektovanje - CEOP - Zahtev - Novi";
            this.Load += new System.EventHandler(this.frmDodaj_Load);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.Button btnDodaj;
        internal System.Windows.Forms.ImageList imgDodaj;
        internal System.Windows.Forms.Label lblNazivPredmeta;
        internal System.Windows.Forms.TextBox txtNazivPredmeta;
        internal System.Windows.Forms.Button btnTehnickiPregled;
        internal System.Windows.Forms.Button btnEEE;
        internal System.Windows.Forms.Button btnRevizija;
        internal System.Windows.Forms.Button btnProjekat;
        internal System.Windows.Forms.ComboBox cmbStatusZahteva;
        internal System.Windows.Forms.Label lblStatusZahteva;
        internal System.Windows.Forms.Label lblZahtevWeb;
        internal System.Windows.Forms.TextBox txtZahtevWeb;
        internal System.Windows.Forms.Label lblTehnickiPregled;
        internal System.Windows.Forms.TextBox txtTehnickiPregled;
        internal System.Windows.Forms.Label lblEEE;
        internal System.Windows.Forms.TextBox txtEEE;
        internal System.Windows.Forms.Label lblRevizija;
        internal System.Windows.Forms.TextBox txtRevizija;
        internal System.Windows.Forms.Label lblProjekat;
        internal System.Windows.Forms.TextBox txtProjekat;
        internal System.Windows.Forms.ComboBox cmbVrstaZahteva;
        internal System.Windows.Forms.Label lblVrstaZahteva;
        internal System.Windows.Forms.Label lblBroj;
        internal System.Windows.Forms.TextBox txtBroj;
        internal System.Windows.Forms.DateTimePicker dtpDatum;
        internal System.Windows.Forms.Label lblDatum;
        internal System.Windows.Forms.Button btnNazivPredmeta;
        private System.Windows.Forms.ToolTip tipDodaj;
    }
}