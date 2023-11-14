using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.Extensions;
using MySql.Data.MySqlClient;
using vlute_course_manager.controls;

namespace vlute_course_manager
{
    public partial class HomeForm : Form
    {
        private DataTable sessionEnrollTable;
        private MysqlConnect mysqlConnect;

        public HomeForm(int userId)
        {
            this.mysqlConnect = new MysqlConnect();

            InitializeComponent();

            this.initialEvent();
        }

        private void initialEvent()
        {
            // Panel profile/click event
            foreach (Control control in this.panelNavigateProfile.Controls)
            {
                control.Click += panelNavigationClickHandle;
            }
        }
        
        private void panelNavigationClickHandle(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void panelNavigateProfile_Click(object sender, EventArgs e)
        {
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            string getSessionTitleList = "SELECT * FROM `enroll_session` ORDER BY start_at";
            this.sessionEnrollTable = mysqlConnect.selectQuery(getSessionTitleList);

            this.comboBoxEnrollSession.Items.Add("--- Chọn phiên đăng ký ---");
            this.comboBoxEnrollSession.SelectedIndex = 0;
            this.sessionEnrollTable = this.mysqlConnect.selectQuery(getSessionTitleList);

            foreach (DataRow dr in this.sessionEnrollTable.Rows)
            {
                this.comboBoxEnrollSession.Items.Add((string) dr["title"]);
            }


            if (this.flowLayoutPanelCourseList.Controls.Count == 0)
            {
                this.flowLayoutPanelCourseList.Controls.Clear();
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = this.textBoxSearch.Text;
            int currentSessionIndex = this.comboBoxEnrollSession.SelectedIndex;

            if (currentSessionIndex == 0) return;

            // Update search value label
            this.labelSearch.Text = $"Đang tìm kiếm \"{searchValue}\"";

            // Updated list
            this.flowLayoutPanelCourseList.Controls.Clear();

            // Get search course from DB
            DataTable dt = this.mysqlConnect.selectQuery($"call searchCourse(" +
                $"  '{searchValue}'," +
                $"  {this.sessionEnrollTable.Rows[currentSessionIndex - 1]["enroll_session_id"]}" +
                $")");
            this.updateFlowLayoutData(dt);
        }

        private void comboBoxEnrollSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxEnrollSession.SelectedIndex ;

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
                item.courseName = (string) dr["course_name"];
                item.teacher = (string) dr["teacher_fullname"];
                item.courseNumber = (int) dr["course_number"];
                item.currentMemberCount = Convert.ToInt32(dr["current_member_count"]);
                item.maxMemberCount = (int) dr["max_member_count"];
                item.practice = Convert.ToInt32(dr["practice"]) == 1;

                this.flowLayoutPanelCourseList.Controls.Add(item);
            }
        }
   }
}
