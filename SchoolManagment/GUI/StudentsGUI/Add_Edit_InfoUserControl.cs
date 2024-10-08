﻿using BuisnessLayer;
using DocumentFormat.OpenXml.Office2016.Excel;
using SchoolManagment.Codes;
using SchoolManagment.GUI.ClassesGUI;
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
        private int ClassID;
        private enMode Mode;

        Students Student;
        Classes Class;

        private async void LoadSubjects()
        {
            cmb_Class.DataSource = await Task.Run(() => Classes.GetAll());
            cmb_Class.ValueMember = "ID";
            cmb_Class.DisplayMember = "ClassName";
            ClassID = (int)(cmb_Class.SelectedValue ?? -1)!;
            Class = Classes.GetById(ClassID);
            if (Class == null)
            {
                Messages.NotFoundMessage();
                return;
            }
            Txt_ClassName.Text = Class.ClassName;
            Txt_ClassYear.Text = Class.AcademicYear.AcademicYearName;
        }

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
                cmb_Class.SelectedValue = Student.ClassID;
            }
            catch (Exception ex)
            {
                Messages.ErrorMessage(ex);
            }
        }

        /// <summary>
        /// Check If Any Required Fields Doesn't Filled
        /// </summary>
        private bool Valid()
        => !(string.IsNullOrEmpty(Txt_Name.Text) || cmb_Class.SelectedIndex == -1);

        private void AddNew()
        {
            Student = new Students()
            {
                FullName = Txt_Name.Text.Trim(),
                DOB = dateTimePicker1.Value,
                Phone = string.IsNullOrEmpty(Txt_Phone.Text.Trim()) ?
                null : Txt_Phone.Text.Trim(),
                Address = string.IsNullOrEmpty(Txt_Address.Text.Trim()) ?
                null : Txt_Address.Text.Trim(),
                ClassID = (int)cmb_Class.SelectedValue!
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

            Student.DOB = dateTimePicker1.Value;
            Student.ClassID = (int)cmb_Class.SelectedValue!;

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
            dateTimePicker1.Value = DateTime.Now;
            Txt_Address.Clear();
            cmb_Class.SelectedIndex = 0;
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
            if (Class.Full())
            {
                Messages.FullClassMessage();
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

        public Add_Edit_InfoUserControl()
        {
            InitializeComponent();
            LoadSubjects();
            Mode = enMode.AddNew;
        }

        public Add_Edit_InfoUserControl(int ID)
        {
            InitializeComponent();
            LoadSubjects();
            this.ID = ID;
            LoadDataUpdateMode();
            Mode = enMode.Update;
        }


        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Txt_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (!Helper.ValidPhoneNumber(Txt_Phone.Text.Trim()))
            {
                Messages.InvalidMessage();
                Txt_Phone.SelectAll();
                Txt_Phone.Focus();
            }
        }

        private void cmb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
