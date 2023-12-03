using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace vlute_course_manager.controls
{
    public partial class ImageItem : UserControl
    {
        private OpenFileDialog openFileDialog;

        public ImageItem()
        {
            InitializeComponent();

            // Open file dialog
            this.openFileDialog = new OpenFileDialog();
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            this.openFileDialog.FileOk += openFileDialog_FileOK;

            // Initial events
            this.buttonChange.Click += this.handleChangeImage;
        }

        private string _image;
        private bool _isEditMode;
        private EventHandler _onRemoveImage;

        [Category("Image Item Property")]
        public string image
        {
            get { return this._image; }
            set
            {
                this._image = value;
                this.pictureBox.Image = new Bitmap(value);
            }
        }

        [Category("Image Item Property")]
        public bool isEditMode
        {
            get { return this._isEditMode; }
            set
            {
                this._isEditMode = value;
                this.panelToolbar.Enabled = value;
                this.panelToolbar.Visible = value;
            }
        }

        [Category("Image Item Property")]
        public EventHandler onRemoveImage
        {
            get { return this._onRemoveImage; }
            set
            {
                this._onRemoveImage = value;

                if (value != null)
                {
                    this.buttonRemove.Click += value;
                }
            }
        }

        private void handleChangeImage(object sender, EventArgs args)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show(
                    "Không thể mở cửa sổ chọn tệp!",
                    "Lỗi!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void openFileDialog_FileOK(object sender, EventArgs args)
        {
            this.image = this.openFileDialog.FileName;
        }

        private void ImageItem_Load(object sender, EventArgs e)
        {
        }
    }
}
