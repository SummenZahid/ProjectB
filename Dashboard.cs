using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLO_details c = new CLO_details();
            c.Show();
            this.Hide();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            StudentDetails s = new StudentDetails();
            this.Hide();
            s.Show();
        }

        private void btn_rubric_Click(object sender, EventArgs e)
        {
            CLO_details r = new CLO_details();
            r.Show();
            this.Hide();
            MessageBox.Show("Select CLO to add rubrics");
        }

        private void btn_level_Click(object sender, EventArgs e)
        {
            Rubrics_Level r = new Rubrics_Level() ;
            r.Show();

        }
    }
}
