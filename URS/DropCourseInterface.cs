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
    public partial class DropCourseInterface : Form
    {
        public DropCourseInterface()
        {
            InitializeComponent();

            updateCourseSelector(); 
        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            // Ask for confirmation
            DialogResult dialog_result = MessageBox.Show("Do you want to drop this course?", "Confirmation", MessageBoxButtons.YesNo);
            
            if (dialog_result == DialogResult.Yes)
            {
                string result = DropCourseController.dropCourse(
                    Member.member_id,
                    cbbCourseSelector.SelectedValue.ToString());

                if (result == "ok")
                {
                    MessageBox.Show("Course is dropped!");
                }
                else
                {
                    MessageBox.Show("Course fails to drop! Reason: " + result);
                }
                updateCourseSelector(); 
            }
            else if (dialog_result == DialogResult.No)
            {
                MessageBox.Show("Okay, nothing dropped");
            }
        }

        private void updateCourseSelector()
        {            
            List<Course> course_list = DropCourseController.getCurrentCourse();
            cbbCourseSelector.DataSource = course_list;
            if (course_list.Count >0)
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
    }
}
