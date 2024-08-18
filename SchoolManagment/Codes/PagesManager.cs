using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.Codes
{
    public class PagesManager
    {
        private Frm_Main _Main;

        public PagesManager(Frm_Main Main)
        {
            this._Main = Main;
        }

        /// <summary>
        /// To Manage The Pages That Open In Main Form
        /// </summary
        public void SetPages(UserControl Page)
        {
            if (Page != null)
                Page.Dock = DockStyle.Fill;
            UserControl OldPage = _Main.Panel_Container.Controls.OfType<UserControl>().FirstOrDefault()!;
            if (OldPage != null && Page != OldPage)
                _Main.Panel_Container.Controls.Remove(OldPage);
            if (OldPage != Page)
                _Main.Panel_Container.Controls.Add(Page);
        }
    }
}
