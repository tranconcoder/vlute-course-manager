using System;
using System.Data;
using System.Windows.Forms;

namespace vlute_course_manager.forms
{
    public partial class CourseDetailForm : Form
    {
        private MySQLConnect mysqlConnect;
        private DataTable courseInfo;
        private DataTable courseImage;

        public CourseDetailForm(int courseId)
        {
            InitializeComponent();

            mysqlConnect = new MySQLConnect();

            initial(courseId);
            renderUI();
        }

        private void initial(int courseId)
        {
            courseInfo = mysqlConnect.selectQuery($"call selectCourseInfoById({courseId})");
            courseImage = mysqlConnect.selectQuery($"SELECT * FROM `course_image` WHERE `course_id` = {courseId}");
        }

        private void renderUI()
        {
        }

        private void CourseDetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
