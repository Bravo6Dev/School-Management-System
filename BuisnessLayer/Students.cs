using System;
using DataLayer;
using System.Data
;
using System.Linq;
using System.Collections.Generic;
namespace BuisnessLayer
{
    public class Students
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int ClassID { get; set; }

        public Classes Class { get; set; }

        public Students()
        {
            Mode = enMode.AddNew;
        }

        public Students(int ID, string FullName, DateTime DOB, string Address, string Phone, int ClassID)
        {
            this.ID = ID;
            this.FullName = FullName;
            this.DOB = DOB;
            this.Address = Address;
            this.Phone = Phone;
            this.ClassID = ClassID;
            this.Class = Classes.GetById(ClassID);

            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = StudentsData.AddNew(FullName, DOB, Address, Phone, ClassID);
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            try
            {
                DataTable dt = StudentsData.GetAll();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Update()
        {
            return StudentsData.Update(ID, FullName, DOB, Address, Phone, ClassID);
        }

        static public bool Delete(int ID)
                => StudentsData.Delete(ID);

        static public Students GetById(int ID)
        {
            string FullName = string.Empty;
            DateTime DOB = new DateTime();
            string Address = string.Empty;
            string Phone = string.Empty;
            int ClassID = 0;

            return StudentsData.Find(ID, ref FullName, ref DOB, ref Address, ref Phone, ref ClassID) ?
                new Students(ID, FullName, DOB, Address, Phone, ClassID) : null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return Update();
            }
            return false; 
        }

        public bool IsDuplicate()
        {
            DataTable DT = GetAll();
            return DT.AsEnumerable()
                .Count(R => R.Field<string>("FullName") == FullName) > 0;
        }

        public static DataTable GetAll(int ClassID)
        {
            return GetAll().AsEnumerable()
                .Where(R => R.Field<int>("StudiedYear") == ClassID)
                .CopyToDataTable();
        }

    }
}
