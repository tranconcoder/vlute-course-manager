using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vlute_course_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Properties
        private String EMPTY_USERNAME_ALERT = "Vui lòng điền tên đăng nhập.";
        private String EMPTY_PASSWORD_ALERT = "Vui lòng điền mật khẩu.";

        // Methods
        private bool emptyValidateTextBox(Guna2HtmlLabel alertElm, String value, String msg)
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
        private void frmUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.emptyValidateTextBox(
                frmUsernameAlert,
                frmUsernameTextBox.Text,
                this.EMPTY_USERNAME_ALERT
            );
        }
        // Password
        private void frmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.emptyValidateTextBox(
                frmPasswordAlert,
                frmPasswordTextBox.Text,
                this.EMPTY_PASSWORD_ALERT
            );
        }
        // Login button
        private void frmLoginButton_Click(object sender, EventArgs e)
        {
            // Username check
            bool validateUsernameResult = emptyValidateTextBox(
                frmUsernameAlert,
                frmUsernameTextBox.Text,
                EMPTY_USERNAME_ALERT
            );
            // Validate check
            bool validatePasswordResult = emptyValidateTextBox(
                frmPasswordAlert,
                frmPasswordTextBox.Text,
                EMPTY_PASSWORD_ALERT
            );

            if (validateUsernameResult && validatePasswordResult)
            {
                Hide();

                Home HomeForm = new Home();
                HomeForm.Show();
            }
        }
    }
}
