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
using System.Text.RegularExpressions;

namespace mini_project
{
    public partial class Student : Form
    {
        string id;
        int update;
        public Student()
        {
            InitializeComponent();
        }
        public Student(string Id, string fname, string lname, string contact, string email, string reg, string status)
        {
            InitializeComponent();
            id = Id;
            txt_fname.Text = fname;
            txt_lname.Text = lname;
            txt_contact.Text = contact;
            txt_email.Text = email;
            txt_registration.Text = reg;
            cmb_status.Text = status.ToString();
            update = 1;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (txt_fname.Text != "" && txt_lname.Text != "" && txt_contact.Text != "" && txt_email.Text != "" && txt_registration.Text != "" && cmb_status.Text != "" && reg.IsMatch(txt_email.Text) && txt_contact.Text.All(c => char.IsDigit(c))) 
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                int LookupId = 5;
                if (cmb_status.Text == "Active")
                {
                    LookupId = 5;
                }
                else
                {
                    LookupId = 6;
                }
                if (update == 1)
                {
                    conn.Open();
                    string query2 = "Update Student set FirstName = '" + txt_fname.Text + " ', LastName = '" + txt_lname.Text + "' , Contact = '" + txt_contact.Text + "', Email = '" + txt_email.Text + "' , RegistrationNumber= '" + txt_registration.Text + " ', Status = '" + LookupId + "' where Id = '" + this.id + "'";
                    SqlCommand update_command = new SqlCommand(query2, conn);
                    int j = update_command.ExecuteNonQuery();
                    if (j != 0)
                    {
                        MessageBox.Show("Student Record Updated Successfully");
                        Student ff = new Student();
                        ff.Close();
                        StudentDetails ss = new StudentDetails();
                        ss.Show();
                        this.Hide();
                    }
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    string query = "Insert into Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) values('" + txt_fname.Text + "', '" + txt_lname.Text + "', '" + txt_contact.Text + "', '" + txt_email.Text + "', '" + txt_registration.Text + "', '" + LookupId + "')";
                    SqlCommand command = new SqlCommand(query, conn);
                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Student Record Inserted Successfully");
                        Student f = new Student();
                        f.Close();
                        StudentDetails s = new StudentDetails();
                        this.Hide();
                        s.Show();
                    }
                    conn.Close();
                }
            }
            else
            {
                if (!txt_contact.Text.All(c => char.IsDigit(c) && txt_contact.Text != ""))
                {
                    error_msg.Text = "Contact Number Must Be Digits";
                }
                else if (!reg.IsMatch(txt_email.Text) && txt_email.Text != "")
                {
                    error_msg.Text = "Email is not in correct format";
                }
                else
                {
                    error_msg.Text = "Please Fill In All The Required Fields";
                }
                error_msg.Show();
            }
           
        }

        private void Student_Load(object sender, EventArgs e)
        {
            error_msg.Hide();
            if (update == 1)
            {
                btn_submit.Text = "update";
            }
        }

        private void CLO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard c = new Dashboard();
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }

        private void btn_clo_Click(object sender, EventArgs e)
        {
            CLO_details c = new CLO_details();
            c.Show();
            this.Hide();
        }

        private void btn_rubric_Click(object sender, EventArgs e)
        {
            
            CLO_details c = new CLO_details();
            c.Show();
            MessageBox.Show("SELECT CLO TO ADD OR SHOW RUBRICS");
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_rubric_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_cloo_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btn_student_Click_1(object sender, EventArgs e)
        {
            StudentDetails s = new StudentDetails();
            s.Show();
            this.Hide();
        }

        private void btn_rubric_Click_2(object sender, EventArgs e)
        {
            CLO_details r = new CLO_details();
            MessageBox.Show("Select clo to add or show rubrics");
            r.Show();
            this.Hide();
        }

        private void btn_cloo_Click_1(object sender, EventArgs e)
        {
            CLO_details c = new CLO_details();
            this.Hide();
            c.Show();
            
        }
    }
}
