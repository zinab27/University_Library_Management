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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class AddBook : Form
    {
        string sql = "Server=.;Database=Project;Integrated Security = true";

        string Username;
        public AddBook(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string isbn = isbntxt.Text;
            string rate = ratetxt.Text;
            string year = yeartxt.Text;
            string title = titletxt.Text;
            string author = authortxt.Text;
            string description = desctxt.Text;
            string category = cattxt.Text;
            string numbOfCopies =ncopytxt.Text;
            string bookid = bookidtxt.Text;
            string authorid = authoridtxt.Text;

            decimal rateValue;
            int yearValue, numbOfCopiesValue, bookidValue, authoridValue;

            if (!decimal.TryParse(rate, out rateValue) ||
                !int.TryParse(year, out yearValue) ||
                !int.TryParse(numbOfCopies, out numbOfCopiesValue) ||
                !int.TryParse(bookid, out bookidValue) ||
                !int.TryParse(authorid, out authoridValue))
            {
                MessageBox.Show("Invalid input for numeric fields.");
                return;
            }

            string query = "INSERT INTO Book (ISBN, RATE, PUBLISHEDYEAR, TITLE, AUTHOR, DESCRIPTION, CATEGORY, NUMBEROFCOPIES, BOOKID) " +
                           "VALUES (@isbn, @rate, @year, @title, @author, @description, @category, @numbOfCopies, @bookid)";

            using (SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@isbn", isbn);
                    command.Parameters.AddWithValue("@rate", rateValue);
                    command.Parameters.AddWithValue("@year", yearValue);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@numbOfCopies", numbOfCopiesValue);
                    command.Parameters.AddWithValue("@bookid", bookidValue);
                    command.ExecuteNonQuery(); // Execute the SQL command
                }
            }

            MessageBox.Show("Book added successfully.");
            admin adm = new admin(Username);
            adm.Show();
            this.Hide();

        }
    }
}
