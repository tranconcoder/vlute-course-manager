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
        private string _courseId;
        private string _teacher;
        private string _courseType;

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
        public string courseId
        {
            get { return this._courseId; }
            set
            {
                this._courseId = value;
                this.labelCourseId.Text = value;
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
        public string courseType
        {
            get { return this._courseType; }
            set
            {
                this._courseType = value;
                this.labelCourseType.Text = value;
            }
        }

        #endregion
    }
}
