namespace vlute_course_manager.controls
{
    partial class NavigationItem
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
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BorderRadius = 10;
            this.panelContainer.Controls.Add(this.pictureBoxIcon);
            this.panelContainer.FillColor = System.Drawing.Color.Transparent;
            this.panelContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(163)))));
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(412, 70);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Click += new System.EventHandler(this.panelContainer_Click);
            this.panelContainer.MouseLeave += new System.EventHandler(this.panelContainer_MouseLeave);
            this.panelContainer.MouseHover += new System.EventHandler(this.panelContainer_MouseHover);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.Image = global::vlute_course_manager.Properties.Resources.profile;
            this.pictureBoxIcon.ImageRotate = 0F;
            this.pictureBoxIcon.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 1;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.Click += new System.EventHandler(this.panelContainer_Click);
            this.pictureBoxIcon.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(163)))));
            this.labelTitle.Location = new System.Drawing.Point(80, 25);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(101, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Trang chủ";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.panelContainer_Click);
            this.labelTitle.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // NavigationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NavigationItem";
            this.Size = new System.Drawing.Size(412, 70);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelTitle;
    }
}
