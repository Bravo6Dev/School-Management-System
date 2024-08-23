using BuisnessLayer;
using Microsoft.Data.SqlClient;
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

namespace SchoolManagment.GUI.SubjectsGUI
{
    public partial class SubjectsUserControl : UserControl
    {
        static private SubjectsUserControl _SubjectUserControl { get; set; }
        static public SubjectsUserControl Instance
        {
            get
            {
                return _SubjectUserControl ?? (_SubjectUserControl = new SubjectsUserControl());
            }
        }

        private DataTable Data;

        private void ConfigColumns()
        {
            dgv_Subjects.Columns[0].Visible = false;
            dgv_Subjects.Columns[1].Visible = false;
            dgv_Subjects.Columns[2].HeaderText = "اسم المادة";
            dgv_Subjects.Columns[3].HeaderText = "اعمال السنة";
            dgv_Subjects.Columns[4].HeaderText = "درجة النصفي";
            dgv_Subjects.Columns[5].HeaderText = "درجة النهائي";
            dgv_Subjects.Columns[6].HeaderText = "الدرجة النهائية";
            dgv_Subjects.Columns[7].HeaderText = "السنة الدراسية";
        }

        private async void LoadData()
        {
            try
            {
                Data = await Task.Run(() => Subjects.GetAll());
                if (Data != null)
                {
                    dgv_Subjects.DataSource = Data;
                    ConfigColumns();
                    lbl_Data.Visible = dgv_Subjects.Rows.Count == 0;
                }
                this.Controls.Remove(Pic_Loading);
                Pic_Loading = null;
            }
            catch (Exception ex)
            {
                Messages.ErrorMessage(ex);
            }
        }

        private void Delete()
        {
            if (dgv_Subjects.Rows.Count > 0)
            {
                try
                {
                    int Id = dgv_Subjects.CurrentRow == null ?
                        (int)dgv_Subjects.Rows[0].Cells[0].Value :
                        (int)dgv_Subjects.CurrentRow.Cells[0].Value;
                    if (Messages.Ask("هل انت متأكد انك تريد حذف هذه المادة") == DialogResult.Yes)
                    {
                        if (Subjects.Delete(Id))
                        {
                            Messages.DeleteMessage(true);
                            LoadData();
                        }
                        else
                            Messages.DeleteMessage(false);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {

                    }
                }
                catch (Exception ex)
                {
                    Messages.ErrorMessage(ex);
                }
            }
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(Txt_Search.Text))
                Data.DefaultView.RowFilter = string.Empty;
            else
                Data.DefaultView.RowFilter = $"SubjectName LIKE '%{Txt_Search.Text.Trim()}%'";
        }

        private async void Edit()
        {
            if (dgv_Subjects.Rows.Count > 0)
            {
                int Id = dgv_Subjects.CurrentRow == null ?
                    (int)dgv_Subjects.Rows[0].Cells[0].Value :
                    (int)dgv_Subjects.CurrentRow.Cells[0].Value;
                Frm_Add_Edit_Subjects Frm = new Frm_Add_Edit_Subjects(Id);
                Frm.ShowDialog();
                LoadData();
            }
        }

        public SubjectsUserControl()
        {
            InitializeComponent();
            Data = new DataTable();
            LoadData();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Btn_teachers_Click(object sender, EventArgs e)
        {
            Frm_Add_Edit_Subjects Frm = new Frm_Add_Edit_Subjects();
            Frm.ShowDialog();
            LoadData();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void dgv_Subjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }
    }
}
