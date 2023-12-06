namespace vlute_course_manager.forms
{
    partial class CreateCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCourseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numericUpDownDateRange = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelSessionWarning = new System.Windows.Forms.Label();
            this.flowLayoutPanelEnrollSession = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonAddSession = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSessionName = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonReset = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonAddImage = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelImageList = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelEnrollSessionWarning = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxEnrollSession = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelMajorWarning = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxMajor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numbericUpDownMaxMemberCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelSubjectWarning = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelTeacherWarning = new System.Windows.Forms.Label();
            this.labelCourseNameWarning = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBoxCourseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageItemThumb = new vlute_course_manager.controls.ImageItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateRange)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDownMaxMemberCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo phiên đăng ký";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownDateRange);
            this.splitContainer1.Panel1.Controls.Add(this.labelSessionWarning);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelEnrollSession);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerStart);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddSession);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSessionName);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.buttonReset);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSubmit);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.imageItemThumb);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDescription);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddImage);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelImageList);
            this.splitContainer1.Panel2.Controls.Add(this.guna2Panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Size = new System.Drawing.Size(2030, 1171);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 1;
            // 
            // numericUpDownDateRange
            // 
            this.numericUpDownDateRange.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownDateRange.BorderRadius = 10;
            this.numericUpDownDateRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownDateRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownDateRange.Location = new System.Drawing.Point(20, 360);
            this.numericUpDownDateRange.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownDateRange.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDownDateRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDateRange.Name = "numericUpDownDateRange";
            this.numericUpDownDateRange.Size = new System.Drawing.Size(660, 80);
            this.numericUpDownDateRange.TabIndex = 9;
            this.numericUpDownDateRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSessionWarning
            // 
            this.labelSessionWarning.AutoSize = true;
            this.labelSessionWarning.ForeColor = System.Drawing.Color.Red;
            this.labelSessionWarning.Location = new System.Drawing.Point(15, 114);
            this.labelSessionWarning.Name = "labelSessionWarning";
            this.labelSessionWarning.Size = new System.Drawing.Size(285, 25);
            this.labelSessionWarning.TabIndex = 8;
            this.labelSessionWarning.Text = "Vui lòng nhập tên phiên mới!";
            // 
            // flowLayoutPanelEnrollSession
            // 
            this.flowLayoutPanelEnrollSession.AutoScroll = true;
            this.flowLayoutPanelEnrollSession.Location = new System.Drawing.Point(20, 609);
            this.flowLayoutPanelEnrollSession.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelEnrollSession.Name = "flowLayoutPanelEnrollSession";
            this.flowLayoutPanelEnrollSession.Size = new System.Drawing.Size(660, 542);
            this.flowLayoutPanelEnrollSession.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày mở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePickerStart.BorderRadius = 10;
            this.dateTimePickerStart.Checked = true;
            this.dateTimePickerStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(222)))), ((int)(((byte)(123)))));
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerStart.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerStart.Location = new System.Drawing.Point(20, 219);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(2023, 11, 21, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(660, 80);
            this.dateTimePickerStart.TabIndex = 2;
            this.dateTimePickerStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTimePickerStart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.dateTimePickerStart.Value = new System.DateTime(2023, 11, 21, 21, 30, 37, 0);
            // 
            // buttonAddSession
            // 
            this.buttonAddSession.BorderRadius = 10;
            this.buttonAddSession.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddSession.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddSession.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddSession.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddSession.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.buttonAddSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonAddSession.ForeColor = System.Drawing.Color.White;
            this.buttonAddSession.Location = new System.Drawing.Point(20, 477);
            this.buttonAddSession.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddSession.Name = "buttonAddSession";
            this.buttonAddSession.Size = new System.Drawing.Size(660, 80);
            this.buttonAddSession.TabIndex = 1;
            this.buttonAddSession.Text = "Thêm phiên đăng ký";
            this.buttonAddSession.Click += new System.EventHandler(this.buttonAddSession_Click);
            // 
            // textBoxSessionName
            // 
            this.textBoxSessionName.BorderRadius = 10;
            this.textBoxSessionName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSessionName.DefaultText = "";
            this.textBoxSessionName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSessionName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSessionName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSessionName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSessionName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSessionName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSessionName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSessionName.Location = new System.Drawing.Point(20, 20);
            this.textBoxSessionName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSessionName.Name = "textBoxSessionName";
            this.textBoxSessionName.PasswordChar = '\0';
            this.textBoxSessionName.PlaceholderText = "";
            this.textBoxSessionName.SelectedText = "";
            this.textBoxSessionName.Size = new System.Drawing.Size(660, 80);
            this.textBoxSessionName.TabIndex = 0;
            this.textBoxSessionName.TextChanged += new System.EventHandler(this.textBoxSessionName_TextChanged);
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
            this.buttonReset.Location = new System.Drawing.Point(866, 1375);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(200, 60);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Điền lại";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BorderRadius = 10;
            this.buttonSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(1086, 1375);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(200, 60);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Tạo lớp";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label14.Location = new System.Drawing.Point(15, 595);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 30);
            this.label14.TabIndex = 12;
            this.label14.Text = "Mô tả học phần";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.Location = new System.Drawing.Point(15, 1047);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mô tả học phần";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescription.DefaultText = "";
            this.textBoxDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDescription.Location = new System.Drawing.Point(20, 1092);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PasswordChar = '\0';
            this.textBoxDescription.PlaceholderText = "";
            this.textBoxDescription.SelectedText = "";
            this.textBoxDescription.Size = new System.Drawing.Size(1266, 223);
            this.textBoxDescription.TabIndex = 9;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.BorderRadius = 10;
            this.buttonAddImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(54)))));
            this.buttonAddImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddImage.ForeColor = System.Drawing.Color.Black;
            this.buttonAddImage.Location = new System.Drawing.Point(405, 612);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(180, 45);
            this.buttonAddImage.TabIndex = 7;
            this.buttonAddImage.Text = "Thêm hình";
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // flowLayoutPanelImageList
            // 
            this.flowLayoutPanelImageList.AutoScroll = true;
            this.flowLayoutPanelImageList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelImageList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelImageList.Location = new System.Drawing.Point(405, 638);
            this.flowLayoutPanelImageList.Name = "flowLayoutPanelImageList";
            this.flowLayoutPanelImageList.Size = new System.Drawing.Size(881, 413);
            this.flowLayoutPanelImageList.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.labelEnrollSessionWarning);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.comboBoxEnrollSession);
            this.guna2Panel1.Controls.Add(this.labelMajorWarning);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.comboBoxMajor);
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.Controls.Add(this.numbericUpDownMaxMemberCount);
            this.guna2Panel1.Controls.Add(this.labelSubjectWarning);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.comboBoxSubject);
            this.guna2Panel1.Controls.Add(this.labelTeacherWarning);
            this.guna2Panel1.Controls.Add(this.labelCourseNameWarning);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.comboBoxTeacher);
            this.guna2Panel1.Controls.Add(this.textBoxCourseName);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 20);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(20);
            this.guna2Panel1.Size = new System.Drawing.Size(1266, 543);
            this.guna2Panel1.TabIndex = 4;
            // 
            // labelEnrollSessionWarning
            // 
            this.labelEnrollSessionWarning.AutoSize = true;
            this.labelEnrollSessionWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelEnrollSessionWarning.ForeColor = System.Drawing.Color.Red;
            this.labelEnrollSessionWarning.Location = new System.Drawing.Point(180, 110);
            this.labelEnrollSessionWarning.Name = "labelEnrollSessionWarning";
            this.labelEnrollSessionWarning.Size = new System.Drawing.Size(316, 25);
            this.labelEnrollSessionWarning.TabIndex = 26;
            this.labelEnrollSessionWarning.Text = "Vui lòng nhập tên lớp học phần!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 26);
            this.label10.TabIndex = 25;
            this.label10.Text = "Phiên đăng ký";
            // 
            // comboBoxEnrollSession
            // 
            this.comboBoxEnrollSession.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEnrollSession.BorderRadius = 10;
            this.comboBoxEnrollSession.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEnrollSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnrollSession.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEnrollSession.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEnrollSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEnrollSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxEnrollSession.IntegralHeight = false;
            this.comboBoxEnrollSession.ItemHeight = 64;
            this.comboBoxEnrollSession.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboBoxEnrollSession.Location = new System.Drawing.Point(185, 30);
            this.comboBoxEnrollSession.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxEnrollSession.Name = "comboBoxEnrollSession";
            this.comboBoxEnrollSession.Size = new System.Drawing.Size(1061, 70);
            this.comboBoxEnrollSession.TabIndex = 24;
            this.comboBoxEnrollSession.SelectedIndexChanged += new System.EventHandler(this.comboBoxEnrollSession_SelectedIndexChanged);
            // 
            // labelMajorWarning
            // 
            this.labelMajorWarning.AutoSize = true;
            this.labelMajorWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelMajorWarning.ForeColor = System.Drawing.Color.Red;
            this.labelMajorWarning.Location = new System.Drawing.Point(180, 232);
            this.labelMajorWarning.Name = "labelMajorWarning";
            this.labelMajorWarning.Size = new System.Drawing.Size(316, 25);
            this.labelMajorWarning.TabIndex = 23;
            this.labelMajorWarning.Text = "Vui lòng nhập tên lớp học phần!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "Chuyên ngành";
            // 
            // comboBoxMajor
            // 
            this.comboBoxMajor.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxMajor.BorderRadius = 10;
            this.comboBoxMajor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMajor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMajor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMajor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxMajor.IntegralHeight = false;
            this.comboBoxMajor.ItemHeight = 64;
            this.comboBoxMajor.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboBoxMajor.Location = new System.Drawing.Point(185, 151);
            this.comboBoxMajor.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxMajor.Name = "comboBoxMajor";
            this.comboBoxMajor.Size = new System.Drawing.Size(1061, 70);
            this.comboBoxMajor.TabIndex = 21;
            this.comboBoxMajor.SelectedIndexChanged += new System.EventHandler(this.comboBoxMajor_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(621, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "Số lượng tối đa";
            // 
            // numbericUpDownMaxMemberCount
            // 
            this.numbericUpDownMaxMemberCount.BackColor = System.Drawing.Color.Transparent;
            this.numbericUpDownMaxMemberCount.BorderRadius = 10;
            this.numbericUpDownMaxMemberCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numbericUpDownMaxMemberCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numbericUpDownMaxMemberCount.Location = new System.Drawing.Point(797, 419);
            this.numbericUpDownMaxMemberCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numbericUpDownMaxMemberCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numbericUpDownMaxMemberCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbericUpDownMaxMemberCount.Name = "numbericUpDownMaxMemberCount";
            this.numbericUpDownMaxMemberCount.Size = new System.Drawing.Size(450, 70);
            this.numbericUpDownMaxMemberCount.TabIndex = 19;
            this.numbericUpDownMaxMemberCount.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelSubjectWarning
            // 
            this.labelSubjectWarning.AutoSize = true;
            this.labelSubjectWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelSubjectWarning.ForeColor = System.Drawing.Color.Red;
            this.labelSubjectWarning.Location = new System.Drawing.Point(135, 504);
            this.labelSubjectWarning.Name = "labelSubjectWarning";
            this.labelSubjectWarning.Size = new System.Drawing.Size(237, 25);
            this.labelSubjectWarning.TabIndex = 12;
            this.labelSubjectWarning.Text = "Vui lòng chọn môn học!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Môn học";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSubject.BorderRadius = 10;
            this.comboBoxSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSubject.IntegralHeight = false;
            this.comboBoxSubject.ItemHeight = 64;
            this.comboBoxSubject.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboBoxSubject.Location = new System.Drawing.Point(140, 419);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(450, 70);
            this.comboBoxSubject.TabIndex = 10;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // labelTeacherWarning
            // 
            this.labelTeacherWarning.AutoSize = true;
            this.labelTeacherWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelTeacherWarning.ForeColor = System.Drawing.Color.Red;
            this.labelTeacherWarning.Location = new System.Drawing.Point(792, 373);
            this.labelTeacherWarning.Name = "labelTeacherWarning";
            this.labelTeacherWarning.Size = new System.Drawing.Size(254, 25);
            this.labelTeacherWarning.TabIndex = 9;
            this.labelTeacherWarning.Text = "Vui lòng chọn giảng viên!";
            // 
            // labelCourseNameWarning
            // 
            this.labelCourseNameWarning.AutoSize = true;
            this.labelCourseNameWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelCourseNameWarning.ForeColor = System.Drawing.Color.Red;
            this.labelCourseNameWarning.Location = new System.Drawing.Point(135, 373);
            this.labelCourseNameWarning.Name = "labelCourseNameWarning";
            this.labelCourseNameWarning.Size = new System.Drawing.Size(316, 25);
            this.labelCourseNameWarning.TabIndex = 8;
            this.labelCourseNameWarning.Text = "Vui lòng nhập tên lớp học phần!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giảng viên";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxTeacher.BorderRadius = 10;
            this.comboBoxTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTeacher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxTeacher.IntegralHeight = false;
            this.comboBoxTeacher.ItemHeight = 64;
            this.comboBoxTeacher.Location = new System.Drawing.Point(797, 288);
            this.comboBoxTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(450, 70);
            this.comboBoxTeacher.TabIndex = 6;
            this.comboBoxTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeacher_SelectedIndexChanged);
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxCourseName.BorderRadius = 10;
            this.textBoxCourseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCourseName.DefaultText = "";
            this.textBoxCourseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCourseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCourseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCourseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCourseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCourseName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxCourseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCourseName.Location = new System.Drawing.Point(140, 288);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.PasswordChar = '\0';
            this.textBoxCourseName.PlaceholderText = "";
            this.textBoxCourseName.SelectedText = "";
            this.textBoxCourseName.Size = new System.Drawing.Size(450, 70);
            this.textBoxCourseName.TabIndex = 5;
            this.textBoxCourseName.TextChanged += new System.EventHandler(this.textBoxCourseName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Inter", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(163)))));
            this.label5.Location = new System.Drawing.Point(752, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tạo khóa học";
            // 
            // imageItemThumb
            // 
            this.imageItemThumb.BackColor = System.Drawing.Color.Transparent;
            this.imageItemThumb.image = "D:\\Workspace\\.NET\\vlute-course-manager\\assets\\images\\formHome\\courseIcon.png";
            this.imageItemThumb.isEditMode = true;
            this.imageItemThumb.Location = new System.Drawing.Point(20, 638);
            this.imageItemThumb.Name = "imageItemThumb";
            this.imageItemThumb.onRemoveImage = null;
            this.imageItemThumb.Padding = new System.Windows.Forms.Padding(10);
            this.imageItemThumb.Size = new System.Drawing.Size(360, 360);
            this.imageItemThumb.TabIndex = 10;
            // 
            // CreateCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2054, 1229);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateCourseForm";
            this.Text = "Tạo tài liệu";
            this.Load += new System.EventHandler(this.CreateCourseForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateCourseForm_Paint);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDateRange)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDownMaxMemberCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSessionName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonAddSession;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEnrollSession;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxTeacher;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCourseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTeacherWarning;
        private System.Windows.Forms.Label labelCourseNameWarning;
        private System.Windows.Forms.Label labelSubjectWarning;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSubject;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2NumericUpDown numbericUpDownMaxMemberCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImageList;
        private Guna.UI2.WinForms.Guna2Button buttonAddImage;
        private controls.ImageItem imageItem1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDescription;
        private controls.ImageItem imageItemThumb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button buttonSubmit;
        private Guna.UI2.WinForms.Guna2Button buttonReset;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxMajor;
        private System.Windows.Forms.Label labelMajorWarning;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxEnrollSession;
        private System.Windows.Forms.Label labelEnrollSessionWarning;
        private System.Windows.Forms.Label labelSessionWarning;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownDateRange;
    }
}