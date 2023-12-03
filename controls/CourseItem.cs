using System;
using System.ComponentModel;
using System.Windows.Forms;
using vlute_course_manager.forms;

namespace vlute_course_manager.controls
{
    public partial class CourseItem : UserControl
    {
        public CourseItem()
        {
            InitializeComponent();
        }

        #region Properties
        private int _id;
        private string _courseName;
        private string _teacher;
        private bool _practice;
        private int _courseNumber;
        private int _currentMemberCount;
        private int _maxMemberCount;
        private string _subjectName;
        private string _subjectCode;
        private byte _theoryCreditCount;
        private byte _practiceCreditCount;

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
        public int courseNumber
        {
            get { return this._courseNumber; }
            set
            {
                this._courseNumber = value;
                this.labelCourseCode.Text = $"Lớp {value} - {this.getCourseType(this._practice)}";
            }
        }


        [Category("Course info")]
        public bool practice
        {
            get { return this._practice; }
            set
            {
                this._practice = value;
                this.labelCourseCode.Text = $"Lớp {this._courseNumber} - {this.getCourseType(value)}";
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
    }
}
