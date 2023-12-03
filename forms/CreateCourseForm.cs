using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using vlute_course_manager.controls;

namespace vlute_course_manager.forms
{
    public partial class CreateCourseForm : Form
    {
        // Authorization
        private int userId;

        private DataTable enrollSessionList;
        private DataTable majorList;
        private DataTable teacherList;
        private DataTable subjectList;
        private MySQLConnect mySQLConnect;
        private OpenFileDialog openFileDialog;
        private List<ImageItem> imageControlList;

        public CreateCourseForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;
            this.mySQLConnect = new MySQLConnect();
            this.imageControlList = new List<ImageItem>();

            // Initial open file dialog
            this.openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog.FileOk += openFileDialog_FileOK;
        }

        private void initial()
        {
            // Enroll session list
            string selectEnrollSessionQuery = "SELECT * FROM `enroll_session` ORDER BY `start_at`";
            this.enrollSessionList = this.mySQLConnect.selectQuery(selectEnrollSessionQuery);
            // Major list
            string selectMajorQuery = "SELECT * FROM `major`";
            this.majorList = this.mySQLConnect.selectQuery(selectMajorQuery);
            // Teacher list
            string selectTeacherQuery = $"SELECT * FROM `user` WHERE `role` = 'teacher'";
            this.teacherList = this.mySQLConnect.selectQuery(selectTeacherQuery);
            // Subject list
            this.subjectList = new DataTable();
        }

        private void renderUI()
        {
            // Render enroll session
            foreach (DataRow row in enrollSessionList.Rows)
            {
                EnrollSessionItem item = new EnrollSessionItem((a, b) =>
                {
                    MessageBox.Show((string)row["title"]);
                });

                item.enrollSessionId = Convert.ToInt32(row["enroll_session_id"]);
                item.enrollSessionName = (string)row["title"];
                item.dateStart = (DateTime)row["start_at"];
                item.dateCount = Convert.ToInt32(row["date_range"]);

                this.flowLayoutPanelEnrollSession.Controls.Add(item);
            }

            // Render combo box
            this.renderComboBox("---- Chọn chuyên ngành ----", this.majorList.Rows, "major_title", this.comboBoxMajor);
            this.renderComboBox("---- Chọn giảng viên ----", this.teacherList.Rows, "fullname", this.comboBoxTeacher);
            this.renderComboBox("---- Chọn môn học ----", this.subjectList.Rows, "subject_name", this.comboBoxSubject);
        }

        private void CreateCourseForm_Load(object sender, EventArgs e)
        {
            this.initial();
            this.renderUI();
        }

        #region Render UI
        private void renderComboBox(string label, DataRowCollection dataRowCollection, string rowName, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(label);
            comboBox.SelectedIndex = 0;

            foreach (DataRow item in dataRowCollection)
            {
                comboBox.Items.Add(item[rowName].ToString());
            }
        }
        private void renderImageList()
        {
            this.flowLayoutPanelImageList.Controls.Clear();

            foreach (ImageItem item in this.imageControlList)
            {
                this.flowLayoutPanelImageList.Controls.Add(item);
            }
        }

        #endregion

        #region Event
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Lỗi trong quá trình thay đổi hình ảnh!");
            }
        }

        private void openFileDialog_FileOK(object sender, EventArgs args)
        {
            // Handle add new image
            ImageItem imageItem = new ImageItem();

            imageItem.image = this.openFileDialog.FileName;
            imageItem.isEditMode = true;
            imageItem.onRemoveImage = this.imageItem_Close;

            this.imageControlList.Add(imageItem);
            this.renderImageList();
        }

        private void imageItem_Close(object sender, EventArgs args)
        {
            Guna2ImageButton removeButton = (Guna2ImageButton)sender;
            ImageItem imageItem = removeButton.GetContainerControl() as ImageItem;

            this.imageControlList.Remove(imageItem);
            this.renderImageList();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Data in control
            int selectedTeacherIndex = this.comboBoxTeacher.SelectedIndex;
            int selectedSubjectIndex = this.comboBoxSubject.SelectedIndex;

            // Data to submit
            string courseName = this.textBoxCourseName.Text;
            string courseThumb = this.imageItemThumb.image;
            string description = this.textBoxDescription.Text;
            int teacherId = Convert.ToInt32(this.teacherList.Rows[selectedTeacherIndex]["user_id"]);
            int subjectId = Convert.ToInt32(this.subjectList.Rows[selectedSubjectIndex]["subject_id"]);
            int maxMemberCount = Convert.ToInt32(this.numbericUpDownMaxMemberCount.Value);
            List<string> imageList = this.imageControlList.Select(control => control.image).ToList();

            try
            {
                // Add course info to database
                string saveCourseInfoQuery =
                    $"INSERT INTO `course`" +
                    $"(`subject_id`, `teacher_id`, `course_name`, `max_member_count`, `description`) VALUES " +
                    $"({subjectId},  {teacherId},  '{courseName}', {maxMemberCount},   '{description}')";
                int columnChangedCount = this.mySQLConnect.query(saveCourseInfoQuery);

                if (columnChangedCount == 0) throw new Exception("Xảy ra lỗi, không thể thêm khóa học!");

                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                // Handle error
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCourseName_TextChanged(object sender, EventArgs e)
        {
            bool invalid = this.textBoxCourseName.Text.Length == 0;
            this.labelCourseNameWarning.Visible = invalid;
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool invalid = this.comboBoxTeacher.SelectedIndex == 0;
            this.labelTeacherWarning.Visible = invalid;
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool invalid = this.comboBoxSubject.SelectedIndex == 0;
            this.labelSubjectWarning.Visible = invalid;
        }

        private void numbericUpDownCourseNumber_ValueChanged(object sender, EventArgs e)
        {
            // Validate dependency
            // Subject
            this.comboBoxSubject_SelectedIndexChanged(null, null);
            if (this.labelSubjectWarning.Visible) return;


            // Handle check courseNumber
            string checkCourseNumberQuery = $"SELECT COUNT(*) FROM `enroll_session`";
        }

        #endregion

        private bool validateForm()
        {
            this.textBoxCourseName_TextChanged(null, null);
            this.comboBoxTeacher_SelectedIndexChanged(null, null);
            this.comboBoxSubject_SelectedIndexChanged(null, null);

            return true;
        }

        private void comboBoxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxMajor.SelectedIndex == 0)
            {
                this.subjectList.Clear();
            }
            else
            {
                int majorId = Convert.ToInt32(this.majorList.Rows[this.comboBoxMajor.SelectedIndex - 1]["major_id"]);
                string selectSubjectQuery = $"SELECT * FROM `subject` WHERE `major_id` = {majorId}";
                this.subjectList = this.mySQLConnect.selectQuery(selectSubjectQuery);
            }

            this.renderComboBox("---- Chọn môn học ----", this.subjectList.Rows, "subject_name", this.comboBoxSubject);
        }
    }
}
