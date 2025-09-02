using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class Books : Form
    {
        string sql = "Server=.;Database=Project;Integrated Security = true";

        string Username;

        public Books(string username)
        {
            InitializeComponent();
            this.Username = username;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Books_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Table();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Assuming the first column contains the ID and the second column contains the Book Name
                int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
                int selectedauthorId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
                string selectedBookName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string selectedCategory = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string selectedAuthor = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string selectedDesc = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                float selectedRate = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                string selectedISBN = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                DateTime selectedDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
                int selectedncopy = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);

                // Pass the selected data to the UpdateBook form
                //UpdateBook updateBook = new UpdateBook(selectedId, selectedBookName);
                UpdateBook updateBook = new UpdateBook(selectedId,selectedBookName,selectedauthorId,selectedISBN,selectedncopy,selectedAuthor,selectedDesc,selectedCategory,selectedRate,selectedDate);
                updateBook.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
                DeleteBook(selectedId);
                dataGridView1.DataSource = Table(); // Refresh the DataGridView after deletion
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void DeleteBook(int id)
        {
            SqlConnection connection = new SqlConnection(sql);

            connection.Open();

            string deleteBorrowQuery = "DELETE FROM BORROW WHERE BOOKID IN (SELECT BOOKID FROM BOOKCOPY WHERE BOOKID = @bookId)";
            using (SqlCommand deleteBorrowCommand = new SqlCommand(deleteBorrowQuery, connection))
            {
                deleteBorrowCommand.Parameters.AddWithValue("@bookId", id);
                deleteBorrowCommand.ExecuteNonQuery();
            }

            // Delete related records in BOOKCOPY table
            string deleteBookCopyQuery = "DELETE FROM BOOKCOPY WHERE BOOKID = @bookId";
            using (SqlCommand deleteBookCopyCommand = new SqlCommand(deleteBookCopyQuery, connection))
            {
                deleteBookCopyCommand.Parameters.AddWithValue("@bookId", id);
                deleteBookCopyCommand.ExecuteNonQuery();
            }
            string query = "DELETE FROM Book WHERE BOOKId = @Id";

            using (SqlConnection con = new SqlConnection(sql))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();
                string updateQuery = "UPDATE [User] SET isLogin = @isLogin WHERE username = @username";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@isLogin", false);
                updateCommand.Parameters.AddWithValue("@username", Username);
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
            admin admin = new admin(Username);
            admin.Show();
            this.Hide();

        }
    }
}
