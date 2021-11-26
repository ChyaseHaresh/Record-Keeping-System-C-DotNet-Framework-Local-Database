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
    public partial class ChangeRecovery : Form
    {
        ConnectionString objcs = new ConnectionString();
        Form1 f1 = new Form1();
        

        public ChangeRecovery()
        {
            InitializeComponent();
        }
        private void recover_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (recover.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(objcs.connectionPath))
                {
                    string usr = f1.user.Text;
                    string query = "UPDATE admins SET recovery='" + recover.Text + "' WHERE username='" + usr + "'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The recovery answer has been changed Successfully..");
                        this.Close();
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("The password should be same.");
            }
        }

        private void recover_Click_1(object sender, EventArgs e)
        {
            label6.Visible = true;
        }
    }
}
