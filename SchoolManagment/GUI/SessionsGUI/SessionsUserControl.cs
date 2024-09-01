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

namespace SchoolManagment.GUI.SessionsGUI
{
    public partial class SessionsUserControl : UserControl
    {
        private static SessionsUserControl _Instance;
        private DataTable Data;

        public static SessionsUserControl Instance
        {
            get
            {
                if (_Instance != null)
                {
                    _Instance.LoadClassData();
                    return _Instance;
                }
                else
                    return (_Instance = new SessionsUserControl());
            }
        }

        private async void LoadClassData()
        {
            DataTable DT = await Classes.GetAllAsync();
            DataRow dr = DT.NewRow();

            dr["ClassName"] = "لايوجد";
            dr["StudiedYear"] = new AcademicYears();
            dr["Capacity"] = -1;
            DT.Rows.InsertAt(dr, 0);

            cmb_Classes.DataSource = DT;
            cmb_Classes.ValueMember = "ID";
            cmb_Classes.DisplayMember = "ClassName";

            if (cmb_Classes.Items.Count > 0)
                cmb_Classes.SelectedIndex = 0;
        }

        private async void LoadData()
        {
            Data = await Task.Run(() => Sessions.GetAll());
            if (Data != null)
            {
                dgv_Sessions.DataSource = Data;
                ConfigColumns();
                lbl_Data.Visible = dgv_Sessions.Rows.Count == 0;

                // Config The Start Time Picker
                StartTime_Picker.Format = DateTimePickerFormat.Custom;
                StartTime_Picker.CustomFormat = "hh:mm tt";
                // Config The Combo boxes
                LoadClassData();
                cmb_Days.SelectedIndex = 0;

                // Delete Load Picture
                Controls.Remove(Pic_Loading);
                Pic_Loading = null;
            }
        }

        private void ConfigColumns()
        {
            dgv_Sessions.Columns[0].Visible = false;
            dgv_Sessions.Columns[1].Visible = false;
            dgv_Sessions.Columns[2].HeaderText = "الفصل";
            dgv_Sessions.Columns[3].HeaderText = "الاستاذ";
            dgv_Sessions.Columns[4].HeaderText = "اليوم";

            dgv_Sessions.Columns[5].HeaderText = "بداية الحصة";
            dgv_Sessions.Columns[6].HeaderText = "نهاية الحصة";
        }

        private void Delete()
        {
            if (dgv_Sessions.Rows.Count > 0)
            {
                int Id = dgv_Sessions.CurrentRow == null ?
                    (int)dgv_Sessions.Rows[0].Cells[0].Value :
                    (int)dgv_Sessions.CurrentRow.Cells[0].Value;
                if (Messages.Ask("هل انت متأكد انك تريد حذف هذه المحاضرة") == DialogResult.Yes)
                {
                    if (Sessions.Delete(Id))
                    {
                        Messages.DeleteMessage(true);
                        LoadData();
                    }
                    else
                        Messages.DeleteMessage(false);
                }

            }

        }

        private void Update()
        {
            if (dgv_Sessions.Rows.Count > 0)
            {
                int ID = dgv_Sessions.CurrentRow == null ?
                    (int)dgv_Sessions.Rows[0].Cells[0].Value :
                    (int)dgv_Sessions.CurrentRow.Cells[0].Value;
                Frm_Add_Edit_Sessions Frm = new Frm_Add_Edit_Sessions(ID);
                Frm.ShowDialog();
                LoadData();
            }
        }

        private void Search()
        {
            string Filter = "";
            if (!string.IsNullOrEmpty(Txt_TeacherName.Text))
                Filter += $"FullName LIKE '%{Txt_TeacherName.Text.Trim()}%' ";
            if (cmb_Classes.SelectedIndex != 0)
            {
                if (!string.IsNullOrEmpty(Filter))
                    Filter += $"AND ClassID = {(int)cmb_Classes.SelectedValue} ";
                else
                    Filter += $"ClassID = {(int)cmb_Classes.SelectedValue} ";
            }
            if (cmb_Days.SelectedIndex != 0)
            {
                if (!string.IsNullOrEmpty(Filter))
                    Filter += $"AND Day LIKE '%{cmb_Days.Text}%' ";
                else
                    Filter += $"Day LIKE '%{cmb_Days.Text}%' ";
            }
            if (ck_ByTime.Checked)
            {
                if (!string.IsNullOrEmpty(Filter))
                    Filter += $" AND CONVERT(StartTime, 'System.String') LIKE '%{StartTime_Picker.Value.TimeOfDay}%'";
                else
                    Filter = $"CONVERT(StartTime, 'System.String') LIKE '%{StartTime_Picker.Value.TimeOfDay}%'";
            }
            Data.DefaultView.RowFilter = Filter;
        }

        private void Clear()
        {
            Data.DefaultView.RowFilter = string.Empty;
            Txt_TeacherName.Clear();
            cmb_Classes.SelectedIndex = cmb_Days.SelectedIndex = 0;
            ck_ByTime.Checked = false;
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

            DT.Columns[2].SetOrdinal(1);
            DT.Columns[2].ColumnName = "الفصل";

            DT.Columns[3].SetOrdinal(2);
            DT.Columns[3].ColumnName = "الاستاذ";

            DT.Columns[4].SetOrdinal(3);
            DT.Columns[4].ColumnName = "اليوم";

            DT.Columns[4].SetOrdinal(4);
            DT.Columns[4].ColumnName = "بداية الحصة";

            DT.Columns[4].SetOrdinal(5);
            DT.Columns[4].ColumnName = "نهاية الحصة";

            DT.Columns.Remove("ClassID");

            Helper.Export(DT, "Sessions");
        }

        public SessionsUserControl()
        {
            InitializeComponent();
            Data = new DataTable();
            LoadData();
        }

        private void Btn_teachers_Click(object sender, EventArgs e)
        {
            Frm_Add_Edit_Sessions Frm = new Frm_Add_Edit_Sessions();
            Frm.ShowDialog();
            LoadData();
        }

        private void dgv_Sessions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_Sessions.Columns[e.ColumnIndex].Index >= 5)
            {
                if (e.Value != null)
                {
                    if (TimeSpan.TryParse(e.Value.ToString(), out TimeSpan ts))
                    {
                        e.Value = ts.ToString(@"hh\:mm");
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
