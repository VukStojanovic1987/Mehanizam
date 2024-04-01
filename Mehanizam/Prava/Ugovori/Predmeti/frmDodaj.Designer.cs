namespace Mehanizam.Prava.Ugovori.Predmeti
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.imgDodaj = new System.Windows.Forms.ImageList(this.components);
            this.lblVrstaUgovora = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.cmbVrstaUgovora = new System.Windows.Forms.ComboBox();
            this.pan1 = new System.Windows.Forms.Panel();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblLice = new System.Windows.Forms.Label();
            this.txtLice = new System.Windows.Forms.TextBox();
            this.tipDodaj = new System.Windows.Forms.ToolTip(this.components);
            this.pan1.SuspendLayout();
            this.SuspendLayout();
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
            this.tipDodaj.SetToolTip(this.btnDodaj, "Dodajte novi ugovor.");
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // imgDodaj
            // 
            this.imgDodaj.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDodaj.ImageStream")));
            this.imgDodaj.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDodaj.Images.SetKeyName(0, "AddUser_16x.png");
            // 
            // lblVrstaUgovora
            // 
            this.lblVrstaUgovora.AutoSize = true;
            this.lblVrstaUgovora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVrstaUgovora.Location = new System.Drawing.Point(17, 240);
            this.lblVrstaUgovora.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblVrstaUgovora.Name = "lblVrstaUgovora";
            this.lblVrstaUgovora.Size = new System.Drawing.Size(92, 16);
            this.lblVrstaUgovora.TabIndex = 7;
            this.lblVrstaUgovora.Text = "Vrsta ugovora*";
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
            this.txtBroj.Size = new System.Drawing.Size(424, 22);
            this.txtBroj.TabIndex = 0;
            this.txtBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBroj_KeyPress);
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBroj.Location = new System.Drawing.Point(17, 47);
            this.lblBroj.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(84, 16);
            this.lblBroj.TabIndex = 1;
            this.lblBroj.Text = "Broj ugovora*";
            // 
            // cmbVrstaUgovora
            // 
            this.cmbVrstaUgovora.AutoCompleteCustomSource.AddRange(new string[] {
            "stambeni objekat",
            "poslovni objekat",
            "pomoćni objekat"});
            this.cmbVrstaUgovora.BackColor = System.Drawing.Color.White;
            this.cmbVrstaUgovora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrstaUgovora.FormattingEnabled = true;
            this.cmbVrstaUgovora.Items.AddRange(new object[] {
            "Ugovor i kratkoročnoj pozajmici",
            "Ništa od ponuđenog"});
            this.cmbVrstaUgovora.Location = new System.Drawing.Point(20, 211);
            this.cmbVrstaUgovora.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbVrstaUgovora.Name = "cmbVrstaUgovora";
            this.cmbVrstaUgovora.Size = new System.Drawing.Size(424, 24);
            this.cmbVrstaUgovora.TabIndex = 6;
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.Controls.Add(this.cmbGodina);
            this.pan1.Controls.Add(this.lblGodina);
            this.pan1.Controls.Add(this.lblLice);
            this.pan1.Controls.Add(this.txtLice);
            this.pan1.Controls.Add(this.cmbVrstaUgovora);
            this.pan1.Controls.Add(this.lblBroj);
            this.pan1.Controls.Add(this.txtBroj);
            this.pan1.Controls.Add(this.lblVrstaUgovora);
            this.pan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan1.Location = new System.Drawing.Point(0, 0);
            this.pan1.Margin = new System.Windows.Forms.Padding(0);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(464, 533);
            this.pan1.TabIndex = 0;
            // 
            // cmbGodina
            // 
            this.cmbGodina.BackColor = System.Drawing.Color.White;
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(20, 83);
            this.cmbGodina.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(424, 24);
            this.cmbGodina.TabIndex = 2;
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGodina.Location = new System.Drawing.Point(17, 112);
            this.lblGodina.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(141, 16);
            this.lblGodina.TabIndex = 3;
            this.lblGodina.Text = "Godina izrade ugovora*";
            // 
            // lblLice
            // 
            this.lblLice.AutoSize = true;
            this.lblLice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLice.Location = new System.Drawing.Point(17, 175);
            this.lblLice.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblLice.Name = "lblLice";
            this.lblLice.Size = new System.Drawing.Size(37, 16);
            this.lblLice.TabIndex = 5;
            this.lblLice.Text = "Lice*";
            // 
            // txtLice
            // 
            this.txtLice.BackColor = System.Drawing.Color.White;
            this.txtLice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLice.ForeColor = System.Drawing.Color.Black;
            this.txtLice.Location = new System.Drawing.Point(20, 148);
            this.txtLice.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtLice.Name = "txtLice";
            this.txtLice.Size = new System.Drawing.Size(424, 22);
            this.txtLice.TabIndex = 4;
            this.txtLice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLice_KeyPress);
            // 
            // tipDodaj
            // 
            this.tipDodaj.ToolTipTitle = "Prava - Ugovori";
            // 
            // frmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.pan1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prava - Ugovor - Novi";
            this.Load += new System.EventHandler(this.frmDodaj_Load);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnDodaj;
        internal System.Windows.Forms.ImageList imgDodaj;
        internal System.Windows.Forms.Label lblVrstaUgovora;
        internal System.Windows.Forms.TextBox txtBroj;
        internal System.Windows.Forms.Label lblBroj;
        internal System.Windows.Forms.ComboBox cmbVrstaUgovora;
        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.ComboBox cmbGodina;
        internal System.Windows.Forms.Label lblGodina;
        internal System.Windows.Forms.Label lblLice;
        internal System.Windows.Forms.TextBox txtLice;
        private System.Windows.Forms.ToolTip tipDodaj;
    }
}