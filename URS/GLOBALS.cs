using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace URS
{
    public class GLOBALS
    {
        public static string current_semester = "SP2015";
        static string connection = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\..\uni_registration.accdb; Persist Security Info=False";
            
              
        // return the data table based on a query SELECT
        public static DataTable db_query(string query){
            OleDbConnection db_connection = new OleDbConnection(connection);
            OleDbDataAdapter db_adapter = new OleDbDataAdapter(query, db_connection);
            DataTable dt = new DataTable();
            try
            {
                db_adapter.Fill(dt);
            }
            catch
            {
                return dt;
            }
            return dt;
        }

        // for non-query command, for example, INSERT, UPDATE
        public static bool db_command(string command)
        {

            try
            {
                OleDbConnection db_connection = new OleDbConnection(connection);
                OleDbCommand db_command = new OleDbCommand();
                db_command.Connection = db_connection;
                db_command.CommandText = command;

                db_connection.Open();
                db_command.ExecuteNonQuery();
                db_connection.Close();
            }
            catch
            {
                return false;
            }

            return true;

        }

        // check if a string is alpha numeric
        public static bool isAlphaNumeric(string input)
        {
            if (input.All(char.IsLetterOrDigit))
            {
                return true;
            }
            return false;
        }
    }
}
