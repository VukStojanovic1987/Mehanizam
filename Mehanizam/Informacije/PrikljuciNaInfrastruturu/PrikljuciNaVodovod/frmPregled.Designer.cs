namespace Mehanizam.Informacije.PrikljuciNaInfrastrukturu.PrikljuciNaVodovod
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lin1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pan1 = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.imgPregled = new System.Windows.Forms.ImageList(this.components);
            this.pan2 = new System.Windows.Forms.Panel();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnAccess = new System.Windows.Forms.Button();
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
            this.lblNaslov.Size = new System.Drawing.Size(249, 16);
            this.lblNaslov.TabIndex = 29;
            this.lblNaslov.Text = "Infromacije - Priključi na vodovodnu mrežu";
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
            this.imgPregled.Images.SetKeyName(1, "Refresh_grey_16x.png");
            this.imgPregled.Images.SetKeyName(2, "Database_16x.png");
            // 
            // pan2
            // 
            this.pan2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan2.Controls.Add(this.btnOsvezi);
            this.pan2.Controls.Add(this.btnAccess);
            this.pan2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan2.Location = new System.Drawing.Point(0, 30);
            this.pan2.Margin = new System.Windows.Forms.Padding(0);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(944, 30);
            this.pan2.TabIndex = 82;
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOsvezi.AutoSize = true;
            this.btnOsvezi.FlatAppearance.BorderSize = 0;
            this.btnOsvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvezi.ImageIndex = 1;
            this.btnOsvezi.ImageList = this.imgPregled;
            this.btnOsvezi.Location = new System.Drawing.Point(888, 2);
            this.btnOsvezi.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(26, 26);
            this.btnOsvezi.TabIndex = 34;
            this.btnOsvezi.TabStop = false;
            this.tipPregled.SetToolTip(this.btnOsvezi, "Osvežite konekciju sa bazom.");
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccess.AutoSize = true;
            this.btnAccess.FlatAppearance.BorderSize = 0;
            this.btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess.ImageIndex = 2;
            this.btnAccess.ImageList = this.imgPregled;
            this.btnAccess.Location = new System.Drawing.Point(916, 2);
            this.btnAccess.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(26, 26);
            this.btnAccess.TabIndex = 33;
            this.btnAccess.TabStop = false;
            this.tipPregled.SetToolTip(this.btnAccess, "Otvorite bazu podataka (.accdb).");
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPregled.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPregled.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvPregled.RowsDefaultCellStyle = dataGridViewCellStyle15;
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
            "ID",
            "Rečenica"});
            this.cmbKolona.Location = new System.Drawing.Point(72, 80);
            this.cmbKolona.Margin = new System.Windows.Forms.Padding(3, 20, 0, 0);
            this.cmbKolona.Name = "cmbKolona";
            this.cmbKolona.Size = new System.Drawing.Size(78, 24);
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
            this.lblPretraga.Location = new System.Drawing.Point(153, 83);
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
            this.txtPretraga.Location = new System.Drawing.Point(220, 85);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(3, 20, 11, 0);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(704, 15);
            this.txtPretraga.TabIndex = 86;
            this.txtPretraga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretraga_KeyUp);
            // 
            // tipPregled
            // 
            this.tipPregled.ToolTipTitle = "Infromacije - Priključi na vodovodnu mrežu";
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
            this.Text = "Infromacije - Priključi na vodovodnu mrežu";
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
        internal System.Windows.Forms.Button btnAccess;
        internal System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.ToolTip tipPregled;
        private System.Windows.Forms.ToolTip tipUniverzalni;
    }
}