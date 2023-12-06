using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using vlute_course_manager.forms;

namespace vlute_course_manager.controls
{
    public partial class CourseItem : UserControl
    {
        private DataRow userInfo;
        private DataRow courseInfo;
        private MySQLConnect mysqlConnect;

        public CourseItem(DataRow courseInfo, int userId)
        {
            InitializeComponent();

            this.courseInfo = courseInfo;
            mysqlConnect = new MySQLConnect();
            userInfo = mysqlConnect.selectQueryOne($"SELECT * FROM `user` WHERE `user_id` = {userId}");
            initialData();
            updateUI();
        }

        private void initialData()
        {
            courseId = Convert.ToInt32(courseInfo["course_id"]);
            courseName = (string)courseInfo["course_name"];
            teacher = (string)courseInfo["teacher_fullname"];
            currentMemberCount = Convert.ToInt32(courseInfo["member_count"]);
            maxMemberCount = (int)courseInfo["max_member_count"];
            practice = Convert.ToInt32(courseInfo["practice"]) == 1;
            subjectName = (string)courseInfo["subject_name"];
            subjectCode = (string)courseInfo["subject_code"];
            theoryCreditCount = (byte)courseInfo["theory_credit_count"];
            practiceCreditCount = (byte)courseInfo["practice_credit_count"];
            studentId = userInfo["student_id"].ToString();
        }

        #region Properties
        private int _id;
        private string _courseName;
        private string _teacher;
        private bool _practice;
        private int _currentMemberCount;
        private int _maxMemberCount;
        private string _subjectName;
        private string _subjectCode;
        private byte _theoryCreditCount;
        private byte _practiceCreditCount;
        private string _studentId;
        private string _thumb;

        private string getCourseType(bool practice)
        {
            return practice ? "Thực hành" : "Lý thuyết";
        }

        [Category("Course info")]
        public int courseId
        {
            get { return this._id; }
            set { this._id = value; }
        }

        [Category("Course info")]
        public string courseName
        {
            get { return this._courseName; }
            set
            {
                this._courseName = value;
                this.labelCourseName.Text = value;
            }
        }

        [Category("Course info")]
        public string teacher
        {
            get { return this._teacher; }
            set
            {
                this._teacher = value;
                this.labelTeacher.Text = value;
            }
        }

        [Category("Course info")]
        public bool practice
        {
            get { return this._practice; }
            set
            {
                this._practice = value;
                this.labelCourseCode.Text = $"Lớp {this.getCourseType(value)}";
            }
        }

        [Category("Course info")]
        public int currentMemberCount
        {
            get { return this._currentMemberCount; }
            set
            {
                this._currentMemberCount = value;
                this.updateUIMemberCount(value, this.maxMemberCount);
            }
        }

        [Category("Course info")]
        public int maxMemberCount
        {
            get { return this._maxMemberCount; }
            set
            {
                this._maxMemberCount = value;
                this.updateUIMemberCount(this.currentMemberCount, value);
            }
        }

        [Category("Course info")]
        public string subjectName
        {
            get { return this._subjectName; }
            set
            {
                this._subjectName = value;
                this.labelCourseSubject.Text = $"{this.subjectCode} - {this.subjectName}";
            }
        }

        [Category("Course info")]
        public string subjectCode
        {
            get { return this._subjectCode; }
            set
            {
                this._subjectCode = value;
                this.labelCourseSubject.Text = $"{this.subjectCode} - {this.subjectName}";
            }
        }


        [Category("Course info")]
        public byte theoryCreditCount
        {
            get { return this._theoryCreditCount; }
            set
            {
                this._theoryCreditCount = value;
                this.labelCourseCreditCount.Text = $"LT: {value}\tTH: {this._practiceCreditCount}";
            }
        }


        [Category("Course info")]
        public byte practiceCreditCount
        {
            get { return this._practiceCreditCount; }
            set
            {
                this._practiceCreditCount = value;
                this.labelCourseCreditCount.Text = $"LT: {this._theoryCreditCount}\tTH: {value}";
            }
        }

