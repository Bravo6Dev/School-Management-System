namespace SchoolManagment.GUI.SubjectsGUI
{
    partial class SubjectsUserControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_teachers = new Button();
            Btn_Edit = new Button();
            Btn_Delete = new Button();
            Txt_Search = new TextBox();
            lbl_Data = new Label();
            Pic_Loading = new PictureBox();
            Btn_Excel = new Button();
            dgv_Subjects = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Subjects).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_teachers);
            flowLayoutPanel1.Controls.Add(Btn_Edit);
            flowLayoutPanel1.Controls.Add(Btn_Delete);
            flowLayoutPanel1.Controls.Add(Txt_Search);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 5, 20, 5);
            flowLayoutPanel1.Size = new Size(1048, 72);
            flowLayoutPanel1.TabIndex = 11;
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
            Btn_teachers.Location = new Point(889, 10);
            Btn_teachers.Margin = new Padding(5, 5, 10, 5);
            Btn_teachers.Name = "Btn_teachers";
            Btn_teachers.Padding = new Padding(3);
            Btn_teachers.Size = new Size(129, 43);
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
            Btn_Edit.Location = new Point(745, 10);
            Btn_Edit.Margin = new Padding(5, 5, 10, 5);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Padding = new Padding(3);
            Btn_Edit.Size = new Size(129, 43);
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
            Btn_Delete.Location = new Point(601, 10);
            Btn_Delete.Margin = new Padding(5, 5, 10, 5);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Padding = new Padding(3);
            Btn_Delete.Size = new Size(129, 43);
            Btn_Delete.TabIndex = 4;
            Btn_Delete.Text = "حذف";
            Btn_Delete.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Txt_Search
            // 
            Txt_Search.BackColor = Color.White;
            Txt_Search.BorderStyle = BorderStyle.FixedSingle;
            Txt_Search.Location = new Point(350, 17);
            Txt_Search.Margin = new Padding(5, 12, 10, 5);
            Txt_Search.Name = "Txt_Search";
            Txt_Search.PlaceholderText = "اكنب اسم المادة";
            Txt_Search.Size = new Size(236, 29);
            Txt_Search.TabIndex = 0;
            Txt_Search.TextChanged += Txt_Search_TextChanged;
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.BackColor = Color.FromArgb(30, 30, 30);
            lbl_Data.ForeColor = Color.White;
            lbl_Data.Location = new Point(479, 259);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(91, 21);
            lbl_Data.TabIndex = 14;
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
            Pic_Loading.TabIndex = 15;
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
            Btn_Excel.Location = new Point(994, 490);
            Btn_Excel.Margin = new Padding(6, 7, 13, 7);
            Btn_Excel.Name = "Btn_Excel";
            Btn_Excel.Padding = new Padding(5);
            Btn_Excel.Size = new Size(41, 41);
            Btn_Excel.TabIndex = 16;
            Btn_Excel.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Excel.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.NullValue = "لايوجد";
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Subjects.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Subjects.Dock = DockStyle.Fill;
            dgv_Subjects.EnableHeadersVisualStyles = false;
            dgv_Subjects.Location = new Point(0, 72);
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
            dgv_Subjects.Size = new Size(1048, 466);
            dgv_Subjects.TabIndex = 17;
            dgv_Subjects.CellDoubleClick += dgv_Subjects_CellDoubleClick;
            // 
            // SubjectsUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            Controls.Add(lbl_Data);
            Controls.Add(Pic_Loading);
            Controls.Add(Btn_Excel);
            Controls.Add(dgv_Subjects);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SubjectsUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1048, 538);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Subjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_teachers;
        private Button Btn_Edit;
        private Button Btn_Delete;
        private TextBox Txt_Search;
        private Label lbl_Data;
        private PictureBox Pic_Loading;
        private Button Btn_Excel;
        private DataGridView dgv_Subjects;
    }
}
