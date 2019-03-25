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
    public partial class assessment_details : Form
    {
        public assessment_details()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                            e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                int row_index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                string[] values;
                values = new string[7];
                using (SqlConnection con = new SqlConnection("Data Source = DESKTOP - M9PBVHQ; Initial Catalog = ProjectB; Integrated Security = True"))
                {
                    string oString = "Select * from Assessment where Id='" + a + "'";
                    SqlCommand oCmd = new SqlCommand(oString, conn);
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            values[0] = oReader["Id"].ToString();
                            values[1] = oReader["Title"].ToString();
                            values[2] = oReader["DateCreated"].ToString();
                            values[3] = oReader["TotalMarks"].ToString();
                            values[4] = oReader["TotalWeightage"].ToString();
                            break;
                        }

                        conn.Close();
                    }
                }
                assessment s = new assessment(values[0], values[1], values[2], values[3] , values[4]);
                this.Hide();
                s.Show();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                int row_index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                string q2 = "DELETE FROM AssessmentComponent where AssessmentId = '" + a + "'";
                string query = "DELETE FROM Assessment WHERE Id = '" + a + "'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlCommand s = new SqlCommand(q2, conn);
                s.ExecuteNonQuery();
                MessageBox.Show("Assessment deleted of this CLO");
                command.ExecuteNonQuery();
                MessageBox.Show("Row Deleted");
                conn.Close();

                SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                conn.Open();
                string query1 = "select * from Assessment";
                using (SqlDataAdapter am = new SqlDataAdapter(query1, cnn))
                {
                    DataTable t = new DataTable();
                    am.Fill(t);
                    dataGridView1.DataSource = t;
                }
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
             e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                int row_index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                assessment_comp r = new assessment_comp(a);
                this.Hide();
                assess_comp_detail rr = new assess_comp_detail(a);
                rr.Show();
                assessment_details c = new assessment_details();
                c.Hide();

            }
        }

        private void assessment_details_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query = "select * from Assessment";
            using (SqlDataAdapter a = new SqlDataAdapter(query, conn))
            {
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            }
        }

        private void btn_assessment_Click(object sender, EventArgs e)
        {
            assessment s = new assessment();
            s.Show();
            this.Hide();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard s = new Dashboard();
            s.Show();
            this.Hide();
        }
    }
}
