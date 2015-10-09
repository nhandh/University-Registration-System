using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace URS
{
    public class Student
    {
        public string student_id { set; get; }
        public string first_name { set; get; }
        public string last_name { set; get; }
        public string department_id { set; get; }
        public string department { set; get; }
        public string program_id { set; get; }
        public string program_title { set; get; }
        public string current_semester_id { set; get; }
        public string current_semester { set; get; }
        public string email { set; get; }
        public string date_admission { set; get; }        
        public string phone_number { set; get; }
        public int current_credit_hour { set; get; }
        public int max_credit_hour_allowed { set; get; }

        public Student(string id)
        {
            student_id = id;
        }

        public bool getStudentInformation()
        {
            DataTable student_table = GLOBALS.db_query("select * from student where student_id=" + student_id);
            if (student_table.Rows.Count == 1)
            {
                first_name = student_table.Rows[0]["first_name"].ToString();
                last_name = student_table.Rows[0]["last_name"].ToString();
                phone_number = student_table.Rows[0]["phone_number"].ToString();
                email = student_table.Rows[0]["email"].ToString();
                department_id = student_table.Rows[0]["dept_id"].ToString();
                program_id = student_table.Rows[0]["program_id"].ToString();
                current_semester_id = student_table.Rows[0]["current_semester"].ToString();
                date_admission = student_table.Rows[0]["date_admission"].ToString();
                current_credit_hour = Convert.ToInt32(student_table.Rows[0]["current_credit_hr"]);

                // get information from department
                DataTable department_table = GLOBALS.db_query("select * from department where dept_id=" + department_id);
                if (department_table.Rows.Count == 1)
                {
                    department = department_table.Rows[0]["dept_name"].ToString();
                }

                // get information from program
                DataTable program_table = GLOBALS.db_query("select * from program where program_id=" + program_id);
                if (program_table.Rows.Count == 1)
                {
                    program_title = program_table.Rows[0]["program_title"].ToString();
                }

                // get information from semester
                DataTable semester_table = GLOBALS.db_query("select * from semester where semester_id=" + current_semester_id);
                if (semester_table.Rows.Count == 1)
                {
                    current_semester = semester_table.Rows[0]["semester_number"].ToString();
                    max_credit_hour_allowed =  Convert.ToInt32(semester_table.Rows[0]["total_credits"]);
                }

                return true;

            }
            return false;
        }

        public bool updateCreditHour(int new_credit_hour)
        {
            current_credit_hour = new_credit_hour;
            string query = "update STUDENT set current_credit_hr = " + current_credit_hour +
                " where student_id = " + student_id;
            return GLOBALS.db_command(query);
        }

        public static DataTable getStudentList(){
            return GLOBALS.db_query("select student_id, [first_name] & \" \" & [last_name] AS name, email from STUDENT");
        }

    }
}
