using SchoolManagment.Codes;
using SchoolManagment.GUI;
using SchoolManagment.GUI.ClassesGUI;
using SchoolManagment.GUI.StudentsGUI;
using SchoolManagment.GUI.SubjectsGUI;
using SchoolManagment.GUI.TeacherGUI;

namespace SchoolManagment
{
    public partial class Frm_Main : Form
    {
        public PagesManager Pages { get; set; }

        public Frm_Main()
        {
            InitializeComponent();
            Pages = new PagesManager(this);
            Pages.SetPages(TeacherUserControl.Instance);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_teachers_Click(object sender, EventArgs e)
        {
            Pages.SetPages(TeacherUserControl.Instance);
        }

        private void Btn_Subjects_Click(object sender, EventArgs e)
        {
            Pages.SetPages(SubjectsUserControl.Instance);
        }

        private void Btn_Students_Click(object sender, EventArgs e)
        {
            Pages.SetPages(StudentUserControl.Instance);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pages.SetPages(ClassesUserControl.Instance);
        }

        private void Btn_AcademicYears_Click(object sender, EventArgs e)
        {
            Pages.SetPages(AcademicYearUserControl.Instance);
        }
    }
}
