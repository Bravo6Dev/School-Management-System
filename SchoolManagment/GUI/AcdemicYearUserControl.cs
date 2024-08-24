using BuisnessLayer;
using DocumentFormat.OpenXml.InkML;
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

namespace SchoolManagment.GUI
{
    public partial class AcademicYearUserControl : UserControl
    {
        private AcademicYears Academic;
        private static AcademicYearUserControl _Instance;
        private DataTable Data;

        public static AcademicYearUserControl Instance
        {
            get
            {
                _Instance = _Instance ?? (_Instance = new AcademicYearUserControl());
                _Instance.LoadData();
                return _Instance;
            }
        }

        public async void LoadData()
        {
            Data = await Task.Run(() => AcademicYears.GetAll());
            if (Data != null)
            {
                dgv_AcadimecYear.DataSource = Data;
                BindData();
                ConfigColumns();
            }
            lbl_Data.Visible = dgv_AcadimecYear.Rows.Count == 0;
            Controls.Remove(Pic_Loading);
            Pic_Loading = null;
        }

        private void ConfigColumns()
        {
            dgv_AcadimecYear.Columns[0].Visible = false;
            dgv_AcadimecYear.Columns[1].HeaderText = "السنة الدراسية";
        }

        private void BindData()
        {
            Txt_AcademicName.DataBindings.Clear();
            Txt_AcademicName.DataBindings.Add("Text", dgv_AcadimecYear.DataSource,
                "StudiedYear", true, DataSourceUpdateMode.OnValidation);
        }

        private void AddNew()
        {
            if (string.IsNullOrEmpty(Txt_AcademicName.Text))
            {
                Messages.RequiermentFeildsMessage();
                return;
            }
            Academic = new AcademicYears()
            {
                AcademicYearName = Txt_AcademicName.Text.Trim()
            };
            if (Academic.IsDuplicate())
            {
                Messages.DuplicateDataMessage(Codes.Data.AcademicYear);
                return;
            }

            if (Academic.AddNew())
            {
                Messages.AddNewMessage(true);
                LoadData();
            }
            else
                Messages.AddNewMessage(false);
        }

        private void Delete()
        {
            if (dgv_AcadimecYear.Rows.Count > 0)
            {
                int ID = dgv_AcadimecYear.CurrentRow == null ?
                    (int)dgv_AcadimecYear.Rows[0].Cells[0].Value :
                    (int)dgv_AcadimecYear.CurrentRow.Cells[0].Value;
                if (Messages.Ask("هل انت متأكد انك تريد حذف هذا الفصل الدراسي سيتم حذف جميع الفصول والمواد المتعلقة به")
                    == DialogResult.Yes)
                {
                    if (AcademicYears.Delete(ID))
                    {
                        Messages.DeleteMessage(true);
                        LoadData();
                    }
                    else
                        Messages.DeleteMessage(false);
                }
            }
        }

        public AcademicYearUserControl()
        {
            InitializeComponent();
            Data = new DataTable();
        }

        private void Btn_teachers_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
