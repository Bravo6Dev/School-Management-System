using BuisnessLayer;
using SchoolManagment.Codes;
using SchoolManagment.GUI.TeacherGUI;
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
    public partial class StudentUserControl : UserControl
    {
        private static StudentUserControl _Instance;

        public static StudentUserControl Instance
        {
            get
            {
                return _Instance ?? (_Instance = new StudentUserControl());
            }
        }
        private DataTable Data;

        private void ConfigColumns()
        {
            dgv_Student.Columns[0].Visible = false;
            dgv_Student.Columns[1].HeaderText = "الاسم كامل";

            dgv_Student.Columns[2].HeaderText = "تاريخ الولادة";
            dgv_Student.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";

            dgv_Student.Columns[3].HeaderText = "السكن";
            dgv_Student.Columns[4].HeaderText = "رقم الهاتف";

            dgv_Student.Columns[5].Visible = false;
        }

        private async void LoadData()
        {
            try
            {
                Data = await Task.Run(() => Students.GetAll());
                if (Data != null)
                {
                    dgv_Student.DataSource = Data;
                    ConfigColumns();
                    cmb_Filter.SelectedIndex = 0;
                    lbl_Data.Visible = dgv_Student.Rows.Count == 0;
                }
                this.Controls.Remove(Pic_Loading);
                Pic_Loading = null;
            }
            catch (Exception ex)
            {
                Messages.ErrorMessage(ex);
            }
        }

        private void Search()
        {
            switch (cmb_Filter.SelectedIndex)
            {
                case 0:
                    Data.DefaultView.RowFilter = string.Empty;
                    break;
                case 1:
                    Data.DefaultView.RowFilter = $"FullName LIKE '%{Txt_Search.Text.Trim()}%'";
                    break;
                case 2:
                    Data.DefaultView.RowFilter = $"Phone LIKE '%{Txt_Search.Text.Trim()}%'";
                    break;
            }
            if (Txt_Search.Text == string.Empty || cmb_Filter.SelectedIndex == 0)
                Data.DefaultView.RowFilter = string.Empty;
            dgv_Student.DataSource = Data;
        }

        private async void Edit()
        {
            if (dgv_Student.Rows.Count > 0)
            {
                int Id = dgv_Student.CurrentRow == null ?
                    (int)dgv_Student.Rows[0].Cells[0].Value :
                    (int)dgv_Student.CurrentRow.Cells[0].Value;
                Frm_Add_Edit_Student Frm = new Frm_Add_Edit_Student(Id);
                Frm.ShowDialog();
                LoadData();
            }
        }

        private void Export()
        {
            DataTable DT = new DataTable();

            foreach (DataColumn item in Data.Columns)
                DT.Columns.Add(item.ColumnName, typeof(string));
            foreach (DataRow item in Data.Rows)
                DT.ImportRow(item);

            DT.Columns[0].SetOrdinal(0);
            DT.Columns[0].ColumnName = "ر.ق";

            DT.Columns[1].SetOrdinal(1);
            DT.Columns[1].ColumnName = "الاسم";

            DT.Columns[2].SetOrdinal(2);
            DT.Columns[2].ColumnName = "تاريخ الولادة";

            DT.Columns[3].SetOrdinal(3);
            DT.Columns[3].ColumnName = "السكن";

            DT.Columns[4].SetOrdinal(4);
            DT.Columns[4].ColumnName = "رقم الهاتف";

            DT.Columns.Remove("ClassID");

            Helper.Export(DT, "Students");
        }

        public StudentUserControl()
        {

            InitializeComponent();
            Data = new DataTable();
            LoadData();
        }

        private void Btn_teachers_Click(object sender, EventArgs e)
        {
            Frm_Add_Edit_Student Frm = new Frm_Add_Edit_Student();
            Frm.ShowDialog();
            LoadData();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Student.Rows.Count > 0)
            {
                int Id = dgv_Student.CurrentRow == null ?
                    (int)dgv_Student.Rows[0].Cells[0].Value :
                    (int)dgv_Student.CurrentRow.Cells[0].Value;
                if (Messages.Ask("هل انت متأكد انك تريد حذف هذا الطالب") == DialogResult.Yes)
                {
                    if (Students.Delete(Id))
                    {
                        Messages.DeleteMessage(true);
                        LoadData();
                    }
                    else
                        Messages.DeleteMessage(false);
                }
            }
        }

        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Btn_Degree_Click(object sender, EventArgs e)
        {
            if (dgv_Student.Rows.Count > 0)
            {
                int ID = dgv_Student.CurrentRow == null ?
                    (int)dgv_Student.Rows[0].Cells[0].Value :
                    (int)dgv_Student.CurrentRow.Cells[0].Value;
                Frm_Show_Degrees Frm = new Frm_Show_Degrees(ID);
                Frm.ShowDialog();
            }
        }

        private void cmb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Filter.SelectedIndex == 0)
            {
                Data.DefaultView.RowFilter = "";
                Txt_Search.Clear();
            }
        }
    }
}
