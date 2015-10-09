using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URS
{
    class DropCourseController
    {
        public static List<Course> getCurrentCourse()
        {
            return Registration.getCoursesFromStudent(Member.member_id, GLOBALS.current_semester);
        }

        public static string dropCourse(string student_id, string course_designation)
        {          
            Student student = new Student(student_id);
            student.getStudentInformation();
            Course course = new Course(course_designation);
            course.GetCourseInformation(GLOBALS.current_semester);


            // check limit credit hours
            int new_credit_hour = student.current_credit_hour - course.credit_hours;
            if (new_credit_hour < 0) { return "Your credit hours is negative. Seems like your database is corrupted!"; }

            // check course capacity
            if (course.enrolled_student == 0 ) { return "Course database is corrupted!"; }

            // Update Registration Table
            if (Registration.dropRegistration(student, course))
            {
                student.updateCreditHour(new_credit_hour);
                course.updateEnrolledStudent(course.enrolled_student - 1);
                return "ok";
            }

            return "This course conflicts with your Registration. Please contact the admin for more information";
        }
    }
}
