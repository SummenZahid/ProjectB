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
    public partial class assess_comp_detail : Form
    {
        string assess_id;
        public assess_comp_detail()
        {
            InitializeComponent();
        }
        public assess_comp_detail(string id)
        {
            InitializeComponent();
            this.assess_id = id;

        }
        private void assess_comp_detail_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query = "select * from AssessmentComponent where AssessmentId = '" + this.assess_id + "' ";
            using (SqlDataAdapter a = new SqlDataAdapter(query, conn))
            {
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            }
        }

        private void btn_new_comp_Click(object sender, EventArgs e)
        {
            assessment_comp s = new assessment_comp();
            s.Show();
            this.Hide();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

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
                    string oString = "Select * from AssessmentComponent where Id='" + a + "'";
                    SqlCommand oCmd = new SqlCommand(oString, conn);
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            values[0] = oReader["Id"].ToString();
                            values[1] = oReader["Name"].ToString();
                            values[2] = oReader["RubricId"].ToString();
                            values[3] = oReader["TotalMarks"].ToString();
                            values[4] = oReader["DateCreated"].ToString();
                            values[5] = oReader["DateUpdated"].ToString();
                            values[6] = oReader["AssessmentId"].ToString();
                            break;
                        }

                        conn.Close();
                    }
                }
                assessment_comp s = new assessment_comp(values[0], values[1], values[2] , values[3] , values[4], values[5] , values[6]);
                this.Hide();
                s.Show();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                int row_index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                string query = "DELETE FROM AssessmentComponent WHERE Id = '" + a + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Row Deleted");
                conn.Close();

                SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                conn.Open();
                string query1 = "select * from AssessmentComponent where AssessmentId = '" + this.assess_id + "'  ";
                using (SqlDataAdapter am = new SqlDataAdapter(query1, cnn))
                {
                    DataTable t = new DataTable();
                    am.Fill(t);
                    dataGridView1.DataSource = t;
                }
            }
        }
    }
}
