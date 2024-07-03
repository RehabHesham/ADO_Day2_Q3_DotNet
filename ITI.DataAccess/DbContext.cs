using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DataAccess
{
    public static class DbContext
    {
        static SqlConnection con;
        static DbContext()
        {
            con = new SqlConnection("Server=DESKTOP-FANDAQ8;Database=master;Trusted_connection=True;Trust Server Certificate=True");
        }
        // select
        public static DataTable ExecuteQuery(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }


        // insert, update, delete
        public static int ExecuteNonQuery(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, con);

            con.Open();

            int result = command.ExecuteNonQuery();

            con.Close();

            return result;
        }
    }
}
