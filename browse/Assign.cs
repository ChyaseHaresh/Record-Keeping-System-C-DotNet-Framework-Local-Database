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
    public partial class Assign : Form
    {
        public int memId, comityId;
        ConnectionString objcs = new ConnectionString();

        public Assign()
        {
            InitializeComponent();
        }

        public void loadId()
        {
            using (SqlConnection conn = new SqlConnection(objcs.connectionPath))
            {

                // string query = "SELECT * FROM admins WHEERE username='"+uname.Text+"' AND password='"+pass.Text+"'";
                string q = "SELECT MAX(id) FROM assign";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    conn.Open();

                    SqlDataReader meroReader = cmd.ExecuteReader();
                    if (meroReader.Read() == true)
                    {
                        id.Text = (Convert.ToInt32(meroReader[0].ToString()) + 1).ToString();
                    }

                }
            }
        }
        public void loadMembers()
        {
            using (SqlConnection conn = new SqlConnection(objcs.connectionPath))
            {
                string Q = "SELECT fname FROM members";
                //id as id, fname as fname, age as age, address as address, email as mail, phone as ph, education as  edu, gender as gender, disability as dis, mtype as mtype
                using (SqlCommand cmd = new SqlCommand(Q, conn))
                {
                    conn.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    //int k = 0;
                    while (myReader.Read() == true)
                    {
                        cmbMember.Items.Add(myReader[0].ToString());

                    }
                    cmbMember.Text = cmbMember.Items[0].ToString();

                }
            }
        }

        public void loadCommittee()
        {
            using (SqlConnection conn = new SqlConnection(objcs.connectionPath))
            {
                string Q = "SELECT comity FROM committee";
                //id as id, fname as fname, age as age, address as address, email as mail, phone as ph, education as  edu, gender as gender, disability as dis, mtype as mtype
                using (SqlCommand cmd = new SqlCommand(Q, conn))
                {
                    conn.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    //int k = 0;
                    while (myReader.Read() == true)
                    {
                        cmbCmt.Items.Add(myReader[0].ToString());

                    }
                    cmbCmt.Text = cmbCmt.Items[0].ToString();
                }
            }
        }

        public int getMemberId()
        {
            using (SqlConnection conn = new SqlConnection(objcs.connectionPath))
            {
                string Q = "SELECT id FROM members WHERE fname='"+cmbMember.Text+"'";
                using (SqlCommand cmd = new SqlCommand(Q, conn))
                {
                    conn.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();

                    while (myReader.Read() == true)
                    {
                        memId = Convert.ToInt32(myReader[0]);

                    }
                }
            }
            return memId;
        }

        public int getComityId()
        {
            using (SqlConnection conn = new SqlConnection(objcs.connectionPath))
            {
                string Q = "SELECT id FROM committee WHERE comity='"+cmbCmt.Text+"'";
                using (SqlCommand cmd = new SqlCommand(Q, conn))
                {
                    conn.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();

                    while (myReader.Read() == true)
                    {
                        comityId = Convert.ToInt32(myReader[0]);

                    }
                }
            }
            return comityId;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int mid= getMemberId();
            int cid= getComityId();
            using (SqlConnection conn = new SqlConnection(objcs.connectionPath))
            {
                string query = "INSERT INTO assign VALUES('" + Convert.ToInt32(id.Text) + "','" + mid + "','" + cid + "')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Committee has been assigned Successsfully 😊😊");
                    
                    conn.Close();
                }
            }
            loadId();
        }

        private void Assign_Load(object sender, EventArgs e)
        {
            loadId();
            loadMembers();
            loadCommittee();
        }
    }
}
