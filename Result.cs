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
    public partial class Result : Form
    {
      
        public Result()
        {
            InitializeComponent();
        }
        private void lbl_contact_Click(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {
            error_msg.Hide();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query = "Select * from Student";
            SqlCommand command = new SqlCommand(query, conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = Convert.ToString(reader["FirstName"]);
                    item.Value = Convert.ToString(reader["Id"]); ;

                    cmb_student.Items.Add(item);
                }
            }
            string query1 = "Select * from Clo";
            SqlCommand command1 = new SqlCommand(query1, conn);
            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = Convert.ToString(reader["Name"]);
                    item.Value = Convert.ToString(reader["Id"]); ;

                    cmb_clo.Items.Add(item);
                }
            }
            string query2 = "Select * from Assessment";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader = command2.ExecuteReader())
            {
                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = Convert.ToString(reader["Title"]);
                    item.Value = Convert.ToString(reader["Id"]); ;

                    cmb_assessment.Items.Add(item);
                }
            }
        }

        private void cmb_clo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string CloId = (cmb_clo.SelectedItem as ComboboxItem).Value.ToString();
            string query2 = "Select * from Rubric where CloId = '" + CloId + "' ";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = Convert.ToString(reader2["Details"]);
                    item2.Value = Convert.ToString(reader2["Id"]); ;

                    cmb_rubric.Items.Add(item2);
                }
            }
        }

        private void cmb_rubric_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string RUBRICID = (cmb_rubric.SelectedItem as ComboboxItem).Value.ToString();
            string query2 = "Select * from RubricLevel where RubricId = '" + RUBRICID + "' ";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = Convert.ToString(reader2["Details"]);
                    item2.Value = Convert.ToString(reader2["Id"]); ;

                    cmb_rubriclevel.Items.Add(item2);
                }
            }
        }

        private void cmb_assessment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string AssessmentId = (cmb_assessment.SelectedItem as ComboboxItem).Value.ToString();
            string query2 = "Select * from AssessmentComponent where AssessmentId = '" + AssessmentId + "' ";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = Convert.ToString(reader2["Name"]);
                    item2.Value = Convert.ToString(reader2["Id"]); ;

                    cmb_component.Items.Add(item2);
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (cmb_student.Text != "" && cmb_assessment.Text != "" && cmb_component.Text != "" && cmb_rubric.Text != "" && cmb_clo.Text != "" && cmb_rubriclevel.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                conn.Open();
                string RubricLevel = (cmb_rubriclevel.SelectedItem as ComboboxItem).Value.ToString();
                string StudentId = (cmb_student.SelectedItem as ComboboxItem).Value.ToString();
                string AssessmentComponent = (cmb_component.SelectedItem as ComboboxItem).Value.ToString();

                string query = "Insert into StudentResult (StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate) values('" +StudentId  + "','" + AssessmentComponent + "','" + RubricLevel + "', '" + DateTime.Today + "')";
                SqlCommand command = new SqlCommand(query, conn);
                int i = command.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Result Record Inserted Successfully");
                    string query1 = "Select StudentId,AssessmentComponentId,RubricMeasurementId from StudentResult";
                    SqlCommand command1 = new SqlCommand(query1, conn);
                    ShowResult f = new ShowResult();
                    f.Show();
                    this.Hide();
                }
                conn.Close();
            }
            else
            {
                error_msg.Show();
            }
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
