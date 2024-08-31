using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace DataLayer
{
    public class ClassesData
    {
        static public DataTable GetAll()
        {
            DataTable DT = new DataTable();
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"SELECT Classes.ID, ClassName, StudiedYears.StudiedYear, COUNT(Students.ID) AS ClassMembers, Capacity
                                 FROM Classes
                                 LEFT JOIN Students ON Students.ClassID = Classes.ID 
                                 JOIN StudiedYears ON StudiedYears.ID = Classes.StudiedYearID
                                 GROUP BY Classes.ID, ClassName, StudiedYears.StudiedYear, Classes.Capacity";
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

        static public async Task<DataTable> GetAllAsync()
        {
            DataTable DT = new DataTable();
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"SELECT Classes.ID, ClassName, StudiedYears.StudiedYear, COUNT(Students.ID) AS ClassMembers, Capacity
                                 FROM Classes
                                 LEFT JOIN Students ON Students.ClassID = Classes.ID 
                                 JOIN StudiedYears ON StudiedYears.ID = Classes.StudiedYearID
                                 GROUP BY Classes.ID, ClassName, StudiedYears.StudiedYear, Classes.Capacity";
                await Conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    using (SqlDataReader Reader = await cmd.ExecuteReaderAsync())
                    {
                        DT.Load(Reader);
                    }
                }
            }
            return DT;
        }

        static public int AddNew(string ClassName, int ClassYear, int Capicity)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"INSERT INTO [dbo].[Classes]
                                ([ClassName]
                                ,[StudiedYearID]
                                ,[Capacity])
                                 VALUES
                                 (@ClassName,@StudiedYearID,@Capicity);
                                 SELECT SCOPE_IDENTITY();";

                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ClassName", ClassName);
                    cmd.Parameters.AddWithValue("@StudiedYearID", ClassYear);
                    cmd.Parameters.AddWithValue("@Capicity", Capicity);

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
                    string Query = @"DELETE FROM Classes
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

        static public bool Update(int ID, string ClassName, int ClassYear, int Capicity)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"UPDATE [Classes]
                                   SET [ClassName] = @ClassName
                                      ,[StudiedYearID] = @StudiedYearID
                                      ,[Capacity] = @Capacity
                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@ClassName", ClassName);
                    cmd.Parameters.AddWithValue("@StudiedYearID", ClassYear);
                    cmd.Parameters.AddWithValue("@Capacity", Capicity);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        static public bool Find(int ID, ref string ClassName, ref int ClassYear, ref int Capicity)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"SELECT * FROM Classes
                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            ClassName = Convert.ToString(Reader["ClassName"]);
                            ClassYear = Convert.ToInt32(Reader["StudiedYearID"]);
                            Capicity = Convert.ToInt32(Reader["Capacity"]);

                        }
                        return true;
                    }
                }
            }
        }
    }
}
