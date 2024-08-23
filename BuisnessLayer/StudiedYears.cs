using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer
{
    public class StudiedYears
    {
        public int ID { get; set; }
        public string StudeiedYear { get; set; }

        public StudiedYears()
        {
            ID = 0;
            StudeiedYear = string.Empty;
        }

        private StudiedYears(int ID, string StudiedYear)
        {
            this.ID = ID;
            this.StudeiedYear = StudiedYear;
        }
    }
}
