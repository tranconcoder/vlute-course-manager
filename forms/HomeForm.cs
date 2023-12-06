using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using vlute_course_manager.classes;
using vlute_course_manager.controls;
using vlute_course_manager.forms;

namespace vlute_course_manager
{
    public partial class HomeForm : Form
    {
        private Utils utils;
        private DataTable sessionEnrollTable;
        private DataRow userProfileRow;
        private MySQLConnect mysqlConnect;
        public int userId;

        public HomeForm(int userId)
        {
            utils = new Utils();
            mysqlConnect = new MySQLConnect();
            this.userId = userId;

            InitializeComponent();

            navigationItemProfile.form = new ProfileForm(userId);
            navigationItemGiveAccount.form = new GiveAccountForm();
            navigationItemCreateMajor.form = new CreateMajorForm();
            navigationItemCreateSubject.form = new CreateSubjectForm();
            navigationItemCreateCourse.form = new CreateCourseForm(userId);
            navigationItemEnrollHistory.form = new EnrollHistoryForm(userId);
        }

        private void initial()
        {
            string getCurrentUserProfileQuery = $"call selectUserProfile({userId})";
            userProfileRow = mysqlConnect.selectQueryOne(getCurrentUserProfileQuery);

            string getSessionTitleListQuery = "SELECT * FROM `enroll_session` ORDER BY start_at";
            sessionEnrollTable = mysqlConnect.selectQuery(getSessionTitleListQuery);
        }

        private void renderUI()
        {
            // Load UI data for userProfile
            this.pictureBoxAvatar.Image = new Bitmap((string)this.userProfileRow["avatar"]);
            this.labelFullname.Text = (string)this.userProfileRow["fullname"];
            this.labelStudentId.Text = this.userProfileRow["student_id"].ToString();

            switch ((string)this.userProfileRow["role"])
            {
                case "student":
                    this.labelUserRole.Text = "SINH VIÊN";
                    break;
                case "teacher":
                    this.labelUserRole.Text = "GIẢNG VIÊN";
                    panelTeacher.Enabled = true;
                    break;
                case "admin":
                    this.labelUserRole.Text = "QUẢN TRỊ VIÊN";
                    panelAdmin.Enabled = true;
                    panelTeacher.Enabled = true;
                    break;
            }

            utils.renderComboBox("---- Chọn phiên đăng ký ----", sessionEnrollTable.Rows, "title", comboBoxEnrollSession);

            buttonSearch_Click(null, null);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            initial();
            renderUI();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = this.textBoxSearch.Text;
            int currentSessionIndex = this.comboBoxEnrollSession.SelectedIndex;

            if (currentSessionIndex == 0) return;

            // Update search value label
            if (textBoxSearch.Text.Length == 0)
            {
                this.labelSearch.Text = "";
            }
            else
            {
                this.labelSearch.Text = $"Đang tìm kiếm \"{searchValue}\"";
            }

            // Updated list
            this.flowLayoutPanelCourseList.Controls.Clear();

            // Get search course from DB
            DataTable dt = this.mysqlConnect.selectQuery($"call searchCourse(" +
                $"  '{searchValue}'," +
                $"  {this.sessionEnrollTable.Rows[currentSessionIndex - 1]["enroll_session_id"]}" +
                $")");

            this.updateFlowLayoutData(dt);

            // Focus to textboxSearch
            this.textBoxSearch.Focus();
        }

        private void comboBoxEnrollSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxEnrollSession.SelectedIndex;

            if (index == 0)
            {
                this.flowLayoutPanelCourseList.Controls.Clear();
                return;
            }

            // [index -1] Để khớp với index của mảng sessionEnrollTable
            DataRow currentSessionRow = this.sessionEnrollTable.Rows[index - 1];
            string getAllCourseQuery = $"call searchCourse(" +
                $"'{this.textBoxSearch.Text}', " +
                $"{currentSessionRow["enroll_session_id"]});";

            DataTable courseListTable = this.mysqlConnect.selectQuery(getAllCourseQuery);
            this.updateFlowLayoutData(courseListTable);
        }

        private void updateFlowLayoutData(DataTable dt)
        {
            this.flowLayoutPanelCourseList.Controls.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                CourseItem item = new CourseItem(dr, Convert.ToInt32(userProfileRow["user_id"]));
                this.flowLayoutPanelCourseList.Controls.Add(item);
            }
        }

        private void HomeForm_Paint(object sender, PaintEventArgs e)
        {
            initial();
            renderUI();
        }
    }
}
