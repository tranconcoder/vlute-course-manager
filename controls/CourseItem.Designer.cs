namespace vlute_course_manager.controls
{
    partial class CourseItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCourseType = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelCourseId = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.testDataSet1 = new vlute_course_manager.testDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vlute_course_manager.Properties.Resources.courseIcon;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCourseType);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.labelCourseId);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.labelTeacher);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelCourseName);
            this.panel1.Location = new System.Drawing.Point(204, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 170);
            this.panel1.TabIndex = 1;
            // 
            // labelCourseType
            // 
            this.labelCourseType.AutoSize = true;
            this.labelCourseType.Location = new System.Drawing.Point(39, 141);
            this.labelCourseType.Name = "labelCourseType";
            this.labelCourseType.Size = new System.Drawing.Size(125, 29);
            this.labelCourseType.TabIndex = 6;
            this.labelCourseType.Text = "Thực hành";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::vlute_course_manager.Properties.Resources.courseIconCode;
            this.pictureBox4.Location = new System.Drawing.Point(3, 140);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // labelCourseId
            // 
            this.labelCourseId.AutoSize = true;
            this.labelCourseId.Location = new System.Drawing.Point(39, 98);
            this.labelCourseId.Name = "labelCourseId";
            this.labelCourseId.Size = new System.Drawing.Size(328, 29);
            this.labelCourseId.TabIndex = 4;
            this.labelCourseId.Text = "231_1TH1337_KS2A_tructiep";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::vlute_course_manager.Properties.Resources.courseIconCode;
            this.pictureBox3.Location = new System.Drawing.Point(3, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(39, 53);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(225, 29);
            this.labelTeacher.TabIndex = 2;
            this.labelTeacher.Text = "Nguyễn Thị Mỹ Nga";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::vlute_course_manager.Properties.Resources.courseIconUser;
            this.pictureBox2.Location = new System.Drawing.Point(3, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Inter", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCourseName.Location = new System.Drawing.Point(3, 0);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(306, 33);
            this.labelCourseName.TabIndex = 0;
            this.labelCourseName.Text = "Lập trình dotNET (2.2)";
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CourseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CourseItem";
            this.Size = new System.Drawing.Size(1040, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCourseType;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelCourseId;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelCourseName;
        private testDataSet testDataSet1;
    }
}
