using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SchoolManagment.Codes
{
    public class Helper
    {
        private static Regex Pattern;
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

        public static bool ValidPhoneNumber(string phoneNumber)
        {
            Pattern = new Regex("(091|092|093|094)\\s*\\d{7}");
            if (string.IsNullOrEmpty(phoneNumber))
                return true;
            else
                return Pattern.IsMatch(phoneNumber);
        }
    }
}
