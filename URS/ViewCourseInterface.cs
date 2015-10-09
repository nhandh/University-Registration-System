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
    public partial class ViewCourseInterface : Form
    {
        public ViewCourseInterface()
        {        
            InitializeComponent();

            
            if (Member.membership_type == "student")
            {
                btnDropCourse.Visible = true;
                btnViewEnrollement.Visible = false;
                cbbCourseSelector.Visible = false;
            }
            else if (Member.membership_type == "faculty")
            {
                btnDropCourse.Visible = false;
                btnViewEnrollement.Visible = true;
                cbbCourseSelector.Visible = true;
                updateCourseSelector();
            }

            txtCourseList.Text = convertCourseListToString(
                ViewCourseController.getCurrentCourses()
                );


        }
        private string convertCourseListToString(List<Course> course_list)
        {
            // for each course in list course, get the list of students enrolled in this course
            string output = "";
            foreach (var a_course in course_list)
            {
                // get the list of courses name
                output += a_course.course_designation + Environment.NewLine;
            }
            return output;
        }



        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            DropCourseInterface drop_course_interface = new DropCourseInterface();
            drop_course_interface.ShowDialog();

            txtCourseList.Text = convertCourseListToString(
                ViewCourseController.getCurrentCourses()
                );
        }

        private void updateCourseSelector()
        {
            List<Course> course_list = ViewCourseController.getCurrentCourses();
            cbbCourseSelector.DataSource = course_list;
            if (course_list.Count > 0)
            {
                btnDropCourse.Enabled = true;
                cbbCourseSelector.DisplayMember = "course_designation";
                cbbCourseSelector.ValueMember = "course_designation";
            }
            else
            {
                btnDropCourse.Enabled = false;
                cbbCourseSelector.Text = "No course found";
            }

        }

        private void btnViewEnrollement_Click(object sender, EventArgs e)
        {
            if (!GenerateReportController.reportCourseDetail(cbbCourseSelector.SelectedValue.ToString()))
            {
                MessageBox.Show("No students in this course!");
            }
        }
    }
}
