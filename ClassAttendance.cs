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
    public partial class ClassAttendance : Form
    {
        public ClassAttendance()
        {
            InitializeComponent();
        }
        string id;
        int update;
        public ClassAttendance(string Id, string date)
        {
            InitializeComponent();
            id = Id;
            txt_date.Text = date;
            update = 1;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_date.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                if (update == 1)
                {
                    conn.Open();
                    string query2 = "Update ClassAttendance set AttendanceDate = '" + txt_date.Value.Date + "' where Id = '"+this.id+"' ";
                    SqlCommand update_command = new SqlCommand(query2, conn);
                    int j = update_command.ExecuteNonQuery();
                    if (j != 0)
                    {
                        MessageBox.Show("Attendance Record Updated Successfully");
                        ClassAttendance ff = new ClassAttendance();
                        ff.Close();
                        AttendanceDetails ss = new AttendanceDetails();
                        ss.Show();
                        this.Hide();
                    }
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    string query = "Insert into ClassAttendance (AttendanceDate) values('" + txt_date.Value.Date + "')";
                    SqlCommand command = new SqlCommand(query, conn);
                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("CLO Record Inserted Successfully");
                        ClassAttendance f = new ClassAttendance();
                        f.Close();
                        AttendanceDetails s = new AttendanceDetails();
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

        private void ClassAttendance_Load(object sender, EventArgs e)
        {
            error_msg.Hide();
            if (update == 1)
            {
                btn_submit.Text = "update";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard c = new Dashboard();
            c.Show();
            this.Hide();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            StudentDetails c = new StudentDetails();
            c.Show();
            this.Hide();
        }

        private void btn_rubric_Click(object sender, EventArgs e)
        {
            CLO_details c = new CLO_details();
            c.Show();
            this.Hide();
        }

        private void btn_cloo_Click(object sender, EventArgs e)
        {
            CLO_details c = new CLO_details();
            c.Show();
            this.Hide();
        }
    }
}
