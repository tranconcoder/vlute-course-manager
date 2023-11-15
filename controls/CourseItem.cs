using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vlute_course_manager.controls
{
    public partial class CourseItem : UserControl
    {
        public CourseItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _courseName;
        private string _teacher;
        private bool _practice;
        private int _courseNumber;
        private int _currentMemberCount;
        private int _maxMemberCount;
        private string _subjectName;
        private byte _theoryCreditCount;
        private byte _practiceCreditCount;

        private string getCourseType(bool practice)
        {
            return practice ? "Thực hành" : "Lý thuyết";
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
                this._courseNumber= value;
                this.labelCourseCode.Text = $"Lớp {value} - {this.getCourseType(this._practice)}";
            }
        }


        [Category("Course info")]
        public bool practice
        {
            get { return this._practice; }
            set
            {
                this._practice= value;
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
                this.labelMemberCount.Text = $"{value}/{this._maxMemberCount}";

            }
        }

        [Category("Course info")]
        public int maxMemberCount 
        {
            get { return this._maxMemberCount; }
            set
            {
                this._maxMemberCount = value;

                if (value < this._currentMemberCount)
                {
                    this.labelMemberCount.ForeColor = Color.Red;
                } else
                {
                    this.labelMemberCount.ForeColor = Color.Black;
                }

                this.labelMemberCount.Text = $"{this._currentMemberCount}/{value}";
            }
        }

        [Category("Course info")]
        public string subjectName
        {
            get { return this._subjectName; }
            set
            {
                this._subjectName = value;
                this.labelCourseSubject.Text = value;
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


    }
}
