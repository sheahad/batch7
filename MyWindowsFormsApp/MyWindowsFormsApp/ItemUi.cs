using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class ItemUi : Form
    {
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Connection
            string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"INSERT INTO Items (Name, Price) Values ('"+nameTextBox.Text+"', "+priceTextBox.Text+")";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();
            
            //Execute
            int isExecuted = sqlCommand.ExecuteNonQuery();

            if (isExecuted > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            //Close
            sqlConnection.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Connection
            string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            //SELECT * FROM Items
            string commandString = @"SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Execute
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable= new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = dataTable;
            }
            else {
                showDataGridView.DataSource = null;
                MessageBox.Show("No Data Found");
            }
            

            //Close
            sqlConnection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Connection
            string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            //DELETE FROM Items WHERE ID = 3
            string commandString = @"DELETE FROM Items WHERE ID = "+idTextBox.Text+"";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Execute
            int isExecuted = sqlCommand.ExecuteNonQuery();

            if (isExecuted > 0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            //Close
            sqlConnection.Close();
        }
    }
}
