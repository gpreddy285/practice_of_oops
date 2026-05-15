using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_C_
{
    internal class dbconnection
    {
        string connectionstring;
        SqlConnection connection;
        public dbconnection(string conn )
        {
            connectionstring = conn;
            connection = new SqlConnection(connectionstring);
        }
        public void openconnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection opened successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void closeconnection()
        {
            if(connection.State== System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Connection closed seccessfully");
            }
        }
    }
}
