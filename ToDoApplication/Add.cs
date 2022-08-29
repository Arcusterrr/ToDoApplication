using ToDoApplication.Data.Extensions;
using ToDoApplication.Data;
using System.Data.SqlClient;

namespace ToDoApplication
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_todo = textBox1.Text.ToString();
            string description_todo = textBox2.Text.ToString();

            SqlConnection sqlConnection = DataBaseConnection.SqlConnection;
            Data.Extensions.InsertIntoTasks.InsertToDo(sqlConnection, name_todo, description_todo);


            ToDoList toDoList = new ToDoList();
            toDoList.checkedListBoxLoad();

            Add add = new Add();
            this.Close();
            if (add != null)
                add.Close();

        }
    }
}
