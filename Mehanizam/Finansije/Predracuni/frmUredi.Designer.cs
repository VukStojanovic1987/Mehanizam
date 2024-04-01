namespace Mehanizam.Finansije.Predracuni
{
    partial class frmUredi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUredi));
            this.pan1 = new System.Windows.Forms.Panel();
            this.btnOdaberiUplatioca = new System.Windows.Forms.Button();
            this.imgDodaj = new System.Windows.Forms.ImageList(this.components);
            this.txtUplatioc = new System.Windows.Forms.TextBox();
            this.lblZaUplatuSlovima = new System.Windows.Forms.Label();
            this.txtZaUplatuSlovima = new System.Windows.Forms.TextBox();
            this.lblZaUplatu = new System.Windows.Forms.Label();
            this.txtZaUplatu = new System.Windows.Forms.TextBox();
            this.lblStopaPDV = new System.Windows.Forms.Label();
            this.txtStopaPDV = new System.Windows.Forms.TextBox();
            this.lblCenaPoJediniciMere = new System.Windows.Forms.Label();
            this.txtCenaPoJediniciMere = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.cmbJedinicaMere = new System.Windows.Forms.ComboBox();
            this.lblJedinicaMere = new System.Windows.Forms.Label();
            this.lblVrstaRobeUsluge = new System.Windows.Forms.Label();
            this.txtVrstaRobeUsluge = new System.Windows.Forms.TextBox();
            this.lblUplatioc = new System.Windows.Forms.Label();
            this.lblEvidencioniBroj = new System.Windows.Forms.Label();
            this.txtEvidencioniBroj = new System.Windows.Forms.TextBox();
            this.dtpDatumPrometaUsluge = new System.Windows.Forms.DateTimePicker();
            this.lblDatumPrometaUsluge = new System.Windows.Forms.Label();
            this.dtpDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.lblDatumIzdavanjaPredracuna = new System.Windows.Forms.Label();
            this.cmbMesto = new System.Windows.Forms.ComboBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.lblMesto = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.tipUredi = new System.Windows.Forms.ToolTip(this.components);
            this.pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.Controls.Add(this.btnOdaberiUplatioca);
            this.pan1.Controls.Add(this.txtUplatioc);
            this.pan1.Controls.Add(this.lblZaUplatuSlovima);
            this.pan1.Controls.Add(this.txtZaUplatuSlovima);
            this.pan1.Controls.Add(this.lblZaUplatu);
            this.pan1.Controls.Add(this.txtZaUplatu);
            this.pan1.Controls.Add(this.lblStopaPDV);
            this.pan1.Controls.Add(this.txtStopaPDV);
            this.pan1.Controls.Add(this.lblCenaPoJediniciMere);
            this.pan1.Controls.Add(this.txtCenaPoJediniciMere);
            this.pan1.Controls.Add(this.lblKolicina);
            this.pan1.Controls.Add(this.txtKolicina);
            this.pan1.Controls.Add(this.cmbJedinicaMere);
            this.pan1.Controls.Add(this.lblJedinicaMere);
            this.pan1.Controls.Add(this.lblVrstaRobeUsluge);
            this.pan1.Controls.Add(this.txtVrstaRobeUsluge);
            this.pan1.Controls.Add(this.lblUplatioc);
            this.pan1.Controls.Add(this.lblEvidencioniBroj);
            this.pan1.Controls.Add(this.txtEvidencioniBroj);
            this.pan1.Controls.Add(this.dtpDatumPrometaUsluge);
            this.pan1.Controls.Add(this.lblDatumPrometaUsluge);
            this.pan1.Controls.Add(this.dtpDatumIzdavanja);
            this.pan1.Controls.Add(this.lblDatumIzdavanjaPredracuna);
            this.pan1.Controls.Add(this.cmbMesto);
            this.pan1.Controls.Add(this.lblBroj);
            this.pan1.Controls.Add(this.txtBroj);
            this.pan1.Controls.Add(this.lblMesto);
            this.pan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan1.Location = new System.Drawing.Point(0, 0);
            this.pan1.Margin = new System.Windows.Forms.Padding(0);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(464, 533);
            this.pan1.TabIndex = 0;
            // 
            // btnOdaberiUplatioca
            // 
            this.btnOdaberiUplatioca.AutoSize = true;
            this.btnOdaberiUplatioca.BackColor = System.Drawing.Color.White;
            this.btnOdaberiUplatioca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdaberiUplatioca.FlatAppearance.BorderSize = 0;
            this.btnOdaberiUplatioca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOdaberiUplatioca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOdaberiUplatioca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaberiUplatioca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOdaberiUplatioca.ImageIndex = 0;
            this.btnOdaberiUplatioca.ImageList = this.imgDodaj;
            this.btnOdaberiUplatioca.Location = new System.Drawing.Point(399, 397);
            this.btnOdaberiUplatioca.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnOdaberiUplatioca.Name = "btnOdaberiUplatioca";
            this.btnOdaberiUplatioca.Size = new System.Drawing.Size(26, 26);
            this.btnOdaberiUplatioca.TabIndex = 11;
            this.btnOdaberiUplatioca.TabStop = false;
            this.tipUredi.SetToolTip(this.btnOdaberiUplatioca, "Otvorite listu kako biste\r\ndodali uplatioca.");
            this.btnOdaberiUplatioca.UseVisualStyleBackColor = false;
            this.btnOdaberiUplatioca.Click += new System.EventHandler(this.btnOdaberiUplatioca_Click);
            // 
            // imgDodaj
            // 
            this.imgDodaj.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDodaj.ImageStream")));
            this.imgDodaj.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDodaj.Images.SetKeyName(0, "Edit_grey_16x.png");
            // 
            // txtUplatioc
            // 
            this.txtUplatioc.BackColor = System.Drawing.Color.White;
            this.txtUplatioc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUplatioc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUplatioc.ForeColor = System.Drawing.Color.Black;
            this.txtUplatioc.Location = new System.Drawing.Point(20, 337);
            this.txtUplatioc.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtUplatioc.Multiline = true;
            this.txtUplatioc.Name = "txtUplatioc";
            this.txtUplatioc.Size = new System.Drawing.Size(407, 88);
            this.txtUplatioc.TabIndex = 10;
            // 
            // lblZaUplatuSlovima
            // 
            this.lblZaUplatuSlovima.AutoSize = true;
            this.lblZaUplatuSlovima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblZaUplatuSlovima.Location = new System.Drawing.Point(17, 1005);
            this.lblZaUplatuSlovima.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblZaUplatuSlovima.Name = "lblZaUplatuSlovima";
            this.lblZaUplatuSlovima.Size = new System.Drawing.Size(113, 16);
            this.lblZaUplatuSlovima.TabIndex = 26;
            this.lblZaUplatuSlovima.Text = "Za uplatu slovima*";
            // 
            // txtZaUplatuSlovima
            // 
            this.txtZaUplatuSlovima.BackColor = System.Drawing.Color.White;
            this.txtZaUplatuSlovima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZaUplatuSlovima.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZaUplatuSlovima.ForeColor = System.Drawing.Color.Black;
            this.txtZaUplatuSlovima.Location = new System.Drawing.Point(20, 912);
            this.txtZaUplatuSlovima.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtZaUplatuSlovima.Multiline = true;
            this.txtZaUplatuSlovima.Name = "txtZaUplatuSlovima";
            this.txtZaUplatuSlovima.Size = new System.Drawing.Size(406, 88);
            this.txtZaUplatuSlovima.TabIndex = 25;
            // 
            // lblZaUplatu
            // 
            this.lblZaUplatu.AutoSize = true;
            this.lblZaUplatu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaUplatu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblZaUplatu.Location = new System.Drawing.Point(17, 876);
            this.lblZaUplatu.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblZaUplatu.Name = "lblZaUplatu";
            this.lblZaUplatu.Size = new System.Drawing.Size(72, 16);
            this.lblZaUplatu.TabIndex = 24;
            this.lblZaUplatu.Text = "Za uplatu*";
            // 
            // txtZaUplatu
            // 
            this.txtZaUplatu.BackColor = System.Drawing.Color.White;
            this.txtZaUplatu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZaUplatu.Enabled = false;
            this.txtZaUplatu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZaUplatu.ForeColor = System.Drawing.Color.Black;
            this.txtZaUplatu.Location = new System.Drawing.Point(20, 849);
            this.txtZaUplatu.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtZaUplatu.Name = "txtZaUplatu";
            this.txtZaUplatu.Size = new System.Drawing.Size(406, 22);
            this.txtZaUplatu.TabIndex = 23;
            // 
            // lblStopaPDV
            // 
            this.lblStopaPDV.AutoSize = true;
            this.lblStopaPDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStopaPDV.Location = new System.Drawing.Point(17, 813);
            this.lblStopaPDV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblStopaPDV.Name = "lblStopaPDV";
            this.lblStopaPDV.Size = new System.Drawing.Size(210, 16);
            this.lblStopaPDV.TabIndex = 22;
            this.lblStopaPDV.Text = "Stopa poreza na dodatnu vrednost*";
            // 
            // txtStopaPDV
            // 
            this.txtStopaPDV.BackColor = System.Drawing.Color.White;
            this.txtStopaPDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStopaPDV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStopaPDV.ForeColor = System.Drawing.Color.Black;
            this.txtStopaPDV.Location = new System.Drawing.Point(20, 786);
            this.txtStopaPDV.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtStopaPDV.Name = "txtStopaPDV";
            this.txtStopaPDV.Size = new System.Drawing.Size(406, 22);
            this.txtStopaPDV.TabIndex = 21;
            this.txtStopaPDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStopaPDV_KeyPress);
            this.txtStopaPDV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStopaPDV_KeyUp);
            this.txtStopaPDV.Leave += new System.EventHandler(this.txtStopaPDV_Leave);
            // 
            // lblCenaPoJediniciMere
            // 
            this.lblCenaPoJediniciMere.AutoSize = true;
            this.lblCenaPoJediniciMere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCenaPoJediniciMere.Location = new System.Drawing.Point(17, 750);
            this.lblCenaPoJediniciMere.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblCenaPoJediniciMere.Name = "lblCenaPoJediniciMere";
            this.lblCenaPoJediniciMere.Size = new System.Drawing.Size(138, 16);
            this.lblCenaPoJediniciMere.TabIndex = 20;
            this.lblCenaPoJediniciMere.Text = "Cena po jedinici mere*";
            // 
            // txtCenaPoJediniciMere
            // 
            this.txtCenaPoJediniciMere.BackColor = System.Drawing.Color.White;
            this.txtCenaPoJediniciMere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCenaPoJediniciMere.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCenaPoJediniciMere.ForeColor = System.Drawing.Color.Black;
            this.txtCenaPoJediniciMere.Location = new System.Drawing.Point(20, 723);
            this.txtCenaPoJediniciMere.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtCenaPoJediniciMere.Name = "txtCenaPoJediniciMere";
            this.txtCenaPoJediniciMere.Size = new System.Drawing.Size(406, 22);
            this.txtCenaPoJediniciMere.TabIndex = 19;
            this.txtCenaPoJediniciMere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCenaPoJediniciMere_KeyPress);
            this.txtCenaPoJediniciMere.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCenaPoJediniciMere_KeyUp);
            this.txtCenaPoJediniciMere.Leave += new System.EventHandler(this.txtCenaPoJediniciMere_Leave);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblKolicina.Location = new System.Drawing.Point(17, 687);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(59, 16);
            this.lblKolicina.TabIndex = 18;
            this.lblKolicina.Text = "Kolicina*";
            // 
            // txtKolicina
            // 
            this.txtKolicina.BackColor = System.Drawing.Color.White;
            this.txtKolicina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKolicina.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKolicina.ForeColor = System.Drawing.Color.Black;
            this.txtKolicina.Location = new System.Drawing.Point(20, 660);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(407, 22);
            this.txtKolicina.TabIndex = 17;
            this.txtKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKolicina_KeyPress);
            this.txtKolicina.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKolicina_KeyUp);
            this.txtKolicina.Leave += new System.EventHandler(this.txtKolicina_Leave);
            // 
            // cmbJedinicaMere
            // 
            this.cmbJedinicaMere.BackColor = System.Drawing.Color.White;
            this.cmbJedinicaMere.FormattingEnabled = true;
            this.cmbJedinicaMere.Location = new System.Drawing.Point(20, 595);
            this.cmbJedinicaMere.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbJedinicaMere.Name = "cmbJedinicaMere";
            this.cmbJedinicaMere.Size = new System.Drawing.Size(407, 24);
            this.cmbJedinicaMere.TabIndex = 15;
            // 
            // lblJedinicaMere
            // 
            this.lblJedinicaMere.AutoSize = true;
            this.lblJedinicaMere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJedinicaMere.Location = new System.Drawing.Point(17, 624);
            this.lblJedinicaMere.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblJedinicaMere.Name = "lblJedinicaMere";
            this.lblJedinicaMere.Size = new System.Drawing.Size(93, 16);
            this.lblJedinicaMere.TabIndex = 16;
            this.lblJedinicaMere.Text = "Jedinica mere*";
            // 
            // lblVrstaRobeUsluge
            // 
            this.lblVrstaRobeUsluge.AutoSize = true;
            this.lblVrstaRobeUsluge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVrstaRobeUsluge.Location = new System.Drawing.Point(17, 559);
            this.lblVrstaRobeUsluge.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblVrstaRobeUsluge.Name = "lblVrstaRobeUsluge";
            this.lblVrstaRobeUsluge.Size = new System.Drawing.Size(128, 16);
            this.lblVrstaRobeUsluge.TabIndex = 14;
            this.lblVrstaRobeUsluge.Text = "Vrsta robe ili usluge*";
            // 
            // txtVrstaRobeUsluge
            // 
            this.txtVrstaRobeUsluge.BackColor = System.Drawing.Color.White;
            this.txtVrstaRobeUsluge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVrstaRobeUsluge.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVrstaRobeUsluge.ForeColor = System.Drawing.Color.Black;
            this.txtVrstaRobeUsluge.Location = new System.Drawing.Point(20, 466);
            this.txtVrstaRobeUsluge.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtVrstaRobeUsluge.Multiline = true;
            this.txtVrstaRobeUsluge.Name = "txtVrstaRobeUsluge";
            this.txtVrstaRobeUsluge.Size = new System.Drawing.Size(406, 88);
            this.txtVrstaRobeUsluge.TabIndex = 13;
            // 
            // lblUplatioc
            // 
            this.lblUplatioc.AutoSize = true;
            this.lblUplatioc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUplatioc.Location = new System.Drawing.Point(17, 430);
            this.lblUplatioc.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblUplatioc.Name = "lblUplatioc";
            this.lblUplatioc.Size = new System.Drawing.Size(60, 16);
            this.lblUplatioc.TabIndex = 12;
            this.lblUplatioc.Text = "Uplatioc*";
            // 
            // lblEvidencioniBroj
            // 
            this.lblEvidencioniBroj.AutoSize = true;
            this.lblEvidencioniBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEvidencioniBroj.Location = new System.Drawing.Point(17, 236);
            this.lblEvidencioniBroj.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblEvidencioniBroj.Name = "lblEvidencioniBroj";
            this.lblEvidencioniBroj.Size = new System.Drawing.Size(103, 16);
            this.lblEvidencioniBroj.TabIndex = 7;
            this.lblEvidencioniBroj.Text = "Evidencioni broj*";
            // 
            // txtEvidencioniBroj
            // 
            this.txtEvidencioniBroj.BackColor = System.Drawing.Color.White;
            this.txtEvidencioniBroj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEvidencioniBroj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEvidencioniBroj.ForeColor = System.Drawing.Color.Black;
            this.txtEvidencioniBroj.Location = new System.Drawing.Point(20, 209);
            this.txtEvidencioniBroj.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtEvidencioniBroj.Name = "txtEvidencioniBroj";
            this.txtEvidencioniBroj.Size = new System.Drawing.Size(407, 22);
            this.txtEvidencioniBroj.TabIndex = 6;
            // 
            // dtpDatumPrometaUsluge
            // 
            this.dtpDatumPrometaUsluge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPrometaUsluge.Location = new System.Drawing.Point(20, 146);
            this.dtpDatumPrometaUsluge.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.dtpDatumPrometaUsluge.Name = "dtpDatumPrometaUsluge";
            this.dtpDatumPrometaUsluge.Size = new System.Drawing.Size(407, 22);
            this.dtpDatumPrometaUsluge.TabIndex = 4;
            // 
            // lblDatumPrometaUsluge
            // 
            this.lblDatumPrometaUsluge.AutoSize = true;
            this.lblDatumPrometaUsluge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDatumPrometaUsluge.Location = new System.Drawing.Point(17, 173);
            this.lblDatumPrometaUsluge.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDatumPrometaUsluge.Name = "lblDatumPrometaUsluge";
            this.lblDatumPrometaUsluge.Size = new System.Drawing.Size(144, 16);
            this.lblDatumPrometaUsluge.TabIndex = 5;
            this.lblDatumPrometaUsluge.Text = "Datum prometa usluge*";
            // 
            // dtpDatumIzdavanja
            // 
            this.dtpDatumIzdavanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumIzdavanja.Location = new System.Drawing.Point(20, 83);
            this.dtpDatumIzdavanja.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.dtpDatumIzdavanja.Name = "dtpDatumIzdavanja";
            this.dtpDatumIzdavanja.Size = new System.Drawing.Size(407, 22);
            this.dtpDatumIzdavanja.TabIndex = 2;
            // 
            // lblDatumIzdavanjaPredracuna
            // 
            this.lblDatumIzdavanjaPredracuna.AutoSize = true;
            this.lblDatumIzdavanjaPredracuna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDatumIzdavanjaPredracuna.Location = new System.Drawing.Point(17, 110);
            this.lblDatumIzdavanjaPredracuna.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDatumIzdavanjaPredracuna.Name = "lblDatumIzdavanjaPredracuna";
            this.lblDatumIzdavanjaPredracuna.Size = new System.Drawing.Size(176, 16);
            this.lblDatumIzdavanjaPredracuna.TabIndex = 3;
            this.lblDatumIzdavanjaPredracuna.Text = "Datum izdavanja predračuna*";
            // 
            // cmbMesto
            // 
            this.cmbMesto.BackColor = System.Drawing.Color.White;
            this.cmbMesto.FormattingEnabled = true;
            this.cmbMesto.Location = new System.Drawing.Point(20, 272);
            this.cmbMesto.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbMesto.Name = "cmbMesto";
            this.cmbMesto.Size = new System.Drawing.Size(407, 24);
            this.cmbMesto.TabIndex = 8;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBroj.Location = new System.Drawing.Point(17, 47);
            this.lblBroj.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(104, 16);
            this.lblBroj.TabIndex = 1;
            this.lblBroj.Text = "Broj predračuna*";
            // 
            // txtBroj
            // 
            this.txtBroj.BackColor = System.Drawing.Color.White;
            this.txtBroj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBroj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBroj.ForeColor = System.Drawing.Color.Black;
            this.txtBroj.Location = new System.Drawing.Point(20, 20);
            this.txtBroj.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(407, 22);
            this.txtBroj.TabIndex = 0;
            this.txtBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBroj_KeyPress);
            this.txtBroj.Leave += new System.EventHandler(this.txtBroj_Leave);
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMesto.Location = new System.Drawing.Point(17, 301);
            this.lblMesto.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(49, 16);
            this.lblMesto.TabIndex = 9;
            this.lblMesto.Text = "Mesto*";
            // 
            // btnSnimi
            // 
            this.btnSnimi.AutoSize = true;
            this.btnSnimi.BackColor = System.Drawing.Color.Gray;
            this.btnSnimi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSnimi.FlatAppearance.BorderSize = 0;
            this.btnSnimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSnimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSnimi.Location = new System.Drawing.Point(369, 553);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(0, 20, 11, 11);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 28);
            this.btnSnimi.TabIndex = 1;
            this.btnSnimi.Text = "Snimi";
            this.tipUredi.SetToolTip(this.btnSnimi, "Ažurirajte promene na\r\npredračunu.");
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tipUredi
            // 
            this.tipUredi.ToolTipTitle = "Finansije - Predračuni";
            // 
            // frmUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.btnSnimi);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finansije - Predračun - Obrada";
            this.Load += new System.EventHandler(this.frmDodaj_Load);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.Label lblZaUplatuSlovima;
        internal System.Windows.Forms.TextBox txtZaUplatuSlovima;
        internal System.Windows.Forms.Label lblZaUplatu;
        internal System.Windows.Forms.TextBox txtZaUplatu;
        internal System.Windows.Forms.Label lblStopaPDV;
        internal System.Windows.Forms.TextBox txtStopaPDV;
        internal System.Windows.Forms.Label lblCenaPoJediniciMere;
        internal System.Windows.Forms.TextBox txtCenaPoJediniciMere;
        internal System.Windows.Forms.Label lblKolicina;
        internal System.Windows.Forms.TextBox txtKolicina;
        internal System.Windows.Forms.ComboBox cmbJedinicaMere;
        internal System.Windows.Forms.Label lblJedinicaMere;
        internal System.Windows.Forms.Label lblVrstaRobeUsluge;
        internal System.Windows.Forms.TextBox txtVrstaRobeUsluge;
        internal System.Windows.Forms.Label lblUplatioc;
        internal System.Windows.Forms.Label lblEvidencioniBroj;
        internal System.Windows.Forms.TextBox txtEvidencioniBroj;
        internal System.Windows.Forms.DateTimePicker dtpDatumPrometaUsluge;
        internal System.Windows.Forms.Label lblDatumPrometaUsluge;
        internal System.Windows.Forms.DateTimePicker dtpDatumIzdavanja;
        internal System.Windows.Forms.Label lblDatumIzdavanjaPredracuna;
        internal System.Windows.Forms.ComboBox cmbMesto;
        internal System.Windows.Forms.Label lblBroj;
        internal System.Windows.Forms.TextBox txtBroj;
        internal System.Windows.Forms.Label lblMesto;
        internal System.Windows.Forms.Button btnSnimi;
        internal System.Windows.Forms.TextBox txtUplatioc;
        internal System.Windows.Forms.Button btnOdaberiUplatioca;
        internal System.Windows.Forms.ImageList imgDodaj;
        private System.Windows.Forms.ToolTip tipUredi;
    }
}