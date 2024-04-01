namespace Mehanizam.Projektovanje.TehnickiPregled.Predmeti
{
    partial class frmPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregled));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lin1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pan1 = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.imgPregled = new System.Windows.Forms.ImageList(this.components);
            this.pan2 = new System.Windows.Forms.Panel();
            this.btnDirektorijum = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.dgvPregled = new System.Windows.Forms.DataGridView();
            this.cmbKolona = new System.Windows.Forms.ComboBox();
            this.lblKolona = new System.Windows.Forms.Label();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.tipPregled = new System.Windows.Forms.ToolTip(this.components);
            this.tipUniverzalni = new System.Windows.Forms.ToolTip(this.components);
            this.pan1.SuspendLayout();
            this.pan2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lin1});
            this.shapeContainer1.Size = new System.Drawing.Size(944, 681);
            this.shapeContainer1.TabIndex = 87;
            this.shapeContainer1.TabStop = false;
            // 
            // lin1
            // 
            this.lin1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lin1.BorderColor = System.Drawing.Color.Silver;
            this.lin1.Enabled = false;
            this.lin1.Name = "lin1";
            this.lin1.SelectionColor = System.Drawing.Color.Silver;
            this.lin1.X1 = 20;
            this.lin1.X2 = 922;
            this.lin1.Y1 = 105;
            this.lin1.Y2 = 105;
            // 
            // pan1
            // 
            this.pan1.BackColor = System.Drawing.Color.Gray;
            this.pan1.Controls.Add(this.lblNaslov);
            this.pan1.Controls.Add(this.btnZatvori);
            this.pan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan1.Location = new System.Drawing.Point(0, 0);
            this.pan1.Margin = new System.Windows.Forms.Padding(0);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(944, 30);
            this.pan1.TabIndex = 80;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.ForeColor = System.Drawing.Color.Silver;
            this.lblNaslov.Location = new System.Drawing.Point(7, 7);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(193, 16);
            this.lblNaslov.TabIndex = 29;
            this.lblNaslov.Text = "Projektovanje - Tehnički pregledi";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.AutoSize = true;
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.ImageKey = "Close_16x.png";
            this.btnZatvori.ImageList = this.imgPregled;
            this.btnZatvori.Location = new System.Drawing.Point(916, 2);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(26, 26);
            this.btnZatvori.TabIndex = 32;
            this.btnZatvori.TabStop = false;
            this.tipUniverzalni.SetToolTip(this.btnZatvori, "Zatvorite");
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // imgPregled
            // 
            this.imgPregled.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPregled.ImageStream")));
            this.imgPregled.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPregled.Images.SetKeyName(0, "Close_16x.png");
            this.imgPregled.Images.SetKeyName(1, "AccessApplication_16x.png");
            this.imgPregled.Images.SetKeyName(2, "Refresh_grey_16x.png");
            this.imgPregled.Images.SetKeyName(3, "FolderOpen_16x.png");
            this.imgPregled.Images.SetKeyName(4, "RefreshServer_16x.png");
            this.imgPregled.Images.SetKeyName(5, "DodajRed_16x.png");
            this.imgPregled.Images.SetKeyName(6, "Edit_grey_16x.png");
            this.imgPregled.Images.SetKeyName(7, "ObrisiRed_16x.png");
            this.imgPregled.Images.SetKeyName(8, "Open_grey_16x.png");
            this.imgPregled.Images.SetKeyName(9, "OtvoriFasciklu_16x.png");
            this.imgPregled.Images.SetKeyName(10, "Folder_grey_16x.png");
            // 
            // pan2
            // 
            this.pan2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan2.Controls.Add(this.btnDirektorijum);
            this.pan2.Controls.Add(this.btnObrisi);
            this.pan2.Controls.Add(this.btnUredi);
            this.pan2.Controls.Add(this.btnDodaj);
            this.pan2.Controls.Add(this.btnOsvezi);
            this.pan2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan2.Location = new System.Drawing.Point(0, 30);
            this.pan2.Margin = new System.Windows.Forms.Padding(0);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(944, 30);
            this.pan2.TabIndex = 82;
            // 
            // btnDirektorijum
            // 
            this.btnDirektorijum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirektorijum.AutoSize = true;
            this.btnDirektorijum.FlatAppearance.BorderSize = 0;
            this.btnDirektorijum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirektorijum.ImageIndex = 10;
            this.btnDirektorijum.ImageList = this.imgPregled;
            this.btnDirektorijum.Location = new System.Drawing.Point(916, 2);
            this.btnDirektorijum.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnDirektorijum.Name = "btnDirektorijum";
            this.btnDirektorijum.Size = new System.Drawing.Size(26, 26);
            this.btnDirektorijum.TabIndex = 38;
            this.btnDirektorijum.TabStop = false;
            this.tipPregled.SetToolTip(this.btnDirektorijum, "Otvorite direktorijum tehničkih\r\npregleda.");
            this.btnDirektorijum.UseVisualStyleBackColor = true;
            this.btnDirektorijum.Click += new System.EventHandler(this.btnDirektorijum_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.AutoSize = true;
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.ImageIndex = 7;
            this.btnObrisi.ImageList = this.imgPregled;
            this.btnObrisi.Location = new System.Drawing.Point(58, 2);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(26, 26);
            this.btnObrisi.TabIndex = 37;
            this.btnObrisi.TabStop = false;
            this.tipPregled.SetToolTip(this.btnObrisi, "Obrišite odabrani tehnički pregled.");
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.AutoSize = true;
            this.btnUredi.FlatAppearance.BorderSize = 0;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.ImageIndex = 6;
            this.btnUredi.ImageList = this.imgPregled;
            this.btnUredi.Location = new System.Drawing.Point(30, 2);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(26, 26);
            this.btnUredi.TabIndex = 36;
            this.btnUredi.TabStop = false;
            this.tipPregled.SetToolTip(this.btnUredi, "Uredite odabrani tehnički pregled.");
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.AutoSize = true;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ImageIndex = 5;
            this.btnDodaj.ImageList = this.imgPregled;
            this.btnDodaj.Location = new System.Drawing.Point(2, 2);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(26, 26);
            this.btnDodaj.TabIndex = 35;
            this.btnDodaj.TabStop = false;
            this.tipPregled.SetToolTip(this.btnDodaj, "Dodajte novi tehnički pregled.");
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOsvezi.AutoSize = true;
            this.btnOsvezi.FlatAppearance.BorderSize = 0;
            this.btnOsvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvezi.ImageIndex = 2;
            this.btnOsvezi.ImageList = this.imgPregled;
            this.btnOsvezi.Location = new System.Drawing.Point(888, 2);
            this.btnOsvezi.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(26, 26);
            this.btnOsvezi.TabIndex = 34;
            this.btnOsvezi.TabStop = false;
            this.tipPregled.SetToolTip(this.btnOsvezi, "Osvežite konekciju direktorijuma\r\ntehničkih pregleda.");
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // dgvPregled
            // 
            this.dgvPregled.AllowUserToAddRows = false;
            this.dgvPregled.AllowUserToDeleteRows = false;
            this.dgvPregled.AllowUserToResizeColumns = false;
            this.dgvPregled.AllowUserToResizeRows = false;
            this.dgvPregled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPregled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPregled.BackgroundColor = System.Drawing.Color.White;
            this.dgvPregled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPregled.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPregled.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPregled.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPregled.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPregled.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPregled.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPregled.EnableHeadersVisualStyles = false;
            this.dgvPregled.GridColor = System.Drawing.Color.Silver;
            this.dgvPregled.Location = new System.Drawing.Point(20, 124);
            this.dgvPregled.Margin = new System.Windows.Forms.Padding(11, 20, 11, 11);
            this.dgvPregled.MultiSelect = false;
            this.dgvPregled.Name = "dgvPregled";
            this.dgvPregled.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPregled.RowHeadersVisible = false;
            this.dgvPregled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvPregled.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPregled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregled.Size = new System.Drawing.Size(904, 537);
            this.dgvPregled.TabIndex = 79;
            // 
            // cmbKolona
            // 
            this.cmbKolona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKolona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKolona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbKolona.FormattingEnabled = true;
            this.cmbKolona.Items.AddRange(new object[] {
            "Predmet"});
            this.cmbKolona.Location = new System.Drawing.Point(72, 80);
            this.cmbKolona.Margin = new System.Windows.Forms.Padding(3, 20, 0, 0);
            this.cmbKolona.Name = "cmbKolona";
            this.cmbKolona.Size = new System.Drawing.Size(80, 24);
            this.cmbKolona.TabIndex = 83;
            this.cmbKolona.SelectedIndexChanged += new System.EventHandler(this.cmbKolona_SelectedIndexChanged);
            // 
            // lblKolona
            // 
            this.lblKolona.AutoSize = true;
            this.lblKolona.ForeColor = System.Drawing.Color.Gray;
            this.lblKolona.Location = new System.Drawing.Point(17, 83);
            this.lblKolona.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.lblKolona.Name = "lblKolona";
            this.lblKolona.Size = new System.Drawing.Size(52, 16);
            this.lblKolona.TabIndex = 84;
            this.lblKolona.Text = "Kolona:";
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.ForeColor = System.Drawing.Color.Gray;
            this.lblPretraga.Location = new System.Drawing.Point(155, 83);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(61, 16);
            this.lblPretraga.TabIndex = 85;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPretraga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretraga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPretraga.Location = new System.Drawing.Point(222, 85);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(3, 20, 11, 0);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(702, 15);
            this.txtPretraga.TabIndex = 86;
            this.txtPretraga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretraga_KeyUp);
            // 
            // tipPregled
            // 
            this.tipPregled.ToolTipTitle = "Projektovanje - Tehnički pregledi";
            // 
            // frmPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.lblKolona);
            this.Controls.Add(this.cmbKolona);
            this.Controls.Add(this.dgvPregled);
            this.Controls.Add(this.pan2);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projektovanje - Tehnički pregledi";
            this.Load += new System.EventHandler(this.frmPregled_Load);
            this.Shown += new System.EventHandler(this.frmPregled_Shown);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.pan2.ResumeLayout(false);
            this.pan2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lin1;
        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.Label lblNaslov;
        internal System.Windows.Forms.Panel pan2;
        internal System.Windows.Forms.DataGridView dgvPregled;
        internal System.Windows.Forms.ComboBox cmbKolona;
        internal System.Windows.Forms.Label lblKolona;
        internal System.Windows.Forms.Label lblPretraga;
        internal System.Windows.Forms.TextBox txtPretraga;
        internal System.Windows.Forms.ImageList imgPregled;
        internal System.Windows.Forms.Button btnZatvori;
        internal System.Windows.Forms.Button btnOsvezi;
        internal System.Windows.Forms.Button btnDirektorijum;
        internal System.Windows.Forms.Button btnObrisi;
        internal System.Windows.Forms.Button btnUredi;
        internal System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ToolTip tipPregled;
        private System.Windows.Forms.ToolTip tipUniverzalni;
    }
}