using System;
using System.Data;

using Microsoft.Data.SqlClient;
namespace DataLayer
{
    public class ClassesData
    {
        static readonly string Connstr = "Server = .; Database = SchoolManagment; Integrated Security = true; TrustServerCertificate=True";
        static public DataTable GetAll()
        {
            DataTable DT = new DataTable();
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = "SELECT * FROM Classes";
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

        static public int AddNew(string ClassName, int ClassYear)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"INSERT INTO Classes
                                    ([ClassName], [ClassYear])
                                     VALUES
                                     (@ClassName, @ClassYear);
                                     SELECT SCOPE_IDENTITY();";

                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ClassName", ClassName);
                    cmd.Parameters.AddWithValue("@ClassYear", ClassYear);
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

        static public bool Update(int ID, string ClassName, int ClassYear)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"UPDATE [Classes]
                                   SET [ClassName] = @ClassName
                                      ,[ClassYear] = @ClassYear

                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@ClassName", ClassName);
                    cmd.Parameters.AddWithValue("@ClassYear", ClassYear);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        static public bool Find(int ID, ref string ClassName, ref int ClassYear)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
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
                            ClassYear = Convert.ToInt32(Reader["ClassYear"]);

                        }
                        return true;
                    }
                }
            }
        }

    }
}
