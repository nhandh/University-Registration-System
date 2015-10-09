using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace URS
{
    public class Course
    {
        public string course_id;
        public string title;
        public string course_designation { get; set; }
        public string instructor;
        public string department;
        public int credit_hours;
        public string description;
        public string prereq_course;
        public string year_semester;
        public int capacity;
        public int enrolled_student;
        public string location;
        public string schedule; // include schedule date, start time and end time
        

        public Course(string course_designation_)
        {
            course_designation = course_designation_;
        }

        public bool GetCourseInformation(string year_semester_)
        {      
            string query = "SELECT COURSE.course_id, COURSE.course_designation, COURSE.course_title, [first_name] & \" \" & [last_name] AS instructor, DEPARTMENT.dept_name, COURSE.credit_hour, COURSE.description, COURSE.prereq_course, COURSE_DETAILS.year_semester, COURSE_DETAILS.max_capacity, COURSE_DETAILS.students_enrolled, COURSE_DETAILS.location, [schedule_days] & \" \" & Format([start_time],\"Short Time\") & \"-\" & Format([end_time],\"Short Time\") AS schedule"+
                            " FROM (DEPARTMENT INNER JOIN (COURSE INNER JOIN COURSE_DETAILS ON COURSE.course_id = COURSE_DETAILS.course_id) ON DEPARTMENT.dept_id = COURSE.dept_id) INNER JOIN FACULTY ON (DEPARTMENT.dept_id = FACULTY.dept_id) AND (FACULTY.faculty_id = COURSE.instructor_id)"+
                            " WHERE((   (COURSE_DETAILS.year_semester)='" + year_semester_ + "' and COURSE.course_designation='" + course_designation + "'))";
            DataTable dt = GLOBALS.db_query(query);

            if (dt.Rows.Count == 1)
            {
                course_id = dt.Rows[0]["course_id"].ToString();
                title = dt.Rows[0]["course_title"].ToString();
                instructor = dt.Rows[0]["instructor"].ToString();
                department = dt.Rows[0]["dept_name"].ToString();
                credit_hours = Convert.ToInt32(dt.Rows[0]["credit_hour"]);
                description = dt.Rows[0]["description"].ToString();
                prereq_course = dt.Rows[0]["prereq_course"].ToString();
                year_semester = dt.Rows[0]["year_semester"].ToString();
                capacity = Convert.ToInt32(dt.Rows[0]["max_capacity"]);
                enrolled_student = Convert.ToInt32(dt.Rows[0]["students_enrolled"]);
                location = dt.Rows[0]["location"].ToString();
                schedule = dt.Rows[0]["schedule"].ToString();
          
                return true;
            }

            return false;
        }

        public static List<Course> getCoursesFromFaculty(string faculty_id)
        {
            List<Course> course_list = new List<Course>();
            DataTable course_table = GLOBALS.db_query("select * from course where instructor_id=" + faculty_id);
            foreach (DataRow row in course_table.Rows)
            {
                Course course = new Course(row["course_designation"].ToString());
                course.GetCourseInformation(GLOBALS.current_semester);
                course_list.Add(course);
            }

            return course_list;
        }

        public bool updateEnrolledStudent(int new_enrolled_student){
            enrolled_student = new_enrolled_student;
            string query = "update COURSE_DETAILS set students_enrolled = " + enrolled_student +
                " where course_id = " + course_id +" and year_semester= '" + GLOBALS.current_semester + "'";
            return GLOBALS.db_command(query);
        }

        public static DataTable getSemesterList()
        {
            return GLOBALS.db_query(
                "select distinct year_semester from COURSE_DETAILS"
                );

        }

        public static DataTable getCourseList()
        {
            string query = "SELECT COURSE.course_id, COURSE.course_designation, COURSE.course_title, [first_name] & \" \" & [last_name] AS instructor, DEPARTMENT.dept_name, COURSE.credit_hour, COURSE.description, COURSE.prereq_course, COURSE_DETAILS.year_semester, COURSE_DETAILS.max_capacity, COURSE_DETAILS.students_enrolled, COURSE_DETAILS.location, [schedule_days] & \" \" & Format([start_time],\"Short Time\") & \"-\" & Format([end_time],\"Short Time\") AS schedule" +
                " FROM (DEPARTMENT INNER JOIN (COURSE INNER JOIN COURSE_DETAILS ON COURSE.course_id = COURSE_DETAILS.course_id) ON DEPARTMENT.dept_id = COURSE.dept_id) INNER JOIN FACULTY ON (DEPARTMENT.dept_id = FACULTY.dept_id) AND (FACULTY.faculty_id = COURSE.instructor_id)";

            return GLOBALS.db_query(query);
        }

        public static bool update(
                    string course_id,
                    string title,
                    string course_designation,
                    string instructor_id,
                    string department_id,
                    string num_credit,
                    string course_description,
                    string pre_req_course_id,
                    string max_capacity,
                    string enrolled_student,
                    string semester)
        {
            string query;
            if (pre_req_course_id == null) pre_req_course_id = "Null";

            query = "update COURSE set course_title = '" + title + "', "
                +"course_designation = '" + course_designation + "', "
                + "instructor_id = " + instructor_id + ", "
                + "description = '" + course_description + "', "
                + "prereq_course = " + pre_req_course_id + ", "
                +"dept_id = " + department_id + ", "
                +"credit_hour = " + num_credit + " "
                +" where course_id = " + course_id;

            if (!GLOBALS.db_command(query)) return false;

            query = "update COURSE_DETAILS set "
                + "max_capacity = " + max_capacity + ", "
                + "students_enrolled = " + enrolled_student + " "
                + "where course_id = " + course_id + " "
                + "and year_semester = '" +semester + "'" ;

            if (!GLOBALS.db_command(query)) return false;

            return true;
        }

        public static bool add(
                    string course_id,
                    string title,
                    string course_designation,
                    string instructor_id,
                    string department_id,
                    string num_credit,
                    string course_description,
                    string pre_req_course_id,
                    string max_capacity,
                    string enrolled_student,
                    string semester)
        {
            string query;
            if (pre_req_course_id == null)
            {
                query = "insert into COURSE (course_id, course_title, course_designation, instructor_id, dept_id, credit_hour, description) " +
                            "values (" + course_id + ", '" + title + "', '" + course_designation + "', " + instructor_id + ", " + department_id + ", " + num_credit + ", '" + course_description + "')"; 
            }
            else
            {
                query = "insert into COURSE (course_id, course_title, course_designation, instructor_id, dept_id, credit_hour, description, prereq_course) " +
                            "values (" + course_id + ", '" + title + "', '" + course_designation + "', " + instructor_id + ", " + department_id + ", " + num_credit + ", '" + course_description + "', " + pre_req_course_id + ")";
            }
            if (!GLOBALS.db_command(query)) return false;

            query = "insert into COURSE_DETAILS (course_id, max_capacity, students_enrolled, year_semester) " +
                "values (" + course_id + ", " + max_capacity + ", " + "0" + ", '" + semester + "')";

            if (!GLOBALS.db_command(query)) return false;

            return true;
        }

        public static bool delete(string course_id)
        {
            string query = "delete from COURSE_DETAILS where " +
                "course_id= " + course_id +
                " and year_semester='" + GLOBALS.current_semester + "'";

            return GLOBALS.db_command(query);
        }

        public static string getMaxId()
        {
            DataTable course_max_id = GLOBALS.db_query("select MAX(course_id) from COURSE");

            if (course_max_id.Rows.Count == 1)
            {
                return course_max_id.Rows[0][0].ToString();
            }

            return null;
        }

        public static bool checkDuplicateCourseDesignation(string course_designation)
        {
            DataTable course_dt = GLOBALS.db_query("select * from COURSE where course_designation= '" + course_designation + "'");
            if (course_dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public static string getCourseDesignationFromId(string course_id)
        {
            DataTable course_dt = GLOBALS.db_query("select course_designation from COURSE where course_id = " + course_id);
            if (course_dt.Rows.Count == 1)
            {
                return course_dt.Rows[0][0].ToString();
            }
            return null;
        }

        public static string getCourseIdFromDesignation(string course_designation)
        {
            DataTable course_dt = GLOBALS.db_query("select course_id from COURSE where course_designation = '" + course_designation +"'");
            if (course_dt.Rows.Count == 1)
            {
                return course_dt.Rows[0][0].ToString();
            }
            return null;
        }

        public static bool checkValidCourseDesignation(string course_designation)
        {
            DataTable course_dt = GLOBALS.db_query("select * from COURSE where course_designation = '" + course_designation + "'");
            if (course_dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return (
                "Course title: " + title + Environment.NewLine+
                "Course designation: " + course_designation + Environment.NewLine +
                "Semester: " + year_semester + Environment.NewLine +
                "Instructor: " + instructor + Environment.NewLine+
                "Department: " + department + Environment.NewLine +
                "Credit hours: " + credit_hours + Environment.NewLine +
                "Location: " + location + Environment.NewLine +
                "Schedule: " + schedule + Environment.NewLine +
                "Capacity: " + capacity.ToString() + Environment.NewLine +
                "Enrolled student: " + enrolled_student.ToString() + Environment.NewLine +
                "Description: " + description + Environment.NewLine
            );

        }
    }
}
