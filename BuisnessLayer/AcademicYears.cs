using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BuisnessLayer
{
    public class AcademicYears
    {
        public int ID { get; set; }
        public string AcademicYearName { get; set; }

        public AcademicYears()
        {
            ID = 0;
            AcademicYearName = string.Empty;
        }

        private AcademicYears(int ID, string StudiedYear)
        {
            this.ID = ID;
            this.AcademicYearName = StudiedYear;
        }

        static public DataTable GetAll()
        {
            try
            {
                return AcademicYearData.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsDuplicate()
        {
            return GetAll().AsEnumerable()
                .Count(R => R.Field<string>("StudiedYear") == AcademicYearName) > 0;
        }

        public bool AddNew()
        {
            ID = AcademicYearData.AddNew(AcademicYearName);
            return ID != -1;
        }

        public static bool Delete(int ID)
        {
            return AcademicYearData.Delete(ID);
        }

        public static AcademicYears GetById(int ID)
        {
            string Name = string.Empty;
            return AcademicYearData.GetById(ID, ref Name) ?
                new AcademicYears(ID, Name) : null;
        }
    }
}
