namespace Mehanizam.Projektovanje.EEE.Predmeti
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
            this.lblVrstaObjekta = new System.Windows.Forms.Label();
            this.txtInvestitor = new System.Windows.Forms.TextBox();
            this.lblInvestitor = new System.Windows.Forms.Label();
            this.cmbVrstaObjekta = new System.Windows.Forms.ComboBox();
            this.pan1 = new System.Windows.Forms.Panel();
            this.lblBrojObjekta = new System.Windows.Forms.Label();
            this.txtBrojObjekta = new System.Windows.Forms.TextBox();
            this.cmbKatastarskaOpstina = new System.Windows.Forms.ComboBox();
            this.lblKatastarskaOpstina = new System.Windows.Forms.Label();
            this.lblBrojKatastarskeParcele = new System.Windows.Forms.Label();
            this.txtBrojKatastarskeParcele = new System.Windows.Forms.TextBox();
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
            this.tipDodaj.SetToolTip(this.btnDodaj, "Dodajte novi elaborat energetse efikasnosti.");
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // imgDodaj
            // 
            this.imgDodaj.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDodaj.ImageStream")));
            this.imgDodaj.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDodaj.Images.SetKeyName(0, "AddUser_16x.png");
            // 
            // lblVrstaObjekta
            // 
            this.lblVrstaObjekta.AutoSize = true;
            this.lblVrstaObjekta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVrstaObjekta.Location = new System.Drawing.Point(17, 240);
            this.lblVrstaObjekta.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblVrstaObjekta.Name = "lblVrstaObjekta";
            this.lblVrstaObjekta.Size = new System.Drawing.Size(90, 16);
            this.lblVrstaObjekta.TabIndex = 7;
            this.lblVrstaObjekta.Text = "Vrsta objekta*";
            // 
            // txtInvestitor
            // 
            this.txtInvestitor.BackColor = System.Drawing.Color.White;
            this.txtInvestitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvestitor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInvestitor.ForeColor = System.Drawing.Color.Black;
            this.txtInvestitor.Location = new System.Drawing.Point(20, 20);
            this.txtInvestitor.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtInvestitor.Name = "txtInvestitor";
            this.txtInvestitor.Size = new System.Drawing.Size(424, 22);
            this.txtInvestitor.TabIndex = 0;
            // 
            // lblInvestitor
            // 
            this.lblInvestitor.AutoSize = true;
            this.lblInvestitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvestitor.Location = new System.Drawing.Point(17, 47);
            this.lblInvestitor.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblInvestitor.Name = "lblInvestitor";
            this.lblInvestitor.Size = new System.Drawing.Size(64, 16);
            this.lblInvestitor.TabIndex = 1;
            this.lblInvestitor.Text = "Investitor*";
            // 
            // cmbVrstaObjekta
            // 
            this.cmbVrstaObjekta.AutoCompleteCustomSource.AddRange(new string[] {
            "stambeni objekat",
            "poslovni objekat",
            "pomoćni objekat"});
            this.cmbVrstaObjekta.BackColor = System.Drawing.Color.White;
            this.cmbVrstaObjekta.FormattingEnabled = true;
            this.cmbVrstaObjekta.Items.AddRange(new object[] {
            "stambeni objekat",
            "stambeno - poslovni objekat",
            "poslovni objekat",
            "pomoćni objekat"});
            this.cmbVrstaObjekta.Location = new System.Drawing.Point(20, 211);
            this.cmbVrstaObjekta.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbVrstaObjekta.Name = "cmbVrstaObjekta";
            this.cmbVrstaObjekta.Size = new System.Drawing.Size(424, 24);
            this.cmbVrstaObjekta.TabIndex = 6;
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.Controls.Add(this.lblBrojObjekta);
            this.pan1.Controls.Add(this.txtBrojObjekta);
            this.pan1.Controls.Add(this.cmbKatastarskaOpstina);
            this.pan1.Controls.Add(this.lblKatastarskaOpstina);
            this.pan1.Controls.Add(this.lblBrojKatastarskeParcele);
            this.pan1.Controls.Add(this.txtBrojKatastarskeParcele);
            this.pan1.Controls.Add(this.cmbVrstaObjekta);
            this.pan1.Controls.Add(this.lblInvestitor);
            this.pan1.Controls.Add(this.txtInvestitor);
            this.pan1.Controls.Add(this.lblVrstaObjekta);
            this.pan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan1.Location = new System.Drawing.Point(0, 0);
            this.pan1.Margin = new System.Windows.Forms.Padding(0);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(464, 533);
            this.pan1.TabIndex = 0;
            // 
            // lblBrojObjekta
            // 
            this.lblBrojObjekta.AutoSize = true;
            this.lblBrojObjekta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBrojObjekta.Location = new System.Drawing.Point(17, 303);
            this.lblBrojObjekta.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBrojObjekta.Name = "lblBrojObjekta";
            this.lblBrojObjekta.Size = new System.Drawing.Size(82, 16);
            this.lblBrojObjekta.TabIndex = 9;
            this.lblBrojObjekta.Text = "Broj objekta*";
            // 
            // txtBrojObjekta
            // 
            this.txtBrojObjekta.BackColor = System.Drawing.Color.White;
            this.txtBrojObjekta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrojObjekta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBrojObjekta.ForeColor = System.Drawing.Color.Black;
            this.txtBrojObjekta.Location = new System.Drawing.Point(20, 276);
            this.txtBrojObjekta.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtBrojObjekta.Name = "txtBrojObjekta";
            this.txtBrojObjekta.Size = new System.Drawing.Size(424, 22);
            this.txtBrojObjekta.TabIndex = 8;
            // 
            // cmbKatastarskaOpstina
            // 
            this.cmbKatastarskaOpstina.BackColor = System.Drawing.Color.White;
            this.cmbKatastarskaOpstina.FormattingEnabled = true;
            this.cmbKatastarskaOpstina.Location = new System.Drawing.Point(20, 83);
            this.cmbKatastarskaOpstina.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.cmbKatastarskaOpstina.Name = "cmbKatastarskaOpstina";
            this.cmbKatastarskaOpstina.Size = new System.Drawing.Size(424, 24);
            this.cmbKatastarskaOpstina.TabIndex = 2;
            // 
            // lblKatastarskaOpstina
            // 
            this.lblKatastarskaOpstina.AutoSize = true;
            this.lblKatastarskaOpstina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblKatastarskaOpstina.Location = new System.Drawing.Point(17, 112);
            this.lblKatastarskaOpstina.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblKatastarskaOpstina.Name = "lblKatastarskaOpstina";
            this.lblKatastarskaOpstina.Size = new System.Drawing.Size(129, 16);
            this.lblKatastarskaOpstina.TabIndex = 3;
            this.lblKatastarskaOpstina.Text = "Katastarska opština*";
            // 
            // lblBrojKatastarskeParcele
            // 
            this.lblBrojKatastarskeParcele.AutoSize = true;
            this.lblBrojKatastarskeParcele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBrojKatastarskeParcele.Location = new System.Drawing.Point(17, 175);
            this.lblBrojKatastarskeParcele.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBrojKatastarskeParcele.Name = "lblBrojKatastarskeParcele";
            this.lblBrojKatastarskeParcele.Size = new System.Drawing.Size(154, 16);
            this.lblBrojKatastarskeParcele.TabIndex = 5;
            this.lblBrojKatastarskeParcele.Text = "Broj katastarske parcele*";
            // 
            // txtBrojKatastarskeParcele
            // 
            this.txtBrojKatastarskeParcele.BackColor = System.Drawing.Color.White;
            this.txtBrojKatastarskeParcele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrojKatastarskeParcele.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBrojKatastarskeParcele.ForeColor = System.Drawing.Color.Black;
            this.txtBrojKatastarskeParcele.Location = new System.Drawing.Point(20, 148);
            this.txtBrojKatastarskeParcele.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtBrojKatastarskeParcele.Name = "txtBrojKatastarskeParcele";
            this.txtBrojKatastarskeParcele.Size = new System.Drawing.Size(424, 22);
            this.txtBrojKatastarskeParcele.TabIndex = 4;
            // 
            // tipDodaj
            // 
            this.tipDodaj.ToolTipTitle = "Projektovanje - Elaborati energetske efikasnosti";
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
            this.Text = "Projektovanje - Elaborat energetske efikasnosti - Novi";
            this.Load += new System.EventHandler(this.frmDodaj_Load);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnDodaj;
        internal System.Windows.Forms.ImageList imgDodaj;
        internal System.Windows.Forms.Label lblVrstaObjekta;
        internal System.Windows.Forms.TextBox txtInvestitor;
        internal System.Windows.Forms.Label lblInvestitor;
        internal System.Windows.Forms.ComboBox cmbVrstaObjekta;
        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.Label lblBrojObjekta;
        internal System.Windows.Forms.TextBox txtBrojObjekta;
        internal System.Windows.Forms.ComboBox cmbKatastarskaOpstina;
        internal System.Windows.Forms.Label lblKatastarskaOpstina;
        internal System.Windows.Forms.Label lblBrojKatastarskeParcele;
        internal System.Windows.Forms.TextBox txtBrojKatastarskeParcele;
        private System.Windows.Forms.ToolTip tipDodaj;
    }
}