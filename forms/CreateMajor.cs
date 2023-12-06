using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace vlute_course_manager.controls
{
    public partial class CreateMajorForm : Form
    {
        private DataTable majorList;
        private MySQLConnect mySQLConnect;

        public CreateMajorForm()
        {
            InitializeComponent();

            mySQLConnect = new MySQLConnect();

            initial();
            renderUI();
        }

        private void initial()
        {
            majorList = mySQLConnect.selectQuery("SELECT * FROM `major` ORDER BY `major_title`");
        }

        private void renderUI()
        {
            textBoxMajor.Text = "";
            labelMajorWarning.Text = "";

            dataGridViewMajor.Rows.Clear();
            int order = 1;
            foreach (DataRow row in majorList.Rows)
            {
                dataGridViewMajor.Rows.Add(
                    row["major_id"],
                    order++.ToString(),
                    row["major_title"]
                );
            }
        }

        private void textBoxMajor_TextChanged(object sender, System.EventArgs e)
        {
            string majorName = textBoxMajor.Text;

            if (majorName.Length == 0) labelMajorWarning.Text = "Vui lòng nhập tên chuyên ngành!";
            else
            {
                string checkDupQ = $"SELECT COUNT(*) AS `count` FROM `major` WHERE `major_title` = '{majorName}'";
                if (Convert.ToInt32(mySQLConnect.selectQueryOne(checkDupQ)["count"]) != 0)
                {
                    labelMajorWarning.Text = "Tên chuyên ngành đã được sử dụng!";
                }
                else
                {
                    labelMajorWarning.Text = "";
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            textBoxMajor_TextChanged(null, null);
            if (labelMajorWarning.Text.Length != 0) return;

            // Handle add major
            string majorName = textBoxMajor.Text;
            string insertQ = $"INSERT INTO `major`(`major_title`) VALUES ('{majorName}')";

            if (mySQLConnect.query(insertQ) == 0)
            {
                MessageBox.Show("Không thể thêm, vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initial();
                renderUI();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Bạn có chắc chắn XÓA những chuyên ngành đã chọn?",
               "Question",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
              ) == DialogResult.No)
            {
                return;
            }

            // Find subject id to remove
            var selectedRowList = dataGridViewMajor.SelectedRows;
            List<int> majorIdList = new List<int>();

            foreach (DataGridViewRow row in selectedRowList)
            {
                majorIdList.Add(Convert.ToInt32(
                    row.Cells["majorId"].Value.ToString()
                ));
            }

            // Remove on MySQL
            string majorIdListStr = String.Join(",", majorIdList);
            string deleteQuery = $"DELETE FROM `major` WHERE `major_id` IN ({majorIdListStr})";

            if (mySQLConnect.query(deleteQuery) == 0)
            {
                MessageBox.Show("Lỗi trong quá trình xóa các chuyên ngành!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initial();
                renderUI();
            }
        }
    }
}
