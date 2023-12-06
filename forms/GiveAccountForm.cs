using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using vlute_course_manager.classes;
using vlute_course_manager.controls;

namespace vlute_course_manager.forms
{
    public partial class GiveAccountForm : Form
    {
        private string accountType;
        private int accountIdToChange;

        private OpenFileDialog openFileDialog;
        private Utils utils;
        private MySQLConnect mySQLConnect;
        private DataTable majorList;
        private DataRow? changeUserInfo;

        public GiveAccountForm()
        {
            InitializeComponent();

            // Initial data
            this.initial();

            // Initial events
            this.initialEvent();

            // Render user interface
            this.renderUIAddMode();
        }

        private void initial()
        {
            this.openFileDialog = new OpenFileDialog();
            this.mySQLConnect = new MySQLConnect();
            this.utils = new Utils();
            this.accountType = "";

            string getMajorListQuery = "SELECT * FROM `major`";
            this.majorList = this.mySQLConnect.selectQuery(getMajorListQuery);
        }

        private void renderUIAddMode()
        {
            this.changeUserInfo = null;

            // Reset UI
            this.resetUI();

            // Render user account list
            this.renderUserAccountList();
        }

        private void renderUIChangeMode(int userId)
        {

            // Render user info
            DataRow userInfo = this.mySQLConnect.selectQueryOne($"SELECT * FROM `authenticate` " +
                $"INNER JOIN `user` ON `user`.`user_id` = `authenticate`.`user_id` " +
                $"WHERE `authenticate`.`user_id` = {userId}");
            this.changeUserInfo = userInfo;

            // Reset UI
            this.resetUI();

            // Select radio button
            List<string> radioValueList = ["student", "teacher", "admin"];
            Guna2RadioButton[] radioList = new Guna2RadioButton[3];
            radioList[0] = this.radioButtonStudent;
            radioList[1] = this.radioButtonTeacher;
            radioList[2] = this.radioButtonAdmin;
            radioList[radioValueList.FindIndex(v => v.Equals(userInfo["role"].ToString()))].Checked = true;

            // Reset textBox and picture UI
            this.textBoxUsername.Text = userInfo["username"].ToString();
            this.labelUsernameWarning.Text = "";
            this.openFileDialog.FileName = userInfo["avatar"].ToString();
            this.pictureBoxAvatar.Image = new Bitmap(this.openFileDialog.FileName);

            int i = 1;
            foreach (DataRow row in this.majorList.Rows)
            {
                if (Convert.ToInt32(row["major_id"]) == Convert.ToInt32(userInfo["major_id"]))
                {
                    this.comboBoxMajor.SelectedIndex = i;
                    break;
                }

                i++;
            }

            if (userInfo["role"].ToString().Equals("student"))
            {
                this.textBoxStudentId.Enabled = true;
                this.textBoxStudentId.Text = userInfo["student_id"].ToString();
                this.labelStudentIdWarning.Text = "";
            }
            else this.textBoxStudentId.Enabled = false;

            this.textBoxFullname.Text = userInfo["fullname"].ToString();
            this.labelFullnameWarning.Text = "";


        }

        private void initialEvent()
        {
            this.openFileDialog.FileOk += this.openFileDialog_FileOK;
        }

        private void radioButtonStudent_CheckedChanged(object sender, System.EventArgs e)
        {
            this.accountType = "student";
            this.handleChangeAccountType();
        }

        private void radioButtonTeacher_CheckedChanged(object sender, System.EventArgs e)
        {
            this.accountType = "teacher";
            this.handleChangeAccountType();
        }

        private void radioButtonAdmin_CheckedChanged(object sender, System.EventArgs e)
        {
            this.accountType = "admin";
            this.handleChangeAccountType();
        }

        private void handleChangeAccountType()
        {
            textBoxStudentId.Enabled = this.accountType.Equals("student");
            this.textBoxStudentId_TextChanged(null, null);

            if (this.accountType.Equals(""))
            {
                this.labelAccountTypeWarning.Text = "Vui lòng chọn loại tài khoản!";
            }
            else
            {
                this.labelAccountTypeWarning.Text = "";
            }
        }

