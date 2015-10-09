using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URS
{
    class MaintainCourseDetailsController
    {
        public static Course searchCourse(string course_designation, string year_semester){
            Course course = new Course(course_designation);
            if (course.GetCourseInformation(year_semester))
            {
                return course;
            }
            return course;
        }

        public static string getDepartmentFromFacultyID(string faculty_id){
            Faculty faculty = new Faculty(faculty_id);
            if (faculty.getFalcutyInformation()){
                return faculty.department;
            }
            return null;
        }

        public static string getDepartmentIdFromFacultyID(string faculty_id)
        {
            Faculty faculty = new Faculty(faculty_id);
            if (faculty.getFalcutyInformation())
            {
                return faculty.department_id;
            }
            return null;
        }

        public static string getCourseDesignationFromId(string course_id)
        {
            if (course_id == null) return "None";
            return Course.getCourseDesignationFromId(course_id);
        }

        public static bool checkDuplicateCourseDesignation(string course_designation)
        {
            return Course.checkDuplicateCourseDesignation(course_designation);
        }

        public static bool checkPreReqCourseValid(string course_designation)
        {
            return Course.checkValidCourseDesignation(course_designation);         
        }

        public static bool addCourse(
                    string title,
                    string course_designation,
                    string instructor_id,
                    string department_id,
                    string num_credit,
                    string course_description,
                    string pre_req_course,
                    string max_capacity,
                    string enrolled_student)
        {
            int course_id = Convert.ToInt32(Course.getMaxId()) + 1;
            string pre_req_course_id = Course.getCourseIdFromDesignation(pre_req_course);

            if (Course.add(
                    course_id.ToString(),
                    title,
                    course_designation,
                    instructor_id,
                    department_id,
                    num_credit,
                    course_description,
                    pre_req_course_id,
                    max_capacity,
                    enrolled_student,
                    GLOBALS.current_semester))
            {
                return true;

            }

            return false;
        }


        public static bool modifyCourse(
                    string course_id,
                    string title,
                    string course_designation,
                    string instructor_id,
                    string department_id,
                    string num_credit,
                    string course_description,
                    string pre_req_course,
                    string max_capacity,
                    string enrolled_student,
                    string semester)
        {
            string pre_req_course_id = Course.getCourseIdFromDesignation(pre_req_course);
            if (Course.update(
                    course_id,
                    title,
                    course_designation,
                    instructor_id,
                    department_id,
                    num_credit,
                    course_description,
                    pre_req_course_id,
                    max_capacity,
                    enrolled_student,
                    semester))
            {
                return true;

            }

            return false;
        }

        public static bool deleteCourse(string course_id)
        {
            return Course.delete(course_id);
        }
    }
}
