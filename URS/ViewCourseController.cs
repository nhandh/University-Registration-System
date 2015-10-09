using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URS
{
    class ViewCourseController
    {
        public static List<Course> getCurrentCourses(){
            if (Member.membership_type == "student")
            {
                return Registration.getCoursesFromStudent(Member.member_id, GLOBALS.current_semester);
            }
            else if (Member.membership_type == "faculty")
            {
                return Course.getCoursesFromFaculty(Member.member_id);
            }
            else
                return new List<Course>();
        }
    }
}
