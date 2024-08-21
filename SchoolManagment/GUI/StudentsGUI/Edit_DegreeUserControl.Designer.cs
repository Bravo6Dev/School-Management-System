namespace SchoolManagment.GUI.StudentsGUI
{
    partial class Edit_DegreeUserControl
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
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Txt_Address = new TextBox();
            Txt_Phone = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            Txt_Name = new TextBox();
            cmb_Subjects = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            numeric_FinalTermGrade = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            numeric_MidTermGrade = new NumericUpDown();
            numeric_GeneralGrade = new NumericUpDown();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            Btn_Save = new Button();
            Btn_Edit = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_FinalTermGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_MidTermGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_GeneralGrade).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(563, 43);
            label12.Name = "label12";
            label12.Size = new Size(55, 21);
            label12.TabIndex = 110;
            label12.Text = "المادة :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(52, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 29);
            dateTimePicker1.TabIndex = 111;
            dateTimePicker1.TabStop = false;
            // 
            // Txt_Address
            // 
            Txt_Address.BorderStyle = BorderStyle.FixedSingle;
            Txt_Address.Location = new Point(51, 162);
            Txt_Address.Name = "Txt_Address";
            Txt_Address.ReadOnly = true;
            Txt_Address.Size = new Size(217, 29);
            Txt_Address.TabIndex = 109;
            Txt_Address.TabStop = false;
            // 
            // Txt_Phone
            // 
            Txt_Phone.BorderStyle = BorderStyle.FixedSingle;
            Txt_Phone.Location = new Point(400, 162);
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.ReadOnly = true;
            Txt_Phone.Size = new Size(217, 29);
            Txt_Phone.TabIndex = 108;
            Txt_Phone.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 127);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 101;
            label6.Text = "السكن :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(155, 43);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 106;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 127);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 102;
            label5.Text = "رقم الهاتف :";
            // 
            // Txt_Name
            // 
            Txt_Name.BorderStyle = BorderStyle.FixedSingle;
            Txt_Name.Location = new Point(400, 78);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.ReadOnly = true;
            Txt_Name.Size = new Size(217, 29);
            Txt_Name.TabIndex = 103;
            Txt_Name.TabStop = false;
            // 
            // cmb_Subjects
            // 
            cmb_Subjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Subjects.FormattingEnabled = true;
            cmb_Subjects.Location = new Point(435, 77);
            cmb_Subjects.Name = "cmb_Subjects";
            cmb_Subjects.Size = new Size(183, 29);
            cmb_Subjects.TabIndex = 111;
            cmb_Subjects.TabStop = false;
            cmb_Subjects.SelectedIndexChanged += cmb_Subjects_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 43);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 104;
            label3.Text = "تاريخ الولادة :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(510, 43);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 107;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 43);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 110;
            label1.Text = "الاسم كامل :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(545, 43);
            label11.Name = "label11";
            label11.Size = new Size(17, 21);
            label11.TabIndex = 107;
            label11.Text = "*";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numeric_FinalTermGrade);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(numeric_MidTermGrade);
            groupBox2.Controls.Add(numeric_GeneralGrade);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmb_Subjects);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(0, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(638, 167);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "معلومات الفصل";
            // 
            // numeric_FinalTermGrade
            // 
            numeric_FinalTermGrade.BackColor = Color.FromArgb(46, 46, 46);
            numeric_FinalTermGrade.BorderStyle = BorderStyle.FixedSingle;
            numeric_FinalTermGrade.ForeColor = Color.White;
            numeric_FinalTermGrade.Location = new Point(17, 77);
            numeric_FinalTermGrade.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numeric_FinalTermGrade.Name = "numeric_FinalTermGrade";
            numeric_FinalTermGrade.Size = new Size(112, 29);
            numeric_FinalTermGrade.TabIndex = 2;
            numeric_FinalTermGrade.TextAlign = HorizontalAlignment.Center;
            numeric_FinalTermGrade.UpDownAlign = LeftRightAlignment.Left;
            numeric_FinalTermGrade.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(17, 42);
            label13.Name = "label13";
            label13.Size = new Size(17, 21);
            label13.TabIndex = 117;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(36, 42);
            label14.Name = "label14";
            label14.Size = new Size(97, 21);
            label14.TabIndex = 118;
            label14.Text = "درجة النهائي :";
            // 
            // numeric_MidTermGrade
            // 
            numeric_MidTermGrade.BackColor = Color.FromArgb(46, 46, 46);
            numeric_MidTermGrade.BorderStyle = BorderStyle.FixedSingle;
            numeric_MidTermGrade.ForeColor = Color.White;
            numeric_MidTermGrade.Location = new Point(153, 77);
            numeric_MidTermGrade.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numeric_MidTermGrade.Name = "numeric_MidTermGrade";
            numeric_MidTermGrade.Size = new Size(113, 29);
            numeric_MidTermGrade.TabIndex = 1;
            numeric_MidTermGrade.TextAlign = HorizontalAlignment.Center;
            numeric_MidTermGrade.UpDownAlign = LeftRightAlignment.Left;
            numeric_MidTermGrade.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numeric_GeneralGrade
            // 
            numeric_GeneralGrade.BackColor = Color.FromArgb(46, 46, 46);
            numeric_GeneralGrade.BorderStyle = BorderStyle.FixedSingle;
            numeric_GeneralGrade.ForeColor = Color.White;
            numeric_GeneralGrade.Location = new Point(290, 77);
            numeric_GeneralGrade.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numeric_GeneralGrade.Name = "numeric_GeneralGrade";
            numeric_GeneralGrade.Size = new Size(113, 29);
            numeric_GeneralGrade.TabIndex = 0;
            numeric_GeneralGrade.TextAlign = HorizontalAlignment.Center;
            numeric_GeneralGrade.UpDownAlign = LeftRightAlignment.Left;
            numeric_GeneralGrade.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(145, 43);
            label10.Name = "label10";
            label10.Size = new Size(17, 21);
            label10.TabIndex = 112;
            label10.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(291, 42);
            label7.Name = "label7";
            label7.Size = new Size(17, 21);
            label7.TabIndex = 112;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(162, 42);
            label8.Name = "label8";
            label8.Size = new Size(104, 21);
            label8.TabIndex = 113;
            label8.Text = "درجة النصفي :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(310, 42);
            label9.Name = "label9";
            label9.Size = new Size(93, 21);
            label9.TabIndex = 114;
            label9.Text = "اعمال السنة :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(Txt_Address);
            groupBox1.Controls.Add(Txt_Phone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Txt_Name);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 215);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الطالب";
            // 
            // Btn_Save
            // 
            Btn_Save.BackColor = Color.FromArgb(16, 185, 129);
            Btn_Save.FlatAppearance.BorderSize = 0;
            Btn_Save.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 150, 105);
            Btn_Save.FlatStyle = FlatStyle.Flat;
            Btn_Save.Image = Properties.Resources.save_instagram;
            Btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Save.Location = new Point(389, 455);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(138, 40);
            Btn_Save.TabIndex = 13;
            Btn_Save.Text = "اضافة";
            Btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
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
            Btn_Edit.Location = new Point(118, 455);
            Btn_Edit.Margin = new Padding(5, 5, 10, 5);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Padding = new Padding(3);
            Btn_Edit.Size = new Size(138, 40);
            Btn_Edit.TabIndex = 120;
            Btn_Edit.Text = "تعديل";
            Btn_Edit.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Edit.UseVisualStyleBackColor = false;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Edit_DegreeUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            Controls.Add(Btn_Edit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Btn_Save);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "Edit_DegreeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(638, 581);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_FinalTermGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_MidTermGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_GeneralGrade).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private TextBox Txt_Address;
        private TextBox Txt_Phone;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox Txt_Name;
        private ComboBox cmb_Subjects;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button Btn_Save;
        private NumericUpDown numeric_MidTermGrade;
        private NumericUpDown numeric_GeneralGrade;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown numeric_FinalTermGrade;
        private Label label13;
        private Label label14;
        private Button Btn_Edit;
    }
}
