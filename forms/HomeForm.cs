using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using vlute_course_manager.controls;
using vlute_course_manager.forms;

namespace vlute_course_manager
{
    public partial class HomeForm : Form
    {
        private DataTable sessionEnrollTable;
        private DataRow userProfileRow;
        private MySQLConnect mysqlConnect;
        private int userId;

        public HomeForm(int userId)
        {
            this.mysqlConnect = new MySQLConnect();
            this.userId = userId;

            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // Initial UI user profile
            this.initialProfile();

            string getSessionTitleListQuery = "SELECT * FROM `enroll_session` ORDER BY start_at";

            // Initial DataTable
            this.sessionEnrollTable = this.mysqlConnect.selectQuery(getSessionTitleListQuery);

            // Load UI data for comboBoxEnrollSession
            this.comboBoxEnrollSession.Items.Add("--- Chọn phiên đăng ký ---");
            this.comboBoxEnrollSession.SelectedIndex = 0;

            // Load UI data for comboBoxEnrollSession
            foreach (DataRow dr in this.sessionEnrollTable.Rows)
                this.comboBoxEnrollSession.Items.Add((string)dr["title"]);

            this.openFormOnClick(this.panelNavigateGiveAccount, (a, b) =>
            {
                this.Hide();
                GiveAccountForm giveAccountForm = new GiveAccountForm();
                giveAccountForm.ShowDialog(this);
                this.Show();
            });

            this.openFormOnClick(this.panelNavigateCreateMajor, (a, b) =>
            {
                this.Hide();
                CreateSubjectForm createSubjectForm = new CreateSubjectForm();
                createSubjectForm.ShowDialog(this);
                this.Show();
            });
            this.openFormOnClick(this.panelNavigateCreateCourse, (a, b) =>
            {
                this.Hide();
                CreateCourseForm createCourseForm = new CreateCourseForm(this.userId);
                createCourseForm.ShowDialog();
                this.Show();
            });
        }

        private void initialProfile()
        {
            string getCurrentUserProfileQuery = $"call selectUserProfile({this.userId})";
            this.userProfileRow = this.mysqlConnect.selectQuery(getCurrentUserProfileQuery).Rows[0];

            // Load UI data for userProfile
            this.pictureBoxAvatar.Image = new Bitmap((string)this.userProfileRow["avatar"]);
            this.labelFullname.Text = (string)this.userProfileRow["fullname"];
            this.labelStudentId.Text = (string)this.userProfileRow["student_id"];

            switch ((string)this.userProfileRow["role"])
            {
                case "student":
                    this.labelUserRole.Text = "SINH VIÊN";
                    break;
                case "teacher":
                    this.labelUserRole.Text = "GIẢNG VIÊN";
                    break;
                case "admin":
                    this.labelUserRole.Text = "QUẢN TRỊ VIÊN";
                    break;
            }
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
                CourseItem item = new CourseItem();
                item.courseId = Convert.ToInt32(dr["course_id"]);
                item.courseName = (string)dr["course_name"];
                item.teacher = (string)dr["teacher_fullname"];
                item.courseNumber = (int)dr["course_number"];
                item.currentMemberCount = Convert.ToInt32(dr["member_count"]);
                item.maxMemberCount = (int)dr["max_member_count"];
                item.practice = Convert.ToInt32(dr["practice"]) == 1;
                item.subjectName = (string)dr["subject_name"];
                item.subjectCode = (string)dr["subject_code"];
                item.theoryCreditCount = (byte)dr["theory_credit_count"];
                item.practiceCreditCount = (byte)dr["practice_credit_count"];

                this.flowLayoutPanelCourseList.Controls.Add(item);
            }
        }

        private void openFormOnClick(Panel panel, EventHandler cb)
        {
            panel.Click += cb;

            foreach (Control control in panel.Controls)
            {
                control.Click += cb;
            }
        }
    }
}
