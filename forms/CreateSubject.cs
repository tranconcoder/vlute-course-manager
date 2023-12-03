using System;
using System.Data;
using System.Windows.Forms;

namespace vlute_course_manager.forms
{
    public partial class CreateSubject : Form
    {
        private MySQLConnect mySqlConnect;
        private DataTable majorList;


        public CreateSubject()
        {
            InitializeComponent();

            this.mySqlConnect = new MySQLConnect();

            this.initialData();
            this.renderUI();
        }

        private void initialData()
        {
            string selectMajorQuery = $"SELECT * FROM `major`";
            this.majorList = this.mySqlConnect.selectQuery(selectMajorQuery);
        }

        private void renderUI()
        {
            // Major list
            this.comboBoxMajor.Items.Clear();
            this.comboBoxMajor.Items.Add("---- Nhập chuyên ngành ----");
            this.comboBoxMajor.SelectedIndex = 0;
            foreach (DataRow row in this.majorList.Rows)
            {
                this.comboBoxMajor.Items.Add(row["major_title"].ToString());
            }
        }

        private void textBoxSubjectName_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSubjectName.Text.Length == 0)
            {
                this.labelSubjectNameWarning.Text = "Vui lòng nhập tên môn học!";
            }
            else
            {
                this.labelSubjectNameWarning.Text = "";
            }
        }

        private void textBoxSubjectCode_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSubjectCode.Text.Length == 0)
            {
                this.labelSubjectCodeWarning.Text = "Vui lòng nhập mã môn học!";
                return;
            }

            if (this.textBoxSubjectCode.Text.Length != 6)
            {
                this.labelSubjectCodeWarning.Text = "Vui lòng điền đúng độ dài 6 ký tự!";
                return;
            }

            this.labelSubjectCodeWarning.Text = "";
        }
    }
}
