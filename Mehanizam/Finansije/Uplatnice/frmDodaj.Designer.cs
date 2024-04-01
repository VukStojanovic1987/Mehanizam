namespace Mehanizam.Finansije.Uplatnice
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
            this.btnTekuciRacun = new System.Windows.Forms.Button();
            this.imgDodaj = new System.Windows.Forms.ImageList(this.components);
            this.lblPozivNaBroj = new System.Windows.Forms.Label();
            this.txtPozivNaBroj = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblRacunPrimaoca = new System.Windows.Forms.Label();
            this.txtRacunPrimaoca = new System.Windows.Forms.TextBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            this.lblSifraPlacanja = new System.Windows.Forms.Label();
            this.txtSifraPlacanja = new System.Windows.Forms.TextBox();
            this.lblValuta = new System.Windows.Forms.Label();
            this.btnPrimalac = new System.Windows.Forms.Button();
            this.txtPrimalac = new System.Windows.Forms.TextBox();
            this.lblPrimalac = new System.Windows.Forms.Label();
            this.btnPlatilac = new System.Windows.Forms.Button();
            this.txtPlatilac = new System.Windows.Forms.TextBox();
            this.lblSvrhaUplate = new System.Windows.Forms.Label();
            this.txtSvrhaUplate = new System.Windows.Forms.TextBox();
            this.lblPlatilac = new System.Windows.Forms.Label();
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
            this.pan1.Controls.Add(this.btnTekuciRacun);
            this.pan1.Controls.Add(this.lblPozivNaBroj);
            this.pan1.Controls.Add(this.txtPozivNaBroj);
            this.pan1.Controls.Add(this.lblModel);
            this.pan1.Controls.Add(this.txtModel);
            this.pan1.Controls.Add(this.lblRacunPrimaoca);
            this.pan1.Controls.Add(this.txtRacunPrimaoca);
            this.pan1.Controls.Add(this.lblIznos);
            this.pan1.Controls.Add(this.txtIznos);
            this.pan1.Controls.Add(this.cmbValuta);
            this.pan1.Controls.Add(this.lblSifraPlacanja);
            this.pan1.Controls.Add(this.txtSifraPlacanja);
            this.pan1.Controls.Add(this.lblValuta);
            this.pan1.Controls.Add(this.btnPrimalac);
            this.pan1.Controls.Add(this.txtPrimalac);
            this.pan1.Controls.Add(this.lblPrimalac);
            this.pan1.Controls.Add(this.btnPlatilac);
            this.pan1.Controls.Add(this.txtPlatilac);
            this.pan1.Controls.Add(this.lblSvrhaUplate);
            this.pan1.Controls.Add(this.txtSvrhaUplate);
            this.pan1.Controls.Add(this.lblPlatilac);
            this.pan1.Controls.Add(this.dtpDatum);
            this.pan1.Controls.Add(this.lblDatum);
            this.pan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan1.Location = new System.Drawing.Point(0, 0);
            this.pan1.Margin = new System.Windows.Forms.Padding(0);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(464, 533);
            this.pan1.TabIndex = 0;
            // 
            // btnTekuciRacun
            // 
            this.btnTekuciRacun.AutoSize = true;
            this.btnTekuciRacun.BackColor = System.Drawing.Color.White;
            this.btnTekuciRacun.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTekuciRacun.FlatAppearance.BorderSize = 0;
            this.btnTekuciRacun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnTekuciRacun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTekuciRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTekuciRacun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTekuciRacun.ImageIndex = 0;
            this.btnTekuciRacun.ImageList = this.imgDodaj;
            this.btnTekuciRacun.Location = new System.Drawing.Point(401, 667);
            this.btnTekuciRacun.Margin = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnTekuciRacun.Name = "btnTekuciRacun";
            this.btnTekuciRacun.Size = new System.Drawing.Size(26, 26);
            this.btnTekuciRacun.TabIndex = 42;
            this.btnTekuciRacun.TabStop = false;
            this.tipDodaj.SetToolTip(this.btnTekuciRacun, "Otvorite listu kako biste\r\ndodali primaoca i tekući\r\nračun primaoca.");
            this.btnTekuciRacun.UseVisualStyleBackColor = false;
            this.btnTekuciRacun.Click += new System.EventHandler(this.btnTekuciRacun_Click);
            // 
            // imgDodaj
            // 
            this.imgDodaj.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDodaj.ImageStream")));
            this.imgDodaj.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDodaj.Images.SetKeyName(0, "Edit_grey_16x.png");
            // 
            // lblPozivNaBroj
            // 
            this.lblPozivNaBroj.AutoSize = true;
            this.lblPozivNaBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPozivNaBroj.Location = new System.Drawing.Point(17, 823);
            this.lblPozivNaBroj.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPozivNaBroj.Name = "lblPozivNaBroj";
            this.lblPozivNaBroj.Size = new System.Drawing.Size(82, 16);
            this.lblPozivNaBroj.TabIndex = 41;
            this.lblPozivNaBroj.Text = "Poziv na broj";
            // 
            // txtPozivNaBroj
            // 
            this.txtPozivNaBroj.BackColor = System.Drawing.Color.White;
            this.txtPozivNaBroj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPozivNaBroj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPozivNaBroj.ForeColor = System.Drawing.Color.Black;
            this.txtPozivNaBroj.Location = new System.Drawing.Point(20, 796);
            this.txtPozivNaBroj.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtPozivNaBroj.Name = "txtPozivNaBroj";
            this.txtPozivNaBroj.Size = new System.Drawing.Size(407, 22);
            this.txtPozivNaBroj.TabIndex = 40;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModel.Location = new System.Drawing.Point(17, 760);
            this.lblModel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(43, 16);
            this.lblModel.TabIndex = 39;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.White;
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModel.ForeColor = System.Drawing.Color.Black;
            this.txtModel.Location = new System.Drawing.Point(20, 733);
            this.txtModel.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(407, 22);
            this.txtModel.TabIndex = 38;
            // 
            // lblRacunPrimaoca
            // 
            this.lblRacunPrimaoca.AutoSize = true;
            this.lblRacunPrimaoca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRacunPrimaoca.Location = new System.Drawing.Point(17, 697);
            this.lblRacunPrimaoca.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblRacunPrimaoca.Name = "lblRacunPrimaoca";
            this.lblRacunPrimaoca.Size = new System.Drawing.Size(107, 16);
            this.lblRacunPrimaoca.TabIndex = 37;
            this.lblRacunPrimaoca.Text = "Račun primaoca*";
            // 
            // txtRacunPrimaoca
            // 
            this.txtRacunPrimaoca.BackColor = System.Drawing.Color.White;
            this.txtRacunPrimaoca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRacunPrimaoca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRacunPrimaoca.ForeColor = System.Drawing.Color.Black;
            this.txtRacunPrimaoca.Location = new System.Drawing.Point(20, 670);
            this.txtRacunPrimaoca.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtRacunPrimaoca.Name = "txtRacunPrimaoca";
            this.txtRacunPrimaoca.Size = new System.Drawing.Size(379, 22);
            this.txtRacunPrimaoca.TabIndex = 36;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIznos.Location = new System.Drawing.Point(17, 634);
            this.lblIznos.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(44, 16);
            this.lblIznos.TabIndex = 35;
            this.lblIznos.Text = "Iznos*";
            // 
            // txtIznos
            // 
            this.txtIznos.BackColor = System.Drawing.Color.White;
            this.txtIznos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIznos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIznos.ForeColor = System.Drawing.Color.Black;
            this.txtIznos.Location = new System.Drawing.Point(20, 607);
            this.txtIznos.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(407, 22);
            this.txtIznos.TabIndex = 34;
            // 
            // cmbValuta
            // 
            this.cmbValuta.BackColor = System.Drawing.Color.White;
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Location = new System.Drawing.Point(20, 542);
            this.cmbValuta.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(407, 24);
            this.cmbValuta.TabIndex = 32;
            // 
            // lblSifraPlacanja
            // 
            this.lblSifraPlacanja.AutoSize = true;
            this.lblSifraPlacanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSifraPlacanja.Location = new System.Drawing.Point(17, 506);
            this.lblSifraPlacanja.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblSifraPlacanja.Name = "lblSifraPlacanja";
            this.lblSifraPlacanja.Size = new System.Drawing.Size(86, 16);
            this.lblSifraPlacanja.TabIndex = 31;
            this.lblSifraPlacanja.Text = "Šifra plaćanja";
            // 
            // txtSifraPlacanja
            // 
            this.txtSifraPlacanja.BackColor = System.Drawing.Color.White;
            this.txtSifraPlacanja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifraPlacanja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraPlacanja.ForeColor = System.Drawing.Color.Black;
            this.txtSifraPlacanja.Location = new System.Drawing.Point(20, 479);
            this.txtSifraPlacanja.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtSifraPlacanja.Name = "txtSifraPlacanja";
            this.txtSifraPlacanja.Size = new System.Drawing.Size(407, 22);
            this.txtSifraPlacanja.TabIndex = 30;
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValuta.Location = new System.Drawing.Point(17, 571);
            this.lblValuta.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(44, 16);
            this.lblValuta.TabIndex = 33;
            this.lblValuta.Text = "Valuta";
            // 
            // btnPrimalac
            // 
            this.btnPrimalac.AutoSize = true;
            this.btnPrimalac.BackColor = System.Drawing.Color.White;
            this.btnPrimalac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrimalac.FlatAppearance.BorderSize = 0;
            this.btnPrimalac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrimalac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrimalac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimalac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrimalac.ImageIndex = 0;
            this.btnPrimalac.ImageList = this.imgDodaj;
            this.btnPrimalac.Location = new System.Drawing.Point(399, 410);
            this.btnPrimalac.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnPrimalac.Name = "btnPrimalac";
            this.btnPrimalac.Size = new System.Drawing.Size(26, 26);
            this.btnPrimalac.TabIndex = 28;
            this.btnPrimalac.TabStop = false;
            this.tipDodaj.SetToolTip(this.btnPrimalac, "Otvorite listu kako biste\r\ndodali primaoca i tekući\r\nračun primaoca.");
            this.btnPrimalac.UseVisualStyleBackColor = false;
            this.btnPrimalac.Click += new System.EventHandler(this.btnPrimalac_Click);
            // 
            // txtPrimalac
            // 
            this.txtPrimalac.BackColor = System.Drawing.Color.White;
            this.txtPrimalac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimalac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrimalac.ForeColor = System.Drawing.Color.Black;
            this.txtPrimalac.Location = new System.Drawing.Point(20, 350);
            this.txtPrimalac.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtPrimalac.Multiline = true;
            this.txtPrimalac.Name = "txtPrimalac";
            this.txtPrimalac.Size = new System.Drawing.Size(407, 88);
            this.txtPrimalac.TabIndex = 27;
            // 
            // lblPrimalac
            // 
            this.lblPrimalac.AutoSize = true;
            this.lblPrimalac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrimalac.Location = new System.Drawing.Point(17, 443);
            this.lblPrimalac.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPrimalac.Name = "lblPrimalac";
            this.lblPrimalac.Size = new System.Drawing.Size(64, 16);
            this.lblPrimalac.TabIndex = 29;
            this.lblPrimalac.Text = "Primalac*";
            // 
            // btnPlatilac
            // 
            this.btnPlatilac.AutoSize = true;
            this.btnPlatilac.BackColor = System.Drawing.Color.White;
            this.btnPlatilac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlatilac.FlatAppearance.BorderSize = 0;
            this.btnPlatilac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPlatilac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlatilac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlatilac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlatilac.ImageIndex = 0;
            this.btnPlatilac.ImageList = this.imgDodaj;
            this.btnPlatilac.Location = new System.Drawing.Point(399, 152);
            this.btnPlatilac.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnPlatilac.Name = "btnPlatilac";
            this.btnPlatilac.Size = new System.Drawing.Size(26, 26);
            this.btnPlatilac.TabIndex = 11;
            this.btnPlatilac.TabStop = false;
            this.tipDodaj.SetToolTip(this.btnPlatilac, "Otvorite listu kako biste\r\ndodali platioca.");
            this.btnPlatilac.UseVisualStyleBackColor = false;
            this.btnPlatilac.Click += new System.EventHandler(this.btnPlatilac_Click);
            // 
            // txtPlatilac
            // 
            this.txtPlatilac.BackColor = System.Drawing.Color.White;
            this.txtPlatilac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlatilac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlatilac.ForeColor = System.Drawing.Color.Black;
            this.txtPlatilac.Location = new System.Drawing.Point(20, 92);
            this.txtPlatilac.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtPlatilac.Multiline = true;
            this.txtPlatilac.Name = "txtPlatilac";
            this.txtPlatilac.Size = new System.Drawing.Size(407, 88);
            this.txtPlatilac.TabIndex = 10;
            // 
            // lblSvrhaUplate
            // 
            this.lblSvrhaUplate.AutoSize = true;
            this.lblSvrhaUplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSvrhaUplate.Location = new System.Drawing.Point(17, 314);
            this.lblSvrhaUplate.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblSvrhaUplate.Name = "lblSvrhaUplate";
            this.lblSvrhaUplate.Size = new System.Drawing.Size(84, 16);
            this.lblSvrhaUplate.TabIndex = 14;
            this.lblSvrhaUplate.Text = "Svrha uplate*";
            // 
            // txtSvrhaUplate
            // 
            this.txtSvrhaUplate.BackColor = System.Drawing.Color.White;
            this.txtSvrhaUplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSvrhaUplate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSvrhaUplate.ForeColor = System.Drawing.Color.Black;
            this.txtSvrhaUplate.Location = new System.Drawing.Point(20, 221);
            this.txtSvrhaUplate.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtSvrhaUplate.Multiline = true;
            this.txtSvrhaUplate.Name = "txtSvrhaUplate";
            this.txtSvrhaUplate.Size = new System.Drawing.Size(406, 88);
            this.txtSvrhaUplate.TabIndex = 13;
            // 
            // lblPlatilac
            // 
            this.lblPlatilac.AutoSize = true;
            this.lblPlatilac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlatilac.Location = new System.Drawing.Point(17, 185);
            this.lblPlatilac.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPlatilac.Name = "lblPlatilac";
            this.lblPlatilac.Size = new System.Drawing.Size(56, 16);
            this.lblPlatilac.TabIndex = 12;
            this.lblPlatilac.Text = "Platilac*";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(20, 29);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(407, 22);
            this.dtpDatum.TabIndex = 2;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDatum.Location = new System.Drawing.Point(17, 56);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(51, 16);
            this.lblDatum.TabIndex = 3;
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
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.tipDodaj.SetToolTip(this.btnDodaj, "Dodajte novu uplatnicu.");
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tipDodaj
            // 
            this.tipDodaj.ToolTipTitle = "Finansije - Uplatnice";
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
            this.Text = "Finansije - Uplatnica - Nova";
            this.Load += new System.EventHandler(this.frmDodaj_Load);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.Label lblSvrhaUplate;
        internal System.Windows.Forms.TextBox txtSvrhaUplate;
        internal System.Windows.Forms.Label lblPlatilac;
        internal System.Windows.Forms.DateTimePicker dtpDatum;
        internal System.Windows.Forms.Label lblDatum;
        internal System.Windows.Forms.Button btnDodaj;
        internal System.Windows.Forms.TextBox txtPlatilac;
        internal System.Windows.Forms.Button btnPlatilac;
        internal System.Windows.Forms.ImageList imgDodaj;
        internal System.Windows.Forms.Button btnPrimalac;
        internal System.Windows.Forms.TextBox txtPrimalac;
        internal System.Windows.Forms.Label lblPrimalac;
        internal System.Windows.Forms.ComboBox cmbValuta;
        internal System.Windows.Forms.Label lblSifraPlacanja;
        internal System.Windows.Forms.TextBox txtSifraPlacanja;
        internal System.Windows.Forms.Label lblValuta;
        internal System.Windows.Forms.Label lblModel;
        internal System.Windows.Forms.TextBox txtModel;
        internal System.Windows.Forms.Label lblRacunPrimaoca;
        internal System.Windows.Forms.TextBox txtRacunPrimaoca;
        internal System.Windows.Forms.Label lblIznos;
        internal System.Windows.Forms.TextBox txtIznos;
        internal System.Windows.Forms.Label lblPozivNaBroj;
        internal System.Windows.Forms.TextBox txtPozivNaBroj;
        internal System.Windows.Forms.Button btnTekuciRacun;
        private System.Windows.Forms.ToolTip tipDodaj;
    }
}