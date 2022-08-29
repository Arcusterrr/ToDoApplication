using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Windows.Forms;
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
            Add add = new Add();
            add.ShowDialog();

            ToDoList toDoList = new ToDoList();
            toDoList.Close();
            if (toDoList != null)
                toDoList.Close();
        }

        private void ToDoList_Load_1(object sender, EventArgs e)
        {
            DataBaseConnection.OpenConnection();

            checkedListBoxLoad();
        }

        public void checkedListBoxLoad ()
        {
            checkedListBox1.Items.Clear();
            DataTable table = Data.Get.GetTable.GetToDo(DataBaseConnection.SqlConnection);
            
            foreach (DataRow dr in table.Rows)
            {
                checkedListBox1.Items.Add($"{dr.ItemArray[1]} {dr.ItemArray[2]}");
            }
        }

        private void checkedListBox1_MouseClick(object sender, MouseEventArgs e)
        {

            int lastIndex = checkedListBox1.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    checkedListBox1.Items.RemoveAt(i);
                }
            }
        }
    }
}