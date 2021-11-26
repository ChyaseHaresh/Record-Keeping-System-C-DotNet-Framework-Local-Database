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
    public partial class Form2 : Form
    {
        ConnectionString objCS = new ConnectionString();
        public Form2()
        {
            InitializeComponent();
        }

        public void loadId()
        {
            using (SqlConnection conn = new SqlConnection(objCS.connectionPath))
            {

                // string query = "SELECT * FROM admins WHEERE username='"+uname.Text+"' AND password='"+pass.Text+"'";
                string q = "SELECT MAX(id) FROM members";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    conn.Open();

                    SqlDataReader meroReader = cmd.ExecuteReader();
                    if (meroReader.Read() == true)
                    {
                        ids.Text = (Convert.ToInt32(meroReader[0].ToString())+1).ToString();
                    }

                }
            }
        }
        
        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void disability_CheckedChanged(object sender, EventArgs e)
        {
            if (disability.Checked == true)
            {
                disability.Text = "Please spcify the type";
                descriptionBox.Visible = true;
            }
            else
            {
                disability.Text = "Yes";
                descriptionBox.Visible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id =ids.Text;

            string fname = adminFname.Text;
            string age = adminAge.Text;
            string address = adminAddress.Text;
            string email = adminEmail.Text;
            string phone = adminPhone.Text;
            string qualification = education.Text;
            string gender = "";
            string disable = "";
            string membership = mType.Text;

            if (male.Checked == true)
            {
                gender = "Male";
            }
            else if (female.Checked == true)
            {
                gender = "Female";

            }
            else
            {
                gender = "Other";
            }
            if (disability.Checked == true)
            {
                disable = descriptionBox.Text;
            }
            else
            {
                disable= "None";
            }

            using (SqlConnection conn= new SqlConnection(objCS.connectionPath))
            {
                string query = "INSERT INTO members VALUES('"+Convert.ToInt32(id)+"','"+fname+"','"+Convert.ToInt32(age)+"','"+address+"','"+email+"','"+Convert.ToInt64(phone)+"','"+qualification+"','"+gender+"','"+disable+"','"+membership+"')";
                using(SqlCommand cmd= new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The records has been saved Successsfully 😊😊");
                    adminAddress.Text = "";
                    adminAge.Text = "";
                    adminFname.Text = "";
                    adminEmail.Text = "";
                    adminPhone.Text = "";
                    education.Text = "";
                    mType.Text = "";
                    ids.Text = "";
                    conn.Close();
                }
            }
            loadId();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadId();
            education.Text = education.Items[0].ToString();
            mType.Text = mType.Items[0].ToString();
        }

        private void education_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
