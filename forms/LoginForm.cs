using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Design;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;

namespace vlute_course_manager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Properties
        private readonly string EMPTY_USERNAME_ALERT = "Vui lòng điền tên đăng nhập.";
        private readonly string EMPTY_PASSWORD_ALERT = "Vui lòng điền mật khẩu.";
        private readonly string NOT_FOUND_USERNAME_ALERT = "Tài khoản không tồn tại!";
        private readonly string LOGIN_FAIL_ALERT = "Sai mật khẩu!";

        // Methods
        private bool emptyValidateTextBox(Guna2HtmlLabel alertElm, string value, string msg)
        {
            if (value.Length == 0)
            {
                alertElm.Text = msg;
                alertElm.Show();

                return false;
            }
            else
            {
                alertElm.Hide();

                return true;
            }
        }

        // Events
        // Username
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            this.labelLoginFail.Visible = false;
            this.emptyValidateTextBox(
                frmUsernameAlert,
                textBoxUsername.Text,
                this.EMPTY_USERNAME_ALERT
            );
        }
        // Password
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            this.labelLoginFail.Visible = false;
            this.emptyValidateTextBox(
                frmPasswordAlert,
                textBoxPassword.Text,
                this.EMPTY_PASSWORD_ALERT
            );
        }
        // Login button
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Username check
            bool validateUsernameResult = emptyValidateTextBox(
                frmUsernameAlert,
                textBoxUsername.Text,
                EMPTY_USERNAME_ALERT
            );
            // Validate check
            bool validatePasswordResult = emptyValidateTextBox(
                frmPasswordAlert,
                textBoxPassword.Text,
                EMPTY_PASSWORD_ALERT
            );

            if (!validateUsernameResult || !validatePasswordResult) return;

            MysqlConnect mysqlConnect = new MysqlConnect();

            string password = this.textBoxPassword.Text;
            string query = $"SELECT user_id, username, password FROM `authenticate` " +
                $"WHERE username = '{this.textBoxUsername.Text}'";
            
            DataTable dataTable = mysqlConnect.selectQuery(query);
            if (dataTable.Rows.Count == 0)
            {
                this.handleLoginFail(this.NOT_FOUND_USERNAME_ALERT);
                return;
            }

            DataRow dataRow = dataTable.Rows[0];
            if (!BCrypt.Net.BCrypt.Verify(password, (string) dataRow["password"]))
            {
                this.handleLoginFail(this.LOGIN_FAIL_ALERT);
                return;
            }

            HomeForm homeForm = new HomeForm(Convert.ToInt32(dataRow["user_id"]));
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }

        private void handleLoginFail(string message)
        {
            this.labelLoginFail.Visible = true;
            this.labelLoginFail.Text = message;
        }
   }

}