        [Category("Course info")]
        public string studentId
        {
            get { return _studentId; }
            set
            {
                _studentId = value;

                updateUI();
            }
        }

        #endregion

        private void buttonViewCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseDetailForm courseDetailForm = new CourseDetailForm(this.courseId);
            courseDetailForm.ShowDialog();
            this.Show();
        }

        private void updateUIMemberCount(int currentMemberCount, int maxMemberCount)
        {
            if (currentMemberCount >= maxMemberCount)
            {
                this.progressBarMemberCount.Text = $"{currentMemberCount}/{maxMemberCount}";
                this.labelMemberCountWarning.Text = "Đã đầy";
            }
            else
            {
                this.progressBarMemberCount.Text = $"{currentMemberCount}/{maxMemberCount}";
                this.labelMemberCountWarning.Text = "";
            }

            // Update progress bar
            this.progressBarMemberCount.Maximum = maxMemberCount;
            this.progressBarMemberCount.Value = currentMemberCount;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Hide();
            new ChangeCourse(
                Convert.ToInt32(courseInfo["course_id"]),
                Convert.ToInt32(courseInfo["enroll_session_id"]),
                Convert.ToInt32(courseInfo["major_id"]),
                (string)courseInfo["course_name"],
                Convert.ToInt32(courseInfo["teacher_id"]),
                Convert.ToInt32(courseInfo["subject_id"]),
                Convert.ToInt32(courseInfo["max_member_count"])
            ).ShowDialog();
            Show();
        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            if (buttonEnroll.FillColor == Color.Orange)
            {
                // Handle remove admit
                string deleteQ = $"DELETE FROM `course_enroll`" +
                    $"WHERE `course_id` = {courseId} AND `student_id` = '{studentId}'";
                if (mysqlConnect.query(deleteQ) == 0)
                {
                    MessageBox.Show("Hủy thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Hủy thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateUI();
                }
            }
            else
            {
                // Handle admit
                if (getMemCount() >= maxMemberCount)
                {
                    MessageBox.Show("Lớp học đã đầy!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string enrollQ = $"INSERT INTO `course_enroll`" +
                    $"(`course_id`, `student_id`) VALUES " +
                    $"({courseId}, '{studentId}')";

                try
                {
                    if (mysqlConnect.query(enrollQ) == 0) throw new Exception("Không thể ghi danh!");

                    MessageBox.Show("Ghi danh thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateUI();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mysqlConnect.CloseConnection();
                }
            }

        }

        private void updateUI()
        {
            bool isAdmin = userInfo["role"].Equals("admin");

            buttonChange.Visible = isAdmin;
            buttonRemove.Visible = isAdmin;
            buttonEnroll.Enabled = !String.IsNullOrEmpty(studentId);

            string enrollCheckQ = $"SELECT COUNT(*) AS `count` FROM `course_enroll`" +
                $"WHERE `course_id` = {courseId} AND `student_id` = '{studentId}'";
            MySQLConnect mySQLConnect = new MySQLConnect();
            if (Convert.ToInt32(mySQLConnect.selectQueryOne(enrollCheckQ)["count"]) != 0)
            {
                // Handle enrolled
                buttonEnroll.Text = "Hủy Đ.ký";
                buttonEnroll.FillColor = Color.Orange;
            }
            else
            {
                // Handle not enroll
                buttonEnroll.Text = "Đăng ký";
                buttonEnroll.FillColor = Color.FromArgb(94, 148, 255);
            }

            currentMemberCount = getMemCount();
        }

        private int getMemCount()
        {
            string enrollCountQ = "SELECT COUNT(*) AS `count` FROM `course_enroll`" +
                $"INNER JOIN `course` ON `course`.`course_id` = `course_enroll`.`course_id`" +
                $"WHERE `enroll_session_id` = {courseInfo["enroll_session_id"]} AND `course`.`course_id` = {courseId}";

            return Convert.ToInt32(mysqlConnect.selectQueryOne(enrollCountQ)["count"]);
        }
    }
}
