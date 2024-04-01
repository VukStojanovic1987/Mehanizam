namespace Mehanizam.Administracija.Delovodnik
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
            this.cmbIzlazniUlazni = new System.Windows.Forms.ComboBox();
            this.lblIzlazniUlazni = new System.Windows.Forms.Label();
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
            this.brnSnimi = new System.Windows.Forms.Button();
            this.tipUredi = new System.Windows.Forms.ToolTip(this.components);
            this.pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.Controls.Add(this.cmbIzlazniUlazni);
            this.pan1.Controls.Add(this.lblIzlazniUlazni);
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
            // cmbIzlazniUlazni
            // 
            this.cmbIzlazniUlazni.BackColor = System.Drawing.Color.White;
            this.cmbIzlazniUlazni.FormattingEnabled = true;
            this.cmbIzlazniUlazni.Items.AddRange(new object[] {
            "Izlazni",
            "Ulazni"});
            this.cmbIzlazniUlazni.Location = new System.Drawing.Point(20, 276);
            this.cmbIzlazniUlazni.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbIzlazniUlazni.Name = "cmbIzlazniUlazni";
            this.cmbIzlazniUlazni.Size = new System.Drawing.Size(424, 24);
            this.cmbIzlazniUlazni.TabIndex = 10;
            // 
            // lblIzlazniUlazni
            // 
            this.lblIzlazniUlazni.AutoSize = true;
            this.lblIzlazniUlazni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIzlazniUlazni.Location = new System.Drawing.Point(17, 305);
            this.lblIzlazniUlazni.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblIzlazniUlazni.Name = "lblIzlazniUlazni";
            this.lblIzlazniUlazni.Size = new System.Drawing.Size(151, 16);
            this.lblIzlazniUlazni.TabIndex = 11;
            this.lblIzlazniUlazni.Text = "Izlazni/Ulazni dokument*";
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
            this.txtOpisDokumenta.TabIndex = 8;
            // 
            // lblOpisDokumenta
            // 
            this.lblOpisDokumenta.AutoSize = true;
            this.lblOpisDokumenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOpisDokumenta.Location = new System.Drawing.Point(17, 434);
            this.lblOpisDokumenta.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblOpisDokumenta.Name = "lblOpisDokumenta";
            this.lblOpisDokumenta.Size = new System.Drawing.Size(103, 16);
            this.lblOpisDokumenta.TabIndex = 9;
            this.lblOpisDokumenta.Text = "Opis dokumenta";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Enabled = false;
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
            this.lblDatum.Enabled = false;
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
            this.lblBroj.Enabled = false;
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
            this.txtBroj.Enabled = false;
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
            // brnSnimi
            // 
            this.brnSnimi.AutoSize = true;
            this.brnSnimi.BackColor = System.Drawing.Color.Gray;
            this.brnSnimi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.brnSnimi.FlatAppearance.BorderSize = 0;
            this.brnSnimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brnSnimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.brnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnSnimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brnSnimi.Location = new System.Drawing.Point(369, 553);
            this.brnSnimi.Margin = new System.Windows.Forms.Padding(0, 20, 11, 11);
            this.brnSnimi.Name = "brnSnimi";
            this.brnSnimi.Size = new System.Drawing.Size(75, 28);
            this.brnSnimi.TabIndex = 1;
            this.brnSnimi.Text = "Snimi";
            this.tipUredi.SetToolTip(this.brnSnimi, "Ažurirajte promene na\r\ndokumentu.");
            this.brnSnimi.UseVisualStyleBackColor = false;
            this.brnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // tipUredi
            // 
            this.tipUredi.ToolTipTitle = "Administracija - Delovodnik";
            // 
            // frmUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.brnSnimi);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administracija - Delovodnik - Obrada";
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
        internal System.Windows.Forms.Button brnSnimi;
        internal System.Windows.Forms.TextBox txtOpisDokumenta;
        internal System.Windows.Forms.ImageList imgDodaj;
        internal System.Windows.Forms.ComboBox cmbVrstaDokumenta;
        internal System.Windows.Forms.Label lblVrstaDokumenta;
        internal System.Windows.Forms.ComboBox cmbIzlazniUlazni;
        internal System.Windows.Forms.Label lblIzlazniUlazni;
        private System.Windows.Forms.ToolTip tipUredi;
    }
}