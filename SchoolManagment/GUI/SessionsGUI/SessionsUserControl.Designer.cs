namespace SchoolManagment.GUI.SessionsGUI
{
    partial class SessionsUserControl
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
            ck_ByTime = new CheckBox();
            Btn_Clear = new Button();
            Btn_Search = new Button();
            StartTime_Picker = new DateTimePicker();
            cmb_Days = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cmb_Classes = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Txt_TeacherName = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_teachers = new Button();
            Btn_Edit = new Button();
            Btn_Delete = new Button();
            Btn_Excel = new Button();
            lbl_Data = new Label();
            Pic_Loading = new PictureBox();
            dgv_Sessions = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Sessions).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ck_ByTime);
            panel1.Controls.Add(Btn_Clear);
            panel1.Controls.Add(Btn_Search);
            panel1.Controls.Add(StartTime_Picker);
            panel1.Controls.Add(cmb_Days);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmb_Classes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Txt_TeacherName);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(826, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 538);
            panel1.TabIndex = 12;
            // 
            // ck_ByTime
            // 
            ck_ByTime.AutoSize = true;
            ck_ByTime.ForeColor = Color.White;
            ck_ByTime.Location = new Point(27, 360);
            ck_ByTime.Name = "ck_ByTime";
            ck_ByTime.Size = new Size(182, 25);
            ck_ByTime.TabIndex = 31;
            ck_ByTime.Text = "البحث باستخدام التوقيت";
            ck_ByTime.UseVisualStyleBackColor = true;
            // 
            // Btn_Clear
            // 
            Btn_Clear.BackColor = Color.FromArgb(239, 68, 68);
            Btn_Clear.Cursor = Cursors.Hand;
            Btn_Clear.FlatAppearance.BorderSize = 0;
            Btn_Clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 38, 38);
            Btn_Clear.FlatStyle = FlatStyle.Flat;
            Btn_Clear.ForeColor = Color.White;
            Btn_Clear.Image = Properties.Resources.clean;
            Btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Clear.Location = new Point(17, 464);
            Btn_Clear.Margin = new Padding(75, 5, 75, 5);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Padding = new Padding(3);
            Btn_Clear.Size = new Size(192, 40);
            Btn_Clear.TabIndex = 30;
            Btn_Clear.Text = "مسح";
            Btn_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Btn_Search
            // 
            Btn_Search.BackColor = Color.FromArgb(59, 130, 246);
            Btn_Search.Cursor = Cursors.Hand;
            Btn_Search.FlatAppearance.BorderSize = 0;
            Btn_Search.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            Btn_Search.FlatStyle = FlatStyle.Flat;
            Btn_Search.ForeColor = Color.White;
            Btn_Search.Image = Properties.Resources.transparency;
            Btn_Search.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Search.Location = new Point(17, 402);
            Btn_Search.Margin = new Padding(75, 5, 75, 5);
            Btn_Search.Name = "Btn_Search";
            Btn_Search.Padding = new Padding(3);
            Btn_Search.Size = new Size(192, 40);
            Btn_Search.TabIndex = 29;
            Btn_Search.Text = "البحث";
            Btn_Search.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Search.UseVisualStyleBackColor = false;
            Btn_Search.Click += Btn_Search_Click;
            // 
            // StartTime_Picker
            // 
            StartTime_Picker.Format = DateTimePickerFormat.Time;
            StartTime_Picker.Location = new Point(17, 315);
            StartTime_Picker.Name = "StartTime_Picker";
            StartTime_Picker.ShowUpDown = true;
            StartTime_Picker.Size = new Size(192, 29);
            StartTime_Picker.TabIndex = 28;
            // 
            // cmb_Days
            // 
            cmb_Days.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Days.FormattingEnabled = true;
            cmb_Days.Items.AddRange(new object[] { "لايوجد", "الاحد", "الاثنين", "الثلاثاء", "الاربعاء", "الخميس", "السبت" });
            cmb_Days.Location = new Point(17, 246);
            cmb_Days.Name = "cmb_Days";
            cmb_Days.Size = new Size(192, 29);
            cmb_Days.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(148, 288);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 1;
            label5.Text = "الوقت : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(161, 219);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 1;
            label4.Text = "اليوم :";
            // 
            // cmb_Classes
            // 
            cmb_Classes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Classes.FormattingEnabled = true;
            cmb_Classes.Location = new Point(17, 179);
            cmb_Classes.Name = "cmb_Classes";
            cmb_Classes.Size = new Size(192, 29);
            cmb_Classes.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(148, 152);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 1;
            label3.Text = "الفصل :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 72);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "الاسم :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 1;
            label1.Text = "خانة البحث :";
            // 
            // Txt_TeacherName
            // 
            Txt_TeacherName.Location = new Point(17, 99);
            Txt_TeacherName.Name = "Txt_TeacherName";
            Txt_TeacherName.Size = new Size(192, 29);
            Txt_TeacherName.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_teachers);
            flowLayoutPanel1.Controls.Add(Btn_Edit);
            flowLayoutPanel1.Controls.Add(Btn_Delete);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 5, 20, 5);
            flowLayoutPanel1.Size = new Size(826, 72);
            flowLayoutPanel1.TabIndex = 22;
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
            Btn_teachers.Location = new Point(616, 10);
            Btn_teachers.Margin = new Padding(75, 5, 75, 5);
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
            Btn_Edit.Location = new Point(356, 10);
            Btn_Edit.Margin = new Padding(75, 5, 75, 5);
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
            Btn_Delete.Location = new Point(96, 10);
            Btn_Delete.Margin = new Padding(75, 5, 75, 5);
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
            Btn_Excel.Location = new Point(769, 490);
            Btn_Excel.Margin = new Padding(6, 7, 13, 7);
            Btn_Excel.Name = "Btn_Excel";
            Btn_Excel.Padding = new Padding(5);
            Btn_Excel.Size = new Size(41, 41);
            Btn_Excel.TabIndex = 26;
            Btn_Excel.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Excel.UseVisualStyleBackColor = false;
            Btn_Excel.Click += Btn_Excel_Click;
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.BackColor = Color.FromArgb(30, 30, 30);
            lbl_Data.ForeColor = Color.White;
            lbl_Data.Location = new Point(357, 259);
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
            Pic_Loading.Location = new Point(282, 227);
            Pic_Loading.Name = "Pic_Loading";
            Pic_Loading.Size = new Size(241, 84);
            Pic_Loading.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Loading.TabIndex = 24;
            Pic_Loading.TabStop = false;
            // 
            // dgv_Sessions
            // 
            dgv_Sessions.AllowUserToAddRows = false;
            dgv_Sessions.AllowUserToDeleteRows = false;
            dgv_Sessions.AllowUserToResizeColumns = false;
            dgv_Sessions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.NullValue = "لايوجد";
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Sessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Sessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Sessions.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Sessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Sessions.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.NullValue = "لايوجد";
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Sessions.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Sessions.Dock = DockStyle.Fill;
            dgv_Sessions.EnableHeadersVisualStyles = false;
            dgv_Sessions.Location = new Point(0, 72);
            dgv_Sessions.MultiSelect = false;
            dgv_Sessions.Name = "dgv_Sessions";
            dgv_Sessions.ReadOnly = true;
            dgv_Sessions.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.LightGray;
            dataGridViewCellStyle4.NullValue = "لايوجد";
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Sessions.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Sessions.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Sessions.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(37, 37, 37);
            dgv_Sessions.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Sessions.RowTemplate.DefaultCellStyle.ForeColor = Color.LightGray;
            dgv_Sessions.RowTemplate.DefaultCellStyle.NullValue = "لايوجد";
            dgv_Sessions.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgv_Sessions.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Sessions.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_Sessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Sessions.Size = new Size(826, 466);
            dgv_Sessions.TabIndex = 25;
            dgv_Sessions.CellFormatting += dgv_Sessions_CellFormatting;
            // 
            // SessionsUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            Controls.Add(Btn_Excel);
            Controls.Add(lbl_Data);
            Controls.Add(Pic_Loading);
            Controls.Add(dgv_Sessions);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SessionsUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1048, 538);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pic_Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Sessions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox Txt_TeacherName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_teachers;
        private Button Btn_Edit;
        private Button Btn_Delete;
        private Button Btn_Excel;
        private Label lbl_Data;
        private PictureBox Pic_Loading;
        private DataGridView dgv_Sessions;
        private ComboBox cmb_Classes;
        private Label label3;
        private ComboBox cmb_Days;
        private Label label4;
        private DateTimePicker StartTime_Picker;
        private Label label5;
        private Button Btn_Search;
        private Button Btn_Clear;
        private CheckBox ck_ByTime;
    }
}
