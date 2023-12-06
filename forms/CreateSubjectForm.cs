using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace vlute_course_manager.forms
{
    public partial class CreateSubjectForm : Form
    {
        private DataRow? subjectToChange;
        private MySQLConnect mySqlConnect;
        private DataTable majorList;
        private DataTable subjectList;


        public CreateSubjectForm()
        {
            InitializeComponent();

            this.mySqlConnect = new MySQLConnect();
            this.subjectToChange = null;

            this.initialData();
            this.renderUI();
        }

        private void initialData()
        {
            string selectMajorQuery = $"SELECT * FROM `major`";
            this.majorList = this.mySqlConnect.selectQuery(selectMajorQuery);

            string selectSubject = $"SELECT * FROM `subject`";
            this.subjectList = this.mySqlConnect.selectQuery(selectSubject);
        }

        private void renderUI()
        {
            this.subjectToChange = null;
            this.resetUI();

            // Major list
            this.comboBoxMajor.Items.Clear();
            this.comboBoxMajor.Items.Add("---- Tất cả chuyên ngành ----");
            this.comboBoxMajor.SelectedIndex = 0;
            foreach (DataRow row in this.majorList.Rows)
            {
                this.comboBoxMajor.Items.Add(row["major_title"].ToString());
            }


            // Subject list
            this.dataGridViewSubject.Rows.Clear();
            int index = 1;
            foreach (DataRow row in this.subjectList.Rows)
            {
                string? majorName = this.majorList.AsEnumerable()
                    .First(x => Convert.ToInt32(x["major_id"]) == Convert.ToInt32(row["major_id"])).Field<string>("major_title");

                this.dataGridViewSubject.Rows.Add(
                    row["subject_id"], index++, row["subject_name"], row["subject_code"], row["theory_credit_count"], row["practice_credit_count"], majorName == null ? "Tất cả ngành" : majorName
                );
            }
        }

        private void renderUIEditMode(int subjectId)
        {
            this.subjectToChange = this.mySqlConnect.selectQueryOne(
                $"SELECT * FROM `subject` WHERE `subject_id` = {subjectId}"
            );

            // Update UI
            this.resetUI();

            // Render old data
            List<int> majorIndexList = new List<int>();

            foreach (DataRow row in this.majorList.Rows)
                majorIndexList.Add(Convert.ToInt32(row["major_id"]));

            this.textBoxSubjectName.Text = (string)subjectToChange["subject_name"];
            this.textBoxSubjectCode.Text = (string)subjectToChange["subject_code"];
            this.numericUpDownTheory.Value = Convert.ToInt32(subjectToChange["theory_credit_count"]);
            this.numericUpDownPractice.Value = Convert.ToInt32(subjectToChange["practice_credit_count"]);
            this.comboBoxMajor.SelectedIndex =
                majorIndexList.FindIndex(m => m == Convert.ToInt32(subjectToChange["major_id"])) + 1;
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
            }
            else if (this.textBoxSubjectCode.Text.Length != 6)
            {
                this.labelSubjectCodeWarning.Text = "Vui lòng điền đúng độ dài 6 ký tự!";
            }
            else
            {
                string subjectCode = this.textBoxSubjectCode.Text;
                string query = $"SELECT COUNT(*) AS `count` FROM `subject` WHERE `subject_code` = '{subjectCode}'";
                bool isDuplicate = Convert.ToInt32(this.mySqlConnect.selectQueryOne(query)["count"]) != 0;

                if (isDuplicate && (subjectToChange == null || !subjectToChange["subject_code"].Equals(subjectCode))) this.labelSubjectCodeWarning.Text = "Mã môn học đã được sử dụng!";
                else this.labelSubjectCodeWarning.Text = "";
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            bool result = this.getValidateResult();
            if (!result) return;

            // Handle add subject
            int theoryCreditCount = Convert.ToInt32(this.numericUpDownTheory.Value);
            int practiceCreditCount = Convert.ToInt32(this.numericUpDownPractice.Value);
            string subjectCode = this.textBoxSubjectCode.Text;
            string subjectName = this.textBoxSubjectName.Text;

            try
            {
                int majorIndex = this.comboBoxMajor.SelectedIndex;
                int majorId = Convert.ToInt32(this.majorList.Rows[majorIndex - 1]["major_id"]);
                string majorQuery = majorIndex == 0 ? "null" : $"'{majorId}'";

                if (this.subjectToChange != null)
                {
                    // Handle UPDATE subject
                    int oldSubjectId = Convert.ToInt32(subjectToChange["subject_id"]);

                    string updateQuery = $"UPDATE `subject` SET " +
                        $"`subject_name` = '{subjectName}'," +
                        $"`subject_code` = '{subjectCode}'," +
                        $"`theory_credit_count` = {theoryCreditCount}," +
                        $"`practice_credit_count` = {practiceCreditCount}," +
                        $"`major_id` = {majorQuery}" +
                        $"WHERE `subject_id` = {oldSubjectId}";

                    // Update SQL and handle result
                    if (this.mySqlConnect.query(updateQuery) == 0) throw new Exception("Lỗi trong quá trình sửa môn học!");
                    else MessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Handle add subject
                    string addQuery = $"INSERT INTO `subject`" +
                        $"(`subject_name`, `subject_code`, `theory_credit_count`, `practice_credit_count`, `major_id`) VALUES " +
                        $"('{subjectName}','{subjectCode}', {theoryCreditCount},  {practiceCreditCount}, {majorQuery})";

                    if (this.mySqlConnect.query(addQuery) == 0) throw new Exception("Lỗi trong quá trình thêm môn học!");
                    else MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Handle success
                this.initialData();
                this.renderUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool getValidateResult()
        {
            this.textBoxSubjectName_TextChanged(null, null);
            this.textBoxSubjectCode_TextChanged(null, null);

            return (
                this.labelSubjectNameWarning.Text.Length == 0 &&
                this.labelSubjectCodeWarning.Text.Length == 0
            );
        }

        private void resetUI()
        {
            // Reset UI
            this.textBoxSubjectName.Text = "";
            this.textBoxSubjectCode.Text = "";
            this.numericUpDownPractice.Value = 0;
            this.numericUpDownTheory.Value = 0;

            this.labelSubjectNameWarning.Text = "";
            this.labelSubjectCodeWarning.Text = "";

            // Button UI
            this.buttonCancelChange.Visible = this.subjectToChange != null;
            if (this.subjectToChange != null)
            {
                this.buttonSubmit.Text = "Áp dụng chỉnh sửa";
                this.buttonSubmit.FillColor = Color.Orange;
            }
            else
            {
                this.buttonSubmit.Text = "Thêm môn học";
                this.buttonSubmit.FillColor = Color.FromArgb(94, 148, 255);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.dataGridViewSubject.SelectedRows[0].Index;
            int subjectId = Convert.ToInt32(this.subjectList.Rows[selectedIndex]["subject_id"]);

            this.renderUIEditMode(subjectId);
        }

        private void buttonCancelChange_Click(object sender, EventArgs e)
        {
            this.renderUI();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có chắc chắn XÓA những môn học đã chọn?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
               ) == DialogResult.No)
            {
                return;
            }

            // Find subject id to remove
            var selectedRowList = this.dataGridViewSubject.SelectedRows;
            List<int> subjectIdList = new List<int>();

            foreach (DataGridViewRow row in selectedRowList)
            {
                subjectIdList.Add(Convert.ToInt32(
                    row.Cells["subjectId"].Value.ToString()
                ));
            }

            // Remove on MySQL
            string subjectIdListStr = String.Join(",", subjectIdList);
            string deleteQuery = $"DELETE FROM `subject` WHERE `subject_id` IN ({subjectIdListStr})";

            if (this.mySqlConnect.query(deleteQuery) == 0)
            {
                MessageBox.Show("Lỗi trong quá trình xóa các môn học!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.initialData();
                this.renderUI();
                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}