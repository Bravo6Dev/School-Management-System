namespace SchoolManagment.GUI.StudentsGUI
{
    partial class Add_Edit_InfoUserControl
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
            Btn_Clear = new Button();
            Btn_Save = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            Txt_Address = new TextBox();
            Txt_Phone = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            Txt_Name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Txt_ClassYear = new TextBox();
            label9 = new Label();
            cmb_Class = new ComboBox();
            Txt_ClassName = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Clear
            // 
            Btn_Clear.BackColor = Color.FromArgb(239, 68, 68);
            Btn_Clear.FlatAppearance.BorderSize = 0;
            Btn_Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
            Btn_Clear.FlatStyle = FlatStyle.Flat;
            Btn_Clear.Image = Properties.Resources.clean;
            Btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Clear.Location = new Point(382, 475);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(217, 40);
            Btn_Clear.TabIndex = 7;
            Btn_Clear.Text = "مسح الحقول";
            Btn_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Btn_Save
            // 
            Btn_Save.BackColor = Color.FromArgb(16, 185, 129);
            Btn_Save.FlatAppearance.BorderSize = 0;
            Btn_Save.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 150, 105);
            Btn_Save.FlatStyle = FlatStyle.Flat;
            Btn_Save.Image = Properties.Resources.save_instagram;
            Btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Save.Location = new Point(53, 475);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(217, 40);
            Btn_Save.TabIndex = 8;
            Btn_Save.Text = "حفظ";
            Btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
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
            groupBox1.Size = new Size(638, 221);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الطالب";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(52, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 29);
            dateTimePicker1.TabIndex = 111;
            // 
            // Txt_Address
            // 
            Txt_Address.BorderStyle = BorderStyle.FixedSingle;
            Txt_Address.Location = new Point(51, 162);
            Txt_Address.Name = "Txt_Address";
            Txt_Address.Size = new Size(217, 29);
            Txt_Address.TabIndex = 109;
            // 
            // Txt_Phone
            // 
            Txt_Phone.BorderStyle = BorderStyle.FixedSingle;
            Txt_Phone.Location = new Point(400, 162);
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.Size = new Size(217, 29);
            Txt_Phone.TabIndex = 108;
            Txt_Phone.Validating += Txt_Phone_Validating;
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
            Txt_Name.Size = new Size(217, 29);
            Txt_Name.TabIndex = 103;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(Txt_ClassYear);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmb_Class);
            groupBox2.Controls.Add(Txt_ClassName);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(0, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(638, 210);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "معلومات الفصل";
            // 
            // Txt_ClassYear
            // 
            Txt_ClassYear.BorderStyle = BorderStyle.FixedSingle;
            Txt_ClassYear.Location = new Point(211, 159);
            Txt_ClassYear.Name = "Txt_ClassYear";
            Txt_ClassYear.ReadOnly = true;
            Txt_ClassYear.Size = new Size(217, 29);
            Txt_ClassYear.TabIndex = 113;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 125);
            label9.Name = "label9";
            label9.Size = new Size(109, 21);
            label9.TabIndex = 112;
            label9.Text = "السنة الدراسية :";
            // 
            // cmb_Class
            // 
            cmb_Class.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Class.FormattingEnabled = true;
            cmb_Class.Location = new Point(400, 77);
            cmb_Class.Name = "cmb_Class";
            cmb_Class.Size = new Size(218, 29);
            cmb_Class.TabIndex = 111;
            cmb_Class.SelectedIndexChanged += cmb_Class_SelectedIndexChanged;
            // 
            // Txt_ClassName
            // 
            Txt_ClassName.BorderStyle = BorderStyle.FixedSingle;
            Txt_ClassName.Location = new Point(51, 78);
            Txt_ClassName.Name = "Txt_ClassName";
            Txt_ClassName.ReadOnly = true;
            Txt_ClassName.Size = new Size(217, 29);
            Txt_ClassName.TabIndex = 105;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(177, 43);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 104;
            label10.Text = "اسم الفصل :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(541, 43);
            label11.Name = "label11";
            label11.Size = new Size(17, 21);
            label11.TabIndex = 107;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(556, 43);
            label12.Name = "label12";
            label12.Size = new Size(61, 21);
            label12.TabIndex = 110;
            label12.Text = "الفصل :";
            // 
            // Add_Edit_InfoUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Btn_Clear);
            Controls.Add(Btn_Save);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "Add_Edit_InfoUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(638, 581);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Clear;
        private Button Btn_Save;
        private GroupBox groupBox1;
        private TextBox Txt_Address;
        private TextBox Txt_Phone;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox Txt_Name;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cmb_Class;
        private TextBox Txt_ClassName;
        private Label label10;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private TextBox Txt_ClassYear;
        private Label label9;
    }
}
