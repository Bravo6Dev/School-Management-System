using BuisnessLayer;
using SchoolManagment.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.GUI.TeacherGUI
{
    public partial class TeacherUserControl : UserControl
    {
        private static TeacherUserControl _Instance;
        /// <summary>
        /// This Property To Create An Instance From This Class Using Singlton Design Pattern
        /// </summary>
        public static TeacherUserControl Instance
        {
            get
            {
                return _Instance ?? (_Instance = new TeacherUserControl());
            }
        }
        private DataTable Data;

        /// <summary>
        /// Configure The Columns Name, Visible, All Properties If There Exist
        /// </summary>
        private void ConfigColumns()
        {
            dgv_Teachers.Columns[0].Visible = false;
            dgv_Teachers.Columns[1].HeaderText = "الاسم كامل";
            dgv_Teachers.Columns[2].HeaderText = "المحصل التعليمي";
            dgv_Teachers.Columns[3].HeaderText = "رقم الهاتف";
            dgv_Teachers.Columns[4].HeaderText = "العنوان";
            dgv_Teachers.Columns[5].Visible = false;
        }

        private async void LoadData()
        {
            try
            {
                Data = await Task.Run(() => Teachers.GetAll());
                if (Data != null)
                {
                    dgv_Teachers.DataSource = Data;
                    ConfigColumns();
                    cmb_Filter.SelectedIndex = 0;
                    lbl_Data.Visible = dgv_Teachers.Rows.Count == 0;
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
                    Data.DefaultView.RowFilter = $"EductionalOutcome LIKE '%{Txt_Search.Text.Trim()}%'";
                    break;
                case 3:
                    Data.DefaultView.RowFilter = $"Phone LIKE '%{Txt_Search.Text.Trim()}%'";
                    break;
            }
            if (Txt_Search.Text == string.Empty || cmb_Filter.SelectedIndex == 0)
                Data.DefaultView.RowFilter = string.Empty;
            //dgv_Subjects.DataSource = Data;
        }

        private async void Edit()
        {
            if (dgv_Teachers.Rows.Count > 0)
            {
                int Id = dgv_Teachers.CurrentRow == null ?
                    (int)dgv_Teachers.Rows[0].Cells[0].Value :
                    (int)dgv_Teachers.CurrentRow.Cells[0].Value;
                Frm_Add_Edit_Teacher Frm = new Frm_Add_Edit_Teacher(Id);
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
            DT.Columns[2].ColumnName = "المحصل التعليمي";

            DT.Columns[3].SetOrdinal(3);
            DT.Columns[3].ColumnName = "رقم الهاتف";

            DT.Columns[4].SetOrdinal(4);
            DT.Columns[4].ColumnName = "السكن";

            DT.Columns.Remove("SubjectID");

            Helper.Export(DT, "Teachers");
        }

        public TeacherUserControl()
        {
            InitializeComponent();
            Data = new DataTable();
            LoadData();
        }

        private void Btn_teachers_Click(object sender, EventArgs e)
        {
            Frm_Add_Edit_Teacher Frm = new Frm_Add_Edit_Teacher();
            Frm.ShowDialog();
            LoadData();
        }

        private async void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Teachers.Rows.Count > 0)
            {
                int Id = dgv_Teachers.CurrentRow == null ?
                    (int)dgv_Teachers.Rows[0].Cells[0].Value :
                    (int)dgv_Teachers.CurrentRow.Cells[0].Value;
                if (Messages.Ask("هل انت متأكد انك تريد حذف هذا الاستاذ؟") == DialogResult.Yes)
                {
                    if (Teachers.Delete(Id))
                    {
                        Messages.DeleteMessage(true);
                        LoadData();
                    }
                    else
                        Messages.DeleteMessage(false);
                }
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void dgv_Teachers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Filter.SelectedIndex == 0)
            {
                Txt_Search.Clear();
                Data.DefaultView.RowFilter = string.Empty;
            }
        }

        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            Export();
        }
    }
}
