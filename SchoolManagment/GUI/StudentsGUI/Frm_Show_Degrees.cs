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

namespace SchoolManagment.GUI.StudentsGUI
{
    public partial class Frm_Show_Degrees : Form
    {
        SubjectResult StudentResult;
        DataTable Data;
        private int StudentID;

        private void LoadData()
        {
            Data = SubjectResult.GetAll(StudentID);
            if (Data != null)
            {
                dgv_Results.DataSource = Data;
                ConfigColumns();
            }
            lbl_Data.Visible = dgv_Results.Rows.Count == 0;
            Controls.Remove(Pic_Loading);
            Pic_Loading = null;
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
            DT.Columns[1].ColumnName = "اسم المادة";

            DT.Columns[2].SetOrdinal(2);
            DT.Columns[2].ColumnName = "درجة اعمال السنة";

            DT.Columns[3].SetOrdinal(3);
            DT.Columns[3].ColumnName = "درجة النصفي";

            DT.Columns[4].SetOrdinal(4);
            DT.Columns[4].ColumnName = "درجة النهائي";

            Helper.Export(DT, $"Degrees of Student {StudentID}");
        }


        private void ConfigColumns()
        {
            dgv_Results.Columns[0].HeaderText = "اسم المادة";
            dgv_Results.Columns[1].HeaderText = "درجة اعمال السنة";
            dgv_Results.Columns[2].HeaderText = "درجة النصفي";
            dgv_Results.Columns[3].HeaderText = "درجة النهائي";
        }

        public Frm_Show_Degrees(int ID)
        {
            InitializeComponent();
            Data = new DataTable();
            this.StudentID = ID;
            LoadData();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            Export();
        }
    }
}
