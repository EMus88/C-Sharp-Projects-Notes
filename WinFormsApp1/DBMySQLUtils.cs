using MySql.Data.MySqlClient;
using System;


namespace WinFormsApp1
{
    class DBMySQLUtils
    {
        public static MySqlConnection
                GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection connection = new (connString);

            return connection;
        }
    }
}
