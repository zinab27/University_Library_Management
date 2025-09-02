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
    public partial class Browse : Form
    {

        string sql = "Server=.;Database=Project;Integrated Security = true";

        public Browse()
        {
            InitializeComponent();
        }

        public DataTable Table()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * From Book";

            SqlConnection connection = new SqlConnection(sql);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);

            connection.Close();

            return dt;
        }

        private void Browse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Table();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            string searchBy = comboBoxSearchBy.SelectedItem.ToString(); // Get the selected search field
            string searchText = searchtxt.Text;

            DataTable dt = new DataTable();

            string query = $"SELECT * FROM Book WHERE {searchBy} LIKE '%" + searchtxt.Text + "%' ";

            SqlConnection connection = new SqlConnection(sql);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);

            connection.Close();

            dataGridView1.DataSource = dt;
        }
    }
}