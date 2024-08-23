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

namespace SchoolManagment.GUI.TeacherGUI
{
    public partial class Frm_Add_Edit_Teacher : Form
    {
        /// <summary>
        /// Detected The From In Which Mode Will Be
        /// </summary>
        enum enMode { AddNew = 1, Update = 2 }


        private int ID;
        private enMode Mode;

        Teachers Teacher;

        /// <summary>
        /// Load All Subjects From Subjects Table
        /// </summary>
        private async void LoadSubjects()
        {
            cmb_Subject.DataSource = await Task.Run(() => Subjects.GetAll());
            cmb_Subject.ValueMember = "ID";
            cmb_Subject.DisplayMember = "SubjectName";
            if (cmb_Subject.Items.Count > 0)
                cmb_Subject.SelectedIndex = 0;
            Txt_SubName.Text = cmb_Subject.Text;
        }

        /// <summary>
        /// Load All Data Of Object That Been Send And Fill Fields With It
        /// </summary>
        private void LoadDataUpdateMode()
        {
            try
            {
                Teacher = Teachers.GetById(ID);
                if (Teacher == null)
                    throw new ArgumentNullException($"Teacher with {ID} ID not found");
                Txt_Name.Text = Teacher.FullName;
                Txt_EductionOutcome.Text = Teacher.EductionalOutcome;
                Txt_Phone.Text = Teacher.Phone ?? string.Empty;
                Txt_Address.Text = Teacher.Address ?? string.Empty;
                cmb_Subject.SelectedValue = Teacher.SubjectID;
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
            Teacher = new Teachers()
            {
                FullName = Txt_Name.Text.Trim(),
                EductionalOutcome = Txt_EductionOutcome.Text.Trim(),
                Phone = string.IsNullOrEmpty(Txt_Phone.Text.Trim()) ?
                null : Txt_Phone.Text.Trim(),
                Address = string.IsNullOrEmpty(Txt_Address.Text.Trim()) ?
                null : Txt_Address.Text.Trim(),
                SubjectID = (int)cmb_Subject.SelectedValue!
            };
            if (Teacher.IsDuplicate())
            {
                Messages.DuplicateDataMessage(Data.Teacher);
                return;
            }
            if (Teacher.Save())
            {
                Messages.AddNewMessage(true);
                Clear();
            }
            else
                Messages.AddNewMessage(false);
        }

        private void Edit()
        {
            if (Teacher == null)
                throw new ArgumentNullException($"Teacher with {ID} ID not found");

            Teacher.FullName = Txt_Name.Text.Trim();

            Teacher.Address = string.IsNullOrEmpty(Txt_Address.Text.Trim()) ?
                null : Txt_Address.Text.Trim();

            Teacher.Phone = string.IsNullOrEmpty(Txt_Phone.Text.Trim()) ?
                null : Txt_Phone.Text.Trim();

            Teacher.EductionalOutcome = Txt_EductionOutcome.Text.Trim();
            Teacher.SubjectID = (int)cmb_Subject.SelectedValue!;

            if (Teacher.IsDuplicate())
            {
                Messages.DuplicateDataMessage(Data.Teacher);
                return;
            }

            if (Teacher.Save())
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

        public Frm_Add_Edit_Teacher()
        {
            InitializeComponent();
            LoadSubjects();
            Mode = enMode.AddNew;
        }

        public Frm_Add_Edit_Teacher(int ID)
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

        private void Txt_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (!Helper.ValidPhoneNumber(Txt_Phone.Text.Trim()))
            {
                Messages.UnvalidMessage();
                Txt_Phone.SelectAll();
                Txt_Phone.Focus();
            }
        }
    }
}
