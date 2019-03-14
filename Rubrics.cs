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
    public partial class Rubrics : Form
    {
        string clo_id;
        string id;
        int update;
        public Rubrics()
        {
            InitializeComponent();
        }
        public Rubrics(string id)
        {
            InitializeComponent();
            this.clo_id = id;
        }
        public Rubrics(string Id, string details, string Clo_id)
        {
            InitializeComponent();
            id = Id;
            txt_details.Text = details;
            this.clo_id = Clo_id;
            update = 1;

        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            if (update == 1)
            {
                conn.Open();
                string query2 = "Update Rubric set Details = '" + txt_details.Text + " '  where Id = '" + this.id + "'";
                SqlCommand update_command = new SqlCommand(query2, conn);
                int j = update_command.ExecuteNonQuery();
                if (j != 0)
                {
                    MessageBox.Show("Rubrics Record Updated Successfully");
                    Rubrics ff = new Rubrics();
                    ff.Close();
                    Rubric_details ss = new Rubric_details(clo_id);
                    ss.Show();
                    this.Hide();
                }
                conn.Close();
            }
            else
            {
                conn.Open();
                string query = "Insert into Rubric (Details,CloId) values('" + txt_details.Text + "','" + this.clo_id + "' )";
                SqlCommand command = new SqlCommand(query, conn);
                int i = command.ExecuteNonQuery();
                MessageBox.Show(query);
                if (i != 0)
                {
                    MessageBox.Show("Rubrics Record Inserted Successfully");
                    Rubrics f = new Rubrics();
                    f.Close();
                    Rubric_details s = new Rubric_details(clo_id);
                    this.Hide();
                    s.Show();
                }
                conn.Close();
            }
        }

        private void Rubrics_Load(object sender, EventArgs e)
        {
            if (update == 1)
            {
                btn_submit.Text = "update";
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
            StudentDetails s = new StudentDetails();
            s.Show();
            this.Hide();
        }

        private void btn_rubric_Click(object sender, EventArgs e)
        {
            CLO_details r = new CLO_details();
            MessageBox.Show("Select clo to add or show rubrics");
            r.Show();
            this.Hide();
        }

        private void btn_cloo_Click(object sender, EventArgs e)
        {
            CLO_details c = new CLO_details();
            this.Hide();
            c.Show();
        }
    }
}
