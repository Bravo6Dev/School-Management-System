namespace SchoolManagment.GUI.StudentsGUI
{
    partial class StudentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            cmb_Filter = new ComboBox();
            Txt_Search = new TextBox();
            dgv_Subjects = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Btn_teachers = new Button();
            Btn_Edit = new Button();
            Btn_Delete = new Button();
            lbl_Data = new Label();
            Pic_Loading = new PictureBox();
            Btn_Excel = new Button();
            numericUpDown1 = new NumericUpDown();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Subjects).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(733, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 538);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(0, 389);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 149);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "الدرجات";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(0, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 282);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "معلومات الطالب";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Location = new Point(16, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 29);
            dateTimePicker1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(198, 209);
            label8.Name = "label8";
            label8.Size = new Size(17, 21);
            label8.TabIndex = 6;
            label8.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(231, 147);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 6;
            label6.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(84, 90);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 6;
            label4.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(231, 28);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 6;
            label2.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 209);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 5;
            label7.Text = "تاريخ الوادة :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 147);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 5;
            label5.Text = "السكن :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 90);
            label3.Name = "label3";
            label3.Size = new Size(203, 21);
            label3.TabIndex = 5;
            label3.Text = "رقم هاتف الطالب / ولي الامر :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 28);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 5;
            label1.Text = "الاسم : ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(291, 29);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 29);
            textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_Filter);
            groupBox1.Controls.Add(Txt_Search);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "البحث";
            // 
            // cmb_Filter
            // 
            cmb_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Filter.FormattingEnabled = true;
            cmb_Filter.Items.AddRange(new object[] { "لايوجد", "الاسم", "المحصل التعليمي", "رقم الهاتف" });
            cmb_Filter.Location = new Point(97, 28);
            cmb_Filter.Name = "cmb_Filter";
            cmb_Filter.Size = new Size(212, 29);
            cmb_Filter.TabIndex = 3;
            // 
            // Txt_Search
            // 
            Txt_Search.BackColor = Color.White;
            Txt_Search.BorderStyle = BorderStyle.FixedSingle;
            Txt_Search.Location = new Point(18, 68);
            Txt_Search.Name = "Txt_Search";
            Txt_Search.Size = new Size(291, 29);
            Txt_Search.TabIndex = 2;
            // 
            // dgv_Subjects
            // 
            dgv_Subjects.AllowUserToAddRows = false;
            dgv_Subjects.AllowUserToDeleteRows = false;
            dgv_Subjects.AllowUserToResizeColumns = false;
            dgv_Subjects.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.NullValue = "لايوجد";
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Subjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Subjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Subjects.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Subjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Subjects.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.NullValue = "لايوجد";
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Subjects.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Subjects.Dock = DockStyle.Fill;
            dgv_Subjects.EnableHeadersVisualStyles = false;
            dgv_Subjects.Location = new Point(0, 65);
            dgv_Subjects.MultiSelect = false;
            dgv_Subjects.Name = "dgv_Subjects";
            dgv_Subjects.ReadOnly = true;
            dgv_Subjects.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.LightGray;
            dataGridViewCellStyle4.NullValue = "لايوجد";
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Subjects.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Subjects.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Subjects.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(37, 37, 37);
            dgv_Subjects.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Subjects.RowTemplate.DefaultCellStyle.ForeColor = Color.LightGray;
            dgv_Subjects.RowTemplate.DefaultCellStyle.NullValue = "لايوجد";
            dgv_Subjects.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgv_Subjects.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Subjects.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_Subjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Subjects.Size = new Size(733, 473);
            dgv_Subjects.TabIndex = 26;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(Btn_teachers);
            flowLayoutPanel2.Controls.Add(Btn_Edit);
            flowLayoutPanel2.Controls.Add(Btn_Delete);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5, 5, 20, 5);
            flowLayoutPanel2.Size = new Size(733, 65);
            flowLayoutPanel2.TabIndex = 22;
            // 
            // Btn_teachers
            // 
            Btn_teachers.BackColor = Color.FromArgb(16, 185, 129);
            Btn_teachers.Cursor = Cursors.Hand;
            Btn_teachers.FlatAppearance.BorderSize = 0;
            Btn_teachers.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 150, 105);
            Btn_teachers.FlatStyle = FlatStyle.Flat;
            Btn_teachers.ForeColor = Color.White;
            Btn_teachers.Image = Properties.Resources.add;
            Btn_teachers.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_teachers.Location = new Point(574, 10);
            Btn_teachers.Margin = new Padding(5, 5, 10, 5);
            Btn_teachers.Name = "Btn_teachers";
            Btn_teachers.Padding = new Padding(3);
            Btn_teachers.Size = new Size(129, 43);
            Btn_teachers.TabIndex = 2;
            Btn_teachers.Text = "اضافة";
            Btn_teachers.TextAlign = ContentAlignment.MiddleLeft;
            Btn_teachers.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_teachers.UseVisualStyleBackColor = false;
            // 
            // Btn_Edit
            // 
            Btn_Edit.BackColor = Color.FromArgb(59, 130, 246);
            Btn_Edit.Cursor = Cursors.Hand;
            Btn_Edit.FlatAppearance.BorderSize = 0;
            Btn_Edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            Btn_Edit.FlatStyle = FlatStyle.Flat;
            Btn_Edit.ForeColor = Color.White;
            Btn_Edit.Image = Properties.Resources.pencil;
            Btn_Edit.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Edit.Location = new Point(430, 10);
            Btn_Edit.Margin = new Padding(5, 5, 10, 5);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Padding = new Padding(3);
            Btn_Edit.Size = new Size(129, 43);
            Btn_Edit.TabIndex = 3;
            Btn_Edit.Text = "تحديث";
            Btn_Edit.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Edit.UseVisualStyleBackColor = false;
            // 
            // Btn_Delete
            // 
            Btn_Delete.BackColor = Color.FromArgb(239, 68, 68);
            Btn_Delete.Cursor = Cursors.Hand;
            Btn_Delete.FlatAppearance.BorderSize = 0;
            Btn_Delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 38, 38);
            Btn_Delete.FlatStyle = FlatStyle.Flat;
            Btn_Delete.ForeColor = Color.White;
            Btn_Delete.Image = Properties.Resources.bin;
            Btn_Delete.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Delete.Location = new Point(286, 10);
            Btn_Delete.Margin = new Padding(5, 5, 10, 5);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Padding = new Padding(3);
            Btn_Delete.Size = new Size(129, 43);
            Btn_Delete.TabIndex = 4;
            Btn_Delete.Text = "حذف";
            Btn_Delete.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.BackColor = Color.FromArgb(30, 30, 30);
            lbl_Data.ForeColor = Color.White;
            lbl_Data.Location = new Point(324, 258);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(91, 21);
            lbl_Data.TabIndex = 23;
            lbl_Data.Text = "لايوجد بيانات";
            lbl_Data.Visible = false;
            // 
            // Pic_Loading
            // 
            Pic_Loading.BackColor = Color.FromArgb(30, 30, 30);
            Pic_Loading.Image = Properties.Resources.hzk6C;
            Pic_Loading.Location = new Point(255, 227);
            Pic_Loading.Name = "Pic_Loading";
            Pic_Loading.Size = new Size(241, 84);
            Pic_Loading.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Loading.TabIndex = 24;
            Pic_Loading.TabStop = false;
            // 
            // Btn_Excel
            // 
            Btn_Excel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_Excel.BackColor = Color.FromArgb(30, 30, 30);
            Btn_Excel.Cursor = Cursors.Hand;
            Btn_Excel.FlatAppearance.BorderSize = 0;
            Btn_Excel.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 150, 105);
            Btn_Excel.FlatStyle = FlatStyle.Flat;
            Btn_Excel.ForeColor = Color.White;
            Btn_Excel.Image = Properties.Resources.office365;
            Btn_Excel.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Excel.Location = new Point(676, 490);
            Btn_Excel.Margin = new Padding(6, 7, 13, 7);
            Btn_Excel.Name = "Btn_Excel";
            Btn_Excel.Padding = new Padding(5);
            Btn_Excel.Size = new Size(41, 41);
            Btn_Excel.TabIndex = 25;
            Btn_Excel.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Excel.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(46, 46, 46);
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(238, 59);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(71, 29);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.UpDownAlign = LeftRightAlignment.Left;
            // 
            // StudentUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            Controls.Add(lbl_Data);
            Controls.Add(Pic_Loading);
            Controls.Add(Btn_Excel);
            Controls.Add(dgv_Subjects);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "StudentUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1048, 538);
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Subjects).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_Subjects;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button Btn_teachers;
        private Button Btn_Edit;
        private Button Btn_Delete;
        private Label lbl_Data;
        private PictureBox Pic_Loading;
        private Button Btn_Excel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox cmb_Filter;
        private TextBox Txt_Search;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private TextBox textBox3;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
    }
}
