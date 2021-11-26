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
    public partial class MemberUpdate : Form
    {
        ConnectionString objCS = new ConnectionString();

        public MemberUpdate()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = ids.Text;

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
                disable = "None";
            }

            using (SqlConnection conn = new SqlConnection(objCS.connectionPath))
            {

                string query = "UPDATE members SET fname='" + fname + "',age='" + Convert.ToInt32(age) + "',address='" + address + "',email='" + email + "',phone='" + Convert.ToInt64(phone) + "',education='" + qualification + "',gender='" + gender + "',disability='" + disable + "',mtype='" + membership + "' WHERE id='"+id+"'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The records has been Updated Successsfully 😊😊");
                    Form3 reloads = new Form3();
                    Form3 f3 = new Form3();
                    f3.Show();
                    conn.Close();
                    this.Close();


                }
            }
            


        }
    }
}
