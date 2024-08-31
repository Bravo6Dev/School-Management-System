namespace SchoolManagment.GUI.SubjectsGUI
{
    partial class Frm_Add_Edit_Subjects
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
            Btn_Clear = new Button();
            cmb_StudiedYear = new ComboBox();
            numeric_MidTermGrade = new NumericUpDown();
            label6 = new Label();
            numeric_FinalTermGrade = new NumericUpDown();
            label8 = new Label();
            numeric_GeneralGrade = new NumericUpDown();
            Btn_Close = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            Txt_Name = new TextBox();
            label10 = new Label();
            label3 = new Label();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            Btn_Save = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numeric_MidTermGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_FinalTermGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_GeneralGrade).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            Btn_Clear.Location = new Point(332, 291);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(217, 40);
            Btn_Clear.TabIndex = 15;
            Btn_Clear.Text = "مسح الحقول";
            Btn_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Clear.UseVisualStyleBackColor = false;
            // 
            // cmb_StudiedYear
            // 
            cmb_StudiedYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_StudiedYear.FormattingEnabled = true;
            cmb_StudiedYear.Location = new Point(187, 162);
            cmb_StudiedYear.Name = "cmb_StudiedYear";
            cmb_StudiedYear.Size = new Size(225, 29);
            cmb_StudiedYear.TabIndex = 102;
            cmb_StudiedYear.SelectedIndexChanged += cmb_Classes_SelectedIndexChanged;
            // 
            // numeric_MidTermGrade
            // 
            numeric_MidTermGrade.BackColor = Color.FromArgb(46, 46, 46);
            numeric_MidTermGrade.BorderStyle = BorderStyle.FixedSingle;
            numeric_MidTermGrade.ForeColor = Color.White;
            numeric_MidTermGrade.Location = new Point(50, 76);
            numeric_MidTermGrade.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numeric_MidTermGrade.Name = "numeric_MidTermGrade";
            numeric_MidTermGrade.Size = new Size(113, 29);
            numeric_MidTermGrade.TabIndex = 101;
            numeric_MidTermGrade.TextAlign = HorizontalAlignment.Center;
            numeric_MidTermGrade.UpDownAlign = LeftRightAlignment.Left;
            numeric_MidTermGrade.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(44, 41);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 1;
            label6.Text = "*";
            // 
            // numeric_FinalTermGrade
            // 
            numeric_FinalTermGrade.BackColor = Color.FromArgb(46, 46, 46);
            numeric_FinalTermGrade.BorderStyle = BorderStyle.FixedSingle;
            numeric_FinalTermGrade.ForeColor = Color.White;
            numeric_FinalTermGrade.Location = new Point(440, 163);
            numeric_FinalTermGrade.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numeric_FinalTermGrade.Name = "numeric_FinalTermGrade";
            numeric_FinalTermGrade.Size = new Size(112, 29);
            numeric_FinalTermGrade.TabIndex = 101;
            numeric_FinalTermGrade.TextAlign = HorizontalAlignment.Center;
            numeric_FinalTermGrade.UpDownAlign = LeftRightAlignment.Left;
            numeric_FinalTermGrade.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(440, 128);
            label8.Name = "label8";
            label8.Size = new Size(17, 21);
            label8.TabIndex = 1;
            label8.Text = "*";
            // 
            // numeric_GeneralGrade
            // 
            numeric_GeneralGrade.BackColor = Color.FromArgb(46, 46, 46);
            numeric_GeneralGrade.BorderStyle = BorderStyle.FixedSingle;
            numeric_GeneralGrade.ForeColor = Color.White;
            numeric_GeneralGrade.Location = new Point(194, 76);
            numeric_GeneralGrade.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numeric_GeneralGrade.Name = "numeric_GeneralGrade";
            numeric_GeneralGrade.Size = new Size(113, 29);
            numeric_GeneralGrade.TabIndex = 101;
            numeric_GeneralGrade.TextAlign = HorizontalAlignment.Center;
            numeric_GeneralGrade.UpDownAlign = LeftRightAlignment.Left;
            numeric_GeneralGrade.Value = new decimal(new int[] { 10, 0, 0, 0 });
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
            Btn_Close.Click += Btn_Close_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(Btn_Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 31);
            panel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(195, 41);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 1;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 41);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 100;
            label5.Text = "درجة النصفي :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(459, 128);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 100;
            label7.Text = "درجة النهائي :";
            // 
            // Txt_Name
            // 
            Txt_Name.BorderStyle = BorderStyle.FixedSingle;
            Txt_Name.Location = new Point(338, 76);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(217, 29);
            Txt_Name.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(288, 128);
            label10.Name = "label10";
            label10.Size = new Size(17, 21);
            label10.TabIndex = 1;
            label10.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 41);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 100;
            label3.Text = "اعمال السنة :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(299, 128);
            label9.Name = "label9";
            label9.Size = new Size(113, 21);
            label9.TabIndex = 100;
            label9.Text = "السنة الدراسية : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(449, 41);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 1;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 41);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 100;
            label1.Text = "اسم المادة :";
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
            Btn_Save.Location = new Point(31, 291);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(217, 40);
            Btn_Save.TabIndex = 16;
            Btn_Save.Text = "حفظ";
            Btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_StudiedYear);
            groupBox1.Controls.Add(numeric_MidTermGrade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numeric_FinalTermGrade);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(numeric_GeneralGrade);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Txt_Name);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 214);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المادة";
            // 
            // Frm_Add_Edit_Subjects
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            ClientSize = new Size(597, 349);
            Controls.Add(Btn_Clear);
            Controls.Add(panel1);
            Controls.Add(Btn_Save);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Frm_Add_Edit_Subjects";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Add_Edit_Subjects";
            Load += Frm_Add_Edit_Subjects_Load;
            ((System.ComponentModel.ISupportInitialize)numeric_MidTermGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_FinalTermGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_GeneralGrade).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Clear;
        private ComboBox cmb_StudiedYear;
        private NumericUpDown numeric_MidTermGrade;
        private Label label6;
        private NumericUpDown numeric_FinalTermGrade;
        private Label label8;
        private NumericUpDown numeric_GeneralGrade;
        private Button Btn_Close;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox Txt_Name;
        private Label label10;
        private Label label3;
        private Label label9;
        private Label label2;
        private Label label1;
        private Button Btn_Save;
        private GroupBox groupBox1;
    }
}