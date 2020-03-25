using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace Assignment1
{
    class BaseContext
    {
        private SqlCommand cmd;
        private static string connectionString = "Data Source=PRATIKPC\\SQLEXPRESS;Initial Catalog=MovieDb;Integrated Security=true";
        private SqlConnection con = new SqlConnection(connectionString);

        public SqlDataReader GetReader(string command)
        {
            cmd = new SqlCommand(command, con);
            con.Open();
            SqlDataReader sqlDataReader= cmd.ExecuteReader();
            return sqlDataReader;
        }

        public void ExecuteNonQuery(string command)
        {
            con.Open();
            cmd = new SqlCommand(command,con);
            cmd.ExecuteNonQuery();
        }

        public void CloseConnection()
        {
            con.Close();
        }
    }
}
