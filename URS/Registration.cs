using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace URS
{
    public class Registration
    {

        public static List<Course> getCoursesFromStudent(string student_id, string year_semester)
        {
            List<Course> course_list = new List<Course>();
            string query = "select * from registration where student_id=" + student_id + " and year_semester='" + year_semester + "'";
            DataTable registration_table = GLOBALS.db_query(query);

            foreach (DataRow row in registration_table.Rows){
                DataTable course_table = GLOBALS.db_query("select course_designation from course where course_id=" + row["course_id"].ToString());
                Course course = new Course(course_table.Rows[0]["course_designation"].ToString());
                if (course.GetCourseInformation(GLOBALS.current_semester))
                {
                    course_list.Add(course);
                }                
            }

            return course_list;
        }

        public static List<Student> getStudentsFromCourseCurrentSemester(string course_id)
        {
            List<Student> student_list = new List<Student>();
            string query = "select * from registration where course_id=" + course_id +" and year_semester='" + GLOBALS.current_semester +"'";
            DataTable registration_table = GLOBALS.db_query(query);

            foreach (DataRow row in registration_table.Rows)
            {
                Student student = new Student(row["student_id"].ToString());
                student.getStudentInformation();
                student_list.Add(student);
            }

            return student_list;
        }

        public static DataTable getCoursesFromSemester(string semester_number, string program_id)
        {
            return GLOBALS.db_query(
                "select course_designation, prereq_course " +
                "from COURSE " +
                "where course_id = any( " +
                    "select cs.course_id " +
                    "from course_semester as cs " +
                    "where cs.semester_id = all( select semester_id from semester " +
                    "where semester_number = " + semester_number +" and program = " + program_id +"))");
        }

        public static bool checkCourseTaken(Student student, Course course)
        {
            DataTable dt = GLOBALS.db_query(
                "select * from REGISTRATION " +
                "where course_id = "+course.course_id+
                " and student_id = "+student.student_id+
                " and (passed_course = 1 or passed_course is null)");

            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public static bool checkCoursePrereqNotTaken(Student student, Course course)
        {
            // if there is no pre-req course
            if (course.prereq_course == null || course.prereq_course == "") return false;

            DataTable dt = GLOBALS.db_query(
                "select * from REGISTRATION " +
                "where course_id = " + course.prereq_course +
                " and student_id = " + student.student_id +
                " and passed_course = 1");

            if (dt.Rows.Count == 1)
            {
                return false;
            }
            return true;
        }

        public static bool addRegistration(Student student, Course course)
        {
            string query = "insert into REGISTRATION (course_id, student_id, year_semester)" +
                "values (" + course.course_id + ", " + student.student_id + ", '" + GLOBALS.current_semester + "')"; 
            return GLOBALS.db_command(query);            
        }

        public static bool dropRegistration(Student student, Course course)
        {
            string query = "delete from REGISTRATION where "+
                "course_id= "+course.course_id +
                " and student_id =" + student.student_id +
                " and year_semester='"+ GLOBALS.current_semester + "'";

            return GLOBALS.db_command(query);
        }
    }
}
