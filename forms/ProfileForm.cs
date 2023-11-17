using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vlute_course_manager.classes;

namespace vlute_course_manager
{
    public partial class ProfileForm : Form
    {
        private int userId;
        private DataRow userProfileRow;
        private MysqlConnect mysqlConnect;
        private bool fullNameValid = false;
        private bool newPasswordValid = false;
        private bool retypePasswordValid = false;

        public ProfileForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;
            this.mysqlConnect = new MysqlConnect();
        }

        private void ProfileForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // Get user profile
            DataTable dt = this.mysqlConnect.selectQuery($"call selectUserProfile({this.userId})");
            this.userProfileRow = dt.Rows[0];

            // Load default value to change
            this.pictureBoxAvatar.Image = new Bitmap((string) this.userProfileRow["avatar"]);
            this.textBoxFullname.Text = (string) this.userProfileRow["fullname"];
        }

        private void buttonChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            // Không làm gì nếu không mở được hộp thoại chọn ảnh
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            this.pictureBoxAvatar.Image = new Bitmap(openFileDialog.FileName);
        }

        private void buttonApplyChange_Click(object sender, EventArgs e)
        {
            // Validate
            bool isChangePassword = toggleSwitchChangePassword.Checked;
            this.textBoxFullname_TextChanged(null, null);

            if (isChangePassword)
            {
                this.textBoxNewPassword_TextChanged(null, null);
                this.textBoxRetypePassword_TextChanged(null, null);
            }


            // Any value invalid -> stop handle
            if (
                !this.fullNameValid || 
                (isChangePassword && (!this.newPasswordValid || !this.retypePasswordValid))
            ) return;

            if (!((string) userProfileRow["fullname"]).Equals(this.textBoxFullname.Text))
            {
                // Handle fullname
                string updateFullnameQuery = $"UPDATE `user` SET `fullname` = '{this.textBoxFullname.Text}' " +
                    $"WHERE `user_id` = {Convert.ToInt32(userProfileRow["user_id"])};";

                this.mysqlConnect.query(updateFullnameQuery);
            }

            if (isChangePassword)
            {
                try
                {
                    // Handle password
                    string getAuthDataQuery = $"SELECT `password` FROM `authenticate` WHERE `user_id` = {this.userProfileRow["user_id"]};";
                    DataTable authData = this.mysqlConnect.selectQuery(getAuthDataQuery);
                    string oldPasswordHash = (string) authData.Rows[0]["password"];
                    string newPassword = this.textBoxNewPassword.Text;

                    if (BCrypt.Net.BCrypt.Verify(this.textBoxOldPassword.Text, oldPasswordHash))
                    {
                        string newPasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
                        string updatePasswordQuery = $"UPDATE `authenticate` SET `password` = {newPasswordHash}";

                        this.mysqlConnect.query(updatePasswordQuery);
                    } else this.labelValidateOldPassword.Text = "Sai mật khẩu!";
                } catch(Exception ex)
                {
                    MessageBox.Show("Thay đổi thất bại, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxFullname_TextChanged(object sender, EventArgs e)
        {
            // Validate
            if (this.textBoxFullname.Text.Length == 0)
            {
                this.labelValidateFullname.Visible = true;
                this.fullNameValid = false;
            }
            else
            {
                this.labelValidateFullname.Visible = false;
                this.fullNameValid = true;
            }
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            Utils utils = new Utils();

            this.labelValidateNewPassword.Text = utils.checkNewPasswordSecure(this.textBoxNewPassword.Text);

            if (this.labelValidateNewPassword.Text.Length == 0)
                this.newPasswordValid = true;
            else
                this.newPasswordValid = false;
        }

        private void textBoxRetypePassword_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxRetypePassword.Text.Equals(this.textBoxNewPassword.Text))
            {
                this.labelValidateRetypePassword.Visible = true;
                this.retypePasswordValid = false;
            }
            else
            {
                this.labelValidateRetypePassword.Visible = false;
                this.retypePasswordValid = true;
            }
        }

        private void textBoxOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxOldPassword.Text.Length == 0)
                this.labelValidateOldPassword.Text = "Vui lòng nhập mật khẩu!";
            else
                this.labelValidateOldPassword.Text = "";
        }

        private void toggleSwitchChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            bool toggleChecked = this.toggleSwitchChangePassword.Checked;
            this.panelChangePassword.Visible = toggleChecked;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();       
        }
    }
}
