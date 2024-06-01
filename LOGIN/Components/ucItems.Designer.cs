namespace LOGIN.Components
{
    partial class ucItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucItems));
            this.panelCtrl = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblDisc = new System.Windows.Forms.Label();
            this.lblPcs = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBoxDisc = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCtrl
            // 
            this.panelCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCtrl.BackColor = System.Drawing.Color.Transparent;
            this.panelCtrl.Controls.Add(this.btnAdd);
            this.panelCtrl.Controls.Add(this.lblDisc);
            this.panelCtrl.Controls.Add(this.picBoxDisc);
            this.panelCtrl.Controls.Add(this.lblPcs);
            this.panelCtrl.Controls.Add(this.guna2PictureBox1);
            this.panelCtrl.Controls.Add(this.lblPrice);
            this.panelCtrl.Controls.Add(this.lblTitle);
            this.panelCtrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.panelCtrl.Location = new System.Drawing.Point(15, 14);
            this.panelCtrl.Name = "panelCtrl";
            this.panelCtrl.ShadowColor = System.Drawing.Color.Black;
            this.panelCtrl.ShadowShift = 3;
            this.panelCtrl.Size = new System.Drawing.Size(172, 293);
            this.panelCtrl.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(11, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 35);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.BackColor = System.Drawing.Color.Transparent;
            this.lblDisc.Font = new System.Drawing.Font("Euclid Circular B Light", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.ForeColor = System.Drawing.Color.White;
            this.lblDisc.Location = new System.Drawing.Point(50, 192);
            this.lblDisc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(51, 15);
            this.lblDisc.TabIndex = 35;
            this.lblDisc.Text = "Rp2200";
            // 
            // lblPcs
            // 
            this.lblPcs.AutoSize = true;
            this.lblPcs.BackColor = System.Drawing.Color.Transparent;
            this.lblPcs.Font = new System.Drawing.Font("Euclid Circular B Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcs.ForeColor = System.Drawing.Color.White;
            this.lblPcs.Location = new System.Drawing.Point(9, 141);
            this.lblPcs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPcs.Name = "lblPcs";
            this.lblPcs.Size = new System.Drawing.Size(66, 14);
            this.lblPcs.TabIndex = 33;
            this.lblPcs.Text = "Per 1 sachet";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(8, 159);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 24);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "Rp2000";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(9, 122);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 16);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Ambroxol - Obat Batuk";
            // 
            // picBoxDisc
            // 
            this.picBoxDisc.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDisc.Image")));
            this.picBoxDisc.ImageRotate = 0F;
            this.picBoxDisc.Location = new System.Drawing.Point(12, 190);
            this.picBoxDisc.Name = "picBoxDisc";
            this.picBoxDisc.Size = new System.Drawing.Size(35, 19);
            this.picBoxDisc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDisc.TabIndex = 34;
            this.picBoxDisc.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(167, 104);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 32;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ucItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panelCtrl);
            this.Name = "ucItems";
            this.Size = new System.Drawing.Size(203, 327);
            this.Load += new System.EventHandler(this.ucItems_Load);
            this.panelCtrl.ResumeLayout(false);
            this.panelCtrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panelCtrl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDisc;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxDisc;
        private System.Windows.Forms.Label lblPcs;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}
