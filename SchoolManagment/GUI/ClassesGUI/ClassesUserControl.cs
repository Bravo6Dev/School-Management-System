using BuisnessLayer;
using Microsoft.Data.SqlClient;
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
    public partial class ClassesUserControl : UserControl
    {
        public static event EventHandler StudentAdded;

        private static ClassesUserControl _Instance;
        private DataTable Data;

        public static ClassesUserControl Instance
        {
            get
            {
                if (_Instance != null)
                    _Instance.LoadData();
                _Instance = _Instance ?? (_Instance = new ClassesUserControl());
                return _Instance;
            }
        }


        private void DeleteStudentClass(int ClassID)
        {
            if (Messages.Ask("هذا الفصل يحتوي على طلبة هل تريد حذف الطلبة؟") == DialogResult.Yes)
            {
                DataTable DT = Students.GetAll(ClassID);
                foreach (DataRow dr in DT.Rows)
                    Students.Delete(dr.Field<int>("ID"));
            }
        }

        private void Delete()
        {
            int ID = dgv_Classes.CurrentRow == null ?
                (int)dgv_Classes.Rows[0].Cells[0].Value :
                (int)dgv_Classes.CurrentRow.Cells[0].Value;
            try
            {
                if (dgv_Classes.Rows.Count > 0)
                {
                    if (Messages.Ask("هل انت متأكد من حذف هذا الفصل") == DialogResult.Yes)
                    {
                        if (Classes.Delete(ID))
                        {
                            Messages.DeleteMessage(true);
                            LoadData();
                        }
                        else
                            Messages.DeleteMessage(false);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    DeleteStudentClass(ID);
                    if (Classes.Delete(ID))
                    {
                        Messages.DeleteMessage(true);
                        LoadData();
                    }
                    else
                        Messages.DeleteMessage(false);
                 
                }
            }
        }

        private async void LoadData()
        {
            Data = await Task.Run(() => Classes.GetAll());

            if (Data != null)
            {
                dgv_Classes.DataSource = Data;
                ConfigColumns();
                lbl_Data.Visible = dgv_Classes.Rows.Count == 0;
                Controls.Remove(Pic_Loading);
                Pic_Loading = null;
            }
        }

        private void ConfigColumns()
        {
            dgv_Classes.Columns[0].Visible = false;
            dgv_Classes.Columns[1].HeaderText = "اسم الفصل";
            dgv_Classes.Columns[2].HeaderText = "السنة الدراسية للفصل";
            dgv_Classes.Columns[3].HeaderText = "عدد الطلبة";
            dgv_Classes.Columns[4].HeaderText = "سعة الفصل";
        }

        public ClassesUserControl()
        {
            InitializeComponent();
            Data = new DataTable();
            LoadData();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Frm_Add_Classes Frm = new Frm_Add_Classes();
            Frm.ShowDialog();
            LoadData();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
