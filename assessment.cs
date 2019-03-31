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
    public partial class assessment : Form
    {
        string id;
        int update;
        string date;
        public assessment()
        {
            InitializeComponent();
        }
        public assessment(string Id, string title, string date_created, string total_marks ,string  total_weightage)
        {
            InitializeComponent();
            id = Id;
            txt_title.Text = title;
            txt_marks.Text = total_marks;
            txt_weightage.Text = total_weightage;
            date = date_created;
            update = 1;
        }
        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            StudentDetails d = new StudentDetails();
            d.Show();
            this.Hide();
        }

        private void btn_rubric_Click(object sender, EventArgs e)
        {
           CLO_details d = new CLO_details();
            d.Show();
            this.Hide();
        }

        private void btn_cloo_Click(object sender, EventArgs e)
        {
            CLO_details d = new CLO_details();
            d.Show();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_title.Text != "" && txt_marks.Text != "" && txt_weightage.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                if (update == 1)
                {
                    conn.Open();
                    string query2 = "Update Assessment set Title = '" + txt_title.Text + " ', DateCreated = '" + this.date + "' , TotalMarks = '" + txt_marks.Text + "' ,TotalWeightage = '" + txt_weightage.Text + "'  where Id = '" + this.id + "'";
                    SqlCommand update_command = new SqlCommand(query2, conn);
                    int j = update_command.ExecuteNonQuery();
                    if (j != 0)
                    {
                        MessageBox.Show("Assessment Record Updated Successfully");
                        assessment ff = new assessment();
                        ff.Close();
                        assessment_details ss = new assessment_details();
                        ss.Show();
                        this.Hide();
                    }
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    string query = "Insert into Assessment (Title, DateCreated, TotalMarks, TotalWeightage) values('" + txt_title.Text + "', '" + DateTime.Today + "', '" + txt_marks.Text + "' , '" + txt_weightage.Text + "')";
                    SqlCommand command = new SqlCommand(query, conn);
                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Assessment Record Inserted Successfully");
                        assessment f = new assessment();
                        f.Close();
                        assessment_details s = new assessment_details();
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

        private void assessment_Load(object sender, EventArgs e)
        {
            error_msg.Hide();
            if (update == 1)
            {
                btn_submit.Text = "update";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btn_student_Click_1(object sender, EventArgs e)
        {
            StudentDetails d = new StudentDetails();
            d.Show();
            this.Hide();
        }

        private void btn_rubric_Click_1(object sender, EventArgs e)
        {
            CLO_details d = new CLO_details();
            d.Show();
            this.Hide();
        }

        private void btn_cloo_Click_1(object sender, EventArgs e)
        {
            CLO_details d = new CLO_details();
            d.Show();
            this.Hide();
        }

        private void btn_assessment_Click(object sender, EventArgs e)
        {
            assessment_details d = new assessment_details();
            d.Show();
            this.Hide();
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            MarkAttendance d = new MarkAttendance();
            d.Show();
            this.Hide();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            ShowResult d = new ShowResult();
            d.Show();
            this.Hide();
        }
    }
}
