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
            this.labelMajorWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractice)).BeginInit();
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
            this.textBoxSubjectName.Location = new System.Drawing.Point(259, 168);
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
            this.label2.Location = new System.Drawing.Point(36, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1008, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học (6 ký tự)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tín chỉ lý thuyết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1031, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tín chỉ thực hành";
            // 
            // textBoxSubjectCode
            // 
            this.textBoxSubjectCode.BorderRadius = 10;
            this.textBoxSubjectCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSubjectCode.DefaultText = "";
            this.textBoxSubjectCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSubjectCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSubjectCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSubjectCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSubjectCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSubjectCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSubjectCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSubjectCode.Location = new System.Drawing.Point(1347, 168);
            this.textBoxSubjectCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.comboBoxMajor.Location = new System.Drawing.Point(259, 480);
            this.comboBoxMajor.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxMajor.Name = "comboBoxMajor";
            this.comboBoxMajor.Size = new System.Drawing.Size(683, 77);
            this.comboBoxMajor.TabIndex = 10;
            this.comboBoxMajor.SelectedIndexChanged += new System.EventHandler(this.comboBoxMajor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chuyên ngành";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(1347, 480);
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
            this.labelSubjectNameWarning.Location = new System.Drawing.Point(254, 251);
            this.labelSubjectNameWarning.Name = "labelSubjectNameWarning";
            this.labelSubjectNameWarning.Size = new System.Drawing.Size(274, 25);
            this.labelSubjectNameWarning.TabIndex = 13;
            this.labelSubjectNameWarning.Text = "Vui lòng nhập tên môn học!";
            // 
            // labelSubjectCodeWarning
            // 
            this.labelSubjectCodeWarning.AutoSize = true;
            this.labelSubjectCodeWarning.ForeColor = System.Drawing.Color.Red;
            this.labelSubjectCodeWarning.Location = new System.Drawing.Point(1342, 251);
            this.labelSubjectCodeWarning.Name = "labelSubjectCodeWarning";
            this.labelSubjectCodeWarning.Size = new System.Drawing.Size(274, 25);
            this.labelSubjectCodeWarning.TabIndex = 14;
            this.labelSubjectCodeWarning.Text = "Vui lòng nhập tên môn học!";
            // 
            // numericUpDownTheory
            // 
            this.numericUpDownTheory.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownTheory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownTheory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownTheory.Location = new System.Drawing.Point(259, 329);
            this.numericUpDownTheory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownTheory.Name = "numericUpDownTheory";
            this.numericUpDownTheory.Size = new System.Drawing.Size(683, 77);
            this.numericUpDownTheory.TabIndex = 15;
            // 
            // numericUpDownPractice
            // 
            this.numericUpDownPractice.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownPractice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownPractice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownPractice.Location = new System.Drawing.Point(1347, 329);
            this.numericUpDownPractice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownPractice.Name = "numericUpDownPractice";
            this.numericUpDownPractice.Size = new System.Drawing.Size(683, 77);
            this.numericUpDownPractice.TabIndex = 16;
            // 
            // labelMajorWarning
            // 
            this.labelMajorWarning.AutoSize = true;
            this.labelMajorWarning.ForeColor = System.Drawing.Color.Red;
            this.labelMajorWarning.Location = new System.Drawing.Point(254, 574);
            this.labelMajorWarning.Name = "labelMajorWarning";
            this.labelMajorWarning.Size = new System.Drawing.Size(380, 25);
            this.labelMajorWarning.TabIndex = 17;
            this.labelMajorWarning.Text = "Vui lòng nhập chuyên ngành môn học!";
            // 
            // CreateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2054, 683);
            this.Controls.Add(this.labelMajorWarning);
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
            this.Name = "CreateSubject";
            this.Text = "Tạo môn học";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTheory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractice)).EndInit();
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
        private System.Windows.Forms.Label labelMajorWarning;
    }
}