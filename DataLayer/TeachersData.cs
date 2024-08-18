using System;
using System.Data;

using Microsoft.Data.SqlClient;
namespace DataLayer
{
    public class TeachersData
    {
        static public DataTable GetAll()
        {
            DataTable DT = new DataTable();
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = "SELECT * FROM Teachers";
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

        static public int AddNew(string FullName, string EductionalOutcome, string Phone, string Address, int SubjectID)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"INSERT INTO Teachers
                                    ([FullName], [EductionalOutcome], [Phone], [Address], [SubjectID])
                                     VALUES
                                     (@FullName, @EductionalOutcome, @Phone, @Address, @SubjectID);
                                     SELECT SCOPE_IDENTITY();";

                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    cmd.Parameters.AddWithValue("@EductionalOutcome", EductionalOutcome);
                    if(Phone != null)
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                    else
                        cmd.Parameters.AddWithValue("@Phone", DBNull.Value);

                    if (Address != null)
                        cmd.Parameters.AddWithValue("@Address", Address);
                    else
                        cmd.Parameters.AddWithValue("@Address", DBNull.Value);

                    cmd.Parameters.AddWithValue("@SubjectID", SubjectID);
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
                string Query = @"DELETE FROM Teachers
                                    WHERE ID = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        static public bool Update(int ID, string FullName, string EductionalOutcome, string Phone, string Address, int SubjectID)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"UPDATE [Teachers]
                                   SET [FullName] = @FullName
                                      ,[EductionalOutcome] = @EductionalOutcome
                                      ,[Phone] = @Phone
                                      ,[Address] = @Address
                                      ,[SubjectID] = @SubjectID

                                    WHERE [ID] = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    cmd.Parameters.AddWithValue("@EductionalOutcome", EductionalOutcome);
                    if (Phone != null)
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                    else
                        cmd.Parameters.AddWithValue("@Phone", DBNull.Value);

                    if (Address != null)
                        cmd.Parameters.AddWithValue("@Address", Address);
                    else
                        cmd.Parameters.AddWithValue("@Address", DBNull.Value);
                    cmd.Parameters.AddWithValue("@SubjectID", SubjectID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        static public bool Find(int ID, ref string FullName, ref string EductionalOutcome, ref string Phone, ref string Address, ref int SubjectID)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"SELECT * FROM Teachers
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
                            EductionalOutcome = Convert.ToString(Reader["EductionalOutcome"]);
                            Phone = Convert.ToString(Reader["Phone"]);
                            Address = Convert.ToString(Reader["Address"]);
                            SubjectID = Convert.ToInt32(Reader["SubjectID"]);

                        }
                        return true;
                    }
                }
            }
        }

    }
}
