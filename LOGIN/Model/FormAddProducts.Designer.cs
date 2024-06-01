namespace LOGIN
{
    partial class FormAddProducts
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProducts));
            this.picBoxHeader = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dragCtrl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.picBoxWave = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtBoxMedName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtBoxDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoldCount = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorWeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMedName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSold = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.picBoxBurung = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxTextHeader = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtBoxWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWave)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMedName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBurung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTextHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHeader
            // 
            this.picBoxHeader.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.picBoxHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBoxHeader.Image = global::LOGIN.Properties.Resources.icons8_product_unscreen;
            this.picBoxHeader.ImageRotate = 0F;
            this.picBoxHeader.Location = new System.Drawing.Point(28, 23);
            this.picBoxHeader.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxHeader.Name = "picBoxHeader";
            this.picBoxHeader.Size = new System.Drawing.Size(37, 32);
            this.picBoxHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHeader.TabIndex = 1;
            this.picBoxHeader.TabStop = false;
            this.picBoxHeader.UseTransparentBackground = true;
            // 
            // dragCtrl
            // 
            this.dragCtrl.DockIndicatorTransparencyValue = 0.6D;
            this.dragCtrl.TargetControl = this.picBoxWave;
            this.dragCtrl.UseTransparentDrag = true;
            // 
            // picBoxWave
            // 
            this.picBoxWave.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.picBoxWave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBoxWave.Image = ((System.Drawing.Image)(resources.GetObject("picBoxWave.Image")));
            this.picBoxWave.ImageRotate = 0F;
            this.picBoxWave.Location = new System.Drawing.Point(0, 0);
            this.picBoxWave.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxWave.Name = "picBoxWave";
            this.picBoxWave.Size = new System.Drawing.Size(789, 176);
            this.picBoxWave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxWave.TabIndex = 38;
            this.picBoxWave.TabStop = false;
            this.picBoxWave.UseTransparentBackground = true;
            // 
            // txtBoxMedName
            // 
            this.txtBoxMedName.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxMedName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtBoxMedName.BorderRadius = 10;
            this.txtBoxMedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtBoxMedName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxMedName.DefaultText = "";
            this.txtBoxMedName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxMedName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxMedName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxMedName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxMedName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxMedName.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtBoxMedName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMedName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxMedName.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBoxMedName.Location = new System.Drawing.Point(28, 140);
            this.txtBoxMedName.Name = "txtBoxMedName";
            this.txtBoxMedName.PasswordChar = '\0';
            this.txtBoxMedName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBoxMedName.PlaceholderText = "";
            this.txtBoxMedName.SelectedText = "";
            this.txtBoxMedName.Size = new System.Drawing.Size(220, 36);
            this.txtBoxMedName.TabIndex = 6;
            this.txtBoxMedName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMedName_KeyPress);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.lblFullName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblFullName.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.lblFullName.Location = new System.Drawing.Point(25, 121);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(110, 18);
            this.lblFullName.TabIndex = 16;
            this.lblFullName.Text = "Medicine name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.lblPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPrice.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.lblPrice.Location = new System.Drawing.Point(279, 121);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 18);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Price";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.lblWeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblWeight.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.lblWeight.Location = new System.Drawing.Point(23, 305);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(55, 18);
            this.lblWeight.TabIndex = 20;
            this.lblWeight.Text = "Weight";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.lblDesc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDesc.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.lblDesc.Location = new System.Drawing.Point(535, 121);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(85, 18);
            this.lblDesc.TabIndex = 21;
            this.lblDesc.Text = "Description";
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtBoxDesc.BorderRadius = 10;
            this.txtBoxDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtBoxDesc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxDesc.DefaultText = "";
            this.txtBoxDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxDesc.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtBoxDesc.ForeColor = System.Drawing.Color.Black;
            this.txtBoxDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxDesc.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBoxDesc.Location = new System.Drawing.Point(538, 140);
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.PasswordChar = '\0';
            this.txtBoxDesc.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBoxDesc.PlaceholderText = "";
            this.txtBoxDesc.SelectedText = "";
            this.txtBoxDesc.Size = new System.Drawing.Size(220, 129);
            this.txtBoxDesc.TabIndex = 22;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtBoxPrice.BorderRadius = 10;
            this.txtBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtBoxPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxPrice.DefaultText = "";
            this.txtBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPrice.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtBoxPrice.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPrice.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBoxPrice.Location = new System.Drawing.Point(282, 140);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.PasswordChar = '\0';
            this.txtBoxPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBoxPrice.PlaceholderText = "";
            this.txtBoxPrice.SelectedText = "";
            this.txtBoxPrice.Size = new System.Drawing.Size(220, 36);
            this.txtBoxPrice.TabIndex = 23;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            this.txtBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPrice_KeyPress);
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtBoxStock.BorderRadius = 10;
            this.txtBoxStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtBoxStock, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxStock.DefaultText = "";
            this.txtBoxStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxStock.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtBoxStock.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxStock.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBoxStock.Location = new System.Drawing.Point(26, 233);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.PasswordChar = '\0';
            this.txtBoxStock.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBoxStock.PlaceholderText = "";
            this.txtBoxStock.SelectedText = "";
            this.txtBoxStock.Size = new System.Drawing.Size(220, 36);
            this.txtBoxStock.TabIndex = 30;
            this.txtBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStock_KeyPress);
            // 
            // lblSoldCount
            // 
            this.lblSoldCount.AutoSize = true;
            this.lblSoldCount.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.lblSoldCount, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSoldCount.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.lblSoldCount.Location = new System.Drawing.Point(279, 213);
            this.lblSoldCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoldCount.Name = "lblSoldCount";
            this.lblSoldCount.Size = new System.Drawing.Size(0, 18);
            this.lblSoldCount.TabIndex = 29;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.lblStock, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblStock.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.lblStock.Location = new System.Drawing.Point(23, 213);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(46, 18);
            this.lblStock.TabIndex = 28;
            this.lblStock.Text = "Stock";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Controls.Add(this.btnSave);
            this.transition.SetDecoration(this.panelFooter, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelFooter.Location = new System.Drawing.Point(-1, 389);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(843, 71);
            this.panelFooter.TabIndex = 32;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 10;
            this.btnClose.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnClose.CustomImages.CheckedImage = global::LOGIN.Properties.Resources.icons8_cancel_100__1_;
            this.btnClose.CustomImages.HoveredImage = global::LOGIN.Properties.Resources.icons8_cancel_100__1_;
            this.btnClose.CustomImages.Image = global::LOGIN.Properties.Resources.icons8_cancel_100;
            this.btnClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.transition.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.FillColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnClose.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(409, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 45);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.TextOffset = new System.Drawing.Point(40, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 10;
            this.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSave.CustomImages.CheckedImage = global::LOGIN.Properties.Resources.icons8_done_100;
            this.btnSave.CustomImages.HoveredImage = global::LOGIN.Properties.Resources.icons8_done_100;
            this.btnSave.CustomImages.Image = global::LOGIN.Properties.Resources.icons8_done_100__1_;
            this.btnSave.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.transition.SetDecoration(this.btnSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.btnSave.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(587, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.TextOffset = new System.Drawing.Point(40, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorWeight
            // 
            this.errorWeight.ContainerControl = this;
            // 
            // errorPrice
            // 
            this.errorPrice.ContainerControl = this;
            // 
            // errorMedName
            // 
            this.errorMedName.ContainerControl = this;
            // 
            // errorDesc
            // 
            this.errorDesc.ContainerControl = this;
            // 
            // errorStock
            // 
            this.errorStock.ContainerControl = this;
            // 
            // errorSold
            // 
            this.errorSold.ContainerControl = this;
            // 
            // errorGender
            // 
            this.errorGender.ContainerControl = this;
            // 
            // picBoxBurung
            // 
            this.picBoxBurung.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.picBoxBurung, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBoxBurung.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBurung.Image")));
            this.picBoxBurung.ImageRotate = 0F;
            this.picBoxBurung.Location = new System.Drawing.Point(675, 311);
            this.picBoxBurung.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxBurung.Name = "picBoxBurung";
            this.picBoxBurung.Size = new System.Drawing.Size(120, 75);
            this.picBoxBurung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBurung.TabIndex = 7;
            this.picBoxBurung.TabStop = false;
            this.picBoxBurung.UseTransparentBackground = true;
            // 
            // picBoxTextHeader
            // 
            this.picBoxTextHeader.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.picBoxTextHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBoxTextHeader.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTextHeader.Image")));
            this.picBoxTextHeader.ImageRotate = 0F;
            this.picBoxTextHeader.Location = new System.Drawing.Point(79, 0);
            this.picBoxTextHeader.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxTextHeader.Name = "picBoxTextHeader";
            this.picBoxTextHeader.Size = new System.Drawing.Size(167, 83);
            this.picBoxTextHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTextHeader.TabIndex = 39;
            this.picBoxTextHeader.TabStop = false;
            this.picBoxTextHeader.UseTransparentBackground = true;
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxWeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtBoxWeight.BorderRadius = 10;
            this.txtBoxWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtBoxWeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxWeight.DefaultText = "";
            this.txtBoxWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxWeight.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtBoxWeight.ForeColor = System.Drawing.Color.Black;
            this.txtBoxWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxWeight.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBoxWeight.Location = new System.Drawing.Point(26, 325);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.PasswordChar = '\0';
            this.txtBoxWeight.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBoxWeight.PlaceholderText = "";
            this.txtBoxWeight.SelectedText = "";
            this.txtBoxWeight.Size = new System.Drawing.Size(220, 36);
            this.txtBoxWeight.TabIndex = 40;
            this.txtBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxWeight_KeyPress);
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(279, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sold count";
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.cmbBoxCategory.BorderRadius = 10;
            this.transition.SetDecoration(this.cmbBoxCategory, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmbBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.cmbBoxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxCategory.Font = new System.Drawing.Font("Mollen Personal Use", 10F);
            this.cmbBoxCategory.ForeColor = System.Drawing.Color.White;
            this.cmbBoxCategory.ItemHeight = 30;
            this.cmbBoxCategory.Location = new System.Drawing.Point(282, 233);
            this.cmbBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(225, 36);
            this.cmbBoxCategory.TabIndex = 43;
            // 
            // FormAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 460);
            this.Controls.Add(this.cmbBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxWeight);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxMedName);
            this.Controls.Add(this.picBoxTextHeader);
            this.Controls.Add(this.picBoxHeader);
            this.Controls.Add(this.picBoxBurung);
            this.Controls.Add(this.txtBoxStock);
            this.Controls.Add(this.lblSoldCount);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.picBoxWave);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddProducts";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWave)).EndInit();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMedName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBurung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTextHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox picBoxHeader;
        private Guna.UI2.WinForms.Guna2DragControl dragCtrl;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxMedName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDesc;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxDesc;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxStock;
        private System.Windows.Forms.Label lblSoldCount;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel panelFooter;
        internal Guna.UI2.WinForms.Guna2Button btnClose;
        internal Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorWeight;
        private System.Windows.Forms.ErrorProvider errorPrice;
        private System.Windows.Forms.ErrorProvider errorMedName;
        private System.Windows.Forms.ErrorProvider errorDesc;
        private System.Windows.Forms.ErrorProvider errorStock;
        private System.Windows.Forms.ErrorProvider errorSold;
        private System.Windows.Forms.ErrorProvider errorGender;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxBurung;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxWave;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxTextHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxWeight;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxCategory;
    }
}