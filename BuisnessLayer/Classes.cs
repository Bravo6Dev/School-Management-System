using System;
using DataLayer;
using System.Data;
using System.Collections.Generic;
using System.Linq;
namespace BuisnessLayer
{
    public class Classes
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        public int ID { get; set; }
        public string ClassName { get; set; }
        public int StudiedYearID { get; set; }
        public int Capacity { get; set; }

        public Classes()
        {
            ID = 0;
            ClassName = string.Empty;
            StudiedYearID = 0;
            Capacity = 0;
            Mode = enMode.AddNew;
        }

        public Classes(int ID, string ClassName, int ClassYear, int Capicity)
        {
            this.ID = ID;
            this.ClassName = ClassName;
            this.StudiedYearID = ClassYear;
            this.Capacity = Capicity;

            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = ClassesData.AddNew(ClassName, StudiedYearID, Capacity);
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            DataTable dt = ClassesData.GetAll();
            return dt;
        }

        private bool Update()
        {
            return ClassesData.Update(ID, ClassName, StudiedYearID, Capacity);
        }

        static public bool Delete(int ID)
                => ClassesData.Delete(ID);

        static public Classes GetById(int ID)
        {
            string ClassName = string.Empty;
            int Capicity = 0, ClassYear = 0;

            return ClassesData.Find(ID, ref ClassName, ref ClassYear, ref Capicity) ?
                new Classes(ID, ClassName, ClassYear, Capicity) : null;
        }

        public bool Full()
        {
            return Students.GetAll().AsEnumerable().
                Count(R => R.Field<int>("StudiedYear") == ID) == Capacity;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNew())
                    {
                        Mode = enMode.AddNew;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return Update();
            }
            return false;
        }
    }
}
