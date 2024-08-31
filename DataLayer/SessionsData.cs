using System;
using System.Data;

using Microsoft.Data.SqlClient;
namespace DataLayer
{
    public class SessionsData
    { 
        static public DataTable GetAll()
        {
            DataTable DT = new DataTable();
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"SELECT Sessions.ID, ClassID, ClassName, FullName, Day, StartTime, EndTime
                                 FROM Sessions
                                 JOIN Classes ON Sessions.ClassID = Classes.ID
                                 JOIN Teachers ON Sessions.TeacherID =  Teachers.ID";

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

        static public int AddNew(int ClassID, int TeacherID, string Day, TimeSpan Time, TimeSpan EndTime)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"INSERT INTO Sessions
                                    ([ClassID], [TeacherID], [Day], [StartTime], [EndTime])
                                     VALUES
                                     (@ClassID, @TeacherID, @Day, @StartTime, @EndTime);
                                     SELECT SCOPE_IDENTITY();";

                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ClassID", ClassID);
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                    cmd.Parameters.AddWithValue("@Day", Day);
                    cmd.Parameters.AddWithValue("@StartTime", Time);
                    cmd.Parameters.AddWithValue("@EndTime", EndTime);
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID)) { return ID; }
                    return -1;
                }
            }
        }

        static public bool Delete(int ID)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"DELETE FROM Sessions
                                    WHERE ID = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        static public bool Update(int ID, int ClassID, int TeacherID, string Day, TimeSpan Time, TimeSpan EndTime)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"UPDATE [Sessions]
                                   SET [ClassID] = @ClassID
                                      ,[TeacherID] = @TeacherID
                                      ,[Day] = @Day
                                      ,[StartTime] = @Time
                                      ,[EndTime] = @EndTime

                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@ClassID", ClassID);
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                    cmd.Parameters.AddWithValue("@Day", Day);
                    cmd.Parameters.AddWithValue("@Time", Time);
                    cmd.Parameters.AddWithValue("@EndTime", EndTime);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        static public bool Find(int ID, ref int ClassID, ref int TeacherID, ref string Day, ref DateTime Time, ref DateTime EndDate)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"SELECT * FROM Sessions
                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            ClassID = Convert.ToInt32(Reader["ClassID"]);
                            TeacherID = Convert.ToInt32(Reader["TeacherID"]);
                            Day = Convert.ToString(Reader["Day"]);
                            Time = Convert.ToDateTime(Reader["StartTime"]);
                            EndDate = Convert.ToDateTime(Reader["EndTime"]);
                        }
                        return true;
                    }
                }
            }
        }

    }
}
