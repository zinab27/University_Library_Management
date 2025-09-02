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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            Browse books = new Browse();
            books.Show();
            this.Hide();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            Query q = new Query();
            q.Show();
            this.Hide();
        }
    }
}
