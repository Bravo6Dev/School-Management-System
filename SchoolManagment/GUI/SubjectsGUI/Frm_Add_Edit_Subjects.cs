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

namespace SchoolManagment.GUI.SubjectsGUI
{
    public partial class Frm_Add_Edit_Subjects : Form
    {
        enum enMode { AddNew = 1, Update = 2 }

        private int ID;
        private enMode Mode;

        Subjects Subject;

        private async void LoadClasses()
        {
            cmb_StudiedYear.DataSource = await Task.Run(() => AcademicYears.GetAll());
            cmb_StudiedYear.ValueMember = "ID";
            cmb_StudiedYear.DisplayMember = "StudiedYear";
            if (cmb_StudiedYear.Items.Count > 0)
                cmb_StudiedYear.SelectedIndex = 0;
        }

        private void LoadDataUpdateMode()
        {
            try
            {
                Subject = Subjects.GetById(ID);
                if (Subject == null)
                    throw new ArgumentNullException($"Subject with {ID} ID not found");
                Txt_Name.Text = Subject.SubjectName;
                numeric_GeneralGrade.Value = Subject.GeneralGrade;
                numeric_MidTermGrade.Value = Subject.MidTermMostGrade;
                numeric_FinalTermGrade.Value = Subject.FinalMidTerm;
                cmb_StudiedYear.SelectedValue = Subject.StudiedYear;
            }
            catch (Exception ex)
            {
                Messages.ErrorMessage(ex);
            }
        }

        private bool Valid() =>
            !(string.IsNullOrEmpty(Txt_Name.Text));

        private void AddNew()
        {
            Subject = new Subjects()
            {
                SubjectName = Txt_Name.Text.Trim(),
                GeneralGrade = (int)numeric_GeneralGrade.Value,
                MidTermMostGrade = (int)numeric_MidTermGrade.Value,
                FinalMidTerm = (int)numeric_FinalTermGrade.Value,
                StudiedYear = (int)cmb_StudiedYear.SelectedValue!
            };
            if (Subject.IsDuplicate())
            {
                Messages.DuplicateDataMessage(Data.Subject);
                return;
            }
            if (Subject.Save())
            {
                Messages.AddNewMessage(true);
                Clear();
            }
            else
                Messages.AddNewMessage(false);
        }

        private void Edit()
        {
            if (Subject == null)
                throw new ArgumentNullException($"Subject with {ID} ID not found");

            Subject.SubjectName = Txt_Name.Text.Trim();

            Subject.GeneralGrade = (int)numeric_GeneralGrade.Value;
            Subject.MidTermMostGrade = (int)numeric_MidTermGrade.Value;
            Subject.FinalMidTerm = (int)numeric_FinalTermGrade.Value;

            if (Subject.IsDuplicate())
            {
                Messages.DuplicateDataMessage(Data.Subject);
                return;
            }
            if (Subject.Save())
                Messages.UpdateMessage(true);
            else
                Messages.UpdateMessage(false);
        }

        private void Clear()
        {
            Txt_Name.Clear();
            numeric_GeneralGrade.Value = numeric_GeneralGrade.Minimum;
            numeric_MidTermGrade.Value = numeric_MidTermGrade.Minimum;
            numeric_FinalTermGrade.Value = numeric_FinalTermGrade.Minimum;
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

        public Frm_Add_Edit_Subjects()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public Frm_Add_Edit_Subjects(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            LoadDataUpdateMode();
            cmb_StudiedYear.Enabled = false;
            Mode = enMode.Update;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Frm_Add_Edit_Subjects_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void Btn_Close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