        private void buttonChangeAvatar_Click(object sender, System.EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Lỗi không thể mở cửa sổ chọn tệp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileDialog_FileOK(object sender, EventArgs e)
        {
            this.pictureBoxAvatar.Image = new Bitmap(this.openFileDialog.FileName);
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxUsername.Text.Length == 0)
            {
                this.labelUsernameWarning.Text = "Vui lòng điền tên đăng nhập!";
            }
            else
            {
                string username = this.textBoxUsername.Text;
                string checkDoplicateUsernameQuery = $"SELECT COUNT(*) AS `count`, `username` FROM `authenticate` WHERE `username` = '{username}'";
                DataRow checkDouplicateUsername = this.mySQLConnect.selectQueryOne(checkDoplicateUsernameQuery);
                bool isDuplicate = Convert.ToInt32(checkDouplicateUsername["count"]) == 1;

                if (isDuplicate && (changeUserInfo == null || !changeUserInfo["username"].Equals(checkDouplicateUsername["username"])))
                {
                    this.labelUsernameWarning.Text = "Tên đăng nhập này đã được sử dụng!";
                }
                else
                {
                    this.labelUsernameWarning.Text = "";
                }
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.changeUserInfo != null && textBoxPassword.Text.Length == 0) return;

            if (textBoxPassword.Text.Length == 0)
            {
                this.labelPasswordWarning.Text = "Vui lòng nhập mật khẩu!";
            }
            else if (textBoxPassword.Text.Length < 8)
            {
                this.labelPasswordWarning.Text = "Mật khẩu phải có độ dài 8 ký tự!";
            }
            else
            {
                bool hasLower = textBoxPassword.Text.Any(c => Char.IsLower(c));
                bool hasUpper = textBoxPassword.Text.Any(c => Char.IsUpper(c));
                bool hasNumber = textBoxPassword.Text.Any(c => Char.IsNumber(c));
                bool hasSpecial = textBoxPassword.Text.Any(c => !Char.IsLetterOrDigit(c));

                if (hasLower && hasUpper && hasNumber && hasSpecial)
                {
                    this.labelPasswordWarning.Text = "";
                }
                else
                {
                    this.labelPasswordWarning.Text = "Mật khẩu phải chứa chữ thường, chữ hoa, số và ký tự đặc biệt!";
                }
            }
        }

