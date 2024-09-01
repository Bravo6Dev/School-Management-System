namespace SchoolManagment
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Btn_Close = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_teachers = new Button();
            Btn_Subjects = new Button();
            Btn_Students = new Button();
            Btn_Sessions = new Button();
            button4 = new Button();
            Btn_AcademicYears = new Button();
            Panel_Container = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Btn_Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 31);
            panel1.TabIndex = 0;
            // 
            // Btn_Close
            // 
            Btn_Close.Cursor = Cursors.Hand;
            Btn_Close.Dock = DockStyle.Right;
            Btn_Close.FlatAppearance.BorderSize = 0;
            Btn_Close.FlatStyle = FlatStyle.Flat;
            Btn_Close.Image = Properties.Resources.close;
            Btn_Close.Location = new Point(1014, 0);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(34, 31);
            Btn_Close.TabIndex = 0;
            Btn_Close.UseVisualStyleBackColor = true;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_teachers);
            flowLayoutPanel1.Controls.Add(Btn_Subjects);
            flowLayoutPanel1.Controls.Add(Btn_Students);
            flowLayoutPanel1.Controls.Add(Btn_Sessions);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(Btn_AcademicYears);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 569);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 5, 20, 5);
            flowLayoutPanel1.Size = new Size(1048, 72);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Btn_teachers
            // 
            Btn_teachers.BackColor = Color.FromArgb(59, 130, 246);
            Btn_teachers.Cursor = Cursors.Hand;
            Btn_teachers.FlatAppearance.BorderSize = 0;
            Btn_teachers.FlatStyle = FlatStyle.Flat;
            Btn_teachers.ForeColor = Color.White;
            Btn_teachers.Image = Properties.Resources.teacher;
            Btn_teachers.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_teachers.Location = new Point(889, 10);
            Btn_teachers.Margin = new Padding(5, 5, 10, 5);
            Btn_teachers.Name = "Btn_teachers";
            Btn_teachers.Size = new Size(129, 50);
            Btn_teachers.TabIndex = 2;
            Btn_teachers.Text = "الاساتذة";
            Btn_teachers.TextAlign = ContentAlignment.MiddleLeft;
            Btn_teachers.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_teachers.UseVisualStyleBackColor = false;
            Btn_teachers.Click += Btn_teachers_Click;
            // 
            // Btn_Subjects
            // 
            Btn_Subjects.BackColor = Color.FromArgb(59, 130, 246);
            Btn_Subjects.Cursor = Cursors.Hand;
            Btn_Subjects.FlatAppearance.BorderSize = 0;
            Btn_Subjects.FlatStyle = FlatStyle.Flat;
            Btn_Subjects.ForeColor = Color.White;
            Btn_Subjects.Image = Properties.Resources.book;
            Btn_Subjects.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Subjects.Location = new Point(745, 10);
            Btn_Subjects.Margin = new Padding(5, 5, 10, 5);
            Btn_Subjects.Name = "Btn_Subjects";
            Btn_Subjects.Size = new Size(129, 50);
            Btn_Subjects.TabIndex = 3;
            Btn_Subjects.Text = "المواد";
            Btn_Subjects.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Subjects.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Subjects.UseVisualStyleBackColor = false;
            Btn_Subjects.Click += Btn_Subjects_Click;
            // 
            // Btn_Students
            // 
            Btn_Students.BackColor = Color.FromArgb(59, 130, 246);
            Btn_Students.Cursor = Cursors.Hand;
            Btn_Students.FlatAppearance.BorderSize = 0;
            Btn_Students.FlatStyle = FlatStyle.Flat;
            Btn_Students.ForeColor = Color.White;
            Btn_Students.Image = Properties.Resources.graduated;
            Btn_Students.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Students.Location = new Point(601, 10);
            Btn_Students.Margin = new Padding(5, 5, 10, 5);
            Btn_Students.Name = "Btn_Students";
            Btn_Students.Size = new Size(129, 50);
            Btn_Students.TabIndex = 4;
            Btn_Students.Text = "الطلبة";
            Btn_Students.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Students.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Students.UseVisualStyleBackColor = false;
            Btn_Students.Click += Btn_Students_Click;
            // 
            // Btn_Sessions
            // 
            Btn_Sessions.BackColor = Color.FromArgb(59, 130, 246);
            Btn_Sessions.Cursor = Cursors.Hand;
            Btn_Sessions.FlatAppearance.BorderSize = 0;
            Btn_Sessions.FlatStyle = FlatStyle.Flat;
            Btn_Sessions.ForeColor = Color.White;
            Btn_Sessions.Image = Properties.Resources.training;
            Btn_Sessions.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Sessions.Location = new Point(478, 10);
            Btn_Sessions.Margin = new Padding(5, 5, 10, 5);
            Btn_Sessions.Name = "Btn_Sessions";
            Btn_Sessions.Size = new Size(108, 50);
            Btn_Sessions.TabIndex = 5;
            Btn_Sessions.Text = "الحصص";
            Btn_Sessions.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Sessions.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Sessions.UseVisualStyleBackColor = false;
            Btn_Sessions.Click += Btn_Sessions_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(59, 130, 246);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.classroom;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(361, 10);
            button4.Margin = new Padding(5, 5, 10, 5);
            button4.Name = "button4";
            button4.Size = new Size(102, 50);
            button4.TabIndex = 6;
            button4.Text = "الفصول";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Btn_AcademicYears
            // 
            Btn_AcademicYears.BackColor = Color.FromArgb(59, 130, 246);
            Btn_AcademicYears.Cursor = Cursors.Hand;
            Btn_AcademicYears.FlatAppearance.BorderSize = 0;
            Btn_AcademicYears.FlatStyle = FlatStyle.Flat;
            Btn_AcademicYears.ForeColor = Color.White;
            Btn_AcademicYears.Image = Properties.Resources.report_card;
            Btn_AcademicYears.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_AcademicYears.Location = new Point(197, 10);
            Btn_AcademicYears.Margin = new Padding(5, 5, 10, 5);
            Btn_AcademicYears.Name = "Btn_AcademicYears";
            Btn_AcademicYears.Size = new Size(149, 50);
            Btn_AcademicYears.TabIndex = 8;
            Btn_AcademicYears.Text = "سنوات الدراسة";
            Btn_AcademicYears.TextAlign = ContentAlignment.MiddleLeft;
            Btn_AcademicYears.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_AcademicYears.UseVisualStyleBackColor = false;
            Btn_AcademicYears.Click += Btn_AcademicYears_Click;
            // 
            // Panel_Container
            // 
            Panel_Container.Dock = DockStyle.Fill;
            Panel_Container.Location = new Point(0, 31);
            Panel_Container.Name = "Panel_Container";
            Panel_Container.Size = new Size(1048, 538);
            Panel_Container.TabIndex = 2;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            ClientSize = new Size(1048, 641);
            Controls.Add(Panel_Container);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Frm_Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Main";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Btn_Close;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_teachers;
        private Button Btn_Subjects;
        private Button Btn_Students;
        private Button Btn_Sessions;
        private Button button4;
        public Panel Panel_Container;
        private Button Btn_AcademicYears;
    }
}
