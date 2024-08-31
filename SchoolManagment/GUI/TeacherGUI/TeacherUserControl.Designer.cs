namespace SchoolManagment.GUI.TeacherGUI
{
    partial class TeacherUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Pic_Loading = new PictureBox();
            lbl_Data = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_teachers = new Button();
            Btn_Edit = new Button();
            Btn_Delete = new Button();
            panel1 = new Panel();
            cmb_Filter = new ComboBox();
            Txt_Search = new TextBox();
            Btn_Excel = new Button();
            dgv_Teachers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teachers).BeginInit();
            SuspendLayout();
            // 
            // Pic_Loading
            // 
            Pic_Loading.BackColor = Color.FromArgb(30, 30, 30);
            Pic_Loading.Image = Properties.Resources.hzk6C;
            Pic_Loading.Location = new Point(402, 227);
            Pic_Loading.Name = "Pic_Loading";
            Pic_Loading.Size = new Size(241, 84);
            Pic_Loading.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Loading.TabIndex = 0;
            Pic_Loading.TabStop = false;
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.BackColor = Color.FromArgb(30, 30, 30);
            lbl_Data.ForeColor = Color.White;
            lbl_Data.Location = new Point(477, 259);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(91, 21);
            lbl_Data.TabIndex = 0;
            lbl_Data.Text = "لايوجد بيانات";
            lbl_Data.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_teachers);
            flowLayoutPanel1.Controls.Add(Btn_Edit);
            flowLayoutPanel1.Controls.Add(Btn_Delete);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 5, 20, 5);
            flowLayoutPanel1.Size = new Size(1048, 72);
            flowLayoutPanel1.TabIndex = 2;
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
            Btn_teachers.Location = new Point(908, 10);
            Btn_teachers.Margin = new Padding(5, 5, 10, 5);
            Btn_teachers.Name = "Btn_teachers";
            Btn_teachers.Padding = new Padding(3);
            Btn_teachers.Size = new Size(110, 43);
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
            Btn_Edit.Location = new Point(783, 10);
            Btn_Edit.Margin = new Padding(5, 5, 10, 5);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Padding = new Padding(3);
            Btn_Edit.Size = new Size(110, 43);
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
            Btn_Delete.Location = new Point(658, 10);
            Btn_Delete.Margin = new Padding(5, 5, 10, 5);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Padding = new Padding(3);
            Btn_Delete.Size = new Size(110, 43);
            Btn_Delete.TabIndex = 4;
            Btn_Delete.Text = "حذف";
            Btn_Delete.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmb_Filter);
            panel1.Controls.Add(Txt_Search);
            panel1.Location = new Point(161, 12);
            panel1.Margin = new Padding(6, 7, 13, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 41);
            panel1.TabIndex = 5;
            // 
            // cmb_Filter
            // 
            cmb_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Filter.FormattingEnabled = true;
            cmb_Filter.Items.AddRange(new object[] { "لايوجد", "الاسم", "المحصل التعليمي", "رقم الهاتف" });
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
            Btn_Excel.Location = new Point(992, 490);
            Btn_Excel.Margin = new Padding(6, 7, 13, 7);
            Btn_Excel.Name = "Btn_Excel";
            Btn_Excel.Padding = new Padding(5);
            Btn_Excel.Size = new Size(41, 41);
            Btn_Excel.TabIndex = 6;
            Btn_Excel.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Excel.UseVisualStyleBackColor = false;
            Btn_Excel.Click += Btn_Excel_Click;
            // 
            // dgv_Sessions
            // 
            dgv_Teachers.AllowUserToAddRows = false;
            dgv_Teachers.AllowUserToDeleteRows = false;
            dgv_Teachers.AllowUserToResizeColumns = false;
            dgv_Teachers.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.LightGray;
            dataGridViewCellStyle5.NullValue = "لايوجد";
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Teachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Teachers.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle6.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Teachers.ColumnHeadersHeight = 50;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.LightGray;
            dataGridViewCellStyle7.NullValue = "لايوجد";
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.DefaultCellStyle = dataGridViewCellStyle7;
            dgv_Teachers.Dock = DockStyle.Fill;
            dgv_Teachers.EnableHeadersVisualStyles = false;
            dgv_Teachers.Location = new Point(0, 72);
            dgv_Teachers.MultiSelect = false;
            dgv_Teachers.Name = "dgv_Sessions";
            dgv_Teachers.ReadOnly = true;
            dgv_Teachers.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.LightGray;
            dataGridViewCellStyle8.NullValue = "لايوجد";
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgv_Teachers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Teachers.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(37, 37, 37);
            dgv_Teachers.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Teachers.RowTemplate.DefaultCellStyle.ForeColor = Color.LightGray;
            dgv_Teachers.RowTemplate.DefaultCellStyle.NullValue = "لايوجد";
            dgv_Teachers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgv_Teachers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Teachers.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_Teachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Teachers.Size = new Size(1048, 466);
            dgv_Teachers.TabIndex = 8;
            dgv_Teachers.CellDoubleClick += dgv_Teachers_CellDoubleClick;
            // 
            // TeacherUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            Controls.Add(lbl_Data);
            Controls.Add(Pic_Loading);
            Controls.Add(Btn_Excel);
            Controls.Add(dgv_Teachers);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "TeacherUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1048, 538);
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Pic_Loading;
        private Label lbl_Data;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_teachers;
        private Button Btn_Edit;
        private Button Btn_Delete;
        private Button Btn_Excel;
        private Panel panel1;
        private ComboBox cmb_Filter;
        private TextBox Txt_Search;
        private DataGridView dgv_Teachers;
    }
}
