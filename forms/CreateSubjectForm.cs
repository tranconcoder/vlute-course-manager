using System;
using System.Data;
using System.Windows.Forms;

namespace vlute_course_manager.forms
{
    public partial class CreateSubjectForm : Form
    {
        private MySQLConnect mySqlConnect;
        private DataTable majorList;


        public CreateSubjectForm()
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

        private void comboBoxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxMajor.SelectedIndex;

            if (index == 0)
            {
                this.labelMajorWarning.Text = "Vui lòng nhập chuyên ngành môn học!";
            }
            else
            {
                this.labelMajorWarning.Text = "";
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.textBoxSubjectName_TextChanged(sender, e);
            this.textBoxSubjectCode_TextChanged(sender, e);
            this.comboBoxMajor_SelectedIndexChanged(sender, e);

            bool result = this.getValidateResult();

            if (!result) return;

            // Handle add subject
            int majorId = Convert.ToInt32(this.majorList.Rows[this.comboBoxMajor.SelectedIndex - 1]);
            int theoryCreditCount = Convert.ToInt32(this.numericUpDownTheory.Value);
            int practiceCreditCount = Convert.ToInt32(this.numericUpDownPractice.Value);
            string subjectCode = this.textBoxSubjectCode.Text;
            string subjectName = this.textBoxSubjectName.Text;

            try
            {
                string saveSubjectQuery = $"INSERT INTO `subject`" +
                    $"(major_id, subject_code, subject_name, theory_credit_count, pracitce_credit_count) VALUES " +
                    $"({majorId},'{subjectCode}','{subjectName}', {theoryCreditCount}, {practiceCreditCount})";
                int columnChangedCount = this.mySqlConnect.query(saveSubjectQuery);

                if (columnChangedCount == 0) throw new Exception("Không thể thêm, vui lòng thử lại!");

                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool getValidateResult()
        {
            return (
                this.labelSubjectNameWarning.Text.Length != 0 &&
                this.labelSubjectCodeWarning.Text.Length != 0 &&
                this.labelMajorWarning.Text.Length != 0
            );
        }
    }
}
