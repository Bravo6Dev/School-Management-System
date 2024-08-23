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
            dgv_Student = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Btn_teachers = new Button();
            Btn_Edit = new Button();
            Btn_Delete = new Button();
            Btn_Degree = new Button();
            panel1 = new Panel();
            cmb_Filter = new ComboBox();
            Txt_Search = new TextBox();
            lbl_Data = new Label();
            Pic_Loading = new PictureBox();
            Btn_Excel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Student).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).BeginInit();
            SuspendLayout();
            // 
            // dgv_Student
            // 
            dgv_Student.AllowUserToAddRows = false;
            dgv_Student.AllowUserToDeleteRows = false;
            dgv_Student.AllowUserToResizeColumns = false;
            dgv_Student.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.NullValue = "لايوجد";
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Student.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Student.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.NullValue = "لايوجد";
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Student.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Student.Dock = DockStyle.Fill;
            dgv_Student.EnableHeadersVisualStyles = false;
            dgv_Student.Location = new Point(0, 65);
            dgv_Student.MultiSelect = false;
            dgv_Student.Name = "dgv_Student";
            dgv_Student.ReadOnly = true;
            dgv_Student.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.LightGray;
            dataGridViewCellStyle4.NullValue = "لايوجد";
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Student.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Student.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Student.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(37, 37, 37);
            dgv_Student.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Student.RowTemplate.DefaultCellStyle.ForeColor = Color.LightGray;
            dgv_Student.RowTemplate.DefaultCellStyle.NullValue = "لايوجد";
            dgv_Student.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgv_Student.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Student.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_Student.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Student.Size = new Size(1048, 473);
            dgv_Student.TabIndex = 26;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(Btn_teachers);
            flowLayoutPanel2.Controls.Add(Btn_Edit);
            flowLayoutPanel2.Controls.Add(Btn_Delete);
            flowLayoutPanel2.Controls.Add(Btn_Degree);
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5, 5, 20, 5);
            flowLayoutPanel2.Size = new Size(1048, 65);
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
            Btn_teachers.Location = new Point(916, 10);
            Btn_teachers.Margin = new Padding(5, 5, 10, 5);
            Btn_teachers.Name = "Btn_teachers";
            Btn_teachers.Padding = new Padding(3);
            Btn_teachers.Size = new Size(102, 43);
            Btn_teachers.TabIndex = 2;
            Btn_teachers.Text = "اضافة";
            Btn_teachers.TextAlign = ContentAlignment.MiddleLeft;
            Btn_teachers.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_teachers.UseVisualStyleBackColor = false;
            Btn_teachers.Click += Btn_teachers_Click;
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
            Btn_Edit.Location = new Point(799, 10);
            Btn_Edit.Margin = new Padding(5, 5, 10, 5);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Padding = new Padding(3);
            Btn_Edit.Size = new Size(102, 43);
            Btn_Edit.TabIndex = 3;
            Btn_Edit.Text = "تحديث";
            Btn_Edit.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Edit.UseVisualStyleBackColor = false;
            Btn_Edit.Click += Btn_Edit_Click;
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
            Btn_Delete.Location = new Point(682, 10);
            Btn_Delete.Margin = new Padding(5, 5, 10, 5);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Padding = new Padding(3);
            Btn_Delete.Size = new Size(102, 43);
            Btn_Delete.TabIndex = 4;
            Btn_Delete.Text = "حذف";
            Btn_Delete.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Btn_Degree
            // 
            Btn_Degree.BackColor = Color.FromArgb(59, 130, 246);
            Btn_Degree.Cursor = Cursors.Hand;
            Btn_Degree.FlatAppearance.BorderSize = 0;
            Btn_Degree.FlatAppearance.MouseDownBackColor = Color.FromArgb(37, 99, 235);
            Btn_Degree.FlatStyle = FlatStyle.Flat;
            Btn_Degree.ForeColor = Color.White;
            Btn_Degree.Image = Properties.Resources.report_card2;
            Btn_Degree.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Degree.Location = new Point(544, 10);
            Btn_Degree.Margin = new Padding(5, 5, 10, 5);
            Btn_Degree.Name = "Btn_Degree";
            Btn_Degree.Padding = new Padding(3);
            Btn_Degree.Size = new Size(123, 43);
            Btn_Degree.TabIndex = 7;
            Btn_Degree.Text = "الدرجات";
            Btn_Degree.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Degree.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Degree.UseVisualStyleBackColor = false;
            Btn_Degree.Click += Btn_Degree_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmb_Filter);
            panel1.Controls.Add(Txt_Search);
            panel1.Location = new Point(37, 12);
            panel1.Margin = new Padding(6, 7, 13, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 41);
            panel1.TabIndex = 6;
            // 
            // cmb_Filter
            // 
            cmb_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Filter.FormattingEnabled = true;
            cmb_Filter.Items.AddRange(new object[] { "لايوجد", "الاسم", "رقم الهاتف" });
            cmb_Filter.Location = new Point(18, 6);
            cmb_Filter.Name = "cmb_Filter";
            cmb_Filter.Size = new Size(212, 29);
            cmb_Filter.TabIndex = 1;
            cmb_Filter.SelectedIndexChanged += cmb_Filter_SelectedIndexChanged;
            // 
            // Txt_Search
            // 
            Txt_Search.BackColor = Color.White;
            Txt_Search.BorderStyle = BorderStyle.FixedSingle;
            Txt_Search.Location = new Point(242, 7);
            Txt_Search.Name = "Txt_Search";
            Txt_Search.Size = new Size(236, 29);
            Txt_Search.TabIndex = 0;
            Txt_Search.TextChanged += Txt_Search_TextChanged;
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.BackColor = Color.FromArgb(30, 30, 30);
            lbl_Data.ForeColor = Color.White;
            lbl_Data.Location = new Point(473, 258);
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
            Pic_Loading.Location = new Point(404, 227);
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
            Btn_Excel.Location = new Point(994, 488);
            Btn_Excel.Margin = new Padding(6, 7, 13, 7);
            Btn_Excel.Name = "Btn_Excel";
            Btn_Excel.Padding = new Padding(5);
            Btn_Excel.Size = new Size(41, 41);
            Btn_Excel.TabIndex = 25;
            Btn_Excel.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Excel.UseVisualStyleBackColor = false;
            Btn_Excel.Click += Btn_Excel_Click;
            // 
            // StudentUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            Controls.Add(lbl_Data);
            Controls.Add(Pic_Loading);
            Controls.Add(Btn_Excel);
            Controls.Add(dgv_Student);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "StudentUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1048, 538);
            ((System.ComponentModel.ISupportInitialize)dgv_Student).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_Student;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button Btn_teachers;
        private Button Btn_Edit;
        private Button Btn_Delete;
        private Label lbl_Data;
        private PictureBox Pic_Loading;
        private Button Btn_Excel;
        private Button Btn_Degree;
        private Panel panel1;
        private ComboBox cmb_Filter;
        private TextBox Txt_Search;
    }
}
