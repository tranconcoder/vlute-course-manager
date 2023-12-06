using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using vlute_course_manager.classes;
using vlute_course_manager.controls;

namespace vlute_course_manager.forms
{
    public partial class CreateCourseForm : Form
    {
        // Authorization
        private Utils utils;
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

            this.utils = new Utils();
            this.mySQLConnect = new MySQLConnect();
            this.imageControlList = new List<ImageItem>();

            // Initial open file dialog
            this.openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog.FileOk += openFileDialog_FileOK;
        }

        private void initialData()
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
            // Image list
            imageControlList.Clear();
        }

        private void renderUI()
        {
            // Render enroll session
            flowLayoutPanelEnrollSession.Controls.Clear();
            foreach (DataRow row in enrollSessionList.Rows)
            {
                EnrollSessionItem item = new EnrollSessionItem((a, b) =>
                {
                    handleRemoveSession(Convert.ToInt32(row["enroll_session_id"]));
                });

                item.enrollSessionId = Convert.ToInt32(row["enroll_session_id"]);
                item.enrollSessionName = (string)row["title"];
                item.dateStart = (DateTime)row["start_at"];
                item.dateCount = Convert.ToInt32(row["date_range"]);

                flowLayoutPanelEnrollSession.Controls.Add(item);
            }

            // Render combo box
            utils.renderComboBox("---- Chọn học kỳ ----", enrollSessionList.Rows, "title", comboBoxEnrollSession);
            utils.renderComboBox("---- Chọn chuyên ngành ----", majorList.Rows, "major_title", comboBoxMajor);
            utils.renderComboBox("---- Chọn giảng viên ----", teacherList.Rows, "fullname", comboBoxTeacher);
            utils.renderComboBox("---- Chọn môn học ----", subjectList.Rows, "subject_name", comboBoxSubject);

            // Reset textBox
            textBoxSessionName.Text = "";
            numericUpDownDateRange.Value = 1;
            numbericUpDownMaxMemberCount.Value = 30;
            textBoxCourseName.Text = "";

            // Reset validate label
            labelSessionWarning.Text = "";
            labelEnrollSessionWarning.Text = "";
            labelMajorWarning.Text = "";
            labelCourseNameWarning.Text = "";
            labelTeacherWarning.Text = "";
            labelSubjectWarning.Text = "";

            // Image list
            renderImageList();
        }

        private void CreateCourseForm_Load(object sender, EventArgs e)
        {
            this.initialData();
            this.renderUI();
        }

        #region Render UI
        private void renderImageList()
        {
            flowLayoutPanelImageList.Controls.Clear();

            foreach (ImageItem item in imageControlList)
            {
                flowLayoutPanelImageList.Controls.Add(item);
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
            // Validate
            validateForm();
            if (!getValidateResult()) return;

            // Data in control
            int selectedTeacherIndex = this.comboBoxTeacher.SelectedIndex;
            int selectedSubjectIndex = this.comboBoxSubject.SelectedIndex;
            int selectedEnrollSessionIndex = this.comboBoxEnrollSession.SelectedIndex;

            // Data to submit
            string courseName = this.textBoxCourseName.Text;
            string courseThumb = this.imageItemThumb.image;
            string description = this.textBoxDescription.Text;
            int enrollSessionId = Convert.ToInt32(enrollSessionList.Rows[selectedEnrollSessionIndex - 1]["enroll_session_id"]);
            int teacherId = Convert.ToInt32(this.teacherList.Rows[selectedTeacherIndex - 1]["user_id"]);
            int subjectId = Convert.ToInt32(this.subjectList.Rows[selectedSubjectIndex - 1]["subject_id"]);
            int maxMemberCount = Convert.ToInt32(this.numbericUpDownMaxMemberCount.Value);
            List<string> imageList = imageControlList.Select(control => control.image).ToList();
            imageList.Insert(0, courseThumb);

            try
            {
                // Add course info to database
                string saveCourseInfoQuery =
                    $"INSERT INTO `course`" +
                    $"(`subject_id`, `enroll_session_id`, `teacher_id`, `course_name`, `max_member_count`, `description`) VALUES " +
                    $"({subjectId},  {enrollSessionId},  {teacherId},  '{courseName}', {maxMemberCount},   '{description}')";
                int columnChangedCount = this.mySQLConnect.query(saveCourseInfoQuery);
                if (columnChangedCount == 0) throw new Exception("Xảy ra lỗi, không thể thêm khóa học!");

                int newCourseId = Convert.ToInt32(mySQLConnect.selectQueryOne("SELECT LAST_INSERT_ID() AS `course_id`")["course_id"]);
                List<string> imageListQ = imageList.Select((image, index) => $"({newCourseId} ,'{image}', {index})").ToList();
                MessageBox.Show(newCourseId.ToString());

                string saveImageListQ = $"INSERT INTO `course_image`" +
                    $"(`course_id`, `image_path`, `image_order`) VALUES " +
                    String.Join(",", imageListQ);
                int columnChangedCountImage = mySQLConnect.query(saveImageListQ);
                if (columnChangedCountImage == 0) throw new Exception("Xảy ra lỗi, không thể thêm Hình ảnh của khóa học!");

                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initialData();
                renderUI();
            }
            catch (Exception ex)
            {
                // Handle error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCourseName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCourseName.Text.Length == 0)
                labelCourseNameWarning.Text = "Vui lòng nhập tên lớp học phần!";
            else
            {
                if (comboBoxEnrollSession.SelectedIndex == 0)
                {
                    labelCourseNameWarning.Text = "";
                    return;
                }

                string courseName = textBoxCourseName.Text;
                string checkDupQuery = $"SELECT COUNT(*) AS `count` FROM `course`" +
                    $"WHERE `enroll_session_id` = {enrollSessionList.Rows[comboBoxEnrollSession.SelectedIndex - 1]["enroll_session_id"]} " +
                    $"AND `course_name` = '{courseName}'";

                if (Convert.ToInt32(mySQLConnect.selectQueryOne(checkDupQuery)["count"]) != 0)
                {
                    labelCourseNameWarning.Text = "Tên đã được dùng trong đợt đăng ký này!";
                }
                else labelCourseNameWarning.Text = "";
            }
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTeacher.SelectedIndex == 0)
                labelTeacherWarning.Text = "Vui lòng chọn giảng viên!";
            else
                labelTeacherWarning.Text = "";
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubject.SelectedIndex == 0)
                labelSubjectWarning.Text = "Vui lòng chọn môn học!";
            else
                labelSubjectWarning.Text = "";
        }

        #endregion

        private void comboBoxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleValidateMajorInput(true);
        }

        private void comboBoxEnrollSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEnrollSession.SelectedIndex == 0)
                labelEnrollSessionWarning.Text = "Vui lòng chọn học kỳ!";
            else
                labelEnrollSessionWarning.Text = "";
        }

        private void textBoxSessionName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSessionName.Text.Length == 0)
                labelSessionWarning.Text = "Vui lòng nhập tên phiên mới!";
            else
            {
                string sessionName = textBoxSessionName.Text;
                string checkDuplicateSessionName = $"SELECT COUNT(*) AS `count` FROM `enroll_session` WHERE `title` = '{sessionName}'";

                if (Convert.ToInt32(mySQLConnect.selectQueryOne(checkDuplicateSessionName)["count"]) != 0)
                    labelSessionWarning.Text = "Tên phiên đã được sử dụng!";
                else
                    labelSessionWarning.Text = "";
            }
        }

        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            textBoxSessionName_TextChanged(null, null);
            if (labelSessionWarning.Text.Length != 0) return;

            try
            {
                string sessionName = textBoxSessionName.Text;
                string dateStartStr = dateTimePickerStart.Value.ToString("yyyy-MM-dd");
                int dateRange = ((int)numericUpDownDateRange.Value);

                string addSessionQuery = $"INSERT INTO `enroll_session`" +
                    $"(`title`, `start_at`, `date_range`) VALUES " +
                    $"('{sessionName}', '{dateStartStr}', {dateRange})";

                if (mySQLConnect.query(addSessionQuery) == 0) throw new Exception("Không thể thực hiện thêm phiên, vui lòng thử lại!");

                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initialData();
                renderUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool getValidateResult()
        {
            return (
                labelEnrollSessionWarning.Text.Length == 0 &&
                labelMajorWarning.Text.Length == 0 &&
                labelCourseNameWarning.Text.Length == 0 &&
                labelTeacherWarning.Text.Length == 0 &&
                labelSubjectWarning.Text.Length == 0
            );
        }
        private void validateForm()
        {
            comboBoxEnrollSession_SelectedIndexChanged(null, null);
            handleValidateMajorInput(false);
            textBoxCourseName_TextChanged(null, null);
            comboBoxTeacher_SelectedIndexChanged(null, null);
            comboBoxSubject_SelectedIndexChanged(null, null);
        }
        private void handleValidateMajorInput(bool updateSubjectAndTeacher)
        {
            if (this.comboBoxMajor.SelectedIndex == 0)
            {
                if (updateSubjectAndTeacher)
                {
                    subjectList.Clear();
                    teacherList.Clear();
                }
                labelMajorWarning.Text = "Vui lòng chọn chuyên ngành!";
            }
            else
            {
                if (updateSubjectAndTeacher)
                {
                    int majorId = Convert.ToInt32(this.majorList.Rows[this.comboBoxMajor.SelectedIndex - 1]["major_id"]);
                    string selectSubjectQuery = $"SELECT * FROM `subject` WHERE `major_id` = {majorId}";
                    string selectTeacherQ = $"call selectTeacherInMajor({majorId})";

                    subjectList = mySQLConnect.selectQuery(selectSubjectQuery);
                    teacherList = mySQLConnect.selectQuery(selectTeacherQ);

                    utils.renderComboBox("---- Chọn môn học ----", this.subjectList.Rows, "subject_name", this.comboBoxSubject);
                    utils.renderComboBox("---- Chọn giảng viên ----", teacherList.Rows, "fullname", comboBoxTeacher);
                }

                labelMajorWarning.Text = "";
            }
        }

        private void handleRemoveSession(int sessionId)
        {
            string removeSessionQuery = $"DELETE FROM `enroll_session` WHERE `enroll_session_id` = {sessionId}";

            if (mySQLConnect.query(removeSessionQuery) == 0)
                MessageBox.Show("Xóa thất bại, vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initialData();
                renderUI();
            }
        }
        private void CreateCourseForm_Paint(object sender, PaintEventArgs e)
        {
            initialData();
            renderUI();
        }
    }
}
