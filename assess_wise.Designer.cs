namespace mini_project
{
    partial class assess_wise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_comp = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.error_msg = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_assess = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nav = new System.Windows.Forms.TableLayoutPanel();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_rubric = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_cloo = new System.Windows.Forms.Button();
            this.btn_assessment = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_comp
            // 
            this.cmb_comp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_comp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_comp.FormattingEnabled = true;
            this.cmb_comp.Location = new System.Drawing.Point(2, 31);
            this.cmb_comp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_comp.Name = "cmb_comp";
            this.cmb_comp.Size = new System.Drawing.Size(271, 30);
            this.cmb_comp.TabIndex = 18;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(72, 269);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(423, 42);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Show Result";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Location = new System.Drawing.Point(3, 87);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(136, 100);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Component:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.cmb_comp, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(145, 90);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03267F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.93465F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03267F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(275, 94);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // error_msg
            // 
            this.error_msg.AutoSize = true;
            this.error_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.error_msg.ForeColor = System.Drawing.Color.Red;
            this.error_msg.Location = new System.Drawing.Point(145, 187);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(275, 73);
            this.error_msg.TabIndex = 7;
            this.error_msg.Text = "Please fill the require field!";
            this.error_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.56974F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.43026F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_name, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.error_msg, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(72, 3);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.84615F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.84615F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.69231F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(423, 260);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 87);
            this.label2.TabIndex = 8;
            this.label2.Text = "Assessment:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.cmb_assess, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(145, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03267F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.93465F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03267F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(275, 81);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // cmb_assess
            // 
            this.cmb_assess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_assess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_assess.FormattingEnabled = true;
            this.cmb_assess.Location = new System.Drawing.Point(2, 27);
            this.cmb_assess.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_assess.Name = "cmb_assess";
            this.cmb_assess.Size = new System.Drawing.Size(271, 30);
            this.cmb_assess.TabIndex = 18;
            this.cmb_assess.SelectedIndexChanged += new System.EventHandler(this.cmb_assess_SelectedIndexChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.61101F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.02132F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.54529F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_submit, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(161, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(563, 314);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::mini_project.Properties.Resources.student_1_512;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel4.Controls.Add(this.nav, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 68);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(726, 320);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 391);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 59);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(74, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(650, 53);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nav
            // 
            this.nav.ColumnCount = 1;
            this.nav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.nav.Controls.Add(this.btn_student, 0, 1);
            this.nav.Controls.Add(this.btn_rubric, 0, 2);
            this.nav.Controls.Add(this.button3, 0, 0);
            this.nav.Controls.Add(this.btn_cloo, 0, 3);
            this.nav.Controls.Add(this.btn_assessment, 0, 4);
            this.nav.Controls.Add(this.btn_attendance, 0, 5);
            this.nav.Controls.Add(this.btn_result, 0, 6);
            this.nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nav.Location = new System.Drawing.Point(3, 3);
            this.nav.Name = "nav";
            this.nav.RowCount = 8;
            this.nav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.nav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.nav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.nav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.nav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.nav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.nav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.nav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.nav.Size = new System.Drawing.Size(153, 314);
            this.nav.TabIndex = 4;
            // 
            // btn_student
            // 
            this.btn_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_student.FlatAppearance.BorderSize = 0;
            this.btn_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.ForeColor = System.Drawing.Color.Black;
            this.btn_student.Location = new System.Drawing.Point(2, 37);
            this.btn_student.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(149, 28);
            this.btn_student.TabIndex = 3;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click_1);
            // 
            // btn_rubric
            // 
            this.btn_rubric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rubric.FlatAppearance.BorderSize = 0;
            this.btn_rubric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rubric.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rubric.ForeColor = System.Drawing.Color.Black;
            this.btn_rubric.Location = new System.Drawing.Point(2, 71);
            this.btn_rubric.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_rubric.Name = "btn_rubric";
            this.btn_rubric.Size = new System.Drawing.Size(149, 28);
            this.btn_rubric.TabIndex = 4;
            this.btn_rubric.Text = "Rubric";
            this.btn_rubric.UseVisualStyleBackColor = false;
            this.btn_rubric.Click += new System.EventHandler(this.btn_rubric_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(2, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Dashboard";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_cloo
            // 
            this.btn_cloo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_cloo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cloo.FlatAppearance.BorderSize = 0;
            this.btn_cloo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cloo.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cloo.ForeColor = System.Drawing.Color.Black;
            this.btn_cloo.Location = new System.Drawing.Point(2, 105);
            this.btn_cloo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cloo.Name = "btn_cloo";
            this.btn_cloo.Size = new System.Drawing.Size(149, 28);
            this.btn_cloo.TabIndex = 6;
            this.btn_cloo.Text = "CLO";
            this.btn_cloo.UseVisualStyleBackColor = false;
            this.btn_cloo.Click += new System.EventHandler(this.btn_cloo_Click_1);
            // 
            // btn_assessment
            // 
            this.btn_assessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_assessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_assessment.FlatAppearance.BorderSize = 0;
            this.btn_assessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assessment.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assessment.ForeColor = System.Drawing.Color.Black;
            this.btn_assessment.Location = new System.Drawing.Point(2, 139);
            this.btn_assessment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_assessment.Name = "btn_assessment";
            this.btn_assessment.Size = new System.Drawing.Size(149, 28);
            this.btn_assessment.TabIndex = 7;
            this.btn_assessment.Text = "Assessment";
            this.btn_assessment.UseVisualStyleBackColor = false;
            this.btn_assessment.Click += new System.EventHandler(this.btn_assessment_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_attendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_attendance.FlatAppearance.BorderSize = 0;
            this.btn_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendance.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.ForeColor = System.Drawing.Color.Black;
            this.btn_attendance.Location = new System.Drawing.Point(2, 173);
            this.btn_attendance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(149, 28);
            this.btn_attendance.TabIndex = 8;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.UseVisualStyleBackColor = false;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // btn_result
            // 
            this.btn_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_result.FlatAppearance.BorderSize = 0;
            this.btn_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_result.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.ForeColor = System.Drawing.Color.Black;
            this.btn_result.Location = new System.Drawing.Point(2, 207);
            this.btn_result.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(149, 28);
            this.btn_result.TabIndex = 9;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = false;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // assess_wise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "assess_wise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "assess_wise";
            this.Load += new System.EventHandler(this.assess_wise_Load);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_comp;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label error_msg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ComboBox cmb_assess;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel nav;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_rubric;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_cloo;
        private System.Windows.Forms.Button btn_assessment;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_result;
    }
}