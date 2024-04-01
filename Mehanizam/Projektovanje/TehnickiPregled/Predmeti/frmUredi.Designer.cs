namespace Mehanizam.Projektovanje.TehnickiPregled.Predmeti
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
            this.trePredmet = new System.Windows.Forms.TreeView();
            this.imgPredmet = new System.Windows.Forms.ImageList(this.components);
            this.panSadrzaj = new System.Windows.Forms.Panel();
            this.panFooter = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.tipUredi = new System.Windows.Forms.ToolTip(this.components);
            this.imgDirektorijumDatoteke = new System.Windows.Forms.ImageList(this.components);
            this.panSadrzaj.SuspendLayout();
            this.panFooter.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // trePredmet
            // 
            this.trePredmet.BackColor = System.Drawing.Color.White;
            this.trePredmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trePredmet.Cursor = System.Windows.Forms.Cursors.Default;
            this.trePredmet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trePredmet.HideSelection = false;
            this.trePredmet.ImageIndex = 0;
            this.trePredmet.ImageList = this.imgDirektorijumDatoteke;
            this.trePredmet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trePredmet.Location = new System.Drawing.Point(20, 50);
            this.trePredmet.Margin = new System.Windows.Forms.Padding(20);
            this.trePredmet.Name = "trePredmet";
            this.trePredmet.SelectedImageIndex = 0;
            this.trePredmet.Size = new System.Drawing.Size(424, 501);
            this.trePredmet.TabIndex = 90;
            this.trePredmet.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trePredmet_NodeMouseDoubleClick);
            // 
            // imgPredmet
            // 
            this.imgPredmet.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPredmet.ImageStream")));
            this.imgPredmet.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPredmet.Images.SetKeyName(0, "OtvoriFasciklu_16x.png");
            this.imgPredmet.Images.SetKeyName(1, "Refresh_grey_16x.png");
            this.imgPredmet.Images.SetKeyName(2, "Folder_grey_16x.png");
            // 
            // panSadrzaj
            // 
            this.panSadrzaj.BackColor = System.Drawing.Color.White;
            this.panSadrzaj.Controls.Add(this.panFooter);
            this.panSadrzaj.Controls.Add(this.panHeader);
            this.panSadrzaj.Controls.Add(this.trePredmet);
            this.panSadrzaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSadrzaj.Location = new System.Drawing.Point(0, 0);
            this.panSadrzaj.Margin = new System.Windows.Forms.Padding(0);
            this.panSadrzaj.Name = "panSadrzaj";
            this.panSadrzaj.Size = new System.Drawing.Size(464, 601);
            this.panSadrzaj.TabIndex = 94;
            // 
            // panFooter
            // 
            this.panFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panFooter.Controls.Add(this.lblNaslov);
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFooter.Location = new System.Drawing.Point(0, 571);
            this.panFooter.Margin = new System.Windows.Forms.Padding(0);
            this.panFooter.Name = "panFooter";
            this.panFooter.Size = new System.Drawing.Size(464, 30);
            this.panFooter.TabIndex = 93;
            // 
            // lblNaslov
            // 
            this.lblNaslov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNaslov.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.Color.Gray;
            this.lblNaslov.Location = new System.Drawing.Point(0, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(464, 30);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Predmet \'...\'";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panHeader.Controls.Add(this.btnOsvezi);
            this.panHeader.Controls.Add(this.btnOtvori);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(464, 30);
            this.panHeader.TabIndex = 92;
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOsvezi.AutoSize = true;
            this.btnOsvezi.FlatAppearance.BorderSize = 0;
            this.btnOsvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvezi.ImageIndex = 1;
            this.btnOsvezi.ImageList = this.imgPredmet;
            this.btnOsvezi.Location = new System.Drawing.Point(407, 2);
            this.btnOsvezi.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(26, 26);
            this.btnOsvezi.TabIndex = 37;
            this.btnOsvezi.TabStop = false;
            this.tipUredi.SetToolTip(this.btnOsvezi, "Osvežite konekciju direktorijuma\r\ntehničkog pregleda.");
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnOtvori
            // 
            this.btnOtvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtvori.AutoSize = true;
            this.btnOtvori.FlatAppearance.BorderSize = 0;
            this.btnOtvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtvori.ImageIndex = 2;
            this.btnOtvori.ImageList = this.imgPredmet;
            this.btnOtvori.Location = new System.Drawing.Point(435, 2);
            this.btnOtvori.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(26, 26);
            this.btnOtvori.TabIndex = 36;
            this.btnOtvori.TabStop = false;
            this.tipUredi.SetToolTip(this.btnOtvori, "Otvorite direktorijum tehničkog pregleda.");
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // tipUredi
            // 
            this.tipUredi.ToolTipTitle = "Projektovanje - Tehnički pregledi";
            // 
            // imgDirektorijumDatoteke
            // 
            this.imgDirektorijumDatoteke.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDirektorijumDatoteke.ImageStream")));
            this.imgDirektorijumDatoteke.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDirektorijumDatoteke.Images.SetKeyName(0, "Folder_16x.png");
            this.imgDirektorijumDatoteke.Images.SetKeyName(1, "Excel-icon.png");
            this.imgDirektorijumDatoteke.Images.SetKeyName(2, "Image_16x.png");
            this.imgDirektorijumDatoteke.Images.SetKeyName(3, "Files-Pdf-icon.png");
            this.imgDirektorijumDatoteke.Images.SetKeyName(4, "Autodesk AutoCAD.png");
            this.imgDirektorijumDatoteke.Images.SetKeyName(5, "Word-icon.png");
            this.imgDirektorijumDatoteke.Images.SetKeyName(6, "Unknown_LightBorder_16x.png");
            // 
            // frmUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.panSadrzaj);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmUredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projektovanje - Tehnički pregled - Obrada";
            this.Load += new System.EventHandler(this.frmPredmet_Load);
            this.panSadrzaj.ResumeLayout(false);
            this.panFooter.ResumeLayout(false);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView trePredmet;
        internal System.Windows.Forms.ImageList imgPredmet;
        private System.Windows.Forms.Panel panSadrzaj;
        internal System.Windows.Forms.Panel panHeader;
        internal System.Windows.Forms.Button btnOtvori;
        internal System.Windows.Forms.Button btnOsvezi;
        internal System.Windows.Forms.Panel panFooter;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.ToolTip tipUredi;
        internal System.Windows.Forms.ImageList imgDirektorijumDatoteke;
    }
}