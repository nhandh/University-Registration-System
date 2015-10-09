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
    public partial class HomePageAdmin : Form
    {
        public HomePageAdmin()
        {
            InitializeComponent();
            if (Member.membership_type == "administrator")
            {
                btnGenerateReport.Visible = true;
            }
            else if (Member.membership_type == "data entry operator")
            {
                btnGenerateReport.Visible = false;
            }
        }

        private void btnMaintainStudent_Click(object sender, EventArgs e)
        {
            MaintainStudentDetailsInterface maintain_student_details_interface
                = new MaintainStudentDetailsInterface();
            maintain_student_details_interface.ShowDialog();
        }

        private void btnMaintainCourse_Click(object sender, EventArgs e)
        {
            MaintainCourseDetailsInterface maintain_course_details_interface
                = new MaintainCourseDetailsInterface();
            maintain_course_details_interface.ShowDialog();
        }

        private void btnMaintainFaculty_Click(object sender, EventArgs e)
        {
            MaintainFacultyDetailsInterface maintain_faculty_details_interface
                = new MaintainFacultyDetailsInterface();
            maintain_faculty_details_interface.ShowDialog();

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReportInterface generate_report_interface
                = new GenerateReportInterface();
            generate_report_interface.ShowDialog();
        }
    }
}
