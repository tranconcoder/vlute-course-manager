using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using vlute_course_manager.classes;

namespace vlute_course_manager
{
    public partial class ProfileForm : Form
    {
        private int userId;
        private DataRow userProfileRow;
        private MySQLConnect mysqlConnect;
        private OpenFileDialog openFileDialog;

        public ProfileForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            this.mysqlConnect = new MySQLConnect();

            this.openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog.FileOk += openFileDialog_FileOK;
        }

        private void setValidateLabelText(Label label, String text)
        {
            if (text.Length == 0)
            {
                label.Visible = false;
            }
            else
            {
                label.Visible = true;
                label.Text = text;
            }
        }

        private bool validateFullname()
        {
            if (this.textBoxFullname.Text.Length == 0)
            {
                this.setValidateLabelText(this.labelValidateFullname, "Vui lòng nhập họ tên!");
                return true;
            }

            this.setValidateLabelText(this.labelValidateFullname, "");
            return false;
        }

        private bool validateOldPassword()
        {
            if (this.textBoxOldPassword.Text.Length == 0)
            {
                this.setValidateLabelText(this.labelValidateOldPassword, "Vui lòng nhập mật khẩu cũ!");
                return true;
            }

            this.setValidateLabelText(this.labelValidateOldPassword, "");
            return false;
        }

        private bool validateNewPassword()
        {
            Utils utils = new Utils();

            string errorMessageResult = utils.checkNewPasswordSecure(this.textBoxNewPassword.Text) ?? "";

            this.setValidateLabelText(this.labelValidateNewPassword, errorMessageResult);

            return errorMessageResult.Length != 0;
        }

        private bool validateRetypePassword()
        {
            string newPasswordValue = this.textBoxNewPassword.Text;
            string retypePasswordValue = this.textBoxRetypePassword.Text;

            if (retypePasswordValue.Length == 0)
            {
                this.setValidateLabelText(this.labelValidateRetypePassword, "Vui lòng nhập lại mật khẩu mới!");
                return true;
            }

            if (!retypePasswordValue.Equals(newPasswordValue))
            {
                this.setValidateLabelText(this.labelValidateRetypePassword, "Không khớp với mật khẩu mới!");
                return true;
            }

            this.setValidateLabelText(this.labelValidateRetypePassword, "");
            return false;
        }

        private void resetForm()
        {
            string selectUserQuery = $"call selectUserProfile({this.userId})";
            this.userProfileRow = this.mysqlConnect.selectQuery(selectUserQuery).Rows[0];

            this.textBoxFullname.Focus();

            // Textbox
            this.textBoxFullname.Text = (string)userProfileRow["fullname"];
            this.textBoxOldPassword.Text = "";
            this.textBoxNewPassword.Text = "";
            this.textBoxRetypePassword.Text = "";

            // Label validate
            this.labelValidateFullname.Visible = false;
            this.labelValidateOldPassword.Visible = false;
            this.labelValidateNewPassword.Visible = false;
            this.labelValidateRetypePassword.Visible = false;
        }

        private void handleSuccess()
        {
            MessageBox.Show("Thay đổi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.resetForm();
        }

        #region Events
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // Get user profile
            DataTable dt = this.mysqlConnect.selectQuery($"call selectUserProfile({this.userId})");
            this.userProfileRow = dt.Rows[0];

            // Load default value to change
            this.pictureBoxAvatar.Image = new Bitmap((string)this.userProfileRow["avatar"]);
            this.textBoxFullname.Text = (string)this.userProfileRow["fullname"];
        }

        private void buttonChangeAvatar_Click(object sender, EventArgs e)
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

        private void buttonApplyChange_Click(object sender, EventArgs e)
        {
            bool isChangePassword = toggleSwitchChangePassword.Checked;
            int userId = Convert.ToInt32(userProfileRow["user_id"]);

            // Validate
            if (this.validateFullname()) return;
            if (isChangePassword)
            {
                if (this.validateOldPassword()) return;
                if (this.validateNewPassword()) return;
                if (this.validateRetypePassword()) return;
            }


            try
            {
                // Handle fullname and avatar
                string newAvatar = (string)this.openFileDialog.FileName;
                string newAvatarFormat = newAvatar.Replace(@"\", @"\\");

                string oldFullname = (string)userProfileRow["fullname"];
                string newFullname = this.textBoxFullname.Text;

                string updateColumnQuery = "";

                bool isChangeFullname = !oldFullname.Equals(newFullname);
                bool isChangeAvatar = newAvatar.Length != 0;

                if (isChangeFullname) updateColumnQuery += $" `fullname` = '{newFullname}' ";
                if (isChangeAvatar && isChangeFullname) updateColumnQuery += $",";
                if (isChangeAvatar) updateColumnQuery += $" `avatar` = '{newAvatarFormat}' ";
                if (updateColumnQuery.Length != 0)
                {
                    string updateFullnameQuery = $"UPDATE `user` SET" +
                        updateColumnQuery +
                        $"WHERE `user_id` = {userId}";
                    this.mysqlConnect.query(updateFullnameQuery);
                }

                if (!isChangePassword)
                {
                    this.handleSuccess();
                }
                else
                {
                    // Handle password
                    string getAuthDataQuery = $"SELECT `password` " +
                        $"FROM `authenticate` " +
                        $"WHERE `user_id` = {userId};";
                    DataTable authData = this.mysqlConnect.selectQuery(getAuthDataQuery);

                    string oldPasswordHash = (string)authData.Rows[0]["password"];
                    string newPassword = this.textBoxNewPassword.Text;

                    if (BCrypt.Net.BCrypt.Verify(this.textBoxOldPassword.Text, oldPasswordHash))
                    {
                        string newPasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
                        string updatePasswordQuery = $"UPDATE `authenticate` " +
                            $"SET `password` = '{newPasswordHash}' " +
                            $"WHERE `user_id` = {userId}";

                        this.mysqlConnect.query(updatePasswordQuery);
                        this.setValidateLabelText(this.labelValidateOldPassword, "");
                        this.handleSuccess();
                    }
                    else
                    {
                        this.setValidateLabelText(this.labelValidateOldPassword, "Sai mật khẩu!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxFullname_TextChanged(object sender, EventArgs e)
        {
            this.validateFullname();
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            this.validateNewPassword();
            this.validateRetypePassword();
        }

        private void textBoxRetypePassword_TextChanged(object sender, EventArgs e)
        {
            this.validateNewPassword();
            this.validateRetypePassword();
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

        private void textBoxOldPassword_TextChanged(object sender, EventArgs e)
        {
            this.validateOldPassword();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }

        private void openFileDialog_FileOK(object sender, EventArgs e)
        {
            this.pictureBoxAvatar.Image = new Bitmap(openFileDialog.FileName);
        }

        #endregion

        private void ProfileForm_Paint(object sender, PaintEventArgs e)
        {
            resetForm();
        }
    }
}
