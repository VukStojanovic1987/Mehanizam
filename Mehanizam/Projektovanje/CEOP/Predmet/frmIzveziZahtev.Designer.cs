namespace Mehanizam.Projektovanje.CEOP.Predmet
{
    partial class frmIzveziZahtev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzveziZahtev));
            this.pan1 = new System.Windows.Forms.Panel();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnPutanja = new System.Windows.Forms.Button();
            this.imgNapraviArhivu = new System.Windows.Forms.ImageList(this.components);
            this.lblPutanja = new System.Windows.Forms.Label();
            this.txtPutanja = new System.Windows.Forms.TextBox();
            this.btnIzvezi = new System.Windows.Forms.Button();
            this.tipIzveziZahtev = new System.Windows.Forms.ToolTip(this.components);
            this.pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.Controls.Add(this.lblNaziv);
            this.pan1.Controls.Add(this.txtNaziv);
            this.pan1.Controls.Add(this.btnPutanja);
            this.pan1.Controls.Add(this.lblPutanja);
            this.pan1.Controls.Add(this.txtPutanja);
            this.pan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan1.Location = new System.Drawing.Point(0, 0);
            this.pan1.Margin = new System.Windows.Forms.Padding(0);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(904, 146);
            this.pan1.TabIndex = 1;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNaziv.Location = new System.Drawing.Point(17, 110);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(122, 16);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "Naziv direktorijuma*";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.White;
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNaziv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.ForeColor = System.Drawing.Color.Black;
            this.txtNaziv.Location = new System.Drawing.Point(20, 83);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(864, 22);
            this.txtNaziv.TabIndex = 5;
            // 
            // btnPutanja
            // 
            this.btnPutanja.AutoSize = true;
            this.btnPutanja.FlatAppearance.BorderSize = 0;
            this.btnPutanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPutanja.ImageIndex = 0;
            this.btnPutanja.ImageList = this.imgNapraviArhivu;
            this.btnPutanja.Location = new System.Drawing.Point(858, 17);
            this.btnPutanja.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.btnPutanja.Name = "btnPutanja";
            this.btnPutanja.Size = new System.Drawing.Size(26, 26);
            this.btnPutanja.TabIndex = 4;
            this.tipIzveziZahtev.SetToolTip(this.btnPutanja, "Otvorite listu direktorijuma kako biste \r\nodabrali putanju za izvoz zahteva.");
            this.btnPutanja.UseVisualStyleBackColor = true;
            this.btnPutanja.Click += new System.EventHandler(this.btnPutanja_Click);
            // 
            // imgNapraviArhivu
            // 
            this.imgNapraviArhivu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNapraviArhivu.ImageStream")));
            this.imgNapraviArhivu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNapraviArhivu.Images.SetKeyName(0, "OpenFolder_16x.png");
            // 
            // lblPutanja
            // 
            this.lblPutanja.AutoSize = true;
            this.lblPutanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPutanja.Location = new System.Drawing.Point(17, 47);
            this.lblPutanja.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPutanja.Name = "lblPutanja";
            this.lblPutanja.Size = new System.Drawing.Size(135, 16);
            this.lblPutanja.TabIndex = 3;
            this.lblPutanja.Text = "Putanja direktorijuma*";
            // 
            // txtPutanja
            // 
            this.txtPutanja.BackColor = System.Drawing.Color.White;
            this.txtPutanja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPutanja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPutanja.ForeColor = System.Drawing.Color.Black;
            this.txtPutanja.Location = new System.Drawing.Point(20, 20);
            this.txtPutanja.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtPutanja.Name = "txtPutanja";
            this.txtPutanja.Size = new System.Drawing.Size(835, 22);
            this.txtPutanja.TabIndex = 2;
            // 
            // btnIzvezi
            // 
            this.btnIzvezi.AutoSize = true;
            this.btnIzvezi.BackColor = System.Drawing.Color.Gray;
            this.btnIzvezi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnIzvezi.FlatAppearance.BorderSize = 0;
            this.btnIzvezi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIzvezi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnIzvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvezi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIzvezi.Location = new System.Drawing.Point(809, 166);
            this.btnIzvezi.Margin = new System.Windows.Forms.Padding(0, 20, 11, 11);
            this.btnIzvezi.Name = "btnIzvezi";
            this.btnIzvezi.Size = new System.Drawing.Size(75, 28);
            this.btnIzvezi.TabIndex = 2;
            this.btnIzvezi.Text = "Izvezi";
            this.tipIzveziZahtev.SetToolTip(this.btnIzvezi, "Izvezite zahtev na odabranu putanju\r\ni pod zadatim imenom.");
            this.btnIzvezi.UseVisualStyleBackColor = false;
            this.btnIzvezi.Click += new System.EventHandler(this.btnIzvezi_Click);
            // 
            // tipIzveziZahtev
            // 
            this.tipIzveziZahtev.ToolTipTitle = "Projektovanje - CEOP - Zhetv";
            // 
            // frmIzveziZahtev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(904, 214);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.btnIzvezi);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIzveziZahtev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projektovanje - CEOP - Zahtev - Obrada - Izvoz";
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.Label lblPutanja;
        internal System.Windows.Forms.TextBox txtPutanja;
        internal System.Windows.Forms.Button btnIzvezi;
        internal System.Windows.Forms.Button btnPutanja;
        internal System.Windows.Forms.ImageList imgNapraviArhivu;
        internal System.Windows.Forms.Label lblNaziv;
        internal System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ToolTip tipIzveziZahtev;
    }
}