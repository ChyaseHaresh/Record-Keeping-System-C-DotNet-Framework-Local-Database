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

namespace browse
{
    public partial class Form4 : Form
    {
        ConnectionString objCS = new ConnectionString();
        //Form1 main = new Form1();
        public static string name;
        public Form4()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (uname.Text == "")
            {
                MessageBox.Show("The username must not be empty !!");
            }
            else if (pass.Text == "")
            {
                MessageBox.Show("Password field must not be empty..");
            }
            else
            {
                using(SqlConnection conn= new SqlConnection(objCS.connectionPath))
                {
                   
                   // string query = "SELECT * FROM admins WHEERE username='"+uname.Text+"' AND password='"+pass.Text+"'";
                    string q = "SELECT * FROM admins WHERE username='"+uname.Text+"' AND password='"+pass.Text+"'";
                    using (SqlCommand cmd= new SqlCommand(q, conn))
                    {
                        conn.Open();
                       
                        SqlDataReader meroReader = cmd.ExecuteReader();
                        if (meroReader.Read() == true)
                        {
                            name=meroReader[1].ToString();
                            Form1 f1 = new Form1();
                            f1.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("The username or passsword seems to be wrong..");
                        }
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                pass.PasswordChar = '\0';
            }
            else
            {
                pass.PasswordChar = '#';
            }

        }

        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 recover = new Form5();
            recover.Show();
        }
    }
}
