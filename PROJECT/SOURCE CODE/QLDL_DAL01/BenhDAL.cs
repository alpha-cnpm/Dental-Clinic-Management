using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPM_DTO;

namespace QLPM_DAL
{
    public class BenhDAL
    {
        private string connectionString;

        public BenhDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Them(BenhDTO benh)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblLoaiBenh] ([maLB], [tenBenh])";
            query += "VALUES (@maLB, @tenBenh)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maLB", benh.maLB);
                    cmd.Parameters.AddWithValue("@tenBenh", benh.tenBenh);

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
        public bool Sua(BenhDTO benh)
        {
            string query = string.Empty;
            query += "UPDATE [tblLoaiBenh] SET [tenBenh] = @tenBenh WHERE [maLB] = @maLB";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maLB", benh.maLB);
                    cmd.Parameters.AddWithValue("@tenBenh", benh.tenBenh);

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
        public bool Xoa(BenhDTO benh)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblLoaiBenh] WHERE [maLB] = @maLB";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maLB", benh.maLB);
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

        public List<BenhDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maLB], [tenBenh]";
            query += "FROM [tblLoaiBenh]";

            List<BenhDTO> listbenh = new List<BenhDTO>();

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
                                BenhDTO benh = new BenhDTO();
                                benh.maLB = reader["maLB"].ToString();
                                benh.tenBenh = reader["tenBenh"].ToString();


                                listbenh.Add(benh);
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
            return listbenh;
        }

    }

}
