using System;
using System.Data;

using Microsoft.Data.SqlClient;
namespace DataLayer
{
    public class SubjectResultData
    {
        static readonly string Connstr = "Server = .; Database = SchoolManagment; Integrated Security = true; TrustServerCertificate=True";
        static public DataTable GetAll()
        {
            DataTable DT = new DataTable();
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = "SELECT * FROM SubjectResult";
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

        static public DataTable GetAllByStudentID(int StudentId)
        {
            DataTable DT = new DataTable();
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"SELECT SubjectName, GeneralGrade, MidTermGrade, FineTermGrade  FROM SubjectResult
                                JOIN Subjects ON Subjects.ID = SubjectResult.SubjectID 
                                WHERE [StudentID] = @StudentID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentId);
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        DT.Load(Reader);
                    }
                }
            }
            return DT;
        }

        static public int AddNew(int StudentID, int SubjectID, int MidTermGrade, int FineTermGrade, int GeneralGrade)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"INSERT INTO SubjectResult
                                    ([StudentID], [SubjectID], [MidTermGrade], [FineTermGrade], [GeneralGrade])
                                     VALUES
                                     (@StudentID, @SubjectID, @MidTermGrade, @FineTermGrade, @GeneralGrade);
                                     SELECT SCOPE_IDENTITY();";

                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    cmd.Parameters.AddWithValue("@SubjectID", SubjectID);
                    cmd.Parameters.AddWithValue("@MidTermGrade", MidTermGrade);
                    cmd.Parameters.AddWithValue("@FineTermGrade", FineTermGrade);
                    cmd.Parameters.AddWithValue("@GeneralGrade", GeneralGrade);
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID)) { return ID; }
                    return -1;
                }
            }
        }

        static public bool Delete(int ID)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"DELETE FROM SubjectResult
                                    WHERE ID = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        static public bool Update(int ID, int StudentID, int SubjectID, int MidTermGrade, int FineTermGrade, int GeneralGrade)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"UPDATE [SubjectResult]
                                   SET [StudentID] = @StudentID
                                      ,[SubjectID] = @SubjectID
                                      ,[MidTermGrade] = @MidTermGrade
                                      ,[FineTermGrade] = @FineTermGrade
                                      ,[GeneralGrade] = @GeneralGrade

                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    cmd.Parameters.AddWithValue("@SubjectID", SubjectID);
                    cmd.Parameters.AddWithValue("@MidTermGrade", MidTermGrade);
                    cmd.Parameters.AddWithValue("@FineTermGrade", FineTermGrade);
                    cmd.Parameters.AddWithValue("@GeneralGrade", GeneralGrade);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        static public bool Find(int ID, ref int StudentID, ref int SubjectID,  ref int MidTermGrade, ref int FineTermGrade, ref int GeneralGrade)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"SELECT * FROM SubjectResult
                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            StudentID = Convert.ToInt32(Reader["StudentID"]);
                            SubjectID = Convert.ToInt32(Reader["SubjectID"]);
                            MidTermGrade = Convert.ToInt32(Reader["MidTermGrade"]);
                            FineTermGrade = Convert.ToInt32(Reader["FineTermGrade"]);
                            GeneralGrade = Convert.ToInt32(Reader["GeneralGrade"]);

                        }
                        return true;
                    }
                }
            }
        }

        static public bool FindBySubjectIDAndStudentID(int SubjectID, int StudentID, ref int ID, ref int MidTermGrade, ref int FineTermGrade, ref int GeneralGrade)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"SELECT * FROM SubjectResult
                                    WHERE [SubjectID] = @SubjectID AND [StudentID] = @StudentID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", SubjectID);
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            ID = Convert.ToInt32(Reader["ID"]);
                            MidTermGrade = Convert.ToInt32(Reader["MidTermGrade"]);
                            FineTermGrade = Convert.ToInt32(Reader["FineTermGrade"]);
                            GeneralGrade = Convert.ToInt32(Reader["GeneralGrade"]);
                        }
                        return true;
                    }
                }
            }
        }

        static public bool FindByStudentID(int StudentID, ref int SubjectID, ref int ID, ref int MidTermGrade, ref int FineTermGrade, ref int GeneralGrade)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"SELECT * FROM SubjectResult
                                    WHERE [StudentID] = @StudentID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            ID = Convert.ToInt32(Reader["ID"]);
                            SubjectID = Convert.ToInt32(Reader["SubjectID"]);
                            MidTermGrade = Convert.ToInt32(Reader["MidTermGrade"]);
                            FineTermGrade = Convert.ToInt32(Reader["FineTermGrade"]);
                            GeneralGrade = Convert.ToInt32(Reader["GeneralGrade"]);
                        }
                        return true;
                    }
                }
            }
        }
    }
}
