﻿using System;
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
    public partial class rubric_level_details : Form
    {
        string rubric_id;
        public rubric_level_details()
        {
            InitializeComponent();
        }
        public rubric_level_details(string id)
        {
            InitializeComponent();
            this.rubric_id = id;

        }
        private void rubric_level_details_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query = "select * from RubricLevel where RubricId = '" + this.rubric_id + "' ";
            using (SqlDataAdapter a = new SqlDataAdapter(query, conn))
            {
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            }
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
                    string oString = "Select * from RubricLevel where Id='" + a + "'";
                    SqlCommand oCmd = new SqlCommand(oString, conn);
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            values[0] = oReader["Id"].ToString();
                            values[1] = oReader["RubricId"].ToString();
                            values[2] = oReader["Details"].ToString();
                            values[3] = oReader["MeasurementLevel"].ToString();
                            break;
                        }

                        conn.Close();
                    }
                }
                Rubrics_Level s = new Rubrics_Level(values[0], values[1], values[2],values[3]);
                this.Hide();
                s.Show();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                int row_index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                string query = "DELETE FROM RubricLevel WHERE Id = '" + a + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Row Deleted");
                conn.Close();

                SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                conn.Open();
                string query1 = "select * from RubricLevel where RubricId = '" + this.rubric_id + "'  ";
                using (SqlDataAdapter am = new SqlDataAdapter(query1, cnn))
                {
                    DataTable t = new DataTable();
                    am.Fill(t);
                    dataGridView1.DataSource = t;
                }
            }
        }

        private void btn_new_level_Click(object sender, EventArgs e)
        {
            Rubrics_Level r = new Rubrics_Level(rubric_id);
            r.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
