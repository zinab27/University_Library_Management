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
    public partial class UpdateBook : Form
    {

        string sql = "Server=.;Database=Project;Integrated Security = true";

        string Username;
        public UpdateBook(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void titletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private int id;
        private int authorID;
        private string isbn;
        private int nCopy;
        private string author;
        private string title;
        private string description;
        private string category;
        public float rate;
        public DateTime date;


        public UpdateBook(int bookId, string bookName, int authorID, string isbn, int nCopy, string author, string description, string category, float rate, DateTime date)
        {
            InitializeComponent();
            id = bookId;
            title = bookName;

            this.authorID = authorID;
            this.isbn = isbn;
            this.nCopy = nCopy;
            this.author = author;
            this.description = description;
            this.category = category;
            this.rate = rate;
            this.date = date;
            LoadBookDetails();
        }


        private void LoadBookDetails()
        {
            // Populate form fields with the book details
            bookidtxt.Text = id.ToString();
            titletxt.Text = title;
            authortxt.Text = author;
            authoridtxt.Text = authorID.ToString();
            isbntxt.Text = isbn;
            ncopytxt.Text = nCopy.ToString();
            desctxt.Text = description;
            cattxt.Text = category;
            ratetxt.Text = rate.ToString();
            yeartxt.Text = date.ToString();

        }
        private void UpdateBook_Load(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            // Retrieve updated values from form fields
            title = titletxt.Text;
            author = authortxt.Text;
            authorID = int.Parse(authoridtxt.Text);
            isbn = isbntxt.Text;
            nCopy = int.Parse(ncopytxt.Text);
            description = desctxt.Text;
            category = cattxt.Text;
            rate = float.Parse(ratetxt.Text);
            date = DateTime.Parse(yeartxt.Text);

            string updateQuery = "UPDATE Book SET " +
                                 "Title = @title, " +
                                 "Author = @author, " +
                                 "AuthorID = @authorID, " +
                                 "ISBN = @isbn, " +
                                 "NumberOfCopies = @nCopy, " +
                                 "Description = @description, " +
                                 "Category = @category, " +
                                 "Rate = @rate, " +
                                 "PublishedYear = @date " +
                                 "WHERE BookID = @id";

            using (SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@authorID", authorID);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@nCopy", nCopy);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@rate", rate);
                    cmd.Parameters.AddWithValue("@date", date);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book details updated successfully.");
                        Books admin = new Books(Username);
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error updating book details. No book found with the specified ID.");
                        admin adm = new admin(Username);
                        adm.Show();
                        this.Hide();
                    }
                }
            }

        }
    }
}
