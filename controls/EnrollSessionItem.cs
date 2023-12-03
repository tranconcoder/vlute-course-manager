using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace vlute_course_manager.controls
{
    public partial class EnrollSessionItem : UserControl
    {
        public EnrollSessionItem(EventHandler ClickDeleteButton)
        {
            InitializeComponent();

            this.buttonDelete.Click += ClickDeleteButton;
        }

        private int _courseSessionId;
        private string _courseSessionName;
        private DateTime _dateStart;
        private int _dateCount;

        [Category("Course session info")]
        public int enrollSessionId
        {
            get { return this._courseSessionId; }
            set { this._courseSessionId = value; }
        }

        [Category("Course session info")]
        public string enrollSessionName
        {
            get { return this._courseSessionName; }
            set
            {
                this.labelCourseSessionName.Text = value;
                this._courseSessionName = value;
            }
        }

        [Category("Course session info")]
        public DateTime dateStart
        {
            get { return this._dateStart; }
            set
            {
                DateTime dateEnd = value.AddDays(this.dateCount);

                this._dateStart = value;
                this.labelCourseSessionDate.Text = getDateLabelContent(value, dateEnd);
            }
        }

        [Category("Course session info")]
        public int dateCount
        {
            get { return this._dateCount; }
            set
            {
                DateTime dateEnd = this.dateStart.AddDays(value);

                this._dateCount = value;
                this.labelCourseSessionDate.Text = getDateLabelContent(this.dateStart, dateEnd);
            }
        }

        private string getDateLabelContent(DateTime dateStart, DateTime dateEnd)
        {
            return $"{dateStart.ToString("dd/MM/yyyy")} - {dateEnd.ToString("dd/MM/yyyy")}";
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
