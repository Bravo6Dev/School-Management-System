using BuisnessLayer;
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
    public partial class Add_Edit_InfoUserControl : UserControl
    {
        private static Add_Edit_InfoUserControl _Instance;

        public static Add_Edit_InfoUserControl Instance
        {
            get
            {
                return _Instance ?? (_Instance = new Add_Edit_InfoUserControl()); 
            }
        }

        /// <summary>
        /// Detected The From In Which Mode Will Be
        /// </summary>
        enum enMode { AddNew = 1, Update = 2 }


        private int ID;
        private enMode Mode;

        Students Student;

        /// <summary>
        /// Load All Data Of Object That Been Send And Fill Fields With It
        /// </summary>
        private void LoadDataUpdateMode()
        {
            try
            {
                Student = Students.GetById(ID);
                if (Student == null)
                    throw new ArgumentNullException($"Student with {ID} ID not found");
                Txt_Name.Text = Student.FullName;
                dateTimePicker1.Value = Student.DOB.Date;
                Txt_Phone.Text = Student.Phone ?? string.Empty;
                Txt_Address.Text = Student.Address ?? string.Empty;
                cmb_Subject.SelectedValue = Student.ClassID;
            }
            catch (Exception ex)
            {
                Messages.ErrorMessage(ex);
            }
        }

        /// <summary>
        /// Check If Any Required Fields Doesn't Filled
        /// </summary>
        private bool Valid() =>
            !(string.IsNullOrEmpty(Txt_Name.Text)
                || string.IsNullOrEmpty(Txt_EductionOutcome.Text));

        private void AddNew()
        {
            Student = new Students()
            {
                FullName = Txt_Name.Text.Trim(),
                EductionalOutcome = Txt_EductionOutcome.Text.Trim(),
                Phone = string.IsNullOrEmpty(Txt_Phone.Text.Trim()) ?
                null : Txt_Phone.Text.Trim(),
                Address = string.IsNullOrEmpty(Txt_Address.Text.Trim()) ?
                null : Txt_Address.Text.Trim(),
                SubjectID = (int)cmb_Subject.SelectedValue!
            };
            if (Student.IsDuplicate())
            {
                Messages.DuplicateDataMessage(Data.Student);
                return;
            }
            if (Student.Save())
            {
                Messages.AddNewMessage(true);
                Clear();
            }
            else
                Messages.AddNewMessage(false);
        }

        private void Edit()
        {
            if (Student == null)
                throw new ArgumentNullException($"Student with {ID} ID not found");

            Student.FullName = Txt_Name.Text.Trim();

            Student.Address = string.IsNullOrEmpty(Txt_Address.Text.Trim()) ?
                null : Txt_Address.Text.Trim();

            Student.Phone = string.IsNullOrEmpty(Txt_Phone.Text.Trim()) ?
                null : Txt_Phone.Text.Trim();

            Student.EductionalOutcome = Txt_EductionOutcome.Text.Trim();
            Student.SubjectID = (int)cmb_Subject.SelectedValue!;

            if (Student.IsDuplicate())
            {
                Messages.DuplicateDataMessage(Data.Student);
                return;
            }

            if (Student.Save())
                Messages.UpdateMessage(true);
            else
                Messages.UpdateMessage(false);
        }

        private void Clear()
        {
            Txt_Name.Clear();
            Txt_Phone.Clear();
            Txt_EductionOutcome.Clear();
            Txt_Address.Clear();
            Txt_SubName.Clear();
            Txt_Name.Focus();
        }

        private void Save()
        {
            if (!Valid())
            {
                Messages.RequiermentFeildsMessage();
                Txt_Name.Focus();
                return;
            }
            switch (Mode)
            {
                case enMode.AddNew:
                    AddNew(); break;
                case enMode.Update:
                    Edit(); break;
            }
        }

        public Frm_Add_Edit_Student()
        {
            InitializeComponent();
            LoadSubjects();
            Mode = enMode.AddNew;
        }

        public Frm_Add_Edit_Student(int ID)
        {
            InitializeComponent();
            LoadSubjects();
            this.ID = ID;
            LoadDataUpdateMode();
            Mode = enMode.Update;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void cmb_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_SubName.Text = cmb_Subject.Text;
        }

        public Add_Edit_InfoUserControl()
        {
            InitializeComponent();
        }
    }
}
