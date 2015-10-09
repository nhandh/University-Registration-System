using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace URS
{
    class GenerateReportController
    {
        public static DataTable getSemesterList()
        {
            return Course.getSemesterList();
        }

        public static DataTable getInstructorList()
        {
            return Faculty.getInstructorList();
        }

        public static DataTable getDepartmentList()
        {
            return Faculty.getDepartmentList();
        }

        public static bool reportStudentRegistration(string student_id, string year_semester)
        {
            // check if student_id is valid
            Student student = new Student(student_id);

            if (student.getStudentInformation())
            {
                List<Course> course_list = Registration.getCoursesFromStudent(student_id, year_semester);
                // print out the list of course here
                List<string> lines = new List<string>();
                lines.Add(String.Format("Report for student ID: {0}", student_id));
                lines.Add(String.Format("Student's name: {0} {1}", student.first_name, student.last_name));
                lines.Add("Semester: " + year_semester);
                lines.Add("===============================" + Environment.NewLine);

                foreach (var course in course_list)
                {
                    lines.Add(course.course_designation);
                    lines.Add(course.title);
                    lines.Add("------------------------------" + Environment.NewLine);
                }

                //string file_name = AppDomain.CurrentDomain.BaseDirectory + String.Format("Report: Student ID {0}.txt", student_id);
                string file_path = @".\..\..\Reports\Report_Student.txt";
                System.IO.File.WriteAllLines(file_path, lines);
                System.Diagnostics.Process.Start("notepad.exe", @".\..\..\Reports\Report_Student.txt");
                return true;
            }
            return false;
        }

        public static bool reportCourseDetail(string course_designation){
            // check if student_id is valid
            Course course = new Course(course_designation);

            if (course.GetCourseInformation(GLOBALS.current_semester))
            {
                List<Student> student_list = Registration.getStudentsFromCourseCurrentSemester(course.course_id);
                List<string> lines = new List<string>();

                lines.Add(String.Format("Report for course ID: {0}", course.course_id));
                lines.Add(course.ToString());
                lines.Add("===============================" + Environment.NewLine);
                lines.Add("Students who are in this course: " + Environment.NewLine);
                lines.Add(String.Format("Student ID\t\t First name\t\t Last name" + Environment.NewLine));

                foreach (var student in student_list)
                {                   
                    lines.Add(String.Format("{0}\t\t\t {1}\t\t\t {2}", student.student_id, student.first_name, student.last_name));           
                    lines.Add(Environment.NewLine);
                }

                //string file_name = AppDomain.CurrentDomain.BaseDirectory + String.Format("Report: Student ID {0}.txt", student_id);
                string file_path = @".\..\..\Reports\Report_Course_Detail.txt";
                System.IO.File.WriteAllLines(file_path, lines);
                System.Diagnostics.Process.Start("notepad.exe", @".\..\..\Reports\Report_Course_Detail.txt");
                return true;
            }
            return false;


           
        }

        public static bool reportAllStudents()
        {
            DataTable student_table = Student.getStudentList();
            List<string> lines = new List<string>();

            // convert DataTable to string
            string student_list = String.Join(Environment.NewLine, 
                student_table.Rows.OfType<DataRow>().Select(x => String.Join(";\t", x.ItemArray)));

            lines.Add("ID \tName, \t\t\tEmail ");
            lines.Add(student_list);
            string file_path = @".\..\..\Reports\Report_All_Student.txt";
            System.IO.File.WriteAllLines(file_path, lines);
            System.Diagnostics.Process.Start("notepad.exe", file_path);

            return true;
        }


        public static bool reportAllCourses()
        {
            DataTable course_table = Course.getCourseList();
            List<string> lines = new List<string>();

            foreach (DataRow row in course_table.Rows)
            {
                lines.Add(String.Format("Course Title: {0}", row["course_title"].ToString()));
                lines.Add(String.Format("Course Designation: {0}", row["course_designation"].ToString()));
                lines.Add(String.Format("Year/ Semester: {0}", row["year_semester"].ToString()));
                lines.Add(String.Format("Instructor: {0}", row["instructor"].ToString()));
                lines.Add(String.Format("Max capacity: {0}", row["max_capacity"].ToString()));
                lines.Add(String.Format("Students enrolled: {0}", row["students_enrolled"].ToString()));
                lines.Add("------------------------------");
                lines.Add(Environment.NewLine);
            }

            string file_path = @".\..\..\Reports\Report_All_Courses.txt";
            System.IO.File.WriteAllLines(file_path, lines);
            System.Diagnostics.Process.Start("notepad.exe", file_path);

            return true;
        }
    }
}