        private void textBoxRetypePassword_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRetypePassword.Text.Equals(textBoxPassword.Text))
            {
                this.labelRetypePasswordWaring.Text = "Không khớp với mật khẩu đã nhập!";
            }
            else
            {
                this.labelRetypePasswordWaring.Text = "";
            }
        }

        private void comboBoxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMajor.SelectedIndex != 0)
            {
                this.labelMajorWarning.Text = "";
            }
            else
            {
                this.labelMajorWarning.Text = "Vui lòng chọn chuyên ngành!";
            }
        }

        private void textBoxFullname_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFullname.Text.Length != 0)
            {
                this.labelFullnameWarning.Text = "";
            }
            else
            {
                this.labelFullnameWarning.Text = "Vui lòng nhập họ tên!";
            }
        }

        private void textBoxStudentId_TextChanged(object sender, EventArgs e)
        {
            textBoxStudentId.Text = string.Join("", textBoxStudentId.Text.Where(c => Char.IsNumber(c)));
            textBoxStudentId.SelectionStart = textBoxStudentId.Text.Length;
            textBoxStudentId.SelectionLength = 0;

            // Stop if not student
            if (!this.accountType.Equals("student"))
            {
                this.labelStudentIdWarning.Text = "";
                this.textBoxStudentId.Text = "";
                return;
            }

            if (textBoxStudentId.Text.Length == 0)
            {
                this.labelStudentIdWarning.Text = "Vui lòng nhập mã số sinh viên!";
            }
            else if (textBoxStudentId.Text.Length != 8)
            {
                this.labelStudentIdWarning.Text = "Mã số sinh viên phải đủ 8 ký tự!";
            }
            else
            {
                string studentId = textBoxStudentId.Text;
                string checkDuplicateStudentIdQuery = $"SELECT COUNT(*) AS `count`, `student_id` FROM `user` WHERE `student_id` = '{studentId}'";
                DataRow checkDuplicateStudentId = this.mySQLConnect.selectQueryOne(checkDuplicateStudentIdQuery);
                bool isDuplicate = Convert.ToInt32(checkDuplicateStudentId["count"]) != 0;

                if (isDuplicate && (changeUserInfo == null || !changeUserInfo["student_id"].Equals(checkDuplicateStudentId["student_id"])))
                {
                    this.labelStudentIdWarning.Text = "Mã số sinh viên đã được sử dụng!";
                }
                else
                {
                    this.labelStudentIdWarning.Text = "";
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.validateAllField();

            if (
                this.labelAccountTypeWarning.Text.Length != 0 ||
                this.labelUsernameWarning.Text.Length != 0 ||
                this.labelPasswordWarning.Text.Length != 0 ||
                this.labelRetypePasswordWaring.Text.Length != 0 ||
                this.labelMajorWarning.Text.Length != 0 ||
                (this.accountType.Equals("student") && this.labelStudentIdWarning.Text.Length != 0) ||
                this.labelFullnameWarning.Text.Length != 0
            ) return;

            try
            {
                // Handle save authenticate info
                string username = this.textBoxUsername.Text;
                string password = this.textBoxPassword.Text;
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                string saveAccountSecureQuery = $"INSERT INTO `authenticate` (`username`, `password`) VALUES " +
                    $"('{username}', '{passwordHash}')";

                int columnChangedCountAuth = this.mySQLConnect.query(saveAccountSecureQuery);
                if (columnChangedCountAuth == 0) throw new Exception("Lỗi trong quá trình tạo tài khoản trong CSDL!");

                // Handle save user info
                int userId = Convert.ToInt32(this.mySQLConnect.selectQueryOne($"SELECT `user_id` FROM `authenticate` WHERE `username` = '{username}'")["user_id"]);
                int majorId = Convert.ToInt32(this.majorList.Rows[this.comboBoxMajor.SelectedIndex - 1]["major_id"]);
                string studentId = this.textBoxStudentId.Text;
                string studentIdQuery = studentId.Length != 0 ? $"'{studentId}'" : "null";
                string fullname = this.textBoxFullname.Text;
                string avatar = this.openFileDialog.FileName.Replace(@"\", @"\\");
                string role = this.accountType;

                string saveUserInfoQuery = $"INSERT INTO `user` (`user_id`, `major_id`, `student_id`, `fullname`, `avatar`, `role`) VALUES " +
                    $"({userId}, {majorId}, {studentIdQuery}, '{fullname}', '{avatar}', '{this.accountType}')";
                MessageBox.Show(saveUserInfoQuery);
                int columnChangedCountUser = this.mySQLConnect.query(saveUserInfoQuery);
                if (columnChangedCountUser == 0) throw new Exception("Lỗi không thể lưu thông tin người dùng!");

                // Handle successfully
                MessageBox.Show("Thêm tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.renderUIAddMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void renderUserAccountList()
        {
            string selectUserQuery = "SELECT * FROM `user`";
            DataTable userTable = this.mySQLConnect.selectQuery(selectUserQuery);

            this.flowLayoutPanelAccountList.Controls.Clear();
            foreach (DataRow row in userTable.Rows)
            {
                UserAccountItem item = new UserAccountItem(row);

                item.onRemoveAccount = (a, b) =>
                {
                    if (MessageBox.Show($"Bạn chắc chắn muốn xóa tài khoản '{row["fullname"]}' ?", "Thực hiện xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
                    {
                        return;
                    }

                    try
                    {
                        string removeAccountQuery = $"DELETE FROM `authenticate` WHERE `user_id` = {row["user_id"].ToString()}";

                        int columnRemovedCount = this.mySQLConnect.query(removeAccountQuery);

                        if (columnRemovedCount == 0) throw new Exception("Lỗi khi thực hiện xóa trong CSDL");

                        MessageBox.Show("Xóa thành công!", "Thành công!");
                        this.renderUIAddMode();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                item.onChangeAccount = (a, b) =>
                {
                    this.renderUIChangeMode(Convert.ToInt32(row["user_id"]));
                };

                this.flowLayoutPanelAccountList.Controls.Add(item);
            }
        }

        private void resetUI()
        {
            // Set visible button
            bool isChangeMode = this.changeUserInfo == null;

            this.buttonSubmit.Visible = isChangeMode;
            this.buttonChange.Visible = !isChangeMode;
            this.buttonSwitchToAddMode.Visible = !isChangeMode;

            // Reset text box and comnboBox
            this.radioButtonStudent.Checked = false;
            this.radioButtonAdmin.Checked = false;
            this.radioButtonTeacher.Checked = false;
            this.textBoxUsername.Text = "";
            this.textBoxPassword.Text = "";
            this.textBoxRetypePassword.Text = "";
            this.openFileDialog.FileName = @"D:\Workspace\.NET\vlute-course-manager\assets\images\formHome\user.png";
            this.pictureBoxAvatar.Image = new Bitmap(this.openFileDialog.FileName);
            this.textBoxStudentId.Text = "";
            this.textBoxFullname.Text = "";

            // Reset warning
            this.labelAccountTypeWarning.Text = "";
            this.labelUsernameWarning.Text = "";
            this.labelPasswordWarning.Text = "";
            this.labelStudentIdWarning.Text = "";
            this.labelFullnameWarning.Text = "";
            this.labelRetypePasswordWaring.Text = "";

            this.utils.renderComboBox("---- Chọn chuyên ngành ----", this.majorList.Rows, "major_title", this.comboBoxMajor);
            this.labelMajorWarning.Text = "";

        }

        private void buttonSwitchToAddMode_Click(object sender, EventArgs e)
        {
            this.renderUIAddMode();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            this.validateAllField();

            if (
                labelUsernameWarning.Text.Length != 0 ||
                labelPasswordWarning.Text.Length != 0 ||
                labelRetypePasswordWaring.Text.Length != 0 ||
                labelMajorWarning.Text.Length != 0 ||
                labelStudentIdWarning.Text.Length != 0 ||
                labelFullnameWarning.Text.Length != 0
            ) return;

            try
            {
                // Change user info
                string updateUserQuery = $"UPDATE `user` SET " +
                    $"`major_id` = {majorList.Rows[comboBoxMajor.SelectedIndex - 1]["major_id"]}," +
                    $"`student_id` = {(this.getRoleResult().Equals("student") ? $"'{this.textBoxStudentId.Text}'" : "NULL")}," +
                    $"`fullname` = '{this.textBoxFullname.Text}'," +
                    $"`avatar` = '{this.openFileDialog.FileName.Replace(@"\", @"\\")}'," +
                    $"`role` = '{this.getRoleResult()}' " +
                    $"WHERE `user_id` = {this.changeUserInfo["user_id"]}";

                int columnChangedCount = this.mySQLConnect.query(updateUserQuery);

                if (columnChangedCount == 0) throw new Exception("Không thể thay đổi thông tin, vui lòng thử lại!");

                // Change authenticate info
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);
                string updateAuthQuery = $"UPDATE `authenticate` SET " +
                    $"`username` = '{this.textBoxUsername.Text}'" +
                    (this.textBoxPassword.Text.Length != 0 ? $",`password` = '{passwordHash}' " : " ") +
                    $"WHERE `user_id` = {this.changeUserInfo["user_id"]}";

                int columnChangedAuthCount = this.mySQLConnect.query(updateAuthQuery);
                if (columnChangedAuthCount == 0) throw new Exception("Lỗi trong quá trình cập nhật thông tin đăng nhập!");

                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.renderUIAddMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validateAllField()
        {
            this.handleChangeAccountType();

            this.textBoxUsername_TextChanged(null, null);
            this.textBoxPassword_TextChanged(null, null);
            this.textBoxRetypePassword_TextChanged(null, null);
            this.comboBoxMajor_SelectedIndexChanged(null, null);
            this.textBoxStudentId_TextChanged(null, null);
            this.textBoxFullname_TextChanged(null, null);
        }

        private string getRoleResult()
        {
            if (radioButtonStudent.Checked) return "student";
            if (radioButtonTeacher.Checked) return "teacher";
            return "admin";
        }
    }

}
