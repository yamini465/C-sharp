using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LoginUI
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            sqlcon.ConnectionString= @"Data Source = YAMINIKANAKARAO\MSSQLSERVER02; Initial Catalog = LoginDB; Integrated Security = True";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {
            
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (Username.Text.Equals(""))
            {
                Username.Text = "";
            }
        }

        private void txtUSerLeave(object sender, EventArgs e)
        {
            if(Username.Text.Equals(""))
            {
                Username.Text = @"Username\Email";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if(Password.Text.Equals("Password"))
            {
                Password.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if(Password.Text.Equals(""))
            {
                Password.Text = "Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            com.Connection = sqlcon;
            com.CommandText = "Select * from loginui";
            SqlDataReader sdr = com.ExecuteReader();
            if(sdr.Read())
            {
                if(Username.Text.Equals(sdr["username"].ToString()) && Password.Text.Equals(sdr["password"].ToString()))
                {
                    MessageBox.Show("Login Succesfully","Congrats",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Either your username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            sqlcon.Close();
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
