namespace SchoolManagment.GUI.SessionsGUI
{
    partial class Frm_Add_Edit_Sessions
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
            panel1 = new Panel();
            Btn_Close = new Button();
            groupBox1 = new GroupBox();
            Txt_AcademicYear = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmb_Class = new ComboBox();
            groupBox2 = new GroupBox();
            Txt_Subject = new TextBox();
            label5 = new Label();
            Txt_EductionOutCome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmb_Teacher = new ComboBox();
            groupBox3 = new GroupBox();
            EndTimePicker = new DateTimePicker();
            label8 = new Label();
            StartTimePicker = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            cmb_Days = new ComboBox();
            Btn_Save = new Button();
            Btn_Clear = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Btn_Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 37);
            panel1.TabIndex = 0;
            // 
            // Btn_Close
            // 
            Btn_Close.Cursor = Cursors.Hand;
            Btn_Close.Dock = DockStyle.Right;
            Btn_Close.FlatAppearance.BorderSize = 0;
            Btn_Close.FlatStyle = FlatStyle.Flat;
            Btn_Close.Image = Properties.Resources.close;
            Btn_Close.Location = new Point(741, 0);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(34, 37);
            Btn_Close.TabIndex = 1;
            Btn_Close.UseVisualStyleBackColor = true;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Txt_AcademicYear);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmb_Class);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(7, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 234);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الفصل";
            // 
            // Txt_AcademicYear
            // 
            Txt_AcademicYear.Location = new Point(69, 150);
            Txt_AcademicYear.Name = "Txt_AcademicYear";
            Txt_AcademicYear.ReadOnly = true;
            Txt_AcademicYear.Size = new Size(260, 29);
            Txt_AcademicYear.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 126);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 1;
            label2.Text = "السنة الدراسية :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 45);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 1;
            label1.Text = "الفصل :";
            // 
            // cmb_Class
            // 
            cmb_Class.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Class.FormattingEnabled = true;
            cmb_Class.Location = new Point(69, 69);
            cmb_Class.Name = "cmb_Class";
            cmb_Class.Size = new Size(260, 29);
            cmb_Class.TabIndex = 0;
            cmb_Class.SelectedIndexChanged += cmb_Class_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Txt_Subject);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(Txt_EductionOutCome);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmb_Teacher);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(397, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 234);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "معلومات الاستاذ";
            // 
            // Txt_Subject
            // 
            Txt_Subject.Location = new Point(61, 189);
            Txt_Subject.Name = "Txt_Subject";
            Txt_Subject.ReadOnly = true;
            Txt_Subject.Size = new Size(293, 29);
            Txt_Subject.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(299, 165);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 1;
            label5.Text = "المادة :";
            // 
            // Txt_EductionOutCome
            // 
            Txt_EductionOutCome.Location = new Point(61, 126);
            Txt_EductionOutCome.Name = "Txt_EductionOutCome";
            Txt_EductionOutCome.ReadOnly = true;
            Txt_EductionOutCome.Size = new Size(293, 29);
            Txt_EductionOutCome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 102);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 1;
            label3.Text = "المحصل التعليمي :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 35);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 1;
            label4.Text = "الاستاذ :";
            // 
            // cmb_Teacher
            // 
            cmb_Teacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Teacher.FormattingEnabled = true;
            cmb_Teacher.Location = new Point(149, 59);
            cmb_Teacher.Name = "cmb_Teacher";
            cmb_Teacher.Size = new Size(205, 29);
            cmb_Teacher.TabIndex = 0;
            cmb_Teacher.SelectedIndexChanged += cmb_Class_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(EndTimePicker);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(StartTimePicker);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(cmb_Days);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(0, 278);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(770, 106);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "معلومات الحصة :";
            // 
            // EndTimePicker
            // 
            EndTimePicker.Format = DateTimePickerFormat.Time;
            EndTimePicker.Location = new Point(95, 56);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.ShowUpDown = true;
            EndTimePicker.Size = new Size(128, 29);
            EndTimePicker.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(130, 32);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 5;
            label8.Text = "نهاية الحصة :";
            // 
            // StartTimePicker
            // 
            StartTimePicker.Format = DateTimePickerFormat.Time;
            StartTimePicker.Location = new Point(271, 56);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.ShowUpDown = true;
            StartTimePicker.Size = new Size(128, 29);
            StartTimePicker.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 32);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 5;
            label7.Text = "بداية الحصة :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(660, 32);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 3;
            label6.Text = "اليوم :";
            // 
            // cmb_Days
            // 
            cmb_Days.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Days.FormattingEnabled = true;
            cmb_Days.Items.AddRange(new object[] { "الاحد", "الاتنين", "الثلاثاء", "الاربعاء", "الخميس", "السبت" });
            cmb_Days.Location = new Point(448, 56);
            cmb_Days.Name = "cmb_Days";
            cmb_Days.Size = new Size(260, 29);
            cmb_Days.TabIndex = 2;
            // 
            // Btn_Save
            // 
            Btn_Save.BackColor = Color.FromArgb(16, 185, 129);
            Btn_Save.Cursor = Cursors.Hand;
            Btn_Save.FlatAppearance.BorderSize = 0;
            Btn_Save.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 150, 105);
            Btn_Save.FlatStyle = FlatStyle.Flat;
            Btn_Save.Image = Properties.Resources.save_instagram;
            Btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Save.Location = new Point(105, 425);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(217, 40);
            Btn_Save.TabIndex = 14;
            Btn_Save.Text = "حفظ";
            Btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.BackColor = Color.FromArgb(239, 68, 68);
            Btn_Clear.Cursor = Cursors.Hand;
            Btn_Clear.FlatAppearance.BorderSize = 0;
            Btn_Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
            Btn_Clear.FlatStyle = FlatStyle.Flat;
            Btn_Clear.Image = Properties.Resources.clean;
            Btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Clear.Location = new Point(416, 425);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(217, 40);
            Btn_Clear.TabIndex = 13;
            Btn_Clear.Text = "مسح الحقول";
            Btn_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Clear.UseVisualStyleBackColor = false;
            // 
            // Frm_Add_Edit_Sessions
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            ClientSize = new Size(775, 491);
            Controls.Add(Btn_Save);
            Controls.Add(Btn_Clear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Frm_Add_Edit_Sessions";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Add_Edit_Sessions";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Btn_Close;
        private GroupBox groupBox1;
        private TextBox Txt_AcademicYear;
        private Label label2;
        private Label label1;
        private ComboBox cmb_Class;
        private GroupBox groupBox2;
        private TextBox Txt_EductionOutCome;
        private Label label3;
        private Label label4;
        private ComboBox cmb_Teacher;
        private TextBox Txt_Subject;
        private Label label5;
        private GroupBox groupBox3;
        private Label label6;
        private ComboBox cmb_Days;
        private DateTimePicker StartTimePicker;
        private Label label7;
        private Button Btn_Save;
        private Button Btn_Clear;
        private DateTimePicker EndTimePicker;
        private Label label8;
    }
}