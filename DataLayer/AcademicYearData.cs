using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
using System.Text;

namespace DataLayer
{
    public class AcademicYearData
    {
        static public DataTable GetAll()
        {
            try
            {
                DataTable DT = new DataTable();
                using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
                {
                    string Query = "SELECT * FROM StudiedYears";
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public int AddNew(string Name)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"INSERT INTO StudiedYears
                                ([StudiedYear])
                                VALUES
                                (@Name);
                                SELECT SCOPE_IDENTITY();";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    object result = cmd.ExecuteScalar();
                    if (int.TryParse(result.ToString(), out int ID))
                        return ID;
                    else
                        return -1;
                }
            }
        }

        public static bool Delete(int ID)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"DELETE FROM StudiedYears
                                WHERE ID = @ID";
                Conn.Open();

                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool GetById(int ID, ref string Name)
        {
            using (SqlConnection Conn = new SqlConnection(ConnStr.Connstr))
            {
                string Query = @"SELECT * FROM StudiedYears
                                WHERE ID = @ID";
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                            Name = Reader["StudiedYear"].ToString(); 
                    }
                    return true;
                }
            }
        }
    }
}
