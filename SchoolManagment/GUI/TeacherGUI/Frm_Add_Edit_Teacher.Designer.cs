namespace SchoolManagment.GUI.TeacherGUI
{
    partial class Frm_Add_Edit_Teacher
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
            Txt_Address = new TextBox();
            Txt_Phone = new TextBox();
            Txt_EductionOutcome = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            Txt_Name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cmb_Subject = new ComboBox();
            Txt_SubName = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            Btn_Save = new Button();
            Btn_Clear = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Btn_Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 31);
            panel1.TabIndex = 1;
            // 
            // Btn_Close
            // 
            Btn_Close.Cursor = Cursors.Hand;
            Btn_Close.Dock = DockStyle.Right;
            Btn_Close.FlatAppearance.BorderSize = 0;
            Btn_Close.FlatStyle = FlatStyle.Flat;
            Btn_Close.Image = Properties.Resources.close;
            Btn_Close.Location = new Point(563, 0);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(34, 31);
            Btn_Close.TabIndex = 0;
            Btn_Close.UseVisualStyleBackColor = true;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Txt_Address);
            groupBox1.Controls.Add(Txt_Phone);
            groupBox1.Controls.Add(Txt_EductionOutcome);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Txt_Name);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 359);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الاستاذ";
            // 
            // Txt_Address
            // 
            Txt_Address.BorderStyle = BorderStyle.FixedSingle;
            Txt_Address.Location = new Point(34, 305);
            Txt_Address.Name = "Txt_Address";
            Txt_Address.Size = new Size(217, 29);
            Txt_Address.TabIndex = 3;
            // 
            // Txt_Phone
            // 
            Txt_Phone.BorderStyle = BorderStyle.FixedSingle;
            Txt_Phone.Location = new Point(34, 228);
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.Size = new Size(217, 29);
            Txt_Phone.TabIndex = 2;
            Txt_Phone.Validating += Txt_Phone_Validating;
            // 
            // Txt_EductionOutcome
            // 
            Txt_EductionOutcome.BorderStyle = BorderStyle.FixedSingle;
            Txt_EductionOutcome.Location = new Point(34, 154);
            Txt_EductionOutcome.Name = "Txt_EductionOutcome";
            Txt_EductionOutcome.Size = new Size(217, 29);
            Txt_EductionOutcome.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 270);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 0;
            label6.Text = "السكن :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(107, 119);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 1;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 193);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 0;
            label5.Text = "رقم الهاتف :";
            // 
            // Txt_Name
            // 
            Txt_Name.BorderStyle = BorderStyle.FixedSingle;
            Txt_Name.Location = new Point(34, 74);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(217, 29);
            Txt_Name.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 119);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 0;
            label3.Text = "المحصل التعليمي :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(144, 39);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 1;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 100;
            label1.Text = "الاسم كامل :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmb_Subject);
            groupBox2.Controls.Add(Txt_SubName);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(314, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 214);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "معلومات المادة";
            // 
            // cmb_Subject
            // 
            cmb_Subject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Subject.FormattingEnabled = true;
            cmb_Subject.Location = new Point(34, 74);
            cmb_Subject.Name = "cmb_Subject";
            cmb_Subject.Size = new Size(207, 29);
            cmb_Subject.TabIndex = 3;
            cmb_Subject.TabStop = false;
            cmb_Subject.SelectedIndexChanged += cmb_Subject_SelectedIndexChanged;
            // 
            // Txt_SubName
            // 
            Txt_SubName.BorderStyle = BorderStyle.FixedSingle;
            Txt_SubName.Location = new Point(34, 154);
            Txt_SubName.Name = "Txt_SubName";
            Txt_SubName.ReadOnly = true;
            Txt_SubName.Size = new Size(207, 29);
            Txt_SubName.TabIndex = 1;
            Txt_SubName.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(133, 119);
            label8.Name = "label8";
            label8.Size = new Size(17, 21);
            label8.TabIndex = 1;
            label8.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(156, 119);
            label10.Name = "label10";
            label10.Size = new Size(85, 21);
            label10.TabIndex = 0;
            label10.Text = "اسم المادة :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(144, 39);
            label11.Name = "label11";
            label11.Size = new Size(17, 21);
            label11.TabIndex = 1;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(164, 39);
            label12.Name = "label12";
            label12.Size = new Size(77, 21);
            label12.TabIndex = 100;
            label12.Text = "اختيار مادة";
            // 
            // Btn_Save
            // 
            Btn_Save.BackColor = Color.FromArgb(16, 185, 129);
            Btn_Save.FlatAppearance.BorderSize = 0;
            Btn_Save.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 150, 105);
            Btn_Save.FlatStyle = FlatStyle.Flat;
            Btn_Save.Image = Properties.Resources.save_instagram;
            Btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Save.Location = new Point(334, 276);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(217, 40);
            Btn_Save.TabIndex = 3;
            Btn_Save.Text = "حفظ";
            Btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.BackColor = Color.FromArgb(239, 68, 68);
            Btn_Clear.FlatAppearance.BorderSize = 0;
            Btn_Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
            Btn_Clear.FlatStyle = FlatStyle.Flat;
            Btn_Clear.Image = Properties.Resources.clean;
            Btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Clear.Location = new Point(334, 342);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(217, 40);
            Btn_Clear.TabIndex = 3;
            Btn_Clear.Text = "مسح الحقول";
            Btn_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Frm_Add_Edit_Teacher
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            ClientSize = new Size(597, 410);
            Controls.Add(Btn_Clear);
            Controls.Add(Btn_Save);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Frm_Add_Edit_Teacher";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Add_Edit_Teacher";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Btn_Close;
        private GroupBox groupBox1;
        private TextBox Txt_EductionOutcome;
        private Label label4;
        private TextBox Txt_Name;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Txt_Address;
        private TextBox Txt_Phone;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox Txt_SubName;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cmb_Subject;
        private Button Btn_Save;
        private Button Btn_Clear;
    }
}