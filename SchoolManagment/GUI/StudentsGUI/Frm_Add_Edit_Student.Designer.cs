namespace SchoolManagment.GUI.StudentsGUI
{
    partial class Frm_Add_Edit_Student
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
            Btn_Back = new Button();
            Btn_StudentDegree = new Button();
            Btn_StudentInfo = new Button();
            Panel_Contanier = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Btn_Back);
            panel1.Controls.Add(Btn_StudentDegree);
            panel1.Controls.Add(Btn_StudentInfo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 581);
            panel1.TabIndex = 0;
            // 
            // Btn_Back
            // 
            Btn_Back.Cursor = Cursors.Hand;
            Btn_Back.Dock = DockStyle.Bottom;
            Btn_Back.FlatAppearance.BorderSize = 0;
            Btn_Back.FlatStyle = FlatStyle.Flat;
            Btn_Back.ForeColor = Color.White;
            Btn_Back.Image = Properties.Resources.back;
            Btn_Back.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Back.Location = new Point(0, 542);
            Btn_Back.Name = "Btn_Back";
            Btn_Back.Size = new Size(189, 39);
            Btn_Back.TabIndex = 2;
            Btn_Back.Text = "الرجوع";
            Btn_Back.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Back.UseVisualStyleBackColor = true;
            Btn_Back.Click += Btn_Back_Click;
            // 
            // Btn_StudentDegree
            // 
            Btn_StudentDegree.Cursor = Cursors.Hand;
            Btn_StudentDegree.Dock = DockStyle.Top;
            Btn_StudentDegree.FlatAppearance.BorderSize = 0;
            Btn_StudentDegree.FlatStyle = FlatStyle.Flat;
            Btn_StudentDegree.ForeColor = Color.White;
            Btn_StudentDegree.Image = Properties.Resources.report_card;
            Btn_StudentDegree.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_StudentDegree.Location = new Point(0, 39);
            Btn_StudentDegree.Name = "Btn_StudentDegree";
            Btn_StudentDegree.Size = new Size(189, 39);
            Btn_StudentDegree.TabIndex = 1;
            Btn_StudentDegree.Text = "درجات الطالب";
            Btn_StudentDegree.TextAlign = ContentAlignment.MiddleLeft;
            Btn_StudentDegree.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_StudentDegree.UseVisualStyleBackColor = true;
            Btn_StudentDegree.Click += Btn_StudentInfo_Click;
            // 
            // Btn_StudentInfo
            // 
            Btn_StudentInfo.BackColor = Color.FromArgb(59, 130, 246);
            Btn_StudentInfo.Cursor = Cursors.Hand;
            Btn_StudentInfo.Dock = DockStyle.Top;
            Btn_StudentInfo.FlatAppearance.BorderSize = 0;
            Btn_StudentInfo.FlatStyle = FlatStyle.Flat;
            Btn_StudentInfo.ForeColor = Color.White;
            Btn_StudentInfo.Image = Properties.Resources.graduated;
            Btn_StudentInfo.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_StudentInfo.Location = new Point(0, 0);
            Btn_StudentInfo.Name = "Btn_StudentInfo";
            Btn_StudentInfo.Size = new Size(189, 39);
            Btn_StudentInfo.TabIndex = 0;
            Btn_StudentInfo.Text = "معلومات الطالب";
            Btn_StudentInfo.TextAlign = ContentAlignment.MiddleLeft;
            Btn_StudentInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_StudentInfo.UseVisualStyleBackColor = false;
            Btn_StudentInfo.Click += Btn_StudentInfo_Click;
            // 
            // Panel_Contanier
            // 
            Panel_Contanier.Dock = DockStyle.Fill;
            Panel_Contanier.Location = new Point(189, 0);
            Panel_Contanier.Name = "Panel_Contanier";
            Panel_Contanier.Size = new Size(638, 581);
            Panel_Contanier.TabIndex = 1;
            // 
            // Frm_Add_Edit_Student
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            ClientSize = new Size(827, 581);
            Controls.Add(Panel_Contanier);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Frm_Add_Edit_Student";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Add_Edit_Grades";
            Load += Frm_Add_Edit_Student_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Btn_StudentInfo;
        private Button Btn_Back;
        private Button Btn_StudentDegree;
        public Panel Panel_Contanier;
    }
}