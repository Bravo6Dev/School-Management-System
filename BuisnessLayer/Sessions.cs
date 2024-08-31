using System;
using DataLayer;
using System.Data
;
using System.Linq;
using System.IO;
namespace BuisnessLayer
{
    public class Sessions
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        public int ID { get; set; }
        public int ClassID { get; set; }
        public Classes  Class { get; set; }
        public int TeacherID { get; set; }
        public Teachers Teacher { get; set; }
        public string Day { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Sessions()
        {
            Mode = enMode.AddNew;
        }

        public Sessions(int ID, int ClassID, int TeacherID, string Day, DateTime Time, DateTime EndTime)
        {
            this.ID = ID;
            this.ClassID = ClassID;
            this.TeacherID = TeacherID;
            this.Day = Day;
            this.StartTime = Time;
            this.EndTime = EndTime;
            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = SessionsData.AddNew(ClassID, TeacherID, Day, 
                new TimeSpan(StartTime.Hour, StartTime.Minute, StartTime.Second),
                new TimeSpan(EndTime.Hour, EndTime.Minute, EndTime.Second));
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            DataTable dt = SessionsData.GetAll();
            return dt;
        }

        private bool Update()
        {
            return SessionsData.Update(ID, ClassID, TeacherID, Day, 
                new TimeSpan(StartTime.Hour, StartTime.Minute, StartTime.Second),
                new TimeSpan(EndTime.Hour, EndTime.Minute, EndTime.Second));
        }

        static public bool Delete(int ID)
                => SessionsData.Delete(ID);

        static public Sessions GetById(int ID)
        {
            int ClassID = 0;
            int TeacherID = 0;
            string Day = string.Empty;
            DateTime Time = new DateTime();
            DateTime EndTime = new DateTime();

            return SessionsData.Find(ID, ref ClassID, ref TeacherID, ref Day, ref Time, ref EndTime) ?
                new Sessions(ID, ClassID, TeacherID, Day, Time, EndTime) : null;
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

        public bool SessionInSameTime()
        {
           return GetAll().AsEnumerable()
                .FirstOrDefault(R => StartTime.TimeOfDay < R.Field<TimeSpan>("EndTime") &&
                EndTime.TimeOfDay > R.Field<TimeSpan>("StartTime")
                && ClassID == R.Field<int>("ClassID")
                && Day == R.Field<string>("Day")) != null;
        }
    }
}
