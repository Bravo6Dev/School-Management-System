using BuisnessLayer;
using Microsoft.IdentityModel.Tokens;
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

namespace SchoolManagment.GUI.SessionsGUI
{
    public partial class Frm_Add_Edit_Sessions : Form
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;
        private int SessionID;
        private DataTable ClassesData;
        private DataTable TeachersData;

        private Sessions Session;
        private Classes Class;
        private Teachers Teacher;

        /// <summary>
        /// Set format as custom format and set the format
        /// </summary>
        private void ConfigDatePickers()
        {
            // Config DateTime Picker
            StartTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimePicker.CustomFormat = "HH:mm tt";

            EndTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimePicker.CustomFormat = "HH:mm tt";
        }


        private async void LoadClassesData()
        {
            ClassesData = await Task.Run(() => Classes.GetAll());
            if (ClassesData != null)
            {
                cmb_Class.DataSource = ClassesData;
                cmb_Class.ValueMember = "ID";
                cmb_Class.DisplayMember = "ClassName";
                if (cmb_Class.Items.Count > 0)
                {
                    cmb_Class.SelectedIndex = 0;
                    Class = Classes.GetById((int)cmb_Class.SelectedValue);
                    Txt_AcademicYear.Text = Class.AcademicYear.AcademicYearName;
                }
            }
        }

        private async void LoadTeacherData()
        {
            TeachersData = await Task.Run(() => Teachers.GetAll());
            if (TeachersData != null)
            {
                cmb_Teacher.DataSource = TeachersData;
                cmb_Teacher.ValueMember = "ID";
                cmb_Teacher.DisplayMember = "FullName";
                if (cmb_Teacher.Items.Count > 0)
                {
                    cmb_Teacher.SelectedIndex = 0;
                    Teacher = Teachers.GetById((int)cmb_Teacher.SelectedValue);
                    Txt_EductionOutCome.Text = Teacher.EductionalOutcome;
                    Txt_Subject.Text = Teacher.Subject.SubjectName;
                }
            }
        }

        private void LoadDataUpdateMode()
        {
            LoadClassesData();
            LoadTeacherData();
            ConfigDatePickers();

            Session = Sessions.GetById(SessionID);
            if (Session == null)
            {
                Close();
                return;
            }
            cmb_Class.SelectedValue = Session.ClassID;
            cmb_Teacher.SelectedValue = Session.TeacherID;
            cmb_Days.SelectedItem = Session.Day;
            StartTimePicker.Value = Session.StartTime;
            EndTimePicker.Value = Session.EndTime;
        }

        private void Update()
        {
            if (Session != null)
                return;
            Session.TeacherID = (int)cmb_Teacher.SelectedValue;
            Session.ClassID = (int)cmb_Class.SelectedValue;
            Session.Day = cmb_Days.SelectedText;
            Session.StartTime = StartTimePicker.Value;
            Session.EndTime = EndTimePicker.Value;

            if (Session.Save())
            {
                Messages.UpdateMessage(true);
                Close();
            }
            else
                Messages.UpdateMessage(false);
        }

        private void LoadData()
        {
            LoadClassesData();
            LoadTeacherData();

            ConfigDatePickers();

            if (DateTime.Now.DayOfWeek != DayOfWeek.Saturday)
                cmb_Days.SelectedIndex = (int)DateTime.Now.DayOfWeek;
            else
                cmb_Days.SelectedIndex = cmb_Days.Items.Count - 1;
        }

        private bool Valid()
        {
            if (cmb_Class.Items.Count == 0 || cmb_Teacher.Items.Count == 0)
            {
                Messages.EmptyComboboxMessage(Data.Teacher);
                return false;
            }
            if (cmb_Class.SelectedIndex == -1
                || cmb_Teacher.SelectedIndex == -1)
            {
                Messages.RequiermentSelectInComboBox();
                return false;
            }
            TimeSpan Time1 = new TimeSpan(StartTimePicker.Value.TimeOfDay.Hours,
                StartTimePicker.Value.TimeOfDay.Minutes, StartTimePicker.Value.TimeOfDay.Seconds);
            TimeSpan Time2 = new TimeSpan(EndTimePicker.Value.TimeOfDay.Hours,
                EndTimePicker.Value.TimeOfDay.Minutes, EndTimePicker.Value.TimeOfDay.Seconds);

            if (Time2 - Time1 < new TimeSpan(0, 30, 0))
            {
                Messages.InvalidMessage();
                return false;
            }
            return true;
        }

        private void AddNew()
        {
            if (!Valid())
                return;

            Session = new Sessions()
            {
                ClassID = (int)cmb_Class.SelectedValue,
                Day = cmb_Days.Text,
                TeacherID = (int)cmb_Teacher.SelectedValue,
                StartTime = StartTimePicker.Value,
                EndTime = EndTimePicker.Value
            };

            if (Session.SessionInSameTime())
            {
                Messages.SessionInTimeMessage();
                return;
            }

            if (Session.Save())
                Messages.AddNewMessage(true);
            else
                Messages.AddNewMessage(false);
        }

        private void Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    AddNew();
                    break;
                case enMode.Update:
                    Update();
                    break;
            }
        }

        /// <summary>
        /// Change class object data depends on selected item from combo box
        /// </summary>
        private void ChangeClass()
        {
            Class = Classes.GetById((int)cmb_Class.SelectedValue);
            Txt_AcademicYear.Text = Class.AcademicYear.AcademicYearName;
        }

        /// <summary>
        /// Change teacher object data depends on selected item from combo box
        /// </summary>
        private void ChangeTeacher()
        {
            Teacher = Teachers.GetById((int)cmb_Teacher.SelectedValue);
            Txt_EductionOutCome.Text = Teacher.EductionalOutcome;
            Txt_Subject.Text = Teacher.Subject.SubjectName;
        }

        public Frm_Add_Edit_Sessions()
        {
            InitializeComponent();
            ClassesData = TeachersData = new DataTable();
            LoadData();
            Mode = enMode.AddNew;
        }

        public Frm_Add_Edit_Sessions(int SessionID)
        {
            InitializeComponent();
            this.SessionID = SessionID;
            ClassesData = TeachersData = new DataTable();
            LoadDataUpdateMode();
            Mode = enMode.Update;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;

            if (int.TryParse(cmb.SelectedValue.ToString(), out int ID))
            {
                if (cmb == cmb_Class)
                    ChangeClass();
                else
                    ChangeTeacher();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
