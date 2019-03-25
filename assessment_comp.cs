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
    public partial class assessment_comp : Form
    {
        string assess_id;
        string id;
        string date;
        int update;
        public assessment_comp()
        {
            InitializeComponent();
        }
        public assessment_comp(string id)
        {
            InitializeComponent();
            this.assess_id = id;
        }
        public assessment_comp(string Id, string name, string rubric_id , string marks , string datecreated , string dateupdated , string assessID)
        {
            InitializeComponent();
            id = Id;
            txt_name.Text = name;
            cmb_rubric.Text = rubric_id;
            txt_marks.Text = marks;
            this.assess_id = assessID;
            date = datecreated;
            update = 1;

        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_marks.Text != "" && cmb_clo.Text!= "" && cmb_rubric.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
                if (update == 1)
                {
                    lbl_assess.Show();
                    if (cmb_assessID.Text != "")
                    {
                        
                        conn.Open();
                        string AssessID = (cmb_assessID.SelectedItem as ComboboxItem).Value.ToString();
                        string query2 = "Update AssessmentComponent set Name = '" + txt_name.Text + " ', RubricId = '" + cmb_rubric.Text + " ', TotalMarks = '" + txt_marks.Text + " ' , DateCreated = '" + this.date + " ' , DateUpdated = '" + DateTime.Today + " ', AssessmentId = '" + cmb_assessID.Text + " '   where Id = '" + this.id + "'";
                        SqlCommand update_command = new SqlCommand(query2, conn);
                        int j = update_command.ExecuteNonQuery();
                        if (j != 0)
                        {
                            MessageBox.Show("Component Record Updated Successfully");
                            assessment_comp ff = new assessment_comp();
                            ff.Close();
                            assess_comp_detail ss = new assess_comp_detail(assess_id);
                            ss.Show();
                            this.Hide();
                        }
                        conn.Close();
                    }
                    else
                    {
                        error_msg.Show();
                    }

                }
                else
                {
                    cmb_assessID.Hide();
                    conn.Open();
                    string query = "Insert into AssessmentComponent (Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) values('" + txt_name.Text + "','" + cmb_rubric.Text + "','" + txt_marks.Text + "''" + DateTime.Today + "','" + DateTime.Today + "', '" + this.assess_id + "')";
                    SqlCommand command = new SqlCommand(query, conn);
                    MessageBox.Show(query); 
                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Assessment Component Record Inserted Successfully");
                        assessment_comp f = new assessment_comp();
                        f.Close();
                        assess_comp_detail s = new assess_comp_detail(assess_id);
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

        private void assessment_comp_Load(object sender, EventArgs e)
        {
            MessageBox.Show(assess_id);
            lbl_assess.Hide();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query2 = "Select * from Clo";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = Convert.ToString(reader2["Name"]);
                    item2.Value = Convert.ToString(reader2["Id"]); ;

                    cmb_clo.Items.Add(item2);
                }
            }
            error_msg.Hide();
            if (update == 1)
            {
                btn_submit.Text = "update";
                cmb_assessID.Show();
                string query1 = "Select * from Assessment";
                SqlCommand command = new SqlCommand(query1, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = Convert.ToString(reader["Name"]);
                        item.Value = Convert.ToString(reader["Id"]); ;

                        cmb_assessID.Items.Add(item);
                    }
                }
            }
            else
            {
                cmb_assessID.Hide();
            }
        }

        private void cmb_clo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            conn.Open();
            string query2 = "Select * from Rubric where Details = '" + cmb_clo.Text + "' ";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = Convert.ToString(reader2["Details"]);
                    item2.Value = Convert.ToString(reader2["Id"]); ;

                    cmb_rubric.Items.Add(item2);
                }
            }
        }
    }
}
