namespace vlute_course_manager.controls
{
    partial class CreateMajorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMajorForm));
            this.textBoxMajor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMajorWarning = new System.Windows.Forms.Label();
            this.dataGridViewMajor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.majorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonRemove = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMajor)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.BorderRadius = 10;
            this.textBoxMajor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMajor.DefaultText = "";
            this.textBoxMajor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMajor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMajor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMajor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMajor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMajor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxMajor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMajor.Location = new System.Drawing.Point(300, 156);
            this.textBoxMajor.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.PasswordChar = '\0';
            this.textBoxMajor.PlaceholderText = "";
            this.textBoxMajor.SelectedText = "";
            this.textBoxMajor.Size = new System.Drawing.Size(883, 77);
            this.textBoxMajor.TabIndex = 0;
            this.textBoxMajor.TextChanged += new System.EventHandler(this.textBoxMajor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(163)))));
            this.label5.Location = new System.Drawing.Point(386, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 49);
            this.label5.TabIndex = 1;
            this.label5.Text = "TẠO CHUYÊN NGÀNH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(34, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên chuyên ngành";
            // 
            // labelMajorWarning
            // 
            this.labelMajorWarning.AutoSize = true;
            this.labelMajorWarning.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelMajorWarning.ForeColor = System.Drawing.Color.Red;
            this.labelMajorWarning.Location = new System.Drawing.Point(294, 239);
            this.labelMajorWarning.Name = "labelMajorWarning";
            this.labelMajorWarning.Size = new System.Drawing.Size(380, 29);
            this.labelMajorWarning.TabIndex = 3;
            this.labelMajorWarning.Text = "Vui lòng nhập tên chuyên ngành";
            // 
            // dataGridViewMajor
            // 
            this.dataGridViewMajor.AllowUserToAddRows = false;
            this.dataGridViewMajor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewMajor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMajor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMajor.ColumnHeadersHeight = 60;
            this.dataGridViewMajor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMajor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.majorId,
            this.order,
            this.majorName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMajor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMajor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMajor.Location = new System.Drawing.Point(12, 466);
            this.dataGridViewMajor.Name = "dataGridViewMajor";
            this.dataGridViewMajor.ReadOnly = true;
            this.dataGridViewMajor.RowHeadersVisible = false;
            this.dataGridViewMajor.RowHeadersWidth = 82;
            this.dataGridViewMajor.RowTemplate.Height = 60;
            this.dataGridViewMajor.Size = new System.Drawing.Size(1174, 751);
            this.dataGridViewMajor.TabIndex = 4;
            this.dataGridViewMajor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMajor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewMajor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewMajor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewMajor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewMajor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMajor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMajor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewMajor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMajor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMajor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMajor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMajor.ThemeStyle.HeaderStyle.Height = 60;
            this.dataGridViewMajor.ThemeStyle.ReadOnly = true;
            this.dataGridViewMajor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMajor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMajor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMajor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMajor.ThemeStyle.RowsStyle.Height = 60;
            this.dataGridViewMajor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMajor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // majorId
            // 
            this.majorId.HeaderText = "";
            this.majorId.MinimumWidth = 10;
            this.majorId.Name = "majorId";
            this.majorId.ReadOnly = true;
            this.majorId.Visible = false;
            // 
            // order
            // 
            this.order.HeaderText = "STT";
            this.order.MinimumWidth = 10;
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // majorName
            // 
            this.majorName.HeaderText = "Tên chuyên ngành";
            this.majorName.MinimumWidth = 10;
            this.majorName.Name = "majorName";
            this.majorName.ReadOnly = true;
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
            this.buttonSubmit.Location = new System.Drawing.Point(299, 288);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(884, 77);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Thêm chuyên ngành";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
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
            this.buttonRemove.Location = new System.Drawing.Point(12, 392);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(180, 45);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Xóa";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // CreateMajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 1229);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.dataGridViewMajor);
            this.Controls.Add(this.labelMajorWarning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMajor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateMajorForm";
            this.Text = "Tạo chuyên ngành";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMajor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxMajor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMajorWarning;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorName;
        private Guna.UI2.WinForms.Guna2Button buttonSubmit;
        private Guna.UI2.WinForms.Guna2Button buttonRemove;
    }
}