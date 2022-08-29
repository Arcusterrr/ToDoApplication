using System.Data;
using System.Data.SqlClient;

namespace ToDoApplication.Data.Get
{
    public static class GetTable
    {
        public static DataTable GetToDo(SqlConnection sqlConnection)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string queryString = "select id_todo, name_todo, title_todo, isDone_todo from Tasks";
            SqlCommand cmd = new SqlCommand(queryString, sqlConnection);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            return table;
        }
    }
}
