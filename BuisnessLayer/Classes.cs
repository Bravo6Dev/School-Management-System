using System;
using DataLayer;
using System.Data
;
namespace BuisnessLayer
{
    public class Classes
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        public int ID { get; set; }
        public string ClassName { get; set; }
        public int ClassYear { get; set; }
        public int Capacity { get; set; }

        public Classes()
        {
            Mode = enMode.AddNew;
        }

        public Classes(int ID, string ClassName, int ClassYear)
        {
            this.ID = ID;
            this.ClassName = ClassName;
            this.ClassYear = ClassYear;

            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = ClassesData.AddNew(ClassName, ClassYear);
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            DataTable dt = ClassesData.GetAll();
            return dt;
        }

        private bool Update()
        {
            return ClassesData.Update(ID, ClassName, ClassYear);
        }

        static public bool Delete(int ID)
                => ClassesData.Delete(ID);

        static public Classes GetById(int ID)
        {
            string ClassName = string.Empty;
            int ClassYear = 0;

            return ClassesData.Find(ID, ref ClassName, ref ClassYear) ?
                new Classes(ID, ClassName, ClassYear) : null;
        }

    }
}
