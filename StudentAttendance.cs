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
    public partial class StudentAttendance : Form
    {
        public StudentAttendance()
        {
            InitializeComponent();
        }
        string id;
        int update;
        public StudentAttendance(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        public StudentAttendance(string attendenceid, string studentid, string status)
        {
            InitializeComponent();
            cmb_date.Text = attendenceid;
            cmb_students.Text = studentid;
            this.id = studentid;
            cmb_status.Text = status;
            update = 1;

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
            int LookupId = 5;
            if (cmb_status.Text == "1")
            {
                LookupId = 5;
            }
            else
            {
                LookupId = 6;
            }
            if (cmb_date.Text != "" && cmb_status.Text != "" && cmb_students.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                if (update == 1)
                {
                    conn.Open();
                    string Date = (cmb_date.SelectedItem as ComboboxItem).Value.ToString();
                    string Student = (cmb_students.SelectedItem as ComboboxItem).Value.ToString();
                    string query_update = "Update StudentAttendance set AttendanceId = '" + Date + " ', StudentId = '" + Student + "' , AttendanceStatus = '" + LookupId + "'  where Id = '" + this.id + "'";
                    SqlCommand update_command = new SqlCommand(query_update, conn);
                    int j = update_command.ExecuteNonQuery();
                    if (j != 0)
                    {
                        MessageBox.Show("Attendance Record Updated Successfully");
                        StudentAttendance ff = new StudentAttendance();
                        ff.Close();
                        StudentAttendanceDetail ss = new StudentAttendanceDetail();
                        ss.Show();
                        this.Hide();
                    }
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    string Date = (cmb_date.SelectedItem as ComboboxItem).Value.ToString();
                    string Student = (cmb_students.SelectedItem as ComboboxItem).Value.ToString();            
                    string query_i = "Insert into StudentAttendance (AttendanceId, StudentId, AttendanceStatus) values('" + Date + "', '" + Student + "', '" + LookupId + "')";
                    SqlCommand command_i = new SqlCommand(query_i, conn);
                    int i = command_i.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Attendance Record Inserted Successfully");
                        StudentAttendance ff = new StudentAttendance();
                        ff.Close();
                        StudentAttendanceDetail ss = new StudentAttendanceDetail();
                        ss.Show();
                        this.Hide();
                    }
                    conn.Close();
                }
            }
            else
            {
                error_msg.Show();
            }
        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query2 = "Select * from Student";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = Convert.ToString(reader2["FirstName"]);
                    item2.Value = Convert.ToString(reader2["Id"]); ;

                    cmb_students.Items.Add(item2);
                }
            }
            string query = "Select * from ClassAttendance";
            SqlCommand command = new SqlCommand(query, conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = Convert.ToString(reader["AttendanceDate"]);
                    item.Value = Convert.ToString(reader["Id"]); ;

                    cmb_date.Items.Add(item);
                }
            }
            error_msg.Hide();
            if (update == 1)
            {
                btn_submit.Text = "update";
            }
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
