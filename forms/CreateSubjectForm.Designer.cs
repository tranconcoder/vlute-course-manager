namespace vlute_course_manager.forms
{
    partial class CreateSubjectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubjectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSubjectCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxMajor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.labelSubjectNameWarning = new System.Windows.Forms.Label();
            this.labelSubjectCodeWarning = new System.Windows.Forms.Label();
            this.numericUpDownTheory = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numericUpDownPractice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dataGridViewSubject = new Guna.UI2.WinForms.Guna2DataGridView();
            this.subjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theoryCreditCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practiceCreditCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonChange = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCancelChange = new Guna.UI2.WinForms.Guna2Button();
            this.buttonRemove = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(881, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO MÔN HỌC";
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.BorderRadius = 10;
            this.textBoxSubjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSubjectName.DefaultText = "";
            this.textBoxSubjectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSubjectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSubjectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSubjectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSubjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSubjectName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSubjectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSubjectName.Location = new System.Drawing.Point(259, 117);
            this.textBoxSubjectName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.PasswordChar = '\0';
            this.textBoxSubjectName.PlaceholderText = "";
            this.textBoxSubjectName.SelectedText = "";
            this.textBoxSubjectName.Size = new System.Drawing.Size(683, 77);
            this.textBoxSubjectName.TabIndex = 1;
            this.textBoxSubjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSubjectName.TextChanged += new System.EventHandler(this.textBoxSubjectName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1008, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học (6 ký tự)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tín chỉ lý thuyết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1031, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tín chỉ thực hành";
            // 
            // textBoxSubjectCode
            // 
            this.textBoxSubjectCode.BorderRadius = 10;
            this.textBoxSubjectCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSubjectCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSubjectCode.DefaultText = "";
            this.textBoxSubjectCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSubjectCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSubjectCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSubjectCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSubjectCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSubjectCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSubjectCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSubjectCode.Location = new System.Drawing.Point(1347, 117);
            this.textBoxSubjectCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSubjectCode.MaxLength = 6;
            this.textBoxSubjectCode.Name = "textBoxSubjectCode";
            this.textBoxSubjectCode.PasswordChar = '\0';
            this.textBoxSubjectCode.PlaceholderText = "";
            this.textBoxSubjectCode.SelectedText = "";
            this.textBoxSubjectCode.Size = new System.Drawing.Size(683, 77);
            this.textBoxSubjectCode.TabIndex = 9;
            this.textBoxSubjectCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSubjectCode.TextChanged += new System.EventHandler(this.textBoxSubjectCode_TextChanged);
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
            this.comboBoxMajor.ItemHeight = 71;
            this.comboBoxMajor.Location = new System.Drawing.Point(259, 429);
            this.comboBoxMajor.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxMajor.Name = "comboBoxMajor";
            this.comboBoxMajor.Size = new System.Drawing.Size(683, 77);
            this.comboBoxMajor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chuyên ngành";
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
            this.buttonSubmit.Location = new System.Drawing.Point(1347, 429);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(683, 77);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Tạo môn học";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelSubjectNameWarning
            // 
            this.labelSubjectNameWarning.AutoSize = true;
            this.labelSubjectNameWarning.ForeColor = System.Drawing.Color.Red;
            this.labelSubjectNameWarning.Location = new System.Drawing.Point(254, 200);
            this.labelSubjectNameWarning.Name = "labelSubjectNameWarning";
            this.labelSubjectNameWarning.Size = new System.Drawing.Size(274, 25);
            this.labelSubjectNameWarning.TabIndex = 13;
            this.labelSubjectNameWarning.Text = "Vui lòng nhập tên môn học!";
            // 
            // labelSubjectCodeWarning
            // 
            this.labelSubjectCodeWarning.AutoSize = true;
            this.labelSubjectCodeWarning.ForeColor = System.Drawing.Color.Red;
            this.labelSubjectCodeWarning.Location = new System.Drawing.Point(1342, 200);
            this.labelSubjectCodeWarning.Name = "labelSubjectCodeWarning";
            this.labelSubjectCodeWarning.Size = new System.Drawing.Size(274, 25);
            this.labelSubjectCodeWarning.TabIndex = 14;
            this.labelSubjectCodeWarning.Text = "Vui lòng nhập tên môn học!";
            // 
            // numericUpDownTheory
            // 
            this.numericUpDownTheory.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownTheory.BorderRadius = 10;
            this.numericUpDownTheory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownTheory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownTheory.Location = new System.Drawing.Point(259, 278);
            this.numericUpDownTheory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownTheory.Name = "numericUpDownTheory";
            this.numericUpDownTheory.Size = new System.Drawing.Size(683, 77);
            this.numericUpDownTheory.TabIndex = 15;
            // 
            // numericUpDownPractice
            // 
            this.numericUpDownPractice.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownPractice.BorderRadius = 10;
            this.numericUpDownPractice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownPractice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownPractice.Location = new System.Drawing.Point(1347, 278);
            this.numericUpDownPractice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownPractice.Name = "numericUpDownPractice";
            this.numericUpDownPractice.Size = new System.Drawing.Size(683, 77);
            this.numericUpDownPractice.TabIndex = 16;
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.AllowUserToAddRows = false;
            this.dataGridViewSubject.AllowUserToDeleteRows = false;
            this.dataGridViewSubject.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSubject.ColumnHeadersHeight = 80;
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectId,
            this.index,
            this.subjectName,
            this.subjectCode,
            this.theoryCreditCount,
            this.practiceCreditCount,
            this.majorName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubject.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewSubject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSubject.Location = new System.Drawing.Point(24, 608);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.ReadOnly = true;
            this.dataGridViewSubject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSubject.RowHeadersVisible = false;
            this.dataGridViewSubject.RowHeadersWidth = 82;
            this.dataGridViewSubject.RowTemplate.Height = 60;
            this.dataGridViewSubject.RowTemplate.ReadOnly = true;
            this.dataGridViewSubject.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSubject.Size = new System.Drawing.Size(2006, 609);
            this.dataGridViewSubject.TabIndex = 18;
            this.dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSubject.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSubject.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSubject.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewSubject.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSubject.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSubject.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSubject.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewSubject.ThemeStyle.HeaderStyle.Height = 80;
            this.dataGridViewSubject.ThemeStyle.ReadOnly = true;
            this.dataGridViewSubject.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSubject.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSubject.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSubject.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewSubject.ThemeStyle.RowsStyle.Height = 60;
            this.dataGridViewSubject.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSubject.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // subjectId
            // 
            this.subjectId.HeaderText = "ID";
            this.subjectId.MinimumWidth = 10;
            this.subjectId.Name = "subjectId";
            this.subjectId.ReadOnly = true;
            this.subjectId.Visible = false;
            // 
            // index
            // 
            this.index.FillWeight = 50F;
            this.index.HeaderText = "STT";
            this.index.MinimumWidth = 10;
            this.index.Name = "index";
            this.index.ReadOnly = true;
            // 
            // subjectName
            // 
            this.subjectName.FillWeight = 200F;
            this.subjectName.HeaderText = "Tên môn học";
            this.subjectName.MinimumWidth = 10;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            // 
            // subjectCode
            // 
            this.subjectCode.HeaderText = "Mã môn học";
            this.subjectCode.MinimumWidth = 10;
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.ReadOnly = true;
            // 
            // theoryCreditCount
            // 
            this.theoryCreditCount.HeaderText = "Số TC lý thuyết";
            this.theoryCreditCount.MinimumWidth = 10;
            this.theoryCreditCount.Name = "theoryCreditCount";
            this.theoryCreditCount.ReadOnly = true;
            // 
            // practiceCreditCount
            // 
            this.practiceCreditCount.HeaderText = "Số TC thực hành";
            this.practiceCreditCount.MinimumWidth = 10;
            this.practiceCreditCount.Name = "practiceCreditCount";
            this.practiceCreditCount.ReadOnly = true;
            // 
            // majorName
            // 
            this.majorName.HeaderText = "Chuyên ngành";
            this.majorName.MinimumWidth = 10;
            this.majorName.Name = "majorName";
            this.majorName.ReadOnly = true;
            // 
            // buttonChange
            // 
            this.buttonChange.BorderRadius = 10;
            this.buttonChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(24, 549);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(180, 45);
            this.buttonChange.TabIndex = 19;
            this.buttonChange.Text = "Sửa môn";
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonCancelChange
            // 
            this.buttonCancelChange.BorderRadius = 10;
            this.buttonCancelChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancelChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancelChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCancelChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCancelChange.FillColor = System.Drawing.Color.DarkGray;
            this.buttonCancelChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCancelChange.ForeColor = System.Drawing.Color.White;
            this.buttonCancelChange.Location = new System.Drawing.Point(482, 549);
            this.buttonCancelChange.Name = "buttonCancelChange";
            this.buttonCancelChange.Size = new System.Drawing.Size(180, 45);
            this.buttonCancelChange.TabIndex = 21;
            this.buttonCancelChange.Text = "Hủy sửa môn";
            this.buttonCancelChange.Click += new System.EventHandler(this.buttonCancelChange_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BorderRadius = 10;
            this.buttonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRemove.FillColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(259, 549);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(180, 45);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Xóa môn";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // CreateSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2054, 1229);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonCancelChange);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.dataGridViewSubject);
            this.Controls.Add(this.numericUpDownPractice);
            this.Controls.Add(this.numericUpDownTheory);
            this.Controls.Add(this.labelSubjectCodeWarning);
            this.Controls.Add(this.labelSubjectNameWarning);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMajor);
            this.Controls.Add(this.textBoxSubjectCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.label1);
            this.Name = "CreateSubjectForm";
            this.Text = "sss";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSubjectCode;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxMajor;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button buttonSubmit;
        private System.Windows.Forms.Label labelSubjectNameWarning;
        private System.Windows.Forms.Label labelSubjectCodeWarning;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownTheory;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownPractice;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewSubject;
        private Guna.UI2.WinForms.Guna2Button buttonChange;
        private Guna.UI2.WinForms.Guna2Button buttonCancelChange;
        private Guna.UI2.WinForms.Guna2Button buttonRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn theoryCreditCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn practiceCreditCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorName;
    }
}