using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.Codes
{
    /// <summary>
    /// Detected Where You Call The Class.
    /// </summary>
    public enum Data { Teacher, Student, Subject, Classes, Results, SubjectResult, AcademicYear }
    public static class Messages
    {
        public static void ErrorMessage(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK
                ,MessageBoxIcon.Error);
        }

        public static void AddNewMessage(bool Success)
        {
            if (Success)
                MessageBox.Show("تمت عملية الاضافة بنجاح", "تنبيه", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("فشلت عملية الاضافة", "خطــأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Ask(string message)
        {
            return MessageBox.Show(message, "تنبيه",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void DeleteMessage(bool Success)
        {
            if (Success)
                MessageBox.Show("تمت عملية الحذف بنجاح", "تنبيه", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("خطــأ أثناء عملية الحذف", "خطــأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UpdateMessage(bool Success)
        {
            if (Success)
                MessageBox.Show("تمت عملية التحديث بنجاح", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("خطــأ اثناء التحديث", "خطــأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void RequiermentFeildsMessage()
        {
            MessageBox.Show("الرجاء تعبئة الحقول المطلوبة", "خطــأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DuplicateDataMessage(Data Type)
        {
            switch (Type)
            {
                case Data.Teacher:
                    MessageBox.Show("اسم الاستاذ موجود بالفعل", "خطــأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Data.Subject:
                    MessageBox.Show("اسم المادة موجود بالفعل", "خطــأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Data.SubjectResult:
                    MessageBox.Show("تمت اضافة درجات لهذه المادة بالفعل", "خطــأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Data.AcademicYear:
                    MessageBox.Show("السنة الدراسية موجودة بالفعل", "خطــأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static void NotFoundMessage()
        {
            MessageBox.Show("عذرا, لم يتم العثور على البيانات", "خطــأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void FullClassMessage()
        {
            MessageBox.Show("هذا الفصل ممتلئ الرجاء اختيار فصل اخر", "خطــأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UnvalidMessage()
        {
            MessageBox.Show("الرجاء ادخال بيانات صحيحة", "خطــأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
