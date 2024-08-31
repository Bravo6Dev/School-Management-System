using System;
using System.Data;

using Microsoft.Data.SqlClient;
namespace DataLayer
{
    public class SubjectsData
    {
        static public DataTable GetAll()
        {
            DataTable DT = new DataTable();
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"SELECT Subjects.ID, StudiedYearID,SubjectName,GeneralMostGrade, MidTermMostGrade, FinalMidTerm, MostGrade, StudiedYears.StudiedYear
                                 FROM Subjects
                                 JOIN StudiedYears ON Subjects.StudiedYearID = StudiedYears.ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        DT.Load(Reader);
                    }
                }
            }
            return DT;
        }

        static public int AddNew(string SubjectName, int GeneralMostGrade, int MidTermMostGrade, 
            int FinalMidTerm, int MostGrade, int StudiedYear)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"INSERT INTO Subjects
                                    ([SubjectName], [GeneralMostGrade], [MidTermMostGrade], 
                                     [FinalMidTerm], [MostGrade], [StudiedYearID])
                                     VALUES
                                     (@SubjectName, @GeneralMostGrade, @MidTermMostGrade, 
                                      @FinalMidTerm, @MostGrade, @StudiedYearID);
                                     SELECT SCOPE_IDENTITY();";

                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
                    cmd.Parameters.AddWithValue("@GeneralMostGrade", GeneralMostGrade);
                    cmd.Parameters.AddWithValue("@MidTermMostGrade", MidTermMostGrade);
                    cmd.Parameters.AddWithValue("@FinalMidTerm", FinalMidTerm);
                    cmd.Parameters.AddWithValue("@MostGrade", MostGrade);
                    cmd.Parameters.AddWithValue("@StudiedYearID", StudiedYear);

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID)) { return ID; }
                    return -1;
                }
            }
        }

        static public bool Delete(int ID)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
                {
                    string Query = @"DELETE FROM Subjects
                                        WHERE ID = @ID";
                    Conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, Conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public bool Update(int ID, string SubjectName, int GeneralMostGrade, 
            int MidTermMostGrade, int FinalMidTerm, int MostGrade, int StudiedYear)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"UPDATE [Subjects]
                                   SET [SubjectName] = @SubjectName
                                      ,[GeneralMostGrade] = @GeneralMostGrade
                                      ,[MidTermMostGrade] = @MidTermMostGrade
                                      ,[FinalMidTerm] = @FinalMidTerm
                                      ,[MostGrade] = @MostGrade
                                      ,[StudiedYearID] = @StudiedYearID

                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
                    cmd.Parameters.AddWithValue("@GeneralMostGrade", GeneralMostGrade);
                    cmd.Parameters.AddWithValue("@MidTermMostGrade", MidTermMostGrade);
                    cmd.Parameters.AddWithValue("@FinalMidTerm", FinalMidTerm);
                    cmd.Parameters.AddWithValue("@MostGrade", MostGrade);
                    cmd.Parameters.AddWithValue("@StudiedYearID", StudiedYear);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        static public bool Find(int ID, ref string SubjectName, ref int GeneralMostGrade, ref int MidTermMostGrade, 
            ref int FinalMidTerm, ref int MostGrade, ref int StudiedYear)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"SELECT * FROM Subjects
                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            SubjectName = Convert.ToString(Reader["SubjectName"]);
                            GeneralMostGrade = Convert.ToInt32(Reader["GeneralMostGrade"]);
                            MidTermMostGrade = Convert.ToInt32(Reader["MidTermMostGrade"]);
                            FinalMidTerm = Convert.ToInt32(Reader["FinalMidTerm"]);
                            MostGrade = Convert.ToInt32(Reader["MostGrade"]);
                            StudiedYear = Convert.ToInt32(Reader["StudiedYearID"]);
                        }
                        return true;
                    }
                }
            }
        }

    }
}
