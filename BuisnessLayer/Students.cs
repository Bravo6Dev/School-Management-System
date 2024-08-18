using System;
using DataLayer;
using System.Data
;
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

            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = StudentsData.AddNew(FullName, DOB, Address, Phone, ClassID);
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            DataTable dt = StudentsData.GetAll();
            return dt;
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

    }
}
