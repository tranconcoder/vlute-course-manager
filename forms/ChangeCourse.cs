using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace vlute_course_manager.forms
{
    public partial class ChangeCourse : Form
    {
        private int courseId;
        private int sessionId;
        private int majorId;
        private int teacherId;
        private int subjectId;
        private int maxMemberCount;
        private string courseName;

        private MySQLConnect mysqlConnect;
        private DataTable sessionList;
        private DataTable majorList;
        private DataTable teacherList;
        private DataTable subjectList;

        public ChangeCourse(int courseId, int sessionId, int majorId, string courseName, int teacherId, int subjectId, int maxMemberCount)
        {
            InitializeComponent();

            mysqlConnect = new MySQLConnect();

            this.courseId = courseId;
            this.sessionId = sessionId;
            this.majorId = majorId;
            this.teacherId = teacherId;
            this.subjectId = subjectId;
            this.maxMemberCount = maxMemberCount;
            this.courseName = courseName;

            initialData();
        }

        private void initialData()
        {
            sessionList = mysqlConnect.selectQuery("SELECT * FROM `enroll_session`");
            majorList = mysqlConnect.selectQuery("SELECT * FROM `major`");
            teacherList = mysqlConnect.selectQuery("SELECT * FROM `user` WHERE `role` = 'teacher'");
            subjectList = mysqlConnect.selectQuery($"SELECT * FROM `subject`");
        }

        private void renderUI()
        {
            comboBoxEnrollSession.Items.Clear();
            foreach (DataRow row in sessionList.Rows)
                comboBoxEnrollSession.Items.Add((string)row["title"]);

            comboBoxMajor.Items.Clear();
            foreach (DataRow row in majorList.Rows)
                comboBoxMajor.Items.Add((string)row["major_title"]);

            comboBoxTeacher.Items.Clear();
            foreach (DataRow row in teacherList.Rows)
                comboBoxTeacher.Items.Add((string)row["fullname"]);

            comboBoxSubject.Items.Clear();
            foreach (DataRow row in subjectList.Rows)
                comboBoxSubject.Items.Add((string)row["subject_name"]);

            // Render data
            int sessionIndex = sessionList
                .AsEnumerable()
                .Select(x => Convert.ToInt32(x["enroll_session_id"]))
                .ToList()
                .FindIndex(x => x == sessionId);
            comboBoxEnrollSession.SelectedIndex = sessionIndex;

            int majorIndex = majorList
                .AsEnumerable()
                .Select(x => Convert.ToInt32(x["major_id"]))
                .ToList()
                .FindIndex(x => x == majorId);
            comboBoxMajor.SelectedIndex = majorIndex;

            int teacherIndex = teacherList
                .AsEnumerable()
                .Select(x => Convert.ToInt32(x["user_id"]))
                .ToList()
                .FindIndex(x => x == teacherId);
            comboBoxTeacher.SelectedIndex = teacherIndex;

            int subjectIndex = subjectList
                .AsEnumerable()
                .Select(x => Convert.ToInt32(x["subject_id"]))
                .ToList()
                .FindIndex(x => x == subjectId);
            comboBoxSubject.SelectedIndex = subjectIndex;

            textBoxCourseName.Text = courseName;
            numbericUpDownMaxMemberCount.Value = maxMemberCount;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeCourse_Load(object sender, EventArgs e)
        {
            renderUI();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            try
            {
                int sessionIndex = comboBoxEnrollSession.SelectedIndex;
                int teacherIndex = comboBoxTeacher.SelectedIndex;
                int subjectIndex = comboBoxSubject.SelectedIndex;

                string updateQ = $"UPDATE `course` SET " +
                    $"`enroll_session_id` = {sessionList.Rows[sessionIndex]["enroll_session_id"]}," +
                    $"`course_name` = '{textBoxCourseName.Text}'," +
                    $"`teacher_id` = {teacherList.Rows[teacherIndex]["user_id"]}," +
                    $"`subject_id` = {subjectList.Rows[subjectIndex]["subject_id"]}," +
                    $"`max_member_count` = {numbericUpDownMaxMemberCount.Value} " +
                    $"WHERE `course_id` = {courseId}";

                if (mysqlConnect.query(updateQ) == 0) throw new Exception("Lỗi trong quá trình cập nhật khóa học!");

                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
