using BuisnessLayer;
using DocumentFormat.OpenXml.Office2013.Excel;
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
    public partial class Edit_DegreeUserControl : UserControl
    {
        private static Edit_DegreeUserControl _Instance;
        private int ID;

        Students Student;
        SubjectResult StudentResult;
        Subjects Subject;

        private void AddNew()
        {
            StudentResult = new SubjectResult()
            {
                StudentID = ID,
                FinalTermGrade = (int)numeric_FinalTermGrade.Value,
                GeneralGrade = (int)numeric_GeneralGrade.Value,
                MidTermGrade = (int)numeric_MidTermGrade.Value,
                SubjectID = (int)cmb_Subjects.SelectedValue!
            };
            if (StudentResult.IsDuplicate())
            {
                Messages.DuplicateDataMessage(Data.SubjectResult);
                return;
            }

            if (StudentResult.Save())
            {
                Messages.AddNewMessage(true);
            }
            else
                Messages.AddNewMessage(false);
        }

        private void Edit()
        {
            if (cmb_Subjects.Items.Count > 0)
                StudentResult = SubjectResult.GetBySubjectIdAndStudentID((int)cmb_Subjects.SelectedValue!, Student.ID);
            if (StudentResult == null)
            {
                Messages.NotFoundMessage();
                return;
            }

            StudentResult.GeneralGrade = (int)numeric_GeneralGrade.Value;
            StudentResult.FinalTermGrade = (int)numeric_FinalTermGrade.Value;
            StudentResult.MidTermGrade = (int)numeric_MidTermGrade.Value;

            if (Student.Save())
                Messages.UpdateMessage(true);
            else
                Messages.UpdateMessage(false);
        }

        private void SetMaxValue()
        {
            numeric_FinalTermGrade.Maximum = Subject.FinalMidTerm;
            numeric_MidTermGrade.Maximum = Subject.MidTermMostGrade;
            numeric_GeneralGrade.Maximum = Subject.GeneralGrade;
        }

        private async void LoadSubjectsOfTerm()
        {
            cmb_Subjects.DataSource = await Task.Run(() => Subjects.GetSubjectForClass(Student.ClassID));
            cmb_Subjects.ValueMember = "ID";
            cmb_Subjects.DisplayMember = "SubjectName";

            Subject = Subjects.GetById((int)cmb_Subjects.SelectedValue!);
            if (Subject != null)
                SetMaxValue();

            if (cmb_Subjects.Items.Count > 0)
                cmb_Subjects.SelectedIndex = 0;
        }

        private void LoadStudentData()
        {
            Student = Students.GetById(ID);

            if (Student == null)
            {
                Messages.NotFoundMessage();
                return;
            }

            Txt_Name.Text = Student.FullName;
            Txt_Phone.Text = Student.Phone;
            Txt_Address.Text = Student.Address;
            dateTimePicker1.Value = Student.DOB;
            LoadSubjectsOfTerm();
        }

        public static Edit_DegreeUserControl Instance(int ID)
        {
            return _Instance ?? (_Instance = new Edit_DegreeUserControl(ID));
        }

        public Edit_DegreeUserControl(int ID)
        {
            this.ID = ID;
            InitializeComponent();
            LoadStudentData();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void cmb_Subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmb_Subjects.SelectedValue.ToString(), out int ID))
            {
                Subject = Subjects.GetById(ID);
                if (Subject != null)
                    SetMaxValue();
            }
        }
    }
}
