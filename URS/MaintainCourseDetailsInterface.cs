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
    public partial class MaintainCourseDetailsInterface : Form
    {
        bool cbbInstructorSelector_SelectedIndexChanged_enable;

        public MaintainCourseDetailsInterface()
        {
            InitializeComponent();
            cbbInstructorSelector_SelectedIndexChanged_enable = false;
            updateSelectors();
            resetAllTextbox();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string course_designation = txtSearchCourseDesisgnation.Text;
            if (course_designation != "")
            {
                Course course = MaintainCourseDetailsController.searchCourse
                    (course_designation, cbbSemesterSelector.SelectedValue.ToString());

                // if found
                if (course.course_id != null)
                {
                    txtCourseID.Text = course.course_id;
                    txtTitle.Text = course.title;
                    txtCourseDesignation.Text = course.course_designation;
                    cbbInstructorSelector.Text = course.instructor;
                    txtDepartment.Text = course.department;
                    txtNumCredit.Text = course.credit_hours.ToString();
                    txtPreReqCourse.Text = 
                        MaintainCourseDetailsController.getCourseDesignationFromId(course.prereq_course);
                    txtCourseDescription.Text = course.description;               
                    txtMaxCap.Text = course.capacity.ToString();
                    txtEnrolledStudent.Text = course.enrolled_student.ToString();
                    lblStatusBar.Text = "Course found. Modify or Delete?";
                }
                else
                {
                    resetAllTextbox();
                    lblStatusBar.Text = "No Course found";
                }
            }
        }

        private void updateSelectors()
        {
            // Combobox for semesters           
            cbbSemesterSelector.DataSource = GenerateReportController.getSemesterList();
            cbbSemesterSelector.DisplayMember = "year_semester";
            cbbSemesterSelector.ValueMember = "year_semester";
            cbbSemesterSelector.Text = "";

            // Combobox for instructor         
            cbbInstructorSelector.DataSource = GenerateReportController.getInstructorList();
            cbbInstructorSelector.DisplayMember = "name";
            cbbInstructorSelector.ValueMember = "faculty_id";
            cbbInstructorSelector.Text = "";
            cbbInstructorSelector_SelectedIndexChanged_enable = true;
        }

        private void resetAllTextbox()
        {
            txtCourseID.Text = "";
            txtTitle.Text = "";
            txtCourseDesignation.Text = "";
            cbbInstructorSelector.Text = "";
            txtDepartment.Text = "";
            txtNumCredit.Text = "";
            txtCourseDescription.Text = "";
            txtPreReqCourse.Text = "";
            txtMaxCap.Text = "";
            txtEnrolledStudent.Text = "";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // check for required fields
            if (txtTitle.Text == "" || txtCourseDesignation.Text == "")
            {
                lblStatusBar.Text = "Modify fails!";
                return;
            }

            if (lblStatusBar.Text != "Course found. Modify or Delete?"
                && lblStatusBar.Text != "Modify Success!"
                && lblStatusBar.Text != "Modify fails!") return;



            // check if pre-req course is valid
            if (txtPreReqCourse.Text != "")
            {
                if (!MaintainCourseDetailsController.checkPreReqCourseValid(txtPreReqCourse.Text))
                {
                    lblStatusBar.Text = "Modify fails!";
                    MessageBox.Show("Invalid Pre-requisite Course");
                    return;
                }
            }
            if (!validateAllTextbox())
            {
                lblStatusBar.Text = "Modify fails!";
                return;
            }
            // Ask for confirmation
            DialogResult dialog_result = MessageBox.Show("Do you want to modify this course?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog_result == DialogResult.No)
            {
                return;
            }

            string faculty_id = cbbInstructorSelector.SelectedValue.ToString();
            string department_id = MaintainCourseDetailsController.getDepartmentIdFromFacultyID(faculty_id);

            if (MaintainCourseDetailsController.modifyCourse(
                    txtCourseID.Text,
                    txtTitle.Text,
                    txtCourseDesignation.Text,
                    faculty_id,
                    department_id,
                    txtNumCredit.Text,
                    txtCourseDescription.Text,
                    txtPreReqCourse.Text,
                    txtMaxCap.Text,
                    txtEnrolledStudent.Text,
                    cbbSemesterSelector.SelectedValue.ToString()
                ))
            {
                lblStatusBar.Text = "Modify Success!";
            }
            else
            {
                lblStatusBar.Text = "Modify fails!";
            }
            

        }

        // update Department textbox when Instructor selection changed
        private void cbbInstructorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbbInstructorSelector_SelectedIndexChanged_enable) return;

            txtDepartment.Text = MaintainCourseDetailsController.getDepartmentFromFacultyID(
                cbbInstructorSelector.SelectedValue.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblStatusBar.Text != "Course found. Modify or Delete?") return;
            if (cbbSemesterSelector.SelectedValue.ToString() != GLOBALS.current_semester)
            {
                MessageBox.Show("You cannot delete courses from old semesters!");
                return;
            }

            // Ask for confirmation
            DialogResult dialog_result = MessageBox.Show("Do you want to delete this course?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog_result == DialogResult.No)
            {
                return;
            }

            if (MaintainCourseDetailsController.deleteCourse(txtCourseID.Text))
            {
                lblStatusBar.Text = "Delete Success!";
                resetAllTextbox();
            }
            else
            {
                lblStatusBar.Text = "Delete Fails!";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check for required fields
            if (txtTitle.Text == "" || txtCourseDesignation.Text == "")
            {
                lblStatusBar.Text = "Title and Course Designation is required";
                return;
            }

            if (txtDepartment.Text == "")
            {
                lblStatusBar.Text = "You have to select instructor and department!";
                return;
            }

            if (!validateAllTextbox())
            {
                lblStatusBar.Text = "Add fails!";
                return;
            }

            // Ask for confirmation
            DialogResult dialog_result = MessageBox.Show("Do you want to add this course (to current semester)?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog_result == DialogResult.No)
            {
                return;
            }

            // check if the course_designation is already in the database
            if (MaintainCourseDetailsController.checkDuplicateCourseDesignation(txtCourseDesignation.Text))
            {
                lblStatusBar.Text = "You cannot add same course designation!";
                return;
            }

            // check if pre-req course is valid
            if (txtPreReqCourse.Text != "")
            {
                if (!MaintainCourseDetailsController.checkPreReqCourseValid(txtPreReqCourse.Text))
                {
                    lblStatusBar.Text = "Invalid Pre-requisite course";
                    return;
                }
            }



            string faculty_id = cbbInstructorSelector.SelectedValue.ToString();
            string department_id = MaintainCourseDetailsController.getDepartmentIdFromFacultyID(faculty_id);

            if (MaintainCourseDetailsController.addCourse(
                    txtTitle.Text,
                    txtCourseDesignation.Text,
                    faculty_id,
                    department_id,
                    txtNumCredit.Text,
                    txtCourseDescription.Text,
                    txtPreReqCourse.Text,
                    txtMaxCap.Text,
                    txtEnrolledStudent.Text
                ))
            {
                txtEnrolledStudent.Text = "0";
                lblStatusBar.Text = "Add Success!";
            }
            else
            {
                lblStatusBar.Text = "Add fails!";
            }

        }

        private bool validateAllTextbox()
        {
            if (txtCourseDescription.Text == "") return false;
            if (txtCourseDesignation.Text == "") return false;
            if (txtDepartment.Text == "") return false;
            if (! isNumericAndLargerThan(txtEnrolledStudent.Text,-1)) return false;
            if (! isNumericAndLargerThan(txtMaxCap.Text, 0)) return false;
            if (isNumericAndLargerThan(txtMaxCap.Text, 300)) return false;
            if (! isNumericAndLargerThan(txtNumCredit.Text, -1)) return false;
            if (Convert.ToInt32(txtEnrolledStudent.Text) > Convert.ToInt32(txtMaxCap.Text)) return false;
            if (txtTitle.Text == "") return false;

            return true;

        }

        private bool isNumericAndLargerThan(string lhs, int rhs)
        {
            int number;
            bool result = Int32.TryParse(lhs, out number);
            if (!result) return false;

            return (number > rhs);
        }

    }
}
