namespace SchoolManagment.GUI.ClassesGUI
{
    partial class Frm_Add_Classes
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
            Btn_Save = new Button();
            Btn_Close = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            Txt_Name = new TextBox();
            label5 = new Label();
            label6 = new Label();
            numeric_Capicity = new NumericUpDown();
            groupBox1 = new GroupBox();
            cmb_StudiedYear = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_Capicity).BeginInit();
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
            Btn_Clear.Location = new Point(332, 273);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(217, 40);
            Btn_Clear.TabIndex = 11;
            Btn_Clear.Text = "مسح الحقول";
            Btn_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;
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
            Btn_Save.Location = new Point(31, 273);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(217, 40);
            Btn_Save.TabIndex = 12;
            Btn_Save.Text = "حفظ";
            Btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
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
            // panel1
            // 
            panel1.Controls.Add(Btn_Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 31);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 41);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 100;
            label1.Text = "اسم الفصل :";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(265, 128);
            label9.Name = "label9";
            label9.Size = new Size(113, 21);
            label9.TabIndex = 100;
            label9.Text = "السنة الدراسية : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(254, 128);
            label10.Name = "label10";
            label10.Size = new Size(17, 21);
            label10.TabIndex = 1;
            label10.Text = "*";
            // 
            // Txt_Name
            // 
            Txt_Name.BorderStyle = BorderStyle.FixedSingle;
            Txt_Name.Location = new Point(338, 76);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(217, 29);
            Txt_Name.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 41);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 100;
            label5.Text = "سعة الفصل :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(59, 41);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 1;
            label6.Text = "*";
            // 
            // numeric_Capicity
            // 
            numeric_Capicity.BackColor = Color.FromArgb(46, 46, 46);
            numeric_Capicity.BorderStyle = BorderStyle.FixedSingle;
            numeric_Capicity.ForeColor = Color.White;
            numeric_Capicity.Location = new Point(59, 76);
            numeric_Capicity.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numeric_Capicity.Name = "numeric_Capicity";
            numeric_Capicity.Size = new Size(113, 29);
            numeric_Capicity.TabIndex = 101;
            numeric_Capicity.TextAlign = HorizontalAlignment.Center;
            numeric_Capicity.UpDownAlign = LeftRightAlignment.Left;
            numeric_Capicity.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_StudiedYear);
            groupBox1.Controls.Add(numeric_Capicity);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Txt_Name);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 214);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الفصل";
            // 
            // cmb_StudiedYear
            // 
            cmb_StudiedYear.FormattingEnabled = true;
            cmb_StudiedYear.Location = new Point(165, 165);
            cmb_StudiedYear.Name = "cmb_StudiedYear";
            cmb_StudiedYear.Size = new Size(213, 29);
            cmb_StudiedYear.TabIndex = 102;
            // 
            // Frm_Add_Classes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            ClientSize = new Size(597, 349);
            Controls.Add(panel1);
            Controls.Add(Btn_Save);
            Controls.Add(groupBox1);
            Controls.Add(Btn_Clear);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Frm_Add_Classes";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Add_Classes";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numeric_Capicity).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Clear;
        private Button Btn_Save;
        private Button Btn_Close;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label9;
        private Label label10;
        private TextBox Txt_Name;
        private Label label5;
        private Label label6;
        private NumericUpDown numeric_Capicity;
        private GroupBox groupBox1;
        private ComboBox cmb_StudiedYear;
    }
}