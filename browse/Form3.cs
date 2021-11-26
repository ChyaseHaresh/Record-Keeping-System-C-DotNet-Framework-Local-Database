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
    public partial class Form3 : Form
    {
        ConnectionString objCS = new ConnectionString();
        public Form3()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadData()
        {
            dataGridView1.Rows.Clear();
            using(SqlConnection conn= new SqlConnection(objCS.connectionPath))
            {
                string Q = "SELECT * FROM members";
                //id as id, fname as fname, age as age, address as address, email as mail, phone as ph, education as  edu, gender as gender, disability as dis, mtype as mtype
                using (SqlCommand cmd= new SqlCommand(Q, conn))
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
                        dataGridView1.Rows[k].Cells["Column9"].Value = myReader[8].ToString();
                        dataGridView1.Rows[k].Cells["Column10"].Value = myReader[9].ToString();
                        k++;

                    }
                }
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            DataGridViewRow selectedRows = dataGridView1.Rows[selectedRow];
            MemberInfo mi = new MemberInfo();
           
            
            mi.l1.Text = selectedRows.Cells[0].Value.ToString();
            mi.l2.Text = selectedRows.Cells[1].Value.ToString();
            mi.l3.Text = selectedRows.Cells[2].Value.ToString();
            mi.l4.Text = selectedRows.Cells[3].Value.ToString();
            mi.l5.Text = selectedRows.Cells[4].Value.ToString();
            mi.l6.Text = selectedRows.Cells[5].Value.ToString();
            mi.l7.Text = selectedRows.Cells[7].Value.ToString();
            mi.l8.Text = selectedRows.Cells[8].Value.ToString();
            mi.l9.Text = selectedRows.Cells[6].Value.ToString();
            mi.l10.Text = selectedRows.Cells[9].Value.ToString();

            mi.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
