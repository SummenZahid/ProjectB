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
    public partial class CLO : Form
    {
        string id;
        int update;
        string date;
        public CLO()
        {
            InitializeComponent();
        }
        public CLO(string Id, string name, string date_created, string date_updated)
        {
            InitializeComponent();
            id = Id;
            txt_name.Text = name;
            date = date_created;
            update = 1;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                if (update == 1)
                {
                    conn.Open();
                    string query2 = "Update Clo set Name = '" + txt_name.Text + " ', DateCreated = '" + this.date + "' , DateUpdated = '" + DateTime.Today + "' where Id = '" + this.id + "'";
                    SqlCommand update_command = new SqlCommand(query2, conn);
                    int j = update_command.ExecuteNonQuery();
                    if (j != 0)
                    {
                        MessageBox.Show("CLO Record Updated Successfully");
                        CLO ff = new CLO();
                        ff.Close();
                        CLO_details ss = new CLO_details();
                        ss.Show();
                        this.Hide();
                    }
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    string query = "Insert into Clo (Name, DateCreated, DateUpdated) values('" + txt_name.Text + "', '" + DateTime.Today + "', '" + DateTime.Now + "')";
                    SqlCommand command = new SqlCommand(query, conn);
                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("CLO Record Inserted Successfully");
                        CLO f = new CLO();
                        f.Close();
                        CLO_details s = new CLO_details();
                        this.Hide();
                        s.Show();
                    }
                    conn.Close();
                }
            }
            else
            {
                error_msg.Show();
            }
           
        }

        private void CLO_Load(object sender, EventArgs e)
        {
            error_msg.Hide();
            if (update == 1)
            {
                btn_submit.Text = "update";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            StudentDetails s = new StudentDetails();
            s.Show();
            this.Hide();
        }

        private void btn_rubric_Click(object sender, EventArgs e)
        {
            CLO_details r = new CLO_details();
            MessageBox.Show("Select clo to add or show rubrics");
            r.Show();
            this.Hide();
        }

        private void btn_cloo_Click(object sender, EventArgs e)
        {
            CLO_details c = new CLO_details();
            this.Hide();
            c.Show();
        }
    }
}
