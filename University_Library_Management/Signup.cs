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
    public partial class Signup : Form
    {
   
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
        }

        private void AddAdmin(string fName, string lName, string username, string email, string password, string id)
        {
            string query = "INSERT INTO Admin (FIRSTNAME, LASTNAME, USERNAME, EMAIL, PASSWORD, ID) VALUES (@fName, @lName, @Username, @Email, @Password, @ID)";
            string sql = "Server=.;Database=Project;Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(sql))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@fName", fName);
                command.Parameters.AddWithValue("@lName", lName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("User is Admin!");
        }

        private void AddStudent(string fName, string lName, string username, string email, string password, string id)
        {
            string query = "INSERT INTO Student (FIRSTNAME, LASTNAME, USERNAME, EMAIL, PASSWORD, ID) VALUES (@fName, @lName, @Username, @Email, @Password, @ID)";
            string sql = "Server=.;Database=Project;Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(sql))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@fName", fName);
                command.Parameters.AddWithValue("@lName", lName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("User is Student!");
        }

        private bool IsUsernameUsed(string username)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE Username = @Username";
            string connectionString = "Server=.;Database=Project;Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool IsEmailUsed(string email)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE Email = @Email";
            string connectionString = "Server=.;Database=Project;Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8 || password.Length > 20)
                return false;

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit))
                return false;

            return true;
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string fName = fnametxt.Text;
            string lName = lnametxt.Text;
            string email = emailtxt.Text;
            string username = usernametxt.Text;
            string password = passtxt.Text;
            string confirmPassword = confirmPasstxt.Text;
            string id = idtxt.Text;
            string type = adminbtn.Checked ? "Admin" : "Student";

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the passwords.");
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Invalid password. Password must be more than 8 characters and contain at least 1 uppercase letter, at least 1 lowercase letter, and at least 1 number.");
                return;
            }

            if (IsUsernameUsed(username))
            {
                MessageBox.Show("Username is already taken. Please choose another username.");
                return;
            }

            if (IsEmailUsed(email))
            {
                MessageBox.Show("Email is already taken. Please log in or sign up with another email.");
                return;
            }

            int mode = (type == "Admin"?1:0);//student=0,admin=1

            string query = "INSERT INTO [USER] (FIRSTNAME, LASTNAME, USERNAME, EMAIL, TYPE, PASSWORD, ID) VALUES (@fName, @lName, @Username, @Email, @Type, @Password, @ID)";
            string sql = "Server=.;Database=Project;Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(sql))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@fName", fName);
                command.Parameters.AddWithValue("@lName", lName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Type", mode);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("User signed up successfully!");

            if (type == "Admin")
            {
                AddAdmin(fName, lName, username, email, password, id);
            }
            else if (type == "Student")
            {
                AddStudent(fName, lName, username, email, password, id);
            }

            Home home = new Home();
            home.Show();
            this.Hide();


        }
    }
}