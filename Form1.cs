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

        private void Student_Load(object sender, EventArgs e)
        {
            if (update == 1)
            {
                btn_submit.Text = "update";
            }
        }

        private void CLO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CLO c = new CLO();
            c.Show();
            this.Hide();
        }
    }
}
