using System;
using DataLayer;
using System.Data
;
using System.Linq;
namespace BuisnessLayer
{
    public class Subjects
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        public int ID { get; set; }
        public string SubjectName { get; set; }
        public int GeneralGrade { get; set; }
        public int MidTermMostGrade { get; set; }
        public int FinalMidTerm { get; set; }
        public int MostGrade
        {
            get
            {
                return GeneralGrade + MidTermMostGrade + FinalMidTerm;
            }
        }
        public int StudiedYear { get; set; }

        public AcademicYearData Class { get; set; }


        public Subjects()
        {
            Mode = enMode.AddNew;
        }

        private Subjects(int ID, string SubjectName, int GeneralMostGrade, int MidTermMostGrade, int FinalMidTerm, int ClassID)
        {
            this.ID = ID;
            this.SubjectName = SubjectName;
            this.GeneralGrade = GeneralMostGrade;
            this.MidTermMostGrade = MidTermMostGrade;
            this.FinalMidTerm = FinalMidTerm;
            this.StudiedYear = ClassID;

            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = SubjectsData.AddNew(SubjectName, GeneralGrade, MidTermMostGrade, FinalMidTerm, MostGrade, StudiedYear);
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            DataTable dt = SubjectsData.GetAll();
            return dt;
        }

        private bool Update()
        {
            return SubjectsData.Update(ID, SubjectName, GeneralGrade, MidTermMostGrade, FinalMidTerm, MostGrade, StudiedYear);
        }

        static public bool Delete(int ID)
        {
            try
            {
                return SubjectsData.Delete(ID);
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }

        static public Subjects GetById(int ID)
        {
            string SubjectName = string.Empty;
            int GeneralMostGrade = 0;
            int MidTermMostGrade = 0;
            int FinalMidTerm = 0;
            int MostGrade = 0;
            int ClassID = 0;

            return SubjectsData.Find(ID, ref SubjectName, ref GeneralMostGrade, ref MidTermMostGrade, ref FinalMidTerm, ref MostGrade, ref ClassID) ?
                new Subjects(ID, SubjectName, GeneralMostGrade, MidTermMostGrade, FinalMidTerm, MostGrade) : null;
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
                .Count(S => S.Field<string>("SubjectName") == SubjectName) > 0;
        }

        public static DataTable GetSubjectForClass(int StudeiedYear)
        {
            return GetAll().AsEnumerable()
                .Where(R => R.Field<int>("StudiedYearID") == StudeiedYear)
                .CopyToDataTable();
        }
    }
}
