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
    public partial class AttendanceDetails : Form
    {
        public AttendanceDetails()
        {
            InitializeComponent();
        }

        private void btn_attandance_Click(object sender, EventArgs e)
        {
            ClassAttendance c = new ClassAttendance();
            c.Show();
            this.Hide();
        }

        private void button2btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void AttendanceDetails_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query = "select * from ClassAttendance";
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
                    string oString = "Select * from ClassAttendance where Id='" + a + "'";
                    SqlCommand oCmd = new SqlCommand(oString, conn);
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            values[0] = oReader["Id"].ToString();
                            values[1] = oReader["AttendanceDate"].ToString();
                            break;
                        }

                        conn.Close();
                    }
                }
                ClassAttendance s = new ClassAttendance(values[0], values[1]);
                this.Hide();
                s.Show();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                int row_index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
                string a = Convert.ToString(selectedRow.Cells["Id"].Value);
                string q2 = "DELETE FROM Rubric where CloId = '" + a + "'";
                string query = "DELETE FROM ClassAttendance WHERE Id = '" + a + "'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlCommand s = new SqlCommand(q2, conn);
                s.ExecuteNonQuery();
                MessageBox.Show("Rubrics deleted of this CLO");
                command.ExecuteNonQuery();
                MessageBox.Show("Row Deleted");
                conn.Close();

                SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                conn.Open();
                string query1 = "select * from ClassAttendance";
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
                Rubrics r = new Rubrics(a);
                this.Hide();
                Rubric_details rr = new Rubric_details(a);
                rr.Show();
                CLO_details c = new CLO_details();
                c.Hide();

            }
        }
    }
}
