using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace vlute_course_manager.controls
{
    public partial class NavigationItem : UserControl
    {
        public NavigationItem()
        {
            InitializeComponent();
        }

        private void panelContainer_MouseHover(object sender, EventArgs e)
        {
            this.handleActive();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            this.handleActive();
        }

        private void panelContainer_MouseLeave(object sender, EventArgs e)
        {
            this.handleCancel();
        }
        private void panelContainer_Click(object sender, EventArgs e)
        {
            if (form == null) return;

            FindForm().Hide();
            form.ShowDialog();
            FindForm().Show();
        }

        private void handleActive()
        {
            panelContainer.FillColor = Color.FromArgb(20, 80, 163);
            labelTitle.BackColor = Color.FromArgb(20, 80, 163);
            labelTitle.ForeColor = Color.White;
            pictureBoxIcon.Image = this.imageActive;
        }
        private void handleCancel()
        {
            panelContainer.FillColor = Color.Transparent;
            labelTitle.ForeColor = Color.FromArgb(20, 80, 163);
            labelTitle.BackColor = Color.Transparent;
            pictureBoxIcon.Image = this.image;
        }

        private Image _image;
        private Image _imageActive;
        private string _title;
        private Form _form;

        [Category("Custom prop")]
        public Image image
        {
            get { return _image; }
            set
            {
                _image = value;
                pictureBoxIcon.Image = value;
            }
        }

        [Category("Custom prop")]
        public Image imageActive
        {
            get { return _imageActive; }
            set
            {
                _imageActive = value;
            }
        }

        [Category("Custom prop")]
        public string title
        {
            get { return _title; }
            set
            {
                _title = value;
                labelTitle.Text = value;
            }
        }

        public Form form
        {
            get { return _form; }
            set { _form = value; }
        }
    }
}
