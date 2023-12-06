namespace vlute_course_manager.controls
{
    partial class UserAccountItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountItem));
            this.pictureBoxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelMajor = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.buttonRemove = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonChange = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.ImageRotate = 0F;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxAvatar.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelFullname.Location = new System.Drawing.Point(264, 42);
            this.labelFullname.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(199, 24);
            this.labelFullname.TabIndex = 1;
            this.labelFullname.Text = "Nguyễn Thị Mỹ Nga";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(207)))));
            this.labelRole.Location = new System.Drawing.Point(492, 42);
            this.labelRole.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(100, 24);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Giáo viên";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelMajor.Location = new System.Drawing.Point(610, 42);
            this.labelMajor.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(206, 24);
            this.labelMajor.TabIndex = 3;
            this.labelMajor.Text = "Công nghệ thông tin";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelStudentId.Location = new System.Drawing.Point(120, 42);
            this.labelStudentId.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(114, 24);
            this.labelStudentId.TabIndex = 4;
            this.labelStudentId.Text = "00000000";
            // 
            // buttonRemove
            // 
            this.buttonRemove.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonRemove.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.buttonRemove.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonRemove.ImageRotate = 0F;
            this.buttonRemove.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRemove.Location = new System.Drawing.Point(947, 10);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonRemove.Size = new System.Drawing.Size(30, 80);
            this.buttonRemove.TabIndex = 5;
            // 
            // buttonChange
            // 
            this.buttonChange.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonChange.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.buttonChange.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonChange.Image = ((System.Drawing.Image)(resources.GetObject("buttonChange.Image")));
            this.buttonChange.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonChange.ImageRotate = 0F;
            this.buttonChange.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonChange.Location = new System.Drawing.Point(894, 10);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonChange.Size = new System.Drawing.Size(30, 80);
            this.buttonChange.TabIndex = 6;
            // 
            // UserAccountItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelMajor);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelFullname);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserAccountItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(987, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelMajor;
        private System.Windows.Forms.Label labelStudentId;
        private Guna.UI2.WinForms.Guna2ImageButton buttonRemove;
        private Guna.UI2.WinForms.Guna2ImageButton buttonChange;
    }
}
