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
    public partial class GenerateReportInterface : Form
    {
        public GenerateReportInterface()
        {
            InitializeComponent();
        }

        private void btnReportRegistrationStudent_Click(object sender, EventArgs e)
        {
            // check for blank
            if (txtStudentID.Text != "" && txtStudentID.Text.All(char.IsDigit))
            {
                // check for valid student id
                Student student = new Student(txtStudentID.Text);
                if (student.getStudentInformation())
                {
                    GenerateReportRegistrationInterface generate_report_registration_interface
                        = new GenerateReportRegistrationInterface(txtStudentID.Text);

                    generate_report_registration_interface.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Fail to generate report! No student with that ID found!");
                }
            }

        }

        private void btnReportCourseDetails_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text != "" && GLOBALS.isAlphaNumeric(txtCourseID.Text))
            {

                 if (GenerateReportController.reportCourseDetail(txtCourseID.Text))
                {
                    MessageBox.Show("Report generated!");
                }
                else
                {
                    MessageBox.Show("Fail to generate report! That course is not offered this semester!");
                }
            }

        }

        private void btnReportAllStudents_Click(object sender, EventArgs e)
        {
            GenerateReportController.reportAllStudents();
        }

        private void btnReportAllCourses_Click(object sender, EventArgs e)
        {
            GenerateReportController.reportAllCourses();
        }
    }
}
