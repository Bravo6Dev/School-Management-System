using System;
using DataLayer;
using System.Data
;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace BuisnessLayer
{
    public class SubjectResult
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int MidTermGrade { get; set; }
        public int FinalTermGrade { get; set; }
        public int GeneralGrade { get; set; }

        public SubjectResult()
        {
            Mode = enMode.AddNew;
        }

        public SubjectResult(int ID, int StudentID, int MidTermGrade, int FineTermGrade, int GeneralGrade, int SubjectID)
        {
            this.ID = ID;
            this.StudentID = StudentID;
            this.MidTermGrade = MidTermGrade;
            this.FinalTermGrade = FineTermGrade;
            this.GeneralGrade = GeneralGrade;
            this.SubjectID = SubjectID;

            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = SubjectResultData.AddNew(StudentID, SubjectID, MidTermGrade, FinalTermGrade, GeneralGrade);
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            return SubjectResultData.GetAll();
        }

        static public DataTable GetAll(int StudentID)
        {
            try
            {
                return SubjectResultData.GetAllByStudentID(StudentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Update()
        {
            return SubjectResultData.Update(ID, StudentID, SubjectID, MidTermGrade, FinalTermGrade, GeneralGrade);
        }

        static public bool Delete(int ID)
                => SubjectResultData.Delete(ID);

        static public SubjectResult GetById(int ID)
        {
            int StudentID = 0;
            int SubjectID = 0;
            int MidTermGrade = 0;
            int FineTermGrade = 0;
            int GeneralGrade = 0;

            return SubjectResultData.Find(ID, ref StudentID, ref SubjectID,ref MidTermGrade, ref FineTermGrade, ref GeneralGrade) ?
                new SubjectResult(ID, StudentID, MidTermGrade, FineTermGrade, GeneralGrade, SubjectID) : null;
        }

        static public SubjectResult GetBySubjectIdAndStudentID(int SubjectID, int StudentID)
        {
            int MidTermGrade = 0;
            int FineTermGrade = 0;
            int GeneralGrade = 0;
            int ID = 0;

            try
            {
                return SubjectResultData.FindBySubjectIDAndStudentID(SubjectID, StudentID,  ref ID, ref MidTermGrade,
                    ref FineTermGrade, ref GeneralGrade) ?
                    new SubjectResult(ID, StudentID, MidTermGrade, FineTermGrade, GeneralGrade, SubjectID) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public SubjectResult GetBySubjectIdAndStudentID(int StudentID)
        {
            int MidTermGrade = 0;
            int SubjectID = 0;
            int FineTermGrade = 0;
            int GeneralGrade = 0;
            int ID = 0;

            try
            {
                return SubjectResultData.FindByStudentID(StudentID, ref SubjectID, ref ID, ref MidTermGrade,
                    ref FineTermGrade, ref GeneralGrade) ?
                    new SubjectResult(ID, StudentID, MidTermGrade, FineTermGrade, GeneralGrade, SubjectID) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            return GetAll().AsEnumerable()
                .Count(R => R.Field<int>("SubjectID") == SubjectID
                && R.Field<int>("StudentID") == StudentID) > 0;
        }
    }
}
