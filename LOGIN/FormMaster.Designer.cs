namespace LOGIN
{
    partial class FormMaster
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
            this.ctrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlBoxMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnStockLog = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlBoxClose
            // 
            this.ctrlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlBoxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ctrlBoxClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ctrlBoxClose.HoverState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.ctrlBoxClose.IconColor = System.Drawing.Color.White;
            this.ctrlBoxClose.Location = new System.Drawing.Point(762, 5);
            this.ctrlBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlBoxClose.Name = "ctrlBoxClose";
            this.ctrlBoxClose.Size = new System.Drawing.Size(33, 26);
            this.ctrlBoxClose.TabIndex = 33;
            // 
            // ctrlBoxMin
            // 
            this.ctrlBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlBoxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ctrlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrlBoxMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ctrlBoxMin.HoverState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.ctrlBoxMin.IconColor = System.Drawing.Color.White;
            this.ctrlBoxMin.Location = new System.Drawing.Point(725, 5);
            this.ctrlBoxMin.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlBoxMin.Name = "ctrlBoxMin";
            this.ctrlBoxMin.Size = new System.Drawing.Size(33, 26);
            this.ctrlBoxMin.TabIndex = 32;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.guna2Panel1.Controls.Add(this.ctrlBoxClose);
            this.guna2Panel1.Controls.Add(this.ctrlBoxMin);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(804, 37);
            this.guna2Panel1.TabIndex = 28;
            // 
            // btnProduct
            // 
            this.btnProduct.BorderRadius = 10;
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(217, 102);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(180, 118);
            this.btnProduct.TabIndex = 29;
            this.btnProduct.Text = "Master Product";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BorderRadius = 10;
            this.btnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategory.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(403, 102);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(180, 118);
            this.btnCategory.TabIndex = 30;
            this.btnCategory.Text = "Master Category";
            // 
            // btnUser
            // 
            this.btnUser.BorderRadius = 10;
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(217, 226);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(180, 118);
            this.btnUser.TabIndex = 31;
            this.btnUser.Text = "Master User";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnStockLog
            // 
            this.btnStockLog.BorderRadius = 10;
            this.btnStockLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStockLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStockLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStockLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStockLog.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnStockLog.ForeColor = System.Drawing.Color.White;
            this.btnStockLog.Location = new System.Drawing.Point(403, 226);
            this.btnStockLog.Name = "btnStockLog";
            this.btnStockLog.Size = new System.Drawing.Size(180, 118);
            this.btnStockLog.TabIndex = 32;
            this.btnStockLog.Text = "Master Stock Log";
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStockLog);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMaster";
            this.Text = "FormMaster";
            this.Load += new System.EventHandler(this.FormMaster_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox ctrlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlBoxMin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnStockLog;
    }
}