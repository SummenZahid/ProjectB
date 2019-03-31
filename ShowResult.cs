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
    public partial class ShowResult : Form
    {
        int clo_wise;
        string clo_id;
        int assess_wise;
        string assess_id;
        public ShowResult()
        {
            InitializeComponent();
        }
        public ShowResult(string clo)
        {
            InitializeComponent();
            clo_id = clo;
            clo_wise = 1;
        }
        public ShowResult(int assessid)
        {
            InitializeComponent();
            assess_id = assessid.ToString();
            assess_wise = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            r.Show();
            this.Hide();
        }

        private void ShowResult_Load(object sender, EventArgs e)
        {
            if(clo_wise == 1)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                conn.Open();
                string query = "select StudentId,AssessmentComponentId,RubricMeasurementId from StudentResult where RubricMeasurementId = '"+clo_id+"'  ";
                using (SqlDataAdapter a = new SqlDataAdapter(query, conn))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    dataGridView1.DataSource = t;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int component = Convert.ToInt32(row.Cells["AssessmentComponentId"].Value);
                    int rubric_level = Convert.ToInt32(row.Cells["RubricMeasurementId"].Value);
                    row.Cells["ObtainedMarks"].Value = rubric_level / 4 * component;
                }

            }
            else if (assess_wise == 1)
            {
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                    conn.Open();
                    string query = "select StudentId,AssessmentComponentId,RubricMeasurementId from StudentResult where AssessmentComponentId = '" + assess_id + "'  ";
                    using (SqlDataAdapter a = new SqlDataAdapter(query, conn))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView1.DataSource = t;
                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int component = Convert.ToInt32(row.Cells["AssessmentComponentId"].Value);
                        int rubric_level = Convert.ToInt32(row.Cells["RubricMeasurementId"].Value);
                        row.Cells["ObtainedMarks"].Value = rubric_level / 4 * component;
                    }
            }
            else
            {
             SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query = "select StudentId,AssessmentComponentId,RubricMeasurementId from StudentResult";
            using (SqlDataAdapter a = new SqlDataAdapter(query, conn))
            {
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {           
                int component = Convert.ToInt32(row.Cells["AssessmentComponentId"].Value);
                int rubric_level = Convert.ToInt32(row.Cells["RubricMeasurementId"].Value);
                row.Cells["ObtainedMarks"].Value = rubric_level / 4 * component;          
            }           
            }
           
        }

        private void btn_clo_Click(object sender, EventArgs e)
        {
            clo_wise c = new clo_wise();
            c.Show();
            this.Hide();
        }

        private void btn_assessment_Click(object sender, EventArgs e)
        {
            assess_wise c = new assess_wise();
            c.Show();
            this.Hide();
        }
    }
}
