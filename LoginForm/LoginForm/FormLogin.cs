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
namespace LoginForm
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=YAMINIKANAKARAO\MSSQLSERVER02;Initial Catalog=LoginDB;Integrated Security=True");
            string query="Select * from login where username =  '" +txtUsername.Text.Trim()+"' and password='"+txtPassword.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                FormMain objmain = new FormMain();
                this.Hide();
                objmain.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
