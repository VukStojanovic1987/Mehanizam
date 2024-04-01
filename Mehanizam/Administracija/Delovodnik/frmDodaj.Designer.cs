namespace Mehanizam.Administracija.Delovodnik
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
            this.cmbIzlazUlaz = new System.Windows.Forms.ComboBox();
            this.lblIzlazUlaz = new System.Windows.Forms.Label();
            this.cmbVrstaDokumenta = new System.Windows.Forms.ComboBox();
            this.lblVrstaDokumenta = new System.Windows.Forms.Label();
            this.txtOpisDokumenta = new System.Windows.Forms.TextBox();
            this.lblOpisDokumenta = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.cmbMesto = new System.Windows.Forms.ComboBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.lblMesto = new System.Windows.Forms.Label();
            this.imgDodaj = new System.Windows.Forms.ImageList(this.components);
            this.btnZavedi = new System.Windows.Forms.Button();
            this.tipDodaj = new System.Windows.Forms.ToolTip(this.components);
            this.pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.Controls.Add(this.cmbIzlazUlaz);
            this.pan1.Controls.Add(this.lblIzlazUlaz);
            this.pan1.Controls.Add(this.cmbVrstaDokumenta);
            this.pan1.Controls.Add(this.lblVrstaDokumenta);
            this.pan1.Controls.Add(this.txtOpisDokumenta);
            this.pan1.Controls.Add(this.lblOpisDokumenta);
            this.pan1.Controls.Add(this.dtpDatum);
            this.pan1.Controls.Add(this.lblDatum);
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
            // cmbIzlazUlaz
            // 
            this.cmbIzlazUlaz.BackColor = System.Drawing.Color.White;
            this.cmbIzlazUlaz.FormattingEnabled = true;
            this.cmbIzlazUlaz.Items.AddRange(new object[] {
            "Izlazni",
            "Ulazni"});
            this.cmbIzlazUlaz.Location = new System.Drawing.Point(20, 276);
            this.cmbIzlazUlaz.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbIzlazUlaz.Name = "cmbIzlazUlaz";
            this.cmbIzlazUlaz.Size = new System.Drawing.Size(424, 24);
            this.cmbIzlazUlaz.TabIndex = 8;
            // 
            // lblIzlazUlaz
            // 
            this.lblIzlazUlaz.AutoSize = true;
            this.lblIzlazUlaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIzlazUlaz.Location = new System.Drawing.Point(17, 305);
            this.lblIzlazUlaz.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblIzlazUlaz.Name = "lblIzlazUlaz";
            this.lblIzlazUlaz.Size = new System.Drawing.Size(151, 16);
            this.lblIzlazUlaz.TabIndex = 9;
            this.lblIzlazUlaz.Text = "Izlazni/Ulazni dokument*";
            // 
            // cmbVrstaDokumenta
            // 
            this.cmbVrstaDokumenta.BackColor = System.Drawing.Color.White;
            this.cmbVrstaDokumenta.FormattingEnabled = true;
            this.cmbVrstaDokumenta.Location = new System.Drawing.Point(20, 211);
            this.cmbVrstaDokumenta.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbVrstaDokumenta.Name = "cmbVrstaDokumenta";
            this.cmbVrstaDokumenta.Size = new System.Drawing.Size(424, 24);
            this.cmbVrstaDokumenta.TabIndex = 6;
            // 
            // lblVrstaDokumenta
            // 
            this.lblVrstaDokumenta.AutoSize = true;
            this.lblVrstaDokumenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVrstaDokumenta.Location = new System.Drawing.Point(17, 240);
            this.lblVrstaDokumenta.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblVrstaDokumenta.Name = "lblVrstaDokumenta";
            this.lblVrstaDokumenta.Size = new System.Drawing.Size(112, 16);
            this.lblVrstaDokumenta.TabIndex = 7;
            this.lblVrstaDokumenta.Text = "Vrsta dokumenta*";
            // 
            // txtOpisDokumenta
            // 
            this.txtOpisDokumenta.BackColor = System.Drawing.Color.White;
            this.txtOpisDokumenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpisDokumenta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpisDokumenta.ForeColor = System.Drawing.Color.Black;
            this.txtOpisDokumenta.Location = new System.Drawing.Point(20, 341);
            this.txtOpisDokumenta.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtOpisDokumenta.Multiline = true;
            this.txtOpisDokumenta.Name = "txtOpisDokumenta";
            this.txtOpisDokumenta.Size = new System.Drawing.Size(424, 88);
            this.txtOpisDokumenta.TabIndex = 10;
            // 
            // lblOpisDokumenta
            // 
            this.lblOpisDokumenta.AutoSize = true;
            this.lblOpisDokumenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOpisDokumenta.Location = new System.Drawing.Point(17, 434);
            this.lblOpisDokumenta.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblOpisDokumenta.Name = "lblOpisDokumenta";
            this.lblOpisDokumenta.Size = new System.Drawing.Size(103, 16);
            this.lblOpisDokumenta.TabIndex = 11;
            this.lblOpisDokumenta.Text = "Opis dokumenta";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(20, 20);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(424, 22);
            this.dtpDatum.TabIndex = 0;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDatum.Location = new System.Drawing.Point(17, 47);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(116, 16);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum zavođenja *";
            // 
            // cmbMesto
            // 
            this.cmbMesto.BackColor = System.Drawing.Color.White;
            this.cmbMesto.FormattingEnabled = true;
            this.cmbMesto.Location = new System.Drawing.Point(20, 146);
            this.cmbMesto.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbMesto.Name = "cmbMesto";
            this.cmbMesto.Size = new System.Drawing.Size(424, 24);
            this.cmbMesto.TabIndex = 4;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBroj.Location = new System.Drawing.Point(17, 110);
            this.lblBroj.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(148, 16);
            this.lblBroj.TabIndex = 3;
            this.lblBroj.Text = "Broj dnevnog zavođenja*";
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
            this.txtBroj.Size = new System.Drawing.Size(424, 22);
            this.txtBroj.TabIndex = 2;
            this.txtBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBroj_KeyPress);
            this.txtBroj.Leave += new System.EventHandler(this.txtBroj_Leave);
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMesto.Location = new System.Drawing.Point(17, 175);
            this.lblMesto.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(110, 16);
            this.lblMesto.TabIndex = 5;
            this.lblMesto.Text = "Mesto zavođenja*";
            // 
            // imgDodaj
            // 
            this.imgDodaj.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDodaj.ImageStream")));
            this.imgDodaj.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDodaj.Images.SetKeyName(0, "AddUser_16x.png");
            // 
            // btnZavedi
            // 
            this.btnZavedi.AutoSize = true;
            this.btnZavedi.BackColor = System.Drawing.Color.Gray;
            this.btnZavedi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnZavedi.FlatAppearance.BorderSize = 0;
            this.btnZavedi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnZavedi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnZavedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZavedi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnZavedi.Location = new System.Drawing.Point(369, 553);
            this.btnZavedi.Margin = new System.Windows.Forms.Padding(0, 20, 11, 11);
            this.btnZavedi.Name = "btnZavedi";
            this.btnZavedi.Size = new System.Drawing.Size(75, 28);
            this.btnZavedi.TabIndex = 1;
            this.btnZavedi.Text = "Zavedi";
            this.tipDodaj.SetToolTip(this.btnZavedi, "Zavedite novi dokument.");
            this.btnZavedi.UseVisualStyleBackColor = false;
            this.btnZavedi.Click += new System.EventHandler(this.btnZavedi_Click);
            // 
            // tipDodaj
            // 
            this.tipDodaj.ToolTipTitle = "Administracija - Delovodnik";
            // 
            // frmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.btnZavedi);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administracija - Delovodnik - Novo";
            this.Load += new System.EventHandler(this.frmDodaj_Load);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.Label lblOpisDokumenta;
        internal System.Windows.Forms.DateTimePicker dtpDatum;
        internal System.Windows.Forms.Label lblDatum;
        internal System.Windows.Forms.ComboBox cmbMesto;
        internal System.Windows.Forms.Label lblBroj;
        internal System.Windows.Forms.TextBox txtBroj;
        internal System.Windows.Forms.Label lblMesto;
        internal System.Windows.Forms.Button btnZavedi;
        internal System.Windows.Forms.TextBox txtOpisDokumenta;
        internal System.Windows.Forms.ImageList imgDodaj;
        internal System.Windows.Forms.ComboBox cmbVrstaDokumenta;
        internal System.Windows.Forms.Label lblVrstaDokumenta;
        internal System.Windows.Forms.ComboBox cmbIzlazUlaz;
        internal System.Windows.Forms.Label lblIzlazUlaz;
        private System.Windows.Forms.ToolTip tipDodaj;
    }
}