namespace Mehanizam.Podesavanja
{
    partial class frmLozinka
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
            this.pan1 = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lin1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lin2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.tipLozinka = new System.Windows.Forms.ToolTip(this.components);
            this.pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.Controls.Add(this.lblNaslov);
            this.pan1.Controls.Add(this.lblLozinka);
            this.pan1.Controls.Add(this.txtLozinka);
            this.pan1.Controls.Add(this.ShapeContainer1);
            this.pan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan1.Location = new System.Drawing.Point(0, 0);
            this.pan1.Margin = new System.Windows.Forms.Padding(0);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(464, 533);
            this.pan1.TabIndex = 11;
            // 
            // lblNaslov
            // 
            this.lblNaslov.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Image = global::Mehanizam.Properties.Resources.logo_206x42;
            this.lblNaslov.Location = new System.Drawing.Point(20, 29);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(206, 42);
            this.lblNaslov.TabIndex = 12;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLozinka.Location = new System.Drawing.Point(17, 151);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(58, 16);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka*";
            // 
            // txtLozinka
            // 
            this.txtLozinka.BackColor = System.Drawing.Color.White;
            this.txtLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLozinka.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.ForeColor = System.Drawing.Color.Black;
            this.txtLozinka.Location = new System.Drawing.Point(20, 131);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(20, 60, 20, 0);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(424, 15);
            this.txtLozinka.TabIndex = 0;
            this.txtLozinka.TextChanged += new System.EventHandler(this.txtLozinka_TextChanged);
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lin1});
            this.ShapeContainer1.Size = new System.Drawing.Size(464, 533);
            this.ShapeContainer1.TabIndex = 3;
            this.ShapeContainer1.TabStop = false;
            // 
            // lin1
            // 
            this.lin1.BorderColor = System.Drawing.Color.Silver;
            this.lin1.Enabled = false;
            this.lin1.Name = "lin1";
            this.lin1.SelectionColor = System.Drawing.Color.Silver;
            this.lin1.X1 = 20;
            this.lin1.X2 = 444;
            this.lin1.Y1 = 149;
            this.lin1.Y2 = 149;
            // 
            // lin2
            // 
            this.lin2.BorderColor = System.Drawing.Color.Silver;
            this.lin2.Enabled = false;
            this.lin2.Name = "lin2";
            this.lin2.SelectionColor = System.Drawing.Color.Silver;
            this.lin2.X1 = 20;
            this.lin2.X2 = 444;
            this.lin2.Y1 = 536;
            this.lin2.Y2 = 536;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.AutoSize = true;
            this.btnPotvrdi.BackColor = System.Drawing.Color.White;
            this.btnPotvrdi.Enabled = false;
            this.btnPotvrdi.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPotvrdi.FlatAppearance.BorderSize = 0;
            this.btnPotvrdi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPotvrdi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPotvrdi.Location = new System.Drawing.Point(369, 553);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(0, 20, 11, 11);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 28);
            this.btnPotvrdi.TabIndex = 10;
            this.btnPotvrdi.Text = "Potvrdi";
            this.tipLozinka.SetToolTip(this.btnPotvrdi, "Proverite tačnost lozinke\r\ni nastavite dalje.");
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lin2});
            this.shapeContainer2.Size = new System.Drawing.Size(464, 601);
            this.shapeContainer2.TabIndex = 12;
            this.shapeContainer2.TabStop = false;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.AutoSize = true;
            this.btnOtkazi.BackColor = System.Drawing.Color.White;
            this.btnOtkazi.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOtkazi.FlatAppearance.BorderSize = 0;
            this.btnOtkazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOtkazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOtkazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOtkazi.Location = new System.Drawing.Point(20, 553);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(11, 20, 0, 11);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 28);
            this.btnOtkazi.TabIndex = 13;
            this.btnOtkazi.Text = "Otkaži";
            this.tipLozinka.SetToolTip(this.btnOtkazi, "Zatvorite formular i\r\notkažite radnju.");
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // tipLozinka
            // 
            this.tipLozinka.ToolTipTitle = "Mehanizam";
            // 
            // frmLozinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.ControlBox = false;
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.shapeContainer2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLozinka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mehanizam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLozinka_FormClosing);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pan1;
        internal System.Windows.Forms.Label lblLozinka;
        internal System.Windows.Forms.TextBox txtLozinka;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape lin1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape lin2;
        internal System.Windows.Forms.Button btnPotvrdi;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        internal System.Windows.Forms.Button btnOtkazi;
        internal System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.ToolTip tipLozinka;
    }
}