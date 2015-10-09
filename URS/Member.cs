using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;


namespace URS
{
    static class Member
    {
        public static string membership_type { set; get; }
        public static string member_id { set; get; }
        public static string member_username { set; get; }
        public static string password { set; get; }

        static public bool Validate()
        {

            string query = "select * from login where username='" + member_username + "' and password='" + password + "'";
            DataTable dt = GLOBALS.db_query(query);

            if (dt.Rows.Count == 1)
            {
                member_id = dt.Rows[0]["user_id"].ToString();
                membership_type = dt.Rows[0]["Role"].ToString();
                return true;
            }

            return false;
        }


    }
}
