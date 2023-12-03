namespace vlute_course_manager.controls
{
    partial class EnrollSessionItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollSessionItem));
            this.labelCourseSessionName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelCourseSessionDate = new System.Windows.Forms.Label();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCourseSessionName
            // 
            this.labelCourseSessionName.BackColor = System.Drawing.Color.Transparent;
            this.labelCourseSessionName.Font = new System.Drawing.Font("Inter", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCourseSessionName.Location = new System.Drawing.Point(13, 13);
            this.labelCourseSessionName.Name = "labelCourseSessionName";
            this.labelCourseSessionName.Size = new System.Drawing.Size(465, 38);
            this.labelCourseSessionName.TabIndex = 0;
            this.labelCourseSessionName.Text = "Học kỳ 1 - Năm học 2022 - 2023";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonDelete.ImageRotate = 0F;
            this.buttonDelete.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonDelete.Location = new System.Drawing.Point(543, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonDelete.Size = new System.Drawing.Size(64, 54);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.UseTransparentBackground = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.labelCourseSessionDate);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(207)))));
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(13, 83);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(357, 54);
            this.guna2Panel1.TabIndex = 4;
            // 
            // labelCourseSessionDate
            // 
            this.labelCourseSessionDate.AutoSize = true;
            this.labelCourseSessionDate.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCourseSessionDate.Location = new System.Drawing.Point(13, 14);
            this.labelCourseSessionDate.Name = "labelCourseSessionDate";
            this.labelCourseSessionDate.Size = new System.Drawing.Size(335, 29);
            this.labelCourseSessionDate.TabIndex = 3;
            this.labelCourseSessionDate.Text = "(30/11/2023 - 30/12/2023)";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(543, 67);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(64, 70);
            this.guna2ImageButton2.TabIndex = 2;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.labelCourseSessionName);
            this.guna2ShadowPanel1.Controls.Add(this.guna2ImageButton2);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel1);
            this.guna2ShadowPanel1.Controls.Add(this.buttonDelete);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(620, 150);
            this.guna2ShadowPanel1.TabIndex = 5;
            // 
            // EnrollSessionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Name = "EnrollSessionItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(620, 150);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labelCourseSessionName;
        private Guna.UI2.WinForms.Guna2ImageButton buttonDelete;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label labelCourseSessionDate;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}
