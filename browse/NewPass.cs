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
    public partial class NewPass : Form
    {
        ConnectionString objcs = new ConnectionString();
        string user = Form5.usrname;
        public NewPass()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(pass1.Text !="" || pass2.Text != "")
            {
                if (pass1.Text == pass2.Text)
                {
                    using(SqlConnection conn= new SqlConnection(objcs.connectionPath))
                    {
                        string query = "UPDATE admins SET password='"+pass1.Text+"' WHERE username='"+user+"'";
                        using(SqlCommand cmd= new SqlCommand(query, conn))
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("The password has been changed Successfully..");
                            this.Close();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("The password should be same.");
                }
            }
            else
            {
                MessageBox.Show("The fields should not be empty.");
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                pass1.PasswordChar = '\0';
                pass2.PasswordChar = '\0';

            }
            else
            {
                pass1.PasswordChar = '#';
                pass2.PasswordChar = '#';

            }
        }
    }
}
