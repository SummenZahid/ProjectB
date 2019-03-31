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
    public partial class Rubrics_Level : Form
    {
        string rubric_id;
        string id;
        int update;
        public Rubrics_Level()
        {
            InitializeComponent();
        }
        public Rubrics_Level(string id)
        {
            InitializeComponent();
            this.rubric_id = id;
        }
        public Rubrics_Level(string Id, string rubric_id, string details , string measurement_level)
        {
            InitializeComponent();
            id = Id;
            txt_details.Text = details;
            cmb_level.Text = measurement_level;
            this.rubric_id = rubric_id;
            update = 1;

        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_details.Text != "" && cmb_level.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                if (update == 1 )
                {
                    if (cmb_rubric_ID.Text != "")
                    {
                        conn.Open();
                        string RubricID = (cmb_rubric_ID.SelectedItem as ComboboxItem).Value.ToString();
                        string query2 = "Update RubricLevel set RubricId = '" + RubricID + " ',  Details = '" + txt_details.Text + " ', MeasurementLevel = '" + cmb_level.Text + " '  where Id = '" + this.id + "'";
                        SqlCommand update_command = new SqlCommand(query2, conn);
                        int j = update_command.ExecuteNonQuery();
                        if (j != 0)
                        {
                            MessageBox.Show("Rubrics_Level Record Updated Successfully");
                            Rubrics_Level ff = new Rubrics_Level();
                            ff.Close();
                            rubric_level_details ss = new rubric_level_details(rubric_id);
                            ss.Show();
                            this.Hide();
                        }
                        conn.Close();
                    }
                    error_msg.Show();
                }
                else
                {
                    cmb_rubric_ID.Hide();
                    conn.Open();
                    string query = "Insert into RubricLevel (RubricId,Details,MeasurementLevel) values('" + this.rubric_id + "', '" + txt_details.Text + "','" + cmb_level.Text + "' )";
                    SqlCommand command = new SqlCommand(query, conn);
                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Rubrics_level Record Inserted Successfully");
                        Rubrics_Level f = new Rubrics_Level();
                        f.Close();
                        rubric_level_details s = new rubric_level_details(rubric_id);
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

        private void Rubrics_Level_Load(object sender, EventArgs e)
        {
            error_msg.Hide();
            if (update == 1)
            {
                btn_submit.Text = "update";
                cmb_rubric_ID.Show();
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                conn.Open();
                string query1 = "Select * from Rubric";
                SqlCommand command = new SqlCommand(query1, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = Convert.ToString(reader["Details"]);
                        item.Value = Convert.ToString(reader["Id"]); ;

                        cmb_rubric_ID.Items.Add(item);
                    }
                }
            }
            else
            {
                cmb_rubric_ID.Hide();
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
            Student d = new Student();
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
