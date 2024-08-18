using System;
using System.Data;

using Microsoft.Data.SqlClient;
namespace DataLayer
{
    public class StudentsData
    {
        static readonly string Connstr = "Server = .; Database = SchoolManagment; Integrated Security = true; TrustServerCertificate=True";
        static public DataTable GetAll()
        {
            DataTable DT = new DataTable();
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = "SELECT * FROM Students";
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

        static public int AddNew(string FullName, DateTime DOB, string Address, string Phone, int ClassID)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"INSERT INTO Students
                                    ([FullName], [DOB], [Address], [Phone], [ClassID])
                                     VALUES
                                     (@FullName, @DOB, @Address, @Phone, @ClassID);
                                     SELECT SCOPE_IDENTITY();";

                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@ClassID", ClassID);
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
                string Query = @"DELETE FROM Students
                                    WHERE ID = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        static public bool Update(int ID, string FullName, DateTime DOB, string Address, string Phone, int ClassID)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"UPDATE [Students]
                                   SET [FullName] = @FullName
                                      ,[DOB] = @DOB
                                      ,[Address] = @Address
                                      ,[Phone] = @Phone
                                      ,[ClassID] = @ClassID

                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@ClassID", ClassID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        static public bool Find(int ID, ref string FullName, ref DateTime DOB, ref string Address, ref string Phone, ref int ClassID)
        {
            using (SqlConnection Conn = new SqlConnection(Connstr))
            {
                string Query = @"SELECT * FROM Students
                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            FullName = Convert.ToString(Reader["FullName"]);
                            DOB = Convert.ToDateTime(Reader["DOB"]);
                            Address = Convert.ToString(Reader["Address"]);
                            Phone = Convert.ToString(Reader["Phone"]);
                            ClassID = Convert.ToInt32(Reader["ClassID"]);

                        }
                        return true;
                    }
                }
            }
        }

    }
}
