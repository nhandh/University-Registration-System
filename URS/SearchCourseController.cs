using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URS
{
    class SearchCourseController
    {
        public string searchCourse(string course_designation)
        {
            Course course = new Course(course_designation);
            string result = "No course found in this semester";
            if (course.GetCourseInformation(GLOBALS.current_semester))
            {
                result = course.ToString();
            }

            return result;
        }
    }
}
