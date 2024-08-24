namespace SchoolManagment.GUI
{
    partial class AcademicYearUserControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_teachers = new Button();
            Btn_Delete = new Button();
            label1 = new Label();
            Txt_AcademicName = new TextBox();
            lbl_Data = new Label();
            Pic_Loading = new PictureBox();
            Btn_Excel = new Button();
            dgv_AcadimecYear = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_AcadimecYear).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_teachers);
            flowLayoutPanel1.Controls.Add(Btn_Delete);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(Txt_AcademicName);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 5, 20, 5);
            flowLayoutPanel1.Size = new Size(1048, 72);
            flowLayoutPanel1.TabIndex = 4;
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
            Btn_teachers.Location = new Point(930, 10);
            Btn_teachers.Margin = new Padding(5, 5, 10, 5);
            Btn_teachers.Name = "Btn_teachers";
            Btn_teachers.Padding = new Padding(3);
            Btn_teachers.Size = new Size(88, 43);
            Btn_teachers.TabIndex = 2;
            Btn_teachers.Text = "اضافة";
            Btn_teachers.TextAlign = ContentAlignment.MiddleLeft;
            Btn_teachers.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_teachers.UseVisualStyleBackColor = false;
            Btn_teachers.Click += Btn_teachers_Click;
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
            Btn_Delete.Location = new Point(828, 10);
            Btn_Delete.Margin = new Padding(5, 5, 10, 5);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Padding = new Padding(3);
            Btn_Delete.Size = new Size(87, 43);
            Btn_Delete.TabIndex = 4;
            Btn_Delete.Text = "حذف";
            Btn_Delete.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(702, 22);
            label1.Margin = new Padding(3, 17, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 5;
            label1.Text = "السنة الدراسية : ";
            // 
            // Txt_AcademicName
            // 
            Txt_AcademicName.BackColor = Color.White;
            Txt_AcademicName.BorderStyle = BorderStyle.FixedSingle;
            Txt_AcademicName.Location = new Point(399, 18);
            Txt_AcademicName.Margin = new Padding(6, 13, 13, 7);
            Txt_AcademicName.Name = "Txt_AcademicName";
            Txt_AcademicName.Size = new Size(294, 29);
            Txt_AcademicName.TabIndex = 0;
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.BackColor = Color.FromArgb(30, 30, 30);
            lbl_Data.ForeColor = Color.White;
            lbl_Data.Location = new Point(477, 259);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(91, 21);
            lbl_Data.TabIndex = 13;
            lbl_Data.Text = "لايوجد بيانات";
            lbl_Data.Visible = false;
            // 
            // Pic_Loading
            // 
            Pic_Loading.BackColor = Color.FromArgb(30, 30, 30);
            Pic_Loading.Image = Properties.Resources.hzk6C;
            Pic_Loading.Location = new Point(402, 227);
            Pic_Loading.Name = "Pic_Loading";
            Pic_Loading.Size = new Size(241, 84);
            Pic_Loading.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Loading.TabIndex = 14;
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
            Btn_Excel.Location = new Point(992, 490);
            Btn_Excel.Margin = new Padding(6, 7, 13, 7);
            Btn_Excel.Name = "Btn_Excel";
            Btn_Excel.Padding = new Padding(5);
            Btn_Excel.Size = new Size(41, 41);
            Btn_Excel.TabIndex = 15;
            Btn_Excel.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Excel.UseVisualStyleBackColor = false;
            // 
            // dgv_AcadimecYear
            // 
            dgv_AcadimecYear.AllowUserToAddRows = false;
            dgv_AcadimecYear.AllowUserToDeleteRows = false;
            dgv_AcadimecYear.AllowUserToResizeColumns = false;
            dgv_AcadimecYear.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.LightGray;
            dataGridViewCellStyle5.NullValue = "لايوجد";
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_AcadimecYear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_AcadimecYear.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AcadimecYear.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle6.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_AcadimecYear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_AcadimecYear.ColumnHeadersHeight = 50;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.NullValue = "لايوجد";
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_AcadimecYear.DefaultCellStyle = dataGridViewCellStyle7;
            dgv_AcadimecYear.Dock = DockStyle.Fill;
            dgv_AcadimecYear.EnableHeadersVisualStyles = false;
            dgv_AcadimecYear.Location = new Point(0, 72);
            dgv_AcadimecYear.MultiSelect = false;
            dgv_AcadimecYear.Name = "dgv_AcadimecYear";
            dgv_AcadimecYear.ReadOnly = true;
            dgv_AcadimecYear.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.LightGray;
            dataGridViewCellStyle8.NullValue = "لايوجد";
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_AcadimecYear.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgv_AcadimecYear.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_AcadimecYear.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(37, 37, 37);
            dgv_AcadimecYear.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_AcadimecYear.RowTemplate.DefaultCellStyle.ForeColor = Color.LightGray;
            dgv_AcadimecYear.RowTemplate.DefaultCellStyle.NullValue = "لايوجد";
            dgv_AcadimecYear.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgv_AcadimecYear.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_AcadimecYear.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_AcadimecYear.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_AcadimecYear.Size = new Size(1048, 466);
            dgv_AcadimecYear.TabIndex = 16;
            // 
            // AcademicYearUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            Controls.Add(lbl_Data);
            Controls.Add(Pic_Loading);
            Controls.Add(Btn_Excel);
            Controls.Add(dgv_AcadimecYear);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "AcademicYearUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1048, 538);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_AcadimecYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_teachers;
        private Button Btn_Delete;
        private TextBox Txt_AcademicName;
        private Label label1;
        private Label lbl_Data;
        private PictureBox Pic_Loading;
        private Button Btn_Excel;
        private DataGridView dgv_AcadimecYear;
    }
}
