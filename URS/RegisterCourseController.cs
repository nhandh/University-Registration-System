using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace URS
{
    class RegisterCourseController
    {

        public DataTable getEligibleCourse(string student_id)
        {
            Student student = new Student(student_id);
            student.getStudentInformation();
            DataTable courses_offered_this_semester_table = Registration.getCoursesFromSemester(student.current_semester_id, student.program_id);
            return courses_offered_this_semester_table;
        }

        public string addCourse(string student_id, string course_designation)
        {          
            Student student = new Student(student_id);
            student.getStudentInformation();
            Course course = new Course(course_designation);
            if (!course.GetCourseInformation(GLOBALS.current_semester))
            {
                return "This course is not offered this semester. Sorry!";
            }

            if (Registration.checkCoursePrereqNotTaken(student, course))
            {
                return "Pre requisite is not taken";
            }

            if (Registration.checkCourseTaken(student, course))
            {
                return "You already took this course!";
            }

            // check limit credit hours
            int new_credit_hour = student.current_credit_hour + course.credit_hours;
            if (new_credit_hour > student.max_credit_hour_allowed) { return "Maximum credit hours reached!"; }

            // check course capacity
            if (course.enrolled_student >= course.capacity ) { return "This course is full!"; }

            // Update Registration Table
            if (Registration.addRegistration(student, course))
            {
                student.updateCreditHour(new_credit_hour);
                course.updateEnrolledStudent(course.enrolled_student + 1);
                return "ok";
            }

            return "This course conflicts with your Registration. Please contact the admin for more information";
        }

        
    }
}
