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
    public partial class RegisterCourseInterFace : Form
    {
        public RegisterCourseInterFace()
        {
            InitializeComponent();
            if (Member.membership_type != "student")
            {
                btnRegisterCourse.Visible = false;
            }

            updateCourseSelector();       
        }

        private void btnRegisterCourse_Click(object sender, EventArgs e)
        {
            RegisterCourseController register_course_controller = new RegisterCourseController();
            string result = register_course_controller.addCourse(
                Member.member_id,
                cbbCourseSelector.SelectedValue.ToString() );

            if (result == "ok")    
            {
                MessageBox.Show("Course is added!");
            }
            else
            {
                MessageBox.Show("Course fails to add! Reason: " +result);
            }
            updateCourseSelector();
        }

        private void updateCourseSelector()
        {
            RegisterCourseController register_course_controller = new RegisterCourseController();
            cbbCourseSelector.DataSource = register_course_controller.getEligibleCourse(Member.member_id);
            cbbCourseSelector.DisplayMember = "course_designation";
            cbbCourseSelector.ValueMember = "course_designation";  
        }

    }
}
