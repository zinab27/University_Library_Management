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

namespace WindowsFormsApp2
{
    public partial class Query : Form
    {
        private string sql = "Server=.;Database=Project;Integrated Security = true";

        public Query()
        {
            InitializeComponent();
        }

        private void Query_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            string query = queryInput.Text;
            using (SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void queryInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
