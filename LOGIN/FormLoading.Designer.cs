namespace LOGIN
{
    partial class FormLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
            this.circleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxChemist = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shdwForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.circleProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChemist)).BeginInit();
            this.SuspendLayout();
            // 
            // circleProgressBar
            // 
            this.circleProgressBar.BackColor = System.Drawing.Color.White;
            this.circleProgressBar.Controls.Add(this.guna2PictureBox1);
            this.circleProgressBar.Controls.Add(this.label5);
            this.circleProgressBar.Controls.Add(this.label4);
            this.circleProgressBar.Controls.Add(this.label3);
            this.circleProgressBar.Controls.Add(this.lblValue);
            this.circleProgressBar.Controls.Add(this.label1);
            this.circleProgressBar.Controls.Add(this.picBoxChemist);
            this.circleProgressBar.FillColor = System.Drawing.Color.Transparent;
            this.circleProgressBar.FillThickness = 800;
            this.circleProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.circleProgressBar.ForeColor = System.Drawing.Color.White;
            this.circleProgressBar.Location = new System.Drawing.Point(19, -495);
            this.circleProgressBar.Minimum = 0;
            this.circleProgressBar.Name = "circleProgressBar";
            this.circleProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.circleProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(186)))), ((int)(((byte)(235)))));
            this.circleProgressBar.ProgressThickness = 700;
            this.circleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleProgressBar.Size = new System.Drawing.Size(1800, 1800);
            this.circleProgressBar.TabIndex = 0;
            this.circleProgressBar.ValueChanged += new System.EventHandler(this.circleProgressBar_ValueChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(759, 877);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(285, 253);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Euclid Circular B", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 693);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 79);
            this.label5.TabIndex = 5;
            this.label5.Text = "of your health !";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Euclid Circular B", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 79);
            this.label4.TabIndex = 4;
            this.label4.Text = "to take care";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Euclid Circular B", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 79);
            this.label3.TabIndex = 3;
            this.label3.Text = "its time";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 90F);
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(186)))), ((int)(((byte)(235)))));
            this.lblValue.Location = new System.Drawing.Point(276, 935);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(110, 144);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(866, 1039);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading ...";
            // 
            // picBoxChemist
            // 
            this.picBoxChemist.BackColor = System.Drawing.Color.Transparent;
            this.picBoxChemist.Image = global::LOGIN.Properties.Resources.d800c44f28f6995f3da985d82d2979_unscreen;
            this.picBoxChemist.ImageRotate = 0F;
            this.picBoxChemist.Location = new System.Drawing.Point(711, 733);
            this.picBoxChemist.Name = "picBoxChemist";
            this.picBoxChemist.Size = new System.Drawing.Size(360, 255);
            this.picBoxChemist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxChemist.TabIndex = 0;
            this.picBoxChemist.TabStop = false;
            this.picBoxChemist.UseTransparentBackground = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 600);
            this.Controls.Add(this.circleProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.FormLoading_Load);
            this.circleProgressBar.ResumeLayout(false);
            this.circleProgressBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChemist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar circleProgressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxChemist;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ShadowForm shdwForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}