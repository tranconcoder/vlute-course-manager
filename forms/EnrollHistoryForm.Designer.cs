namespace vlute_course_manager.forms
{
    partial class EnrollHistoryForm
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
            this.flowLayoutPanelCourseEnrolled = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxSession = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCourseEnrolled
            // 
            this.flowLayoutPanelCourseEnrolled.Location = new System.Drawing.Point(12, 253);
            this.flowLayoutPanelCourseEnrolled.Name = "flowLayoutPanelCourseEnrolled";
            this.flowLayoutPanelCourseEnrolled.Size = new System.Drawing.Size(1450, 864);
            this.flowLayoutPanelCourseEnrolled.TabIndex = 0;
            // 
            // comboBoxSession
            // 
            this.comboBoxSession.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSession.BorderRadius = 10;
            this.comboBoxSession.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSession.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSession.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSession.ItemHeight = 70;
            this.comboBoxSession.Location = new System.Drawing.Point(12, 110);
            this.comboBoxSession.Name = "comboBoxSession";
            this.comboBoxSession.Size = new System.Drawing.Size(1450, 76);
            this.comboBoxSession.TabIndex = 1;
            this.comboBoxSession.SelectedIndexChanged += new System.EventHandler(this.comboBoxSession_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(596, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "LỊCH SỬ ĐĂNG KÝ";
            // 
            // EnrollHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1474, 1129);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSession);
            this.Controls.Add(this.flowLayoutPanelCourseEnrolled);
            this.Name = "EnrollHistoryForm";
            this.Text = "Lịch sử đăng ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCourseEnrolled;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSession;
        private System.Windows.Forms.Label label2;
    }
}