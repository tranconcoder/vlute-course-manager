using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using vlute_course_manager.controls;

namespace vlute_course_manager
{
    public partial class HomeForm : Form
    {
        public HomeForm(int userId)
        {
            InitializeComponent();

            this.initialEvent();
        }

        private void initialEvent()
        {
            // Panel profile/click event
            foreach (Control control in this.panelNavigateProfile.Controls)
            {
                control.Click += panelNavigationClickHandle;
            }
        }
        
        private void panelNavigationClickHandle(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void panelNavigateProfile_Click(object sender, EventArgs e)
        {
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            if (this.flowLayoutPanel1.Controls.Count == 0)
            {
                this.flowLayoutPanel1.Controls.Clear();
            }

            for (int i = 0; i < 20; i++)
            {
                CourseItem item = new CourseItem();
                item.courseName = "Lập trình dotNET (2.2)";
                item.courseId = "231_1TH1337_KS2A_tructiep";
                item.courseType = "Thực hành";
                item.teacher = "Nguyễn Thị Mỹ Nga";

                this.flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
