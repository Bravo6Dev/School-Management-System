namespace SchoolManagment.GUI.ClassesGUI
{
    partial class ClassesUserControl
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
            Btn_Delete = new Button();
            Btn_ShowStudents = new Button();
            panel1 = new Panel();
            cmb_Filter = new ComboBox();
            Txt_Search = new TextBox();
            lbl_Data = new Label();
            Pic_Loading = new PictureBox();
            Btn_Excel = new Button();
            dgv_Classes = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Classes).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_teachers);
            flowLayoutPanel1.Controls.Add(Btn_Delete);
            flowLayoutPanel1.Controls.Add(Btn_ShowStudents);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 5, 20, 5);
            flowLayoutPanel1.Size = new Size(1048, 72);
            flowLayoutPanel1.TabIndex = 3;
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
            Btn_teachers.Click += Btn_Add_Click;
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
            // Btn_ShowStudents
            // 
            Btn_ShowStudents.BackColor = Color.FromArgb(59, 130, 246);
            Btn_ShowStudents.Cursor = Cursors.Hand;
            Btn_ShowStudents.FlatAppearance.BorderSize = 0;
            Btn_ShowStudents.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 38, 38);
            Btn_ShowStudents.FlatStyle = FlatStyle.Flat;
            Btn_ShowStudents.ForeColor = Color.White;
            Btn_ShowStudents.Image = Properties.Resources.graduated;
            Btn_ShowStudents.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_ShowStudents.Location = new Point(715, 10);
            Btn_ShowStudents.Margin = new Padding(5, 5, 10, 5);
            Btn_ShowStudents.Name = "Btn_ShowStudents";
            Btn_ShowStudents.Padding = new Padding(3);
            Btn_ShowStudents.Size = new Size(98, 43);
            Btn_ShowStudents.TabIndex = 6;
            Btn_ShowStudents.Text = "الطلبة";
            Btn_ShowStudents.TextAlign = ContentAlignment.MiddleLeft;
            Btn_ShowStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_ShowStudents.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmb_Filter);
            panel1.Controls.Add(Txt_Search);
            panel1.Location = new Point(218, 12);
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
            // 
            // Txt_Search
            // 
            Txt_Search.BackColor = Color.White;
            Txt_Search.BorderStyle = BorderStyle.FixedSingle;
            Txt_Search.Location = new Point(242, 7);
            Txt_Search.Name = "Txt_Search";
            Txt_Search.Size = new Size(236, 29);
            Txt_Search.TabIndex = 0;
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.BackColor = Color.FromArgb(30, 30, 30);
            lbl_Data.ForeColor = Color.White;
            lbl_Data.Location = new Point(477, 259);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(91, 21);
            lbl_Data.TabIndex = 9;
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
            Pic_Loading.TabIndex = 10;
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
            Btn_Excel.TabIndex = 11;
            Btn_Excel.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Excel.UseVisualStyleBackColor = false;
            // 
            // dgv_Classes
            // 
            dgv_Classes.AllowUserToAddRows = false;
            dgv_Classes.AllowUserToDeleteRows = false;
            dgv_Classes.AllowUserToResizeColumns = false;
            dgv_Classes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.NullValue = "لايوجد";
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Classes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Classes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Classes.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Classes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Classes.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.NullValue = "لايوجد";
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Classes.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Classes.Dock = DockStyle.Fill;
            dgv_Classes.EnableHeadersVisualStyles = false;
            dgv_Classes.Location = new Point(0, 72);
            dgv_Classes.MultiSelect = false;
            dgv_Classes.Name = "dgv_Classes";
            dgv_Classes.ReadOnly = true;
            dgv_Classes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.LightGray;
            dataGridViewCellStyle4.NullValue = "لايوجد";
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Classes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Classes.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Classes.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(37, 37, 37);
            dgv_Classes.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Classes.RowTemplate.DefaultCellStyle.ForeColor = Color.LightGray;
            dgv_Classes.RowTemplate.DefaultCellStyle.NullValue = "لايوجد";
            dgv_Classes.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgv_Classes.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Classes.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_Classes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Classes.Size = new Size(1048, 466);
            dgv_Classes.TabIndex = 12;
            // 
            // ClassesUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            Controls.Add(lbl_Data);
            Controls.Add(Pic_Loading);
            Controls.Add(Btn_Excel);
            Controls.Add(dgv_Classes);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ClassesUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1048, 538);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Classes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_teachers;
        private Button Btn_Delete;
        private Button Btn_ShowStudents;
        private Panel panel1;
        private ComboBox cmb_Filter;
        private TextBox Txt_Search;
        private Label lbl_Data;
        private PictureBox Pic_Loading;
        private Button Btn_Excel;
        private DataGridView dgv_Classes;
    }
}
