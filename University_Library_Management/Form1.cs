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
    public partial class admin : Form
    {

        private string sql = "Server=.;Database=Project;Integrated Security = true";

        string Username;
        public admin(string username)
        {
            InitializeComponent();
            this.Username = username;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddBook form2 = new AddBook(Username);
            form2.Show();
            this.Hide();
        }

        

        private void showbtn_Click(object sender, EventArgs e)
        {
            Books books = new Books(Username);
            books.Show();
            this.Hide();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
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
    }
}
