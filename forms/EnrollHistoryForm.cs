using System;
using System.Data;
using System.Windows.Forms;
using vlute_course_manager.classes;
using vlute_course_manager.controls;

namespace vlute_course_manager.forms
{
    public partial class EnrollHistoryForm : Form
    {
        private Utils utils;
        private MySQLConnect mySQLConnect;
        private DataRow userInfo;
        private DataTable courseEnrollHistoryList;
        private DataTable sessionList;

        private int userId;

        public EnrollHistoryForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            mySQLConnect = new MySQLConnect();
            utils = new Utils();

            initialData(userId);
            renderCourseItem();
        }

        private void initialData(int userId)
        {
            userInfo = mySQLConnect.selectQueryOne($"SELECT * FROM `user` WHERE `user_id` = {userId}");
            if (userInfo["student_id"] == null)
            {
                MessageBox.Show("Chỉ sinh viên mới được phép đăng ký học phần!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            courseEnrollHistoryList = new DataTable();
            sessionList = mySQLConnect.selectQuery("SELECT * FROM `enroll_session` ORDER BY `start_at` DESC");

            utils.renderComboBox("---- Chọn phiên đăng ký ----", sessionList.Rows, "title", comboBoxSession);

        }

        private void renderCourseItem()
        {
            flowLayoutPanelCourseEnrolled.Controls.Clear();
            foreach (DataRow row in courseEnrollHistoryList.Rows)
            {
                CourseItem item = new CourseItem(row, userId);
                flowLayoutPanelCourseEnrolled.Controls.Add(item);
            }
        }

        private void comboBoxSession_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxSession.SelectedIndex == 0)
            {
                courseEnrollHistoryList.Clear();

                renderCourseItem();
            }
            else
            {
                int sessionId = Convert.ToInt32(sessionList.Rows[comboBoxSession.SelectedIndex - 1]["enroll_session_id"]);

                courseEnrollHistoryList = mySQLConnect.selectQuery($"call selectCourseEnrolled('{userInfo["student_id"]}', {sessionId})");

                renderCourseItem();
            }
        }

        private void EnrollHistoryForm_Paint(object sender, PaintEventArgs e)
        {
            initialData(userId);
            renderCourseItem();
        }
    }
}
