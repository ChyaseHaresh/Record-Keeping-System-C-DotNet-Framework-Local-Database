using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browse
{
    public partial class MemberInfo : Form
    {
        Form3 dataview = new Form3();
        public MemberInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberUpdate mu = new MemberUpdate();

            mu.ids.Text = l1.Text;

            mu.adminFname.Text = l2.Text;
            mu.adminAge.Text = l3.Text;
            mu.adminAddress.Text = l4.Text;
            mu.adminEmail.Text = l5.Text;
            mu.adminPhone.Text = l6.Text;
            mu.education.SelectedItem = l9.Text;

            if (l7.Text == "Male")
            {
                mu.male.Checked = true;
            }
            else if (l7.Text == "Female")
            {
                mu.female.Checked = true;
            }
            else
            {
                mu.male.Checked = true;
            }

            if (l8.Text != "None")
            {
                mu.disability.Checked = true;
                mu.descriptionBox.Text = l8.Text;
            }
            else
            {
                mu.disability.Checked = false;
            }
           
            mu.mType.SelectedItem = l10.Text;

            mu.ShowDialog();
            this.Close();
            dataview.loadData();

        }
    }
}
