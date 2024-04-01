namespace Mehanizam.Odabir
{
    partial class frmProjektovanjePredmeti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjektovanjePredmeti));
            this.panKontekst = new System.Windows.Forms.Panel();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.lblKolona = new System.Windows.Forms.Label();
            this.cmbKolona = new System.Windows.Forms.ComboBox();
            this.dgvPregled = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lin1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.imgPregled = new System.Windows.Forms.ImageList(this.components);
            this.panKontekst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // panKontekst
            // 
            this.panKontekst.BackColor = System.Drawing.Color.White;
            this.panKontekst.Controls.Add(this.txtPretraga);
            this.panKontekst.Controls.Add(this.lblPretraga);
            this.panKontekst.Controls.Add(this.lblKolona);
            this.panKontekst.Controls.Add(this.cmbKolona);
            this.panKontekst.Controls.Add(this.dgvPregled);
            this.panKontekst.Controls.Add(this.shapeContainer1);
            this.panKontekst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panKontekst.Location = new System.Drawing.Point(0, 0);
            this.panKontekst.Margin = new System.Windows.Forms.Padding(0);
            this.panKontekst.Name = "panKontekst";
            this.panKontekst.Size = new System.Drawing.Size(944, 613);
            this.panKontekst.TabIndex = 3;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPretraga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretraga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPretraga.Location = new System.Drawing.Point(219, 31);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(3, 20, 11, 0);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(708, 15);
            this.txtPretraga.TabIndex = 102;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.ForeColor = System.Drawing.Color.Gray;
            this.lblPretraga.Location = new System.Drawing.Point(152, 29);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(61, 16);
            this.lblPretraga.TabIndex = 101;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // lblKolona
            // 
            this.lblKolona.AutoSize = true;
            this.lblKolona.ForeColor = System.Drawing.Color.Gray;
            this.lblKolona.Location = new System.Drawing.Point(20, 29);
            this.lblKolona.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.lblKolona.Name = "lblKolona";
            this.lblKolona.Size = new System.Drawing.Size(52, 16);
            this.lblKolona.TabIndex = 100;
            this.lblKolona.Text = "Kolona:";
            // 
            // cmbKolona
            // 
            this.cmbKolona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKolona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKolona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbKolona.FormattingEnabled = true;
            this.cmbKolona.Items.AddRange(new object[] {
            "ID",
            "Predmet"});
            this.cmbKolona.Location = new System.Drawing.Point(75, 26);
            this.cmbKolona.Margin = new System.Windows.Forms.Padding(3, 20, 0, 0);
            this.cmbKolona.Name = "cmbKolona";
            this.cmbKolona.Size = new System.Drawing.Size(74, 24);
            this.cmbKolona.TabIndex = 99;
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
            this.dgvPregled.Location = new System.Drawing.Point(20, 70);
            this.dgvPregled.Margin = new System.Windows.Forms.Padding(20);
            this.dgvPregled.MultiSelect = false;
            this.dgvPregled.Name = "dgvPregled";
            this.dgvPregled.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPregled.RowHeadersVisible = false;
            this.dgvPregled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvPregled.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPregled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregled.Size = new System.Drawing.Size(904, 523);
            this.dgvPregled.TabIndex = 95;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lin1});
            this.shapeContainer1.Size = new System.Drawing.Size(944, 613);
            this.shapeContainer1.TabIndex = 103;
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
            this.lin1.Y1 = 52;
            this.lin1.Y2 = 52;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.AutoSize = true;
            this.btnOdaberi.BackColor = System.Drawing.Color.Gray;
            this.btnOdaberi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnOdaberi.FlatAppearance.BorderSize = 0;
            this.btnOdaberi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOdaberi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOdaberi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaberi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOdaberi.Location = new System.Drawing.Point(849, 633);
            this.btnOdaberi.Margin = new System.Windows.Forms.Padding(0, 20, 11, 11);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 28);
            this.btnOdaberi.TabIndex = 4;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // imgPregled
            // 
            this.imgPregled.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPregled.ImageStream")));
            this.imgPregled.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPregled.Images.SetKeyName(0, "EmailAddressViewer_16x.png");
            // 
            // frmProjektovanjePredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panKontekst);
            this.Controls.Add(this.btnOdaberi);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProjektovanjePredmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.Load += new System.EventHandler(this.frmPregled_Load);
            this.Shown += new System.EventHandler(this.frmPregled_Shown);
            this.panKontekst.ResumeLayout(false);
            this.panKontekst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panKontekst;
        internal System.Windows.Forms.TextBox txtPretraga;
        internal System.Windows.Forms.Label lblPretraga;
        internal System.Windows.Forms.Label lblKolona;
        internal System.Windows.Forms.ComboBox cmbKolona;
        internal System.Windows.Forms.DataGridView dgvPregled;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lin1;
        internal System.Windows.Forms.Button btnOdaberi;
        internal System.Windows.Forms.ImageList imgPregled;
    }
}