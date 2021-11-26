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
    public partial class Form5 : Form
    {
        ConnectionString objcs = new ConnectionString();
        public static string usrname;
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(uname.Text=="" || uname.Text == "")
            {
                MessageBox.Show("Fields can't be empty.");
            }
            else
            {
                using(SqlConnection conn= new SqlConnection(objcs.connectionPath))
                {
                    string q = "SELECT * FROM admins WHERE username='" + uname.Text + "' AND recovery='" + answer.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        conn.Open();

                        SqlDataReader meroReader = cmd.ExecuteReader();
                        if (meroReader.Read() == true)
                        {
                            usrname = meroReader[1].ToString();
                            NewPass f1 = new NewPass();
                            f1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("The username or answer seems to be wrong..");
                        }
                    }
                }
            }
        }
    }
}
