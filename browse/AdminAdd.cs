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
    public partial class AdminAdd : Form
    {
        ConnectionString objcs = new ConnectionString();
        public AdminAdd()
        {
            InitializeComponent();
        }
        public void loadId()
        {
            using (SqlConnection conn = new SqlConnection(objcs.connectionPath))
            {

                // string query = "SELECT * FROM admins WHEERE username='"+uname.Text+"' AND password='"+pass.Text+"'";
                string q = "SELECT MAX(id) FROM admins";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    conn.Open();

                    SqlDataReader meroReader = cmd.ExecuteReader();
                    if (meroReader.Read() == true)
                    {
                        ids.Text = (Convert.ToInt32(meroReader[0].ToString()) + 1).ToString();
                    }

                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(uname.Text=="" || pass.Text=="")
            {
                MessageBox.Show("The fields should not be empty.");
            }
            else
            {
                using(SqlConnection conn= new SqlConnection(objcs.connectionPath))
                {
                    string query = "INSERT INTO admins VALUES('" + Convert.ToInt32(ids.Text) + "','" + uname.Text + "','" + pass.Text + "',NULL)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The Admin has been saved Successsfully 😊😊");
                        ids.Text = "";
                        uname.Text = "";
                        pass.Text = "";
                        conn.Close();
                        this.Refresh();
                    }
                }
            }
            loadId();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void showPass_CheckedChanged(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void recover_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {
            loadId();

        }
    }
}
