using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class login : Form
    {
        private string sql = "Server=.;Database=Project;Integrated Security = true";

        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private bool CheckCredentialsInDatabase(string username, string password)
        {

            using (SqlConnection connection = new SqlConnection(sql))
            {
                string query = "SELECT COUNT(*) FROM [Project].[dbo].[USER] WHERE USERNAME = @Username AND PASSWORD = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private int isAdmin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(sql))
            {
                string query = "SELECT [type] FROM [Project].[dbo].[USER] WHERE USERNAME = @Username AND PASSWORD = @Password;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();

                int type = (int)command.ExecuteScalar();

                return type;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (CheckCredentialsInDatabase (username, password))
            {

                using (SqlConnection connection = new SqlConnection(sql))
                {
                    string updateQuery = "UPDATE [Project].[dbo].[USER] SET isLogin = @isLogin WHERE USERNAME = @Username";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@isLogin", true);
                    updateCommand.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                }


                //0 is student
                if (isAdmin(username, password) == 1)
                {
                    admin adminPage = new admin(username);
                    adminPage.Show();
                }
                else
                {
                    studentBrowse browseBooks = new studentBrowse(username);
                    browseBooks.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            passwordInput.PasswordChar = '*';
        }


    }
}
