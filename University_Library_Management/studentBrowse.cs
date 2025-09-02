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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class studentBrowse : Form
    {
        private string sql = "Server=.;Database=Project;Integrated Security = true";
        string StudentUsername;
        public studentBrowse(string username)
        {
            InitializeComponent();
            this.StudentUsername = username;
        }

        public DataTable GetBookTable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [Project].[dbo].[BOOK]";

            try
            {
                using (SqlConnection connection = new SqlConnection(sql))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            connection.Open();
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return dt;
        }

        private void studentBrowse_Load(object sender, EventArgs e)
        {
            booksTable.DataSource = GetBookTable();

        }


        private void booksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void showborrwedbtn_Click(object sender, EventArgs e)
        {
            int studentID=0;
            string getStudentIDquery = "SELECT ID FROM STUDENT WHERE USERNAME = @username";
            SqlConnection connection = new SqlConnection(sql);
            using (SqlCommand getStudentIDcmd = new SqlCommand(getStudentIDquery, connection))
            {
                connection.Open();
                getStudentIDcmd.Parameters.AddWithValue("@username", StudentUsername);

                studentID = (int)getStudentIDcmd.ExecuteScalar();

                //MessageBox.Show(studentID.ToString());

            }

            borrowedBooks borrowed = new borrowedBooks(studentID);
            borrowed.Show();
            this.Hide();
                    
        }



        private void borrowBtn_Click(object sender, EventArgs e)
        {
            if (booksTable.CurrentRow != null)
            {
                int bookID = Convert.ToInt32(booksTable.CurrentRow.Cells[8].Value);
                DateTime borrowDate = DateTime.Today;
                DateTime returnDate = borrowDate.AddDays(10);
                int studentID = 0;

                int copyID = 0;


                using (SqlConnection connection = new SqlConnection(sql))
                {
                    string checkBookCopyQuery = "SELECT COPYBOOKID FROM BOOKCOPY WHERE BOOKID = @bookId AND STATUS = 1";
                    string getStudentIDquery = "SELECT ID FROM STUDENT WHERE USERNAME = @username";
                    string borrowQuery = "INSERT INTO BORROW (ID, BOOKID, COPYBOOKID, RETURNDATE, BORROWDATE) VALUES (@studentId, @bookId, @copyBookId, @returndate, @borrowDate)";
                    string updateQuery = "UPDATE BOOKCOPY SET STATUS = 0 WHERE BOOKID = @bookId AND COPYBOOKID = @copyBookId";
                    string checkQuery = "SELECT COUNT(*) FROM BORROW WHERE BOOKID = @bookId AND COPYBOOKID = @copyBookId";

                    connection.Open();

                    using (SqlCommand checkBookCopyCmd = new SqlCommand(checkBookCopyQuery, connection))
                    using (SqlCommand getStudentIDcmd = new SqlCommand(getStudentIDquery, connection))
                    {
                        getStudentIDcmd.Parameters.AddWithValue("@username", StudentUsername);
                        checkBookCopyCmd.Parameters.AddWithValue("@bookId", bookID);

                        try
                        {

                            object copyIDResult = checkBookCopyCmd.ExecuteScalar();
                            object studentIDResult = getStudentIDcmd.ExecuteScalar();

                            if (copyIDResult != null && studentIDResult != null)
                            {
                                 copyID = (int)copyIDResult;
                                 studentID = (int)studentIDResult;

                            }
                            else
                            {
                                if (copyIDResult == null)
                                    MessageBox.Show("No available copy found for the book.");

                                if (studentIDResult == null)
                                    MessageBox.Show("Student not found.");
                            }

                            //copyID = (int)checkBookCopyCmd.ExecuteScalar();
                            //studentID = (int)getStudentIDcmd.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occurred: " + ex.Message);
                        }
                    }


                    using (SqlCommand borrowCommand = new SqlCommand(borrowQuery, connection))
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {

                        
                        checkCommand.Parameters.AddWithValue("@bookId", bookID);
                        checkCommand.Parameters.AddWithValue("@copyBookId", copyID);

                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            Console.WriteLine("Error: The selected book copy is already borrowed.");
                            return;
                        }

                        borrowCommand.Parameters.AddWithValue("@studentId", studentID);
                        borrowCommand.Parameters.AddWithValue("@bookId", bookID);
                        borrowCommand.Parameters.AddWithValue("@copyBookId", copyID);
                        borrowCommand.Parameters.AddWithValue("@borrowDate", borrowDate);
                        borrowCommand.Parameters.AddWithValue("@returndate", returnDate);

                        updateCommand.Parameters.AddWithValue("@bookId", bookID);
                        updateCommand.Parameters.AddWithValue("@copyBookId", copyID);

                        SqlTransaction transaction = connection.BeginTransaction();
                        borrowCommand.Transaction = transaction;
                        updateCommand.Transaction = transaction;

                        try
                        {
                            updateCommand.ExecuteNonQuery();
                            borrowCommand.ExecuteNonQuery();
                            transaction.Commit();
                            MessageBox.Show("Book borrowed successfully.", "Success", MessageBoxButtons.OK);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occurred: " + ex.Message);
                            transaction.Rollback();
                        }
                    }

                    // this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to borrow.");
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();
                string updateQuery = "UPDATE [User] SET isLogin = @isLogin WHERE Username = @username";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@isLogin", false);
                updateCommand.Parameters.AddWithValue("@username", StudentUsername);
                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Logged Out");

                }

            }

            Home home=new Home();
            home.Show();
            this.Hide();
        }
    }
}
