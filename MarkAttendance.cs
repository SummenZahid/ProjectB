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
    public partial class MarkAttendance : Form
    {
        public MarkAttendance()
        {
            InitializeComponent();
        }
        private void MarkAttendance_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query = "select * from student";
            using (SqlDataAdapter a = new SqlDataAdapter(query, conn))
            {
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            }
        }
        private void btn_attandance_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                conn.Open();
                string query = "Insert into ClassAttendance (AttendanceDate) OUTPUT INSERTED.Id values('" + DateTime.Now + "')";
                SqlCommand command = new SqlCommand(query, conn);

                int attendence_id = (int)command.ExecuteScalar();


                if (row.Cells["Id"].Value != null)
                {
                    string Id = Convert.ToString(row.Cells["Id"].Value);
                    string SelectedText = Convert.ToString((row.Cells["ComboBox_atten"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                    int attendence_status = 1;
                    if (SelectedText == "Absent")
                    {
                        attendence_status = 2;
                    }
                    else if (SelectedText == "Leave")
                    {
                        attendence_status = 3;
                    }
                    else if (SelectedText == "Late")
                    {
                        attendence_status = 4;
                    }
                    string query2 = "Insert into StudentAttendance (AttendanceId,StudentId,AttendanceStatus) values('" + attendence_id + "', '" + Id + "', '" + attendence_status + "')";
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    command2.ExecuteNonQuery();
                 
                }
            }
            MessageBox.Show("Attendance Submitted Successfully");
            this.Close();
            Dashboard s = new Dashboard();
            s.Show();
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
