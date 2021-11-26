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
    public partial class smcc : Form
    {
        ConnectionString objCS = new ConnectionString();
        public smcc()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(objCS.connectionPath))
            {
                string Q = "SELECT members.fname, members.age, members.address, members.email, members.phone, members.education, members.gender, members.mtype FROM members inner join assign on assign.id= members.id WHERE ccid=1";
                //id as id, fname as fname, age as age, address as address, email as mail, phone as ph, education as  edu, gender as gender, disability as dis, mtype as mtype
                using (SqlCommand cmd = new SqlCommand(Q, conn))
                {
                    conn.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    int k = 0;
                    while (myReader.Read() == true)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[k].Cells["Column1"].Value = myReader[0].ToString();
                        dataGridView1.Rows[k].Cells["Column2"].Value = myReader[1].ToString();
                        dataGridView1.Rows[k].Cells["Column3"].Value = myReader[2].ToString();
                        dataGridView1.Rows[k].Cells["Column4"].Value = myReader[3].ToString();
                        dataGridView1.Rows[k].Cells["Column5"].Value = myReader[4].ToString();
                        dataGridView1.Rows[k].Cells["Column6"].Value = myReader[5].ToString();
                        dataGridView1.Rows[k].Cells["Column7"].Value = myReader[6].ToString();
                        dataGridView1.Rows[k].Cells["Column8"].Value = myReader[7].ToString();
                        k++;

                    }
                }
            }
        }

        private void smcc_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
