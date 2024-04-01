namespace Mehanizam.Administracija.Arhiva
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
            this.pan1 = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.imgPregled = new System.Windows.Forms.ImageList(this.components);
            this.pan2 = new System.Windows.Forms.Panel();
            this.btnDirektorijum = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.tipPregled = new System.Windows.Forms.ToolTip(this.components);
            this.tipUniverzalni = new System.Windows.Forms.ToolTip(this.components);
            this.lisDatoteke = new System.Windows.Forms.ListView();
            this.imgDatoteke = new System.Windows.Forms.ImageList(this.components);
            this.treDirektorijumi = new System.Windows.Forms.TreeView();
            this.imgDirektorijumi = new System.Windows.Forms.ImageList(this.components);
            this.panDirektorijumi = new System.Windows.Forms.Panel();
            this.panDatoteke = new System.Windows.Forms.Panel();
            this.lblPutanjaOdabranogDirektorijum = new System.Windows.Forms.Label();
            this.pan1.SuspendLayout();
            this.pan2.SuspendLayout();
            this.panDirektorijumi.SuspendLayout();
            this.panDatoteke.SuspendLayout();
            this.SuspendLayout();
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
            this.lblNaslov.Size = new System.Drawing.Size(136, 16);
            this.lblNaslov.TabIndex = 29;
            this.lblNaslov.Text = "Administracija - Arhiva";
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
            this.tipPregled.SetToolTip(this.btnDirektorijum, "Otvorite direktorijum kataloga.");
            this.btnDirektorijum.UseVisualStyleBackColor = true;
            this.btnDirektorijum.Click += new System.EventHandler(this.btnDirektorijum_Click);
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
            this.tipPregled.SetToolTip(this.btnOsvezi, "Osvežite konekciju direktorijuma\r\nkataloga.");
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // tipPregled
            // 
            this.tipPregled.ToolTipTitle = "Projektovanje - Katalozi";
            // 
            // lisDatoteke
            // 
            this.lisDatoteke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lisDatoteke.BackColor = System.Drawing.Color.White;
            this.lisDatoteke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lisDatoteke.LargeImageList = this.imgDatoteke;
            this.lisDatoteke.Location = new System.Drawing.Point(20, 50);
            this.lisDatoteke.Margin = new System.Windows.Forms.Padding(20);
            this.lisDatoteke.MultiSelect = false;
            this.lisDatoteke.Name = "lisDatoteke";
            this.lisDatoteke.Size = new System.Drawing.Size(484, 511);
            this.lisDatoteke.TabIndex = 83;
            this.lisDatoteke.UseCompatibleStateImageBehavior = false;
            this.lisDatoteke.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lisDatoteke_MouseDoubleClick);
            // 
            // imgDatoteke
            // 
            this.imgDatoteke.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgDatoteke.ImageSize = new System.Drawing.Size(32, 32);
            this.imgDatoteke.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // treDirektorijumi
            // 
            this.treDirektorijumi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treDirektorijumi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treDirektorijumi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treDirektorijumi.Cursor = System.Windows.Forms.Cursors.Default;
            this.treDirektorijumi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treDirektorijumi.HideSelection = false;
            this.treDirektorijumi.ImageIndex = 0;
            this.treDirektorijumi.ImageList = this.imgDirektorijumi;
            this.treDirektorijumi.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treDirektorijumi.Location = new System.Drawing.Point(20, 20);
            this.treDirektorijumi.Margin = new System.Windows.Forms.Padding(20);
            this.treDirektorijumi.Name = "treDirektorijumi";
            this.treDirektorijumi.SelectedImageIndex = 0;
            this.treDirektorijumi.Size = new System.Drawing.Size(320, 541);
            this.treDirektorijumi.TabIndex = 91;
            this.treDirektorijumi.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treDirektorijumi_AfterSelect);
            // 
            // imgDirektorijumi
            // 
            this.imgDirektorijumi.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDirektorijumi.ImageStream")));
            this.imgDirektorijumi.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDirektorijumi.Images.SetKeyName(0, "Folder_16x.png");
            // 
            // panDirektorijumi
            // 
            this.panDirektorijumi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panDirektorijumi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panDirektorijumi.Controls.Add(this.treDirektorijumi);
            this.panDirektorijumi.Location = new System.Drawing.Point(20, 80);
            this.panDirektorijumi.Margin = new System.Windows.Forms.Padding(11, 20, 0, 11);
            this.panDirektorijumi.Name = "panDirektorijumi";
            this.panDirektorijumi.Size = new System.Drawing.Size(360, 581);
            this.panDirektorijumi.TabIndex = 92;
            // 
            // panDatoteke
            // 
            this.panDatoteke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDatoteke.Controls.Add(this.lblPutanjaOdabranogDirektorijum);
            this.panDatoteke.Controls.Add(this.lisDatoteke);
            this.panDatoteke.Location = new System.Drawing.Point(400, 80);
            this.panDatoteke.Margin = new System.Windows.Forms.Padding(20, 20, 11, 11);
            this.panDatoteke.Name = "panDatoteke";
            this.panDatoteke.Size = new System.Drawing.Size(524, 581);
            this.panDatoteke.TabIndex = 93;
            // 
            // lblPutanjaOdabranogDirektorijum
            // 
            this.lblPutanjaOdabranogDirektorijum.BackColor = System.Drawing.Color.White;
            this.lblPutanjaOdabranogDirektorijum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPutanjaOdabranogDirektorijum.ForeColor = System.Drawing.Color.Gray;
            this.lblPutanjaOdabranogDirektorijum.Location = new System.Drawing.Point(0, 0);
            this.lblPutanjaOdabranogDirektorijum.Margin = new System.Windows.Forms.Padding(0);
            this.lblPutanjaOdabranogDirektorijum.Name = "lblPutanjaOdabranogDirektorijum";
            this.lblPutanjaOdabranogDirektorijum.Size = new System.Drawing.Size(524, 30);
            this.lblPutanjaOdabranogDirektorijum.TabIndex = 84;
            this.lblPutanjaOdabranogDirektorijum.Text = "...";
            this.lblPutanjaOdabranogDirektorijum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panDatoteke);
            this.Controls.Add(this.panDirektorijumi);
            this.Controls.Add(this.pan2);
            this.Controls.Add(this.pan1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija - Arhiva";
            this.Load += new System.EventHandler(this.frmPregled_Load);
            this.Shown += new System.EventHandler(this.frmPregled_Shown);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.pan2.ResumeLayout(false);
            this.pan2.PerformLayout();
            this.panDirektorijumi.ResumeLayout(false);
            this.panDatoteke.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.Label lblNaslov;
        internal System.Windows.Forms.Panel pan2;
        internal System.Windows.Forms.ImageList imgPregled;
        internal System.Windows.Forms.Button btnZatvori;
        internal System.Windows.Forms.Button btnOsvezi;
        internal System.Windows.Forms.Button btnDirektorijum;
        private System.Windows.Forms.ToolTip tipUniverzalni;
        private System.Windows.Forms.ToolTip tipPregled;
        private System.Windows.Forms.ListView lisDatoteke;
        private System.Windows.Forms.TreeView treDirektorijumi;
        internal System.Windows.Forms.ImageList imgDirektorijumi;
        internal System.Windows.Forms.ImageList imgDatoteke;
        private System.Windows.Forms.Panel panDirektorijumi;
        private System.Windows.Forms.Panel panDatoteke;
        private System.Windows.Forms.Label lblPutanjaOdabranogDirektorijum;
    }
}