using System;
using DataLayer;
using System.Data
;
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
        public int FineTermGrade { get; set; }
        public int GeneralGrade { get; set; }
        public SubjectResult()
        {
            Mode = enMode.AddNew;
        }

        public SubjectResult(int ID, int StudentID, int MidTermGrade, int FineTermGrade, int GeneralGrade)
        {
            this.ID = ID;
            this.StudentID = StudentID;
            this.MidTermGrade = MidTermGrade;
            this.FineTermGrade = FineTermGrade;
            this.GeneralGrade = GeneralGrade;

            Mode = enMode.Update;
        }

        private bool AddNew()
        {
            ID = SubjectResultData.AddNew(StudentID, SubjectID, MidTermGrade, FineTermGrade, GeneralGrade);
            return ID != -1;
        }

        static public DataTable GetAll()
        {
            DataTable dt = SubjectResultData.GetAll();
            return dt;
        }

        private bool Update()
        {
            return SubjectResultData.Update(ID, SubjectID, StudentID, MidTermGrade, FineTermGrade, GeneralGrade);
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
                new SubjectResult(ID, StudentID, MidTermGrade, FineTermGrade, GeneralGrade) : null;
        }

    }
}
