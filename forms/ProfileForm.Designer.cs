namespace vlute_course_manager
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelChangePassword = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelValidateOldPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelValidateNewPassword = new System.Windows.Forms.Label();
            this.textBoxRetypePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValidateRetypePassword = new System.Windows.Forms.Label();
            this.toggleSwitchChangePassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.labelValidateFullname = new System.Windows.Forms.Label();
            this.buttonChangeAvatar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonClose = new Guna.UI2.WinForms.Guna2Button();
            this.buttonReset = new Guna.UI2.WinForms.Guna2Button();
            this.buttonApplyChange = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(823, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.Image")));
            this.pictureBoxAvatar.ImageRotate = 0F;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(194, 131);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxAvatar.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAvatar.TabIndex = 1;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panelChangePassword);
            this.guna2Panel1.Controls.Add(this.toggleSwitchChangePassword);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.labelValidateFullname);
            this.guna2Panel1.Controls.Add(this.buttonChangeAvatar);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.textBoxFullname);
            this.guna2Panel1.Controls.Add(this.pictureBoxAvatar);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 194);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(2024, 704);
            this.guna2Panel1.TabIndex = 2;
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.textBoxOldPassword);
            this.panelChangePassword.Controls.Add(this.label3);
            this.panelChangePassword.Controls.Add(this.textBoxNewPassword);
            this.panelChangePassword.Controls.Add(this.labelValidateOldPassword);
            this.panelChangePassword.Controls.Add(this.label4);
            this.panelChangePassword.Controls.Add(this.labelValidateNewPassword);
            this.panelChangePassword.Controls.Add(this.textBoxRetypePassword);
            this.panelChangePassword.Controls.Add(this.label5);
            this.panelChangePassword.Controls.Add(this.labelValidateRetypePassword);
            this.panelChangePassword.Location = new System.Drawing.Point(549, 236);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(1106, 436);
            this.panelChangePassword.TabIndex = 21;
            this.panelChangePassword.Visible = false;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(204)))));
            this.textBoxOldPassword.BorderRadius = 10;
            this.textBoxOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOldPassword.DefaultText = "";
            this.textBoxOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxOldPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(119)))));
            this.textBoxOldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxOldPassword.Location = new System.Drawing.Point(345, 46);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(6, 40, 6, 6);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.PlaceholderText = "";
            this.textBoxOldPassword.SelectedText = "";
            this.textBoxOldPassword.Size = new System.Drawing.Size(500, 80);
            this.textBoxOldPassword.TabIndex = 5;
            this.textBoxOldPassword.TextChanged += new System.EventHandler(this.textBoxOldPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(43, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(204)))));
            this.textBoxNewPassword.BorderRadius = 10;
            this.textBoxNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNewPassword.DefaultText = "";
            this.textBoxNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(119)))));
            this.textBoxNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNewPassword.Location = new System.Drawing.Point(345, 172);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(6, 40, 6, 6);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.PlaceholderText = "";
            this.textBoxNewPassword.SelectedText = "";
            this.textBoxNewPassword.Size = new System.Drawing.Size(500, 80);
            this.textBoxNewPassword.TabIndex = 7;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.textBoxNewPassword_TextChanged);
            // 
            // labelValidateOldPassword
            // 
            this.labelValidateOldPassword.AllowDrop = true;
            this.labelValidateOldPassword.AutoEllipsis = true;
            this.labelValidateOldPassword.AutoSize = true;
            this.labelValidateOldPassword.ForeColor = System.Drawing.Color.Red;
            this.labelValidateOldPassword.Location = new System.Drawing.Point(349, 135);
            this.labelValidateOldPassword.Name = "labelValidateOldPassword";
            this.labelValidateOldPassword.Size = new System.Drawing.Size(238, 25);
            this.labelValidateOldPassword.TabIndex = 17;
            this.labelValidateOldPassword.Text = "Vui lòng nhập mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(43, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu mới";
            // 
            // labelValidateNewPassword
            // 
            this.labelValidateNewPassword.AllowDrop = true;
            this.labelValidateNewPassword.AutoEllipsis = true;
            this.labelValidateNewPassword.AutoSize = true;
            this.labelValidateNewPassword.ForeColor = System.Drawing.Color.Red;
            this.labelValidateNewPassword.Location = new System.Drawing.Point(349, 258);
            this.labelValidateNewPassword.Name = "labelValidateNewPassword";
            this.labelValidateNewPassword.Size = new System.Drawing.Size(238, 25);
            this.labelValidateNewPassword.TabIndex = 16;
            this.labelValidateNewPassword.Text = "Vui lòng nhập mật khẩu";
            // 
            // textBoxRetypePassword
            // 
            this.textBoxRetypePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(204)))));
            this.textBoxRetypePassword.BorderRadius = 10;
            this.textBoxRetypePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRetypePassword.DefaultText = "";
            this.textBoxRetypePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxRetypePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxRetypePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRetypePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRetypePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxRetypePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxRetypePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(119)))));
            this.textBoxRetypePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxRetypePassword.Location = new System.Drawing.Point(345, 295);
            this.textBoxRetypePassword.Margin = new System.Windows.Forms.Padding(6, 40, 6, 6);
            this.textBoxRetypePassword.Name = "textBoxRetypePassword";
            this.textBoxRetypePassword.PasswordChar = '*';
            this.textBoxRetypePassword.PlaceholderText = "";
            this.textBoxRetypePassword.SelectedText = "";
            this.textBoxRetypePassword.Size = new System.Drawing.Size(500, 80);
            this.textBoxRetypePassword.TabIndex = 10;
            this.textBoxRetypePassword.TextChanged += new System.EventHandler(this.textBoxRetypePassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(43, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Xác nhận MK mới";
            // 
            // labelValidateRetypePassword
            // 
            this.labelValidateRetypePassword.AutoSize = true;
            this.labelValidateRetypePassword.ForeColor = System.Drawing.Color.Red;
            this.labelValidateRetypePassword.Location = new System.Drawing.Point(349, 381);
            this.labelValidateRetypePassword.Name = "labelValidateRetypePassword";
            this.labelValidateRetypePassword.Size = new System.Drawing.Size(238, 25);
            this.labelValidateRetypePassword.TabIndex = 14;
            this.labelValidateRetypePassword.Text = "Vui lòng nhập mật khẩu";
            // 
            // toggleSwitchChangePassword
            // 
            this.toggleSwitchChangePassword.AutoRoundedCorners = true;
            this.toggleSwitchChangePassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchChangePassword.CheckedState.BorderRadius = 18;
            this.toggleSwitchChangePassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchChangePassword.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitchChangePassword.CheckedState.InnerBorderRadius = 14;
            this.toggleSwitchChangePassword.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitchChangePassword.Location = new System.Drawing.Point(845, 191);
            this.toggleSwitchChangePassword.Name = "toggleSwitchChangePassword";
            this.toggleSwitchChangePassword.Size = new System.Drawing.Size(86, 39);
            this.toggleSwitchChangePassword.TabIndex = 20;
            this.toggleSwitchChangePassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwitchChangePassword.UncheckedState.BorderRadius = 18;
            this.toggleSwitchChangePassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwitchChangePassword.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitchChangePassword.UncheckedState.InnerBorderRadius = 14;
            this.toggleSwitchChangePassword.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitchChangePassword.CheckedChanged += new System.EventHandler(this.toggleSwitchChangePassword_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(543, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 36);
            this.label6.TabIndex = 19;
            this.label6.Text = "Đổi mật khẩu";
            // 
            // labelValidateFullname
            // 
            this.labelValidateFullname.AutoSize = true;
            this.labelValidateFullname.ForeColor = System.Drawing.Color.Red;
            this.labelValidateFullname.Location = new System.Drawing.Point(849, 149);
            this.labelValidateFullname.Name = "labelValidateFullname";
            this.labelValidateFullname.Size = new System.Drawing.Size(250, 25);
            this.labelValidateFullname.TabIndex = 15;
            this.labelValidateFullname.Text = "Vui lòng nhập họ tên mới";
            this.labelValidateFullname.Visible = false;
            // 
            // buttonChangeAvatar
            // 
            this.buttonChangeAvatar.BorderRadius = 10;
            this.buttonChangeAvatar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonChangeAvatar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonChangeAvatar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonChangeAvatar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonChangeAvatar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonChangeAvatar.ForeColor = System.Drawing.Color.White;
            this.buttonChangeAvatar.Location = new System.Drawing.Point(248, 437);
            this.buttonChangeAvatar.Name = "buttonChangeAvatar";
            this.buttonChangeAvatar.Size = new System.Drawing.Size(180, 45);
            this.buttonChangeAvatar.TabIndex = 4;
            this.buttonChangeAvatar.Text = "Đổi ảnh";
            this.buttonChangeAvatar.Click += new System.EventHandler(this.buttonChangeAvatar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(543, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên";
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(204)))));
            this.textBoxFullname.BorderRadius = 10;
            this.textBoxFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFullname.DefaultText = "";
            this.textBoxFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFullname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(119)))));
            this.textBoxFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFullname.Location = new System.Drawing.Point(845, 63);
            this.textBoxFullname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.PasswordChar = '\0';
            this.textBoxFullname.PlaceholderText = "";
            this.textBoxFullname.SelectedText = "";
            this.textBoxFullname.Size = new System.Drawing.Size(500, 80);
            this.textBoxFullname.TabIndex = 2;
            this.textBoxFullname.TextChanged += new System.EventHandler(this.textBoxFullname_TextChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.BorderRadius = 10;
            this.buttonClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClose.FillColor = System.Drawing.Color.OrangeRed;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(12, 1068);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(300, 80);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Hủy và đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BorderRadius = 10;
            this.buttonReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(54)))));
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonReset.ForeColor = System.Drawing.Color.Black;
            this.buttonReset.Location = new System.Drawing.Point(1430, 1068);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(300, 80);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Đặt lại";
            // 
            // buttonApplyChange
            // 
            this.buttonApplyChange.BorderRadius = 10;
            this.buttonApplyChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonApplyChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonApplyChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonApplyChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonApplyChange.FillColor = System.Drawing.Color.LimeGreen;
            this.buttonApplyChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonApplyChange.ForeColor = System.Drawing.Color.White;
            this.buttonApplyChange.Location = new System.Drawing.Point(1736, 1068);
            this.buttonApplyChange.Name = "buttonApplyChange";
            this.buttonApplyChange.Size = new System.Drawing.Size(300, 80);
            this.buttonApplyChange.TabIndex = 9;
            this.buttonApplyChange.Text = "Thay đổi";
            this.buttonApplyChange.Click += new System.EventHandler(this.buttonApplyChange_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2054, 1160);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonApplyChange);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileForm";
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxAvatar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFullname;
        private Guna.UI2.WinForms.Guna2Button buttonChangeAvatar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxOldPassword;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNewPassword;
        private Guna.UI2.WinForms.Guna2Button buttonApplyChange;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox textBoxRetypePassword;
        private Guna.UI2.WinForms.Guna2Button buttonClose;
        private Guna.UI2.WinForms.Guna2Button buttonReset;
        private System.Windows.Forms.Label labelValidateRetypePassword;
        private System.Windows.Forms.Label labelValidateFullname;
        private System.Windows.Forms.Label labelValidateNewPassword;
        private System.Windows.Forms.Label labelValidateOldPassword;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwitchChangePassword;
        private Guna.UI2.WinForms.Guna2Panel panelChangePassword;
    }
}
