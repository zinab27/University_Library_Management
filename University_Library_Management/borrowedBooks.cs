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
    public partial class borrowedBooks : Form
    {
        string sql = "Server=.;Database=Project;Integrated Security = true";
        int userId; // Variable to store the user ID

        public borrowedBooks(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Store the user ID passed from the studentBrowse form
        }

        public DataTable Table()
        {
            DataTable dt = new DataTable();
            // Use the userId variable in your query to retrieve the user's borrowed books
            string query = "SELECT * FROM Borrow WHERE ID = @userId";

            using (SqlConnection connection = new SqlConnection(sql))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        connection.Open();
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        private void borrowedBooks_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Table();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();
                string updateQuery = "UPDATE [User] SET isLogin = @isLogin WHERE id = @id";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@isLogin", false);
                updateCommand.Parameters.AddWithValue("@id", userId);
                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Logged Out");

                }

            }

            Home home = new Home();
            home.Show();
            this.Hide();
        }


        private void backbtn_Click(object sender, EventArgs e)
        {

            string Username = "";
            string getquery = "SELECT USERNAME  FROM STUDENT WHERE ID = @id";
            SqlConnection connection = new SqlConnection(sql);
            using (SqlCommand getStudentIDcmd = new SqlCommand(getquery, connection))
            {
                connection.Open();
                getStudentIDcmd.Parameters.AddWithValue("@id", userId);

                var result = getStudentIDcmd.ExecuteScalar();
                if (result != null)
                {
                    Username = result.ToString();
                }

                //MessageBox.Show(Username.ToString());

            }


           /* using (SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();
                string query = "select username WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", userId);
                command.ExecuteNonQuery();

                Username = query.ExecuteScalar();



            }*/

            studentBrowse st = new studentBrowse(Username);
            st.Show();
            this.Hide();

        }
    }
}
