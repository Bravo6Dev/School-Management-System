using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SchoolManagment.Codes
{
    public class Helper
    {
        /// <summary>
        /// Export The Data To Excel Sheet Using Closed.Excel Library
        /// </summary>
        public static void Export(DataTable DT, string SheetName)
        {
            try
            {
                SaveFileDialog savediailog = new SaveFileDialog()
                {
                    AddExtension = true,
                    Filter = "Excel Files (.xlsx)|*.xlsx",
                    RestoreDirectory = true,
                    DefaultExt = "xlsx",
                    Title = "Export To Excel"
                };
                if (savediailog.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wk = new XLWorkbook())
                    {
                        wk.AddWorksheet(DT, SheetName);
                        using (MemoryStream ms = new MemoryStream())
                        {
                            wk.SaveAs(ms);
                            File.WriteAllBytes(savediailog.FileName, ms.ToArray());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.ErrorMessage(ex);
            }
        }
    }
}
