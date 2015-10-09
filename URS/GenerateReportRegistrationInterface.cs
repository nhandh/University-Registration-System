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
    public partial class GenerateReportRegistrationInterface : Form
    {
        private string student_id;
        public GenerateReportRegistrationInterface(string student_id_)
        {
            student_id = student_id_;
            InitializeComponent();
            updateCourseSelector(); 
        }

        private void btnGenerateReportRegistration_Click(object sender, EventArgs e)
        {
            GenerateReportController.reportStudentRegistration(
                student_id,
                cbbSemesterSelector.SelectedValue.ToString()
                );
        }

        private void updateCourseSelector(){
            cbbSemesterSelector.DataSource = GenerateReportController.getSemesterList();
            cbbSemesterSelector.DisplayMember = "year_semester";
            cbbSemesterSelector.ValueMember = "year_semester";  
        }




    }
}
