using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URS
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            if (Member.membership_type == "faculty")
            {
                btnRegisterCourse.Visible = false;
                btnViewDropCourse.Text = "View your courses";
                btnGenerateRegistrationCard.Visible = false;
                
            }
            if (Member.membership_type == "student")
            {
                btnRegisterCourse.Visible = true;
                btnViewDropCourse.Text = "View/Drop your courses";
                btnGenerateRegistrationCard.Visible = true;
            }
        }

        private void btnRegisterCourse_Click(object sender, EventArgs e)
        {
            RegisterCourseInterFace register_course_interface = new RegisterCourseInterFace();
            register_course_interface.ShowDialog();
        }

        private void btnViewDropCourse_Click(object sender, EventArgs e)
        {
            ViewCourseInterface view_course_interface = new ViewCourseInterface();
            view_course_interface.ShowDialog();
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            SearchCourseInterface search_course_interface = new SearchCourseInterface();
            search_course_interface.ShowDialog();
        }

        private void btnGenerateRegistrationCard_Click(object sender, EventArgs e)
        {
            GenerateReportRegistrationInterface generate_report_registration_interface
                = new GenerateReportRegistrationInterface(Member.member_id);
            generate_report_registration_interface.ShowDialog();
        }





    }
}
