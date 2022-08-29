using System.Data;
using System.Data.SqlClient;

namespace ToDoApplication.Data.Extensions
{
    public static class InsertIntoTasks
    {
        public static void InsertToDo(SqlConnection sqlConnection, string name, string description)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string queryString = $"insert Tasks(name_todo, title_todo, isDone_todo) values ('{name}', '{description}', 0)";
            SqlCommand cmd = new SqlCommand(queryString, sqlConnection);
            
            cmd.ExecuteNonQuery();
        }
    }
}
