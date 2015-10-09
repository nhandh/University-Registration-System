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
    public partial class SearchCourseInterface : Form
    {
        public SearchCourseInterface()
        {
            InitializeComponent();
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            SearchCourseController search_course_controller = new SearchCourseController();
            txtSearchOutput.Text = search_course_controller.searchCourse(txtCourseDesignation.Text);

        }
    }
}
