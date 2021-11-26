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
    public partial class Form1 : Form
    {
        ConnectionString objcs = new ConnectionString();
        Form4 f4 = new Form4();
        string naam = Form4.name;
        public Form1()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
            if (addPanel.Visible == true)
                addPanel.Visible = false;
            if (viewRecordPanel.Visible == true)
                viewRecordPanel.Visible = false;
            if (committeePanel.Visible == true)
                committeePanel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(addPanel);
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
           openChildForm(new AdminAdd());
            hideSubMenu();
        }

        private void addNewMemberBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void addSeniorMemberbtn_Click(object sender, EventArgs e)
        {
            ChangeRecovery chr = new ChangeRecovery();
            chr.ShowDialog();
            hideSubMenu();
        }

        private void vieBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(viewRecordPanel);
        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();
        }

        private void foundingMembersBtn_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void viewNewMemberBtn_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void commityBtn_Click(object sender, EventArgs e)
        {
        }

        private void smcBtn_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void yecBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            controlPanel1.Controls.Add(childForm);
            controlPanel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(naam);
            user.Text = naam;
            using (SqlConnection conn = new SqlConnection(objcs.connectionPath))
            {

                // string query = "SELECT * FROM admins WHEERE username='"+uname.Text+"' AND password='"+pass.Text+"'";
                string q = "SELECT* FROM admins WHERE username='" + naam + "'";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    conn.Open();

                    SqlDataReader meroReader = cmd.ExecuteReader();
                    if (meroReader.Read() == true)
                    {
                        //string check = meroReader["rv"].ToString();
                       // MessageBox.Show(meroReader[0] + " " + meroReader[1] + " " + meroReader[2] + " " + meroReader[3]);
                       if (meroReader[3].ToString() != "")
                        {
                            txt.Visible=false;

                        }
                    }
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt.Hide();
        }

        private void assign_Click(object sender, EventArgs e)
        {
            openChildForm(new Assign());
            hideSubMenu();
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            //dialog= MessageBox.Show();
            if (MessageBox.Show("Do you really want to exit ?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Form4 f4 = new Form4();
                //f4.Show();
                //f4.Close();
                Environment.Exit(0);

            }
        }

        private void yecBtn_Click_1(object sender, EventArgs e)
        {
            openChildForm(new yec());
            hideSubMenu();
        }

        private void smcBtn_Click_1(object sender, EventArgs e)
        {
            openChildForm(new smcc());
            hideSubMenu();
        }

        private void commityBtn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(committeePanel);
        }
    }
}
