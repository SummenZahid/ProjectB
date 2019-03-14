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
    public partial class Rubric_details : Form
    {
        string clo_id;
        public Rubric_details()
        {
            InitializeComponent();
        }
        public Rubric_details(string id)
        {
            InitializeComponent();
            this.clo_id = id;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rubrics r = new Rubrics(clo_id);
            r.Show();
            this.Hide();
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
                    string oString = "Select * from Rubric where Id='" + a + "'";
                    SqlCommand oCmd = new SqlCommand(oString, conn);
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            values[0] = oReader["Id"].ToString();
                            values[1] = oReader["Details"].ToString();
                            values[2] = oReader["CloId"].ToString();
                            break;
                        }

                        conn.Close();
                    }
                }
                Rubrics s = new Rubrics(values[0], values[1], values[2]);
                this.Hide();
                s.Show();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                int row_index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                string query = "DELETE FROM Rubric WHERE Id = '" + a + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Row Deleted");
                conn.Close();

                SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                conn.Open();
                string query1 = "select * from Rubric where CloId = '" + this.clo_id + "'  ";
                using (SqlDataAdapter am = new SqlDataAdapter(query1, cnn))
                {
                    DataTable t = new DataTable();
                    am.Fill(t);
                    dataGridView1.DataSource = t;
                }
            }
        }

        private void Rubric_details_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query = "select * from Rubric where CloId = '" + this.clo_id + "' ";
            using (SqlDataAdapter a = new SqlDataAdapter(query, conn))
            {
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();

        }
    }
}
