namespace vlute_course_manager.controls
{
    partial class ImageItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageItem));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelToolbar = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonChange = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonRemove = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.panelToolbar);
            this.guna2Panel1.Controls.Add(this.pictureBox);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(30);
            this.guna2Panel1.Size = new System.Drawing.Size(360, 360);
            this.guna2Panel1.TabIndex = 1;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.buttonChange);
            this.panelToolbar.Controls.Add(this.buttonRemove);
            this.panelToolbar.FillColor = System.Drawing.Color.Transparent;
            this.panelToolbar.Location = new System.Drawing.Point(286, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(74, 32);
            this.panelToolbar.TabIndex = 3;
            // 
            // buttonChange
            // 
            this.buttonChange.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.buttonChange.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.buttonChange.Image = ((System.Drawing.Image)(resources.GetObject("buttonChange.Image")));
            this.buttonChange.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonChange.ImageRotate = 0F;
            this.buttonChange.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonChange.Location = new System.Drawing.Point(3, 3);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonChange.Size = new System.Drawing.Size(30, 30);
            this.buttonChange.TabIndex = 2;
            // 
            // buttonRemove
            // 
            this.buttonRemove.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonRemove.ImageRotate = 0F;
            this.buttonRemove.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonRemove.Location = new System.Drawing.Point(39, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonRemove.Size = new System.Drawing.Size(30, 30);
            this.buttonRemove.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderRadius = 10;
            this.pictureBox.FillColor = System.Drawing.Color.Transparent;
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(33, 33);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(294, 294);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ImageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ImageItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(360, 360);
            this.Load += new System.EventHandler(this.ImageItem_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton buttonRemove;
        private Guna.UI2.WinForms.Guna2ImageButton buttonChange;
        private Guna.UI2.WinForms.Guna2Panel panelToolbar;
    }
}
