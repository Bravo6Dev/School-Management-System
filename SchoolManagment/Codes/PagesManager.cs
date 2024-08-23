using SchoolManagment.GUI.StudentsGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.Codes
{
    public class PagesManager
    {
        enum enMainForm { Main, MainStudent }
        enMainForm _MainForm;

        private Frm_Main _Main;
        private Frm_Add_Edit_Student _MainStudent;

        public PagesManager(Frm_Main Main)
        {
            this._Main = Main;
            _MainForm = enMainForm.Main;
        }

        public PagesManager(Frm_Add_Edit_Student Main)
        {
            _MainStudent = Main;
            _MainForm = enMainForm.MainStudent;
        }

        private void SetMainPages(UserControl Page)
        {
            if (Page != null)
                Page.Dock = DockStyle.Fill;
            UserControl OldPage = _Main.Panel_Container.Controls.OfType<UserControl>().FirstOrDefault()!;
            if (OldPage != null && Page != OldPage)
                _Main.Panel_Container.Controls.Remove(OldPage);
            if (OldPage != Page)
                _Main.Panel_Container.Controls.Add(Page);
        }

        private void SetStudentPages(UserControl Page)
        {
            if (Page != null)
                Page.Dock = DockStyle.Fill;
            UserControl OldPage = _MainStudent.Panel_Contanier.Controls.OfType<UserControl>().FirstOrDefault()!;
            if (OldPage != null && Page != OldPage)
                _MainStudent.Panel_Contanier.Controls.Remove(OldPage);
            if (OldPage != Page)
                _MainStudent.Panel_Contanier.Controls.Add(Page);
        }

        /// <summary>
        /// To Manage The Pages That Open In Main Form
        /// </summary
        public void SetPages(UserControl Page)
        {
            switch (_MainForm)
            {
                case enMainForm.Main:
                    SetMainPages(Page); break;
                case enMainForm.MainStudent: 
                    SetStudentPages(Page); break;
            }
        }
    }
}
