using System;
using DataLayer;
using System.Data
;
namespace BuisnessLayer
{
    public class Sessions
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        public int ID { get; set; }
        public int ClassID { get; set; }
        public int TeacherID { get; set; }
        public string Day { get; set; }
        public DateTime Time { get; set; }
        public Sessions()
        {
            Mode = enMode.AddNew;
        }

        public Sessions(int ID, int ClassID, int TeacherID, string Day, DateTime Time)
        {
            this.ID = ID;
            this.ClassID = ClassID;
            this.TeacherID = TeacherID;
            this.Day = Day;
            this.Time = Time;

            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = SessionsData.AddNew(ClassID, TeacherID, Day, Time);
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            DataTable dt = SessionsData.GetAll();
            return dt;
        }

        private bool Update()
        {
            return SessionsData.Update(ID, ClassID, TeacherID, Day, Time);
        }

        static public bool Delete(int ID)
                => SessionsData.Delete(ID);

        static public Sessions GetById(int ID)
        {
            int ClassID = 0;
            int TeacherID = 0;
            string Day = string.Empty;
            DateTime Time = new DateTime();

            return SessionsData.Find(ID, ref ClassID, ref TeacherID, ref Day, ref Time) ?
                new Sessions(ID, ClassID, TeacherID, Day, Time) : null;
        }

    }
}
