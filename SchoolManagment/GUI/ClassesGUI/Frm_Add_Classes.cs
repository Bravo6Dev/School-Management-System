﻿using BuisnessLayer;
using DataLayer;
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

namespace SchoolManagment.GUI.ClassesGUI
{
    public partial class Frm_Add_Classes : Form
    {
        Classes Class;

        private async void LoadAcademicYear()
        {
            cmb_AcademicYear.DataSource = await Task.Run(() => AcademicYears.GetAll());
            cmb_AcademicYear.ValueMember = "ID";
            cmb_AcademicYear.DisplayMember = "StudiedYear";

            if (cmb_AcademicYear.Items.Count > 0)
                cmb_AcademicYear.SelectedIndex = 0;
        }

        private bool Valid() =>
            !(string.IsNullOrEmpty(Txt_Name.Text));

        private void AddNew()
        {
            Class = new Classes()
            {
                ClassName = Txt_Name.Text.Trim(),
                AcademicYearID = (int)cmb_AcademicYear.SelectedValue!,
                Capacity = (int)numeric_Capicity.Value,
            };
            if (Class.Save())
            {
                Messages.AddNewMessage(true);
                Clear();
            }
            else
                Messages.AddNewMessage(false);
        }

        private void Clear()
        {
            Txt_Name.Clear();
            numeric_Capicity.Value = numeric_Capicity.Minimum;
            cmb_AcademicYear.SelectedIndex = 0;
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
            AddNew();
        }

        public Frm_Add_Classes()
        {
            InitializeComponent();
            LoadAcademicYear();
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
    }
}
