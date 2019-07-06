using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DAL
{
    public class CachDungDAL
    {
        private string connectionString;

        public CachDungDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool Them(CachDungDTO cd)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblCachDung] ([iDCD], [noiDungCD])";
            query += "VALUES (@noiDungCD, @iDCD)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@noiDungCD", cd.noiDungCD);
                    cmd.Parameters.AddWithValue("@iDCD", cd.iDCD);
                   


                    //try
                    //{
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    //}
                    //catch (Exception ex)
                    //{
                    //    con.Close();
                    //    return false;
                    //}
                }
            }
            return true;
        }
        public bool Sua(CachDungDTO cd)
        {
            string query = string.Empty;
            query += "UPDATE [tblCachDung] SET [noiDungCD] = @noiDungCD WHERE [iDCD] = @iDCD";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDCD", cd.iDCD);
                    cmd.Parameters.AddWithValue("@noiDungCD", cd.noiDungCD);
                   

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public bool Xoa(CachDungDTO cd)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblCachDung] WHERE [iDCD] = @iDCD";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDCD", cd.iDCD);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public List<CachDungDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [iDCD], [noiDungCD]";
            query += "FROM [tblCachDung]";

            List<CachDungDTO> listThuoc = new List<CachDungDTO>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                CachDungDTO cd = new CachDungDTO();
                                cd.iDCD = reader["iDCD"].ToString();
                                cd.noiDungCD = reader["noiDungCD"].ToString();
                                

                                listThuoc.Add(cd);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return listThuoc;
        }

        public List<CachDungDTO> selectten()
        {
            string query = string.Empty;
            query += "SELECT [noiDungCD],[iDCD]";
            query += "FROM [tblCachDung]";
            List<CachDungDTO> data = new List<CachDungDTO>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CachDungDTO s = new CachDungDTO();
                            s.noiDungCD = reader["noiDungCD"].ToString();
                            s.iDCD = reader["iDCD"].ToString();
                            data.Add(s);
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return data;
        }


        public List<string> selectallname(string id)
        {
            string query = string.Empty;
            query += "SELECT [noiDungCD]";
            query += "FROM [tblCachDung] WHERE [iDCD]=@iDCD";
            List<string> data = new List<string>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDCD", id);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string s;
                            s = reader["noiDungCD"].ToString();
                            data.Add(s);
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return data;
        }

    }

}

