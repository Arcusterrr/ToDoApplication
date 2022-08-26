using System.Data.SqlClient;

namespace ToDoApplication.Data
{
    static class DataBaseConnection
    {
        public static SqlConnection SqlConnection = new SqlConnection(@"Data Source =USER-PC;Initial Catalog=ToDo;Integrated Security=true");

        public static void OpenConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public static void CloseConnection() 
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public static SqlConnection GetConnection()
        {
            return SqlConnection;
        }
    }
}
