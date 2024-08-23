using System;
using DataLayer;
using System.Data;
using System.Linq;
using System.Data.Common;


namespace BuisnessLayer
{
    public class Teachers
    {
        /// <summary>
        /// To Check The Mode Of Object Is New Or We Want To Update It
        /// </summary>
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        // The Fields 
        public int ID { get; set; }
        public string FullName { get; set; }
        public string EductionalOutcome { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int SubjectID { get; set; }

        /// <summary>
        /// The Constructor Called In AddNew Mode
        /// </summary>
        public Teachers()
        {
            Mode = enMode.AddNew;
        }
        /// <summary>
        /// The Constructor Called In Update Mode And Send With It The Previous Field
        /// </summary>
        public Teachers(int ID, string FullName, string EductionalOutcome, string Phone, string Address, int SubjectID)
        {
            this.ID = ID;
            this.FullName = FullName;
            this.EductionalOutcome = EductionalOutcome;
            this.Phone = Phone;
            this.Address = Address;
            this.SubjectID = SubjectID;

            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = TeachersData.AddNew(FullName, EductionalOutcome, Phone, Address, SubjectID);
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            DataTable dt = TeachersData.GetAll();
            return dt;
        }

        private bool Update()
        {
            return TeachersData.Update(ID, FullName, EductionalOutcome, Phone, Address, SubjectID);
        }

        static public bool Delete(int ID)
                => TeachersData.Delete(ID);

        static public Teachers GetById(int ID)
        {
            string FullName = string.Empty;
            string EductionalOutcome = string.Empty;
            string Phone = string.Empty;
            string Address = string.Empty;
            int SubjectID = 0;

            return TeachersData.Find(ID, ref FullName, ref EductionalOutcome, ref Phone, ref Address, ref SubjectID) ?
                new Teachers(ID, FullName, EductionalOutcome, Phone, Address, SubjectID) : null;
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
                    else
                        return false;
                case enMode.Update:
                    return Update();
            }
            return false;
        }

        public bool IsDuplicate()
        {
            DataTable DT = GetAll();
            if (DT != null)
                return DT.AsEnumerable()
                    .Count(R => R.Field<string>("FullName") == FullName) > 0;
            else return false;
        }
    }
}
