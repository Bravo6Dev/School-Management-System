using BuisnessLayer;
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
    }
}
