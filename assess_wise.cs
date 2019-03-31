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
    public partial class assess_wise : Form
    {
        public assess_wise()
        {
            InitializeComponent();
        }

        private void cmb_assess_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string assess_id = (cmb_assess.SelectedItem as ComboboxItem).Value.ToString();
            string query2 = "Select * from AssessmentComponent where AssessmentId = '"+assess_id+"' ";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = Convert.ToString(reader2["Name"]);
                    item2.Value = Convert.ToString(reader2["Id"]); ;

                    cmb_comp.Items.Add(item2);
                }
            }
        }

        private void assess_wise_Load(object sender, EventArgs e)
        {
            error_msg.Hide();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query2 = "Select * from Assessment";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = Convert.ToString(reader2["Title"]);
                    item2.Value = Convert.ToString(reader2["Id"]); ;

                    cmb_assess.Items.Add(item2);
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string Assess_id = (cmb_comp.SelectedItem as ComboboxItem).Value.ToString();
            ShowResult f = new ShowResult(Convert.ToInt32(Assess_id));
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
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
