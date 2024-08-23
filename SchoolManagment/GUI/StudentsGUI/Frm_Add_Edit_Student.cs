using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.Web.WebView2.Core;
using SchoolManagment.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.GUI.StudentsGUI
{
    public partial class Frm_Add_Edit_Student : Form
    {
        enum enMode { AddNew = 1, Update = 2}
        enMode Mode;

        PagesManager Pages;
        private int StudentID;

        public Frm_Add_Edit_Student()
        {
            Pages = new PagesManager(this);
            InitializeComponent();
            Pages.SetPages(new Add_Edit_InfoUserControl());
            Mode = enMode.AddNew;
        }


        public Frm_Add_Edit_Student(int ID)
        {
            Pages = new PagesManager(this);
            InitializeComponent();
            this.StudentID = ID;
            Pages.SetPages(new Add_Edit_InfoUserControl(ID));
            Mode = enMode.Update;
        }

        private void Btn_StudentInfo_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            if (button == Btn_StudentDegree)
            {
                button.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
                Btn_StudentInfo.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
                Pages.SetPages(Edit_DegreeUserControl.Instance(StudentID));
            }
            else
            {
                button.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
                Btn_StudentDegree.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
                if (Mode == enMode.AddNew)
                    Pages.SetPages(Add_Edit_InfoUserControl.Instance);
                else
                    Pages.SetPages(new Add_Edit_InfoUserControl(StudentID));
            }
        }

        private void Frm_Add_Edit_Student_Load(object sender, EventArgs e)
        {
            Btn_StudentInfo.Focus();
            Btn_StudentDegree.Enabled = Mode != enMode.AddNew;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
