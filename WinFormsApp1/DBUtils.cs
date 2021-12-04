using MySql.Data.MySqlClient;


namespace WinFormsApp1
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "notes";
            string username = "root";
            string password = "qwerty";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
