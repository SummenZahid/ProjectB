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
    public partial class CLO : Form
    {
        string id;
        int update;
        public CLO()
        {
            InitializeComponent();
        }
        public CLO(string Id, string name, string date_created, string date_updated)
        {
            InitializeComponent();
            id = Id;
            txt_name.Text = name;
            txt_date_created.Text = date_created;
            txt_date_update.Text = date_updated;
            update = 1;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectB;Integrated Security=True");
            if (update == 1)
            {
                conn.Open();
                string query2 = "Update Clo set Name = '" + txt_name.Text + " ', DateCreated = '" + txt_date_created.Value.Date + "' , DateUpdated = '" + txt_date_update.Value.Date + "' where Id = '" + this.id + "'";
                SqlCommand update_command = new SqlCommand(query2, conn);
                int j = update_command.ExecuteNonQuery();
                if (j != 0)
                {
                    MessageBox.Show("CLO Record Updated Successfully");
                    CLO ff = new CLO();
                    ff.Close();
                    CLO_details ss = new CLO_details();
                    ss.Show();
                    this.Hide();
                }
                conn.Close();
            }
            else
            {
                conn.Open();
                string query = "Insert into Clo (Name, DateCreated, DateUpdated) values('" + txt_name.Text + "', '" + txt_date_created.Value.Date + "', '" + txt_date_update.Value.Date + "')";
                SqlCommand command = new SqlCommand(query, conn);
                int i = command.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("CLO Record Inserted Successfully");
                    CLO f = new CLO();
                    f.Close();
                    CLO_details s = new CLO_details();
                    this.Hide();
                    s.Show();
                }
                conn.Close();
            }
        }

        private void CLO_Load(object sender, EventArgs e)
        {
            if (update == 1)
            {
                btn_submit.Text = "update";
            }
        }
    }
}
