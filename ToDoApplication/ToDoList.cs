using System.Data;
using ToDoApplication.Data;

namespace ToDoApplication
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ToDoList_Load_1(object sender, EventArgs e)
        {
            DataBaseConnection.OpenConnection();
            DataTable table = Data.Get.GetTable.GetToDo(DataBaseConnection.SqlConnection);

            foreach (DataRow dr in table.Rows)
            {
                checkedListBox1.Items.Add($"{dr.ItemArray[1]} {dr.ItemArray[2]}");
            }
        }
    }
}