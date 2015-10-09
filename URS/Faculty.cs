using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace URS
{
    public class Faculty
    {
        public string faculty_id { set; get; }
        public string first_name { set; get; }
        public string last_name { set; get; }
        public string phone_number { set; get; }
        public string email { set; get; }
        public string department_id { set; get; }
        public string department { set; get; }

        public Faculty(string faculty_id_)
        {
            faculty_id = faculty_id_;
        }

        public bool getFalcutyInformation()
        {
            DataTable falcuty = GLOBALS.db_query("select * from faculty where faculty_id=" + faculty_id);
            if (falcuty.Rows.Count == 1)
            {
                first_name = falcuty.Rows[0]["first_name"].ToString();
                last_name = falcuty.Rows[0]["last_name"].ToString();
                phone_number = falcuty.Rows[0]["phone_number"].ToString();
                email = falcuty.Rows[0]["email"].ToString();
                department_id = falcuty.Rows[0]["dept_id"].ToString();
                DataTable department_table = GLOBALS.db_query("select * from department where dept_id=" + department_id );
                if (department_table.Rows.Count == 1)
                {
                    department = department_table.Rows[0]["dept_name"].ToString();
                }
                return true;

            }
            return false;
        }

        public static DataTable getInstructorList(){
            return GLOBALS.db_query(
                "select faculty_id, [first_name] & \" \" & [last_name] AS name from Faculty"
                );
        }

        public static DataTable getDepartmentList(){
            return GLOBALS.db_query(
                "select * from Department"
                );
        }



    }
}
