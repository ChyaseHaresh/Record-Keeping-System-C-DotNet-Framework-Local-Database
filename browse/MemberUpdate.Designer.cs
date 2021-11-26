
namespace browse
{
    partial class MemberUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ids = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.disability = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.education = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.other = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.adminAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adminPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adminEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.ids);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mType);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.disability);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.education);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.other);
            this.panel1.Controls.Add(this.female);
            this.panel1.Controls.Add(this.male);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.adminAge);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.adminPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.adminEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.adminAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adminFname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(726, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 460);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ids
            // 
            this.ids.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ids.Enabled = false;
            this.ids.Font = new System.Drawing.Font("Arial", 12F);
            this.ids.ForeColor = System.Drawing.Color.Black;
            this.ids.Location = new System.Drawing.Point(32, 54);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(301, 26);
            this.ids.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label11.Location = new System.Drawing.Point(12, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(142)))));
            this.button1.Location = new System.Drawing.Point(382, 399);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(302, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mType
            // 
            this.mType.FormattingEnabled = true;
            this.mType.Items.AddRange(new object[] {
            "Regular",
            "Senior",
            "Junior"});
            this.mType.Location = new System.Drawing.Point(389, 334);
            this.mType.Name = "mType";
            this.mType.Size = new System.Drawing.Size(295, 21);
            this.mType.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label10.Location = new System.Drawing.Point(363, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Membership Type";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(389, 236);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(295, 47);
            this.descriptionBox.TabIndex = 23;
            this.descriptionBox.Text = "";
            this.descriptionBox.Visible = false;
            // 
            // disability
            // 
            this.disability.AutoSize = true;
            this.disability.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.disability.Location = new System.Drawing.Point(389, 199);
            this.disability.Name = "disability";
            this.disability.Size = new System.Drawing.Size(60, 26);
            this.disability.TabIndex = 22;
            this.disability.Text = "Yes";
            this.disability.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label9.Location = new System.Drawing.Point(363, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Disability";
            // 
            // education
            // 
            this.education.FormattingEnabled = true;
            this.education.Items.AddRange(new object[] {
            "SLC/ SEE",
            "+2",
            "Bachelors Degree",
            "Masters",
            "Above Masters"});
            this.education.Location = new System.Drawing.Point(382, 135);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(301, 21);
            this.education.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label8.Location = new System.Drawing.Point(363, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Education";
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.other.Location = new System.Drawing.Point(601, 52);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(75, 26);
            this.other.TabIndex = 18;
            this.other.TabStop = true;
            this.other.Text = "Other";
            this.other.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.female.Location = new System.Drawing.Point(481, 52);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(92, 26);
            this.female.TabIndex = 17;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.male.Location = new System.Drawing.Point(389, 52);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(68, 26);
            this.male.TabIndex = 16;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label7.Location = new System.Drawing.Point(363, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender";
            // 
            // adminAge
            // 
            this.adminAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminAge.Font = new System.Drawing.Font("Arial", 12F);
            this.adminAge.ForeColor = System.Drawing.Color.Black;
            this.adminAge.Location = new System.Drawing.Point(32, 195);
            this.adminAge.Name = "adminAge";
            this.adminAge.Size = new System.Drawing.Size(301, 26);
            this.adminAge.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Age";
            // 
            // adminPhone
            // 
            this.adminPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminPhone.Font = new System.Drawing.Font("Arial", 12F);
            this.adminPhone.ForeColor = System.Drawing.Color.Black;
            this.adminPhone.Location = new System.Drawing.Point(32, 408);
            this.adminPhone.Name = "adminPhone";
            this.adminPhone.Size = new System.Drawing.Size(301, 26);
            this.adminPhone.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label5.Location = new System.Drawing.Point(12, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone";
            // 
            // adminEmail
            // 
            this.adminEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.adminEmail.ForeColor = System.Drawing.Color.Black;
            this.adminEmail.Location = new System.Drawing.Point(32, 339);
            this.adminEmail.Name = "adminEmail";
            this.adminEmail.Size = new System.Drawing.Size(301, 26);
            this.adminEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail";
            // 
            // adminAddress
            // 
            this.adminAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.adminAddress.ForeColor = System.Drawing.Color.Black;
            this.adminAddress.Location = new System.Drawing.Point(32, 267);
            this.adminAddress.Name = "adminAddress";
            this.adminAddress.Size = new System.Drawing.Size(301, 26);
            this.adminAddress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // adminFname
            // 
            this.adminFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminFname.Font = new System.Drawing.Font("Arial", 12F);
            this.adminFname.ForeColor = System.Drawing.Color.Black;
            this.adminFname.Location = new System.Drawing.Point(32, 119);
            this.adminFname.Name = "adminFname";
            this.adminFname.Size = new System.Drawing.Size(301, 26);
            this.adminFname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Full Name";
            // 
            // MemberUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 460);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox ids;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox mType;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.RichTextBox descriptionBox;
        public System.Windows.Forms.CheckBox disability;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox education;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.RadioButton other;
        public System.Windows.Forms.RadioButton female;
        public System.Windows.Forms.RadioButton male;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox adminAge;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox adminPhone;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox adminEmail;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox adminAddress;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox adminFname;
        public System.Windows.Forms.Label label2;
    }
}