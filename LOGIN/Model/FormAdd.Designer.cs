namespace LOGIN
{
    partial class FormAdd
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.dragCtrl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.picBoxWave = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtfirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxPhoneNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhoneNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDOB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblStrengthPass = new System.Windows.Forms.Label();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxHeader = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxPassWeak = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxMedium = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxStrong = new Guna.UI2.WinForms.Guna2PictureBox();
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.txtlastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWave)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhoneNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassWeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStrong)).BeginInit();
            this.SuspendLayout();
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
            // txtfirstname
            // 
            this.txtfirstname.BackColor = System.Drawing.Color.Transparent;
            this.txtfirstname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtfirstname.BorderRadius = 10;
            this.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtfirstname, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtfirstname.DefaultText = "";
            this.txtfirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfirstname.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtfirstname.ForeColor = System.Drawing.Color.Black;
            this.txtfirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfirstname.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtfirstname.Location = new System.Drawing.Point(28, 140);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.PasswordChar = '\0';
            this.txtfirstname.PlaceholderText = "";
            this.txtfirstname.SelectedText = "";
            this.txtfirstname.Size = new System.Drawing.Size(220, 36);
            this.txtfirstname.TabIndex = 6;
            this.txtfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFullName_KeyPress);
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
            this.lblFullName.Size = new System.Drawing.Size(79, 18);
            this.lblFullName.TabIndex = 16;
            this.lblFullName.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(535, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(26, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(535, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtBoxAddress.BorderRadius = 10;
            this.txtBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtBoxAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxAddress.DefaultText = "";
            this.txtBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAddress.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.txtBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAddress.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBoxAddress.Location = new System.Drawing.Point(538, 233);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.PasswordChar = '\0';
            this.txtBoxAddress.PlaceholderText = "";
            this.txtBoxAddress.SelectedText = "";
            this.txtBoxAddress.Size = new System.Drawing.Size(220, 36);
            this.txtBoxAddress.TabIndex = 22;
            // 
            // txtBoxPhoneNum
            // 
            this.txtBoxPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPhoneNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtBoxPhoneNum.BorderRadius = 10;
            this.txtBoxPhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtBoxPhoneNum, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxPhoneNum.DefaultText = "";
            this.txtBoxPhoneNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPhoneNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPhoneNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPhoneNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPhoneNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPhoneNum.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtBoxPhoneNum.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPhoneNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPhoneNum.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBoxPhoneNum.Location = new System.Drawing.Point(538, 140);
            this.txtBoxPhoneNum.Name = "txtBoxPhoneNum";
            this.txtBoxPhoneNum.PasswordChar = '\0';
            this.txtBoxPhoneNum.PlaceholderText = "";
            this.txtBoxPhoneNum.SelectedText = "";
            this.txtBoxPhoneNum.Size = new System.Drawing.Size(220, 36);
            this.txtBoxPhoneNum.TabIndex = 23;
            this.txtBoxPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPhoneNum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(279, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Gender";
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.cmbBoxGender.BorderRadius = 10;
            this.transition.SetDecoration(this.cmbBoxGender, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmbBoxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.cmbBoxGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBoxGender.Font = new System.Drawing.Font("Mollen Personal Use", 10F);
            this.cmbBoxGender.ForeColor = System.Drawing.Color.White;
            this.cmbBoxGender.ItemHeight = 30;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBoxGender.Location = new System.Drawing.Point(282, 338);
            this.cmbBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(225, 36);
            this.cmbBoxGender.TabIndex = 27;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtBoxPassword.BorderRadius = 10;
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtBoxPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxPassword.DefaultText = "";
            this.txtBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBoxPassword.Location = new System.Drawing.Point(282, 233);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '\0';
            this.txtBoxPassword.PlaceholderText = "";
            this.txtBoxPassword.SelectedText = "";
            this.txtBoxPassword.Size = new System.Drawing.Size(220, 36);
            this.txtBoxPassword.TabIndex = 31;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtBoxUsername.BorderRadius = 10;
            this.txtBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtBoxUsername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxUsername.DefaultText = "";
            this.txtBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.txtBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBoxUsername.Location = new System.Drawing.Point(26, 233);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.PasswordChar = '\0';
            this.txtBoxUsername.PlaceholderText = "";
            this.txtBoxUsername.SelectedText = "";
            this.txtBoxUsername.Size = new System.Drawing.Size(220, 36);
            this.txtBoxUsername.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(279, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(23, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Username";
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
            // errorFullName
            // 
            this.errorFullName.ContainerControl = this;
            // 
            // errorPhoneNum
            // 
            this.errorPhoneNum.ContainerControl = this;
            // 
            // errorDOB
            // 
            this.errorDOB.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorUsername
            // 
            this.errorUsername.ContainerControl = this;
            // 
            // errorPass
            // 
            this.errorPass.ContainerControl = this;
            // 
            // errorGender
            // 
            this.errorGender.ContainerControl = this;
            // 
            // lblStrengthPass
            // 
            this.lblStrengthPass.AutoSize = true;
            this.lblStrengthPass.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.lblStrengthPass, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblStrengthPass.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrengthPass.ForeColor = System.Drawing.Color.Crimson;
            this.lblStrengthPass.Location = new System.Drawing.Point(304, 279);
            this.lblStrengthPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStrengthPass.Name = "lblStrengthPass";
            this.lblStrengthPass.Size = new System.Drawing.Size(101, 15);
            this.lblStrengthPass.TabIndex = 34;
            this.lblStrengthPass.Text = "Password is weak";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Animated = true;
            this.dateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker.BorderColor = System.Drawing.Color.White;
            this.dateTimePicker.BorderRadius = 10;
            this.dateTimePicker.Checked = true;
            this.transition.SetDecoration(this.dateTimePicker, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Mollen Personal Use Narrow", 8.999999F);
            this.dateTimePicker.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.Location = new System.Drawing.Point(29, 338);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(220, 36);
            this.dateTimePicker.TabIndex = 37;
            this.dateTimePicker.UseTransparentBackground = true;
            this.dateTimePicker.Value = new System.DateTime(2023, 5, 29, 16, 8, 48, 673);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(77, 18);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(254, 74);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 39;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // picBoxHeader
            // 
            this.picBoxHeader.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.picBoxHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBoxHeader.Image = global::LOGIN.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_96;
            this.picBoxHeader.ImageRotate = 0F;
            this.picBoxHeader.Location = new System.Drawing.Point(29, 17);
            this.picBoxHeader.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxHeader.Name = "picBoxHeader";
            this.picBoxHeader.Size = new System.Drawing.Size(37, 32);
            this.picBoxHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHeader.TabIndex = 1;
            this.picBoxHeader.TabStop = false;
            this.picBoxHeader.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(675, 311);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(120, 75);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // picBoxPassWeak
            // 
            this.picBoxPassWeak.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.picBoxPassWeak, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBoxPassWeak.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPassWeak.Image")));
            this.picBoxPassWeak.ImageRotate = 0F;
            this.picBoxPassWeak.Location = new System.Drawing.Point(281, 276);
            this.picBoxPassWeak.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxPassWeak.Name = "picBoxPassWeak";
            this.picBoxPassWeak.Size = new System.Drawing.Size(19, 18);
            this.picBoxPassWeak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPassWeak.TabIndex = 36;
            this.picBoxPassWeak.TabStop = false;
            this.picBoxPassWeak.UseTransparentBackground = true;
            // 
            // picBoxMedium
            // 
            this.picBoxMedium.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.picBoxMedium, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBoxMedium.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMedium.Image")));
            this.picBoxMedium.ImageRotate = 0F;
            this.picBoxMedium.Location = new System.Drawing.Point(281, 276);
            this.picBoxMedium.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxMedium.Name = "picBoxMedium";
            this.picBoxMedium.Size = new System.Drawing.Size(19, 18);
            this.picBoxMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMedium.TabIndex = 35;
            this.picBoxMedium.TabStop = false;
            this.picBoxMedium.UseTransparentBackground = true;
            // 
            // picBoxStrong
            // 
            this.picBoxStrong.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.picBoxStrong, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBoxStrong.Image = ((System.Drawing.Image)(resources.GetObject("picBoxStrong.Image")));
            this.picBoxStrong.ImageRotate = 0F;
            this.picBoxStrong.Location = new System.Drawing.Point(281, 276);
            this.picBoxStrong.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxStrong.Name = "picBoxStrong";
            this.picBoxStrong.Size = new System.Drawing.Size(19, 18);
            this.picBoxStrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxStrong.TabIndex = 33;
            this.picBoxStrong.TabStop = false;
            this.picBoxStrong.UseTransparentBackground = true;
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.transition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation2;
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.Color.Transparent;
            this.txtlastname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.txtlastname.BorderRadius = 10;
            this.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtlastname, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtlastname.DefaultText = "";
            this.txtlastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlastname.Font = new System.Drawing.Font("Mollen Personal Use", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtlastname.ForeColor = System.Drawing.Color.Black;
            this.txtlastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlastname.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtlastname.Location = new System.Drawing.Point(287, 140);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.PasswordChar = '\0';
            this.txtlastname.PlaceholderText = "";
            this.txtlastname.SelectedText = "";
            this.txtlastname.Size = new System.Drawing.Size(220, 36);
            this.txtlastname.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.label7.Location = new System.Drawing.Point(284, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Last name";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 460);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.picBoxHeader);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.picBoxPassWeak);
            this.Controls.Add(this.picBoxMedium);
            this.Controls.Add(this.lblStrengthPass);
            this.Controls.Add(this.picBoxStrong);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBoxGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPhoneNum);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.picBoxWave);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdd";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWave)).EndInit();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhoneNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassWeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox picBoxHeader;
        private Guna.UI2.WinForms.Guna2DragControl dragCtrl;
        private Guna.UI2.WinForms.Guna2TextBox txtfirstname;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPhoneNum;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBoxGender;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFooter;
        internal Guna.UI2.WinForms.Guna2Button btnClose;
        internal Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorFullName;
        private System.Windows.Forms.ErrorProvider errorPhoneNum;
        private System.Windows.Forms.ErrorProvider errorDOB;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorUsername;
        private System.Windows.Forms.ErrorProvider errorPass;
        private System.Windows.Forms.ErrorProvider errorGender;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxStrong;
        private System.Windows.Forms.Label lblStrengthPass;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxMedium;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxPassWeak;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxWave;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private Guna.UI2.WinForms.Guna2TextBox txtlastname;
        private System.Windows.Forms.Label label7;
    }
}