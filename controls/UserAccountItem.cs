using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using vlute_course_manager.classes;

namespace vlute_course_manager.controls
{
    public partial class UserAccountItem : UserControl
    {
        private MySQLConnect mysqlConnect;
        private Utils utils;

        public UserAccountItem(DataRow userInfo)
        {
            InitializeComponent();

            this.mysqlConnect = new MySQLConnect();
            this.utils = new Utils();

            this.avatar = userInfo["avatar"].ToString();
            this.studentId = userInfo["student_id"].ToString();
            this.fullname = userInfo["fullname"].ToString();
            this.role = this.utils.getRoleTitle(userInfo["role"].ToString());
            string selectMajorTitleQuery = $"SELECT `major_title` FROM `major` WHERE `major_id` = {userInfo["major_id"].ToString()}";
            this.majorTitle = this.mysqlConnect.selectQueryOne(selectMajorTitleQuery)["major_title"].ToString();
        }

        private string _avatar;
        private string _studentId;
        private string _fullname;
        private string _role;
        private string _majorTitle;
        private EventHandler _onRemoveAccount;
        private EventHandler _onChangeAccount;

        [Category("Custom prop")]
        public string avatar
        {
            get { return this._avatar; }
            set
            {
                this._avatar = value;
                this.pictureBoxAvatar.Image = new Bitmap(value);
            }
        }

        [Category("Custom prop")]
        public string studentId
        {
            get { return this._studentId; }
            set
            {
                this._studentId = value;

                if (this.studentId != null) this.labelStudentId.Text = value;
                else this.labelStudentId.Text = "";
            }
        }

        [Category("Custom prop")]
        public string fullname
        {
            get { return this._fullname; }
            set
            {
                this._fullname = value;
                this.labelFullname.Text = value;
            }
        }

        [Category("Custom prop")]
        public string role
        {
            get { return this._role; }
            set
            {
                this._role = value;
                this.labelRole.Text = value;
            }
        }

        [Category("Custom prop")]
        public string majorTitle
        {
            get { return this._majorTitle; }
            set
            {
                this._majorTitle = value;
                this.labelMajor.Text = value;
            }
        }

        [Category("Custom prop")]
        public EventHandler onRemoveAccount
        {
            get { return this._onRemoveAccount; }
            set
            {
                this._onRemoveAccount = value;
                this.buttonRemove.Click += value;
            }
        }

        [Category("Custom prop")]
        public EventHandler onChangeAccount
        {
            get { return this._onChangeAccount; }
            set
            {
                this._onChangeAccount = value;
                this.buttonChange.Click += value;
            }
        }
    }
}
