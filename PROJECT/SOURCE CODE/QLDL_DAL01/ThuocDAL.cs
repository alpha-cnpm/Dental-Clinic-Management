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
    public class ThuocDAL
    {
        private string connectionString;

        public ThuocDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool Them(ThuocDTO thuoc)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblThuoc] ([maThuoc], [tenThuoc], [donGia],[donViTinh])";
            query += "VALUES (@maThuoc, @tenThuoc, @donGia,@donViTinh)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maThuoc", thuoc.maThuoc);
                    cmd.Parameters.AddWithValue("@tenThuoc", thuoc.tenThuoc);
                    cmd.Parameters.AddWithValue("@donGia", thuoc.donGia);
                    cmd.Parameters.AddWithValue("@donViTinh", thuoc.donViTinh);


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
        public bool Sua(ThuocDTO thuoc)
        {
            string query = string.Empty;
            query += "UPDATE [tblThuoc] SET [tenThuoc] = @tenThuoc, [donGia] = @donGia,[donViTinh]=@donViTinh WHERE [maThuoc] = @maThuoc";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maThuoc", thuoc.maThuoc);
                    cmd.Parameters.AddWithValue("@tenThuoc", thuoc.tenThuoc);
                    cmd.Parameters.AddWithValue("@donGia", thuoc.donGia);
                    cmd.Parameters.AddWithValue("@donViTinh", thuoc.donViTinh);
                    
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
        public bool Xoa(ThuocDTO thuoc)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblThuoc] WHERE [maThuoc] = @maThuoc";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maThuoc", thuoc.maThuoc);
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

        public List<ThuocDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maThuoc], [tenThuoc], [donGia],[donViTinh]";
            query += "FROM [tblThuoc]";

            List<ThuocDTO> listThuoc = new List<ThuocDTO>();

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
                                ThuocDTO thuoc = new ThuocDTO();
                                thuoc.maThuoc = reader["maThuoc"].ToString();
                                thuoc.tenThuoc = reader["tenThuoc"].ToString();
                                thuoc.donGia = int.Parse(reader["donGia"].ToString());
                                thuoc.donViTinh = reader["donViTinh"].ToString();
                               
                                listThuoc.Add(thuoc);
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

        public List<ThuocDTO> selectten()
        {
            string query = string.Empty;
            query += "SELECT [tenThuoc],[maThuoc]";
            query += "FROM [tblThuoc]";
            List<ThuocDTO> data = new List<ThuocDTO>();
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
                            ThuocDTO s = new ThuocDTO();
                            s.tenThuoc = reader["tenThuoc"].ToString();
                            s.maThuoc = reader["maThuoc"].ToString();
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



        public string selecttenforThuoc(string dm)
        {
            string query = string.Empty;
            query += "SELECT [tenThuoc]";
            query += "FROM [tblThuoc] WHERE [maThuoc]=@maThuoc";
            string data = null;
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
                        cmd.Parameters.AddWithValue("@maThuoc", dm);
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            data = reader["tenThuoc"].ToString();
                           
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
            query += "SELECT [tenThuoc]";
            query += "FROM [tblThuoc] WHERE [maThuoc]=@maThuoc";
            List<string> data = new List<string>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maThuoc", id);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string s;
                            s = reader["tenThuoc"].ToString();
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

        public int selectdongia(string id)
        {
            string query = string.Empty;
            query += "SELECT [donGia]";
            query += "FROM [tblThuoc] WHERE [maThuoc]=@id";
            int tien = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", id);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            tien = int.Parse(reader["donGia"].ToString());

                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return 0;
                    }
                }
            }
            return tien;
        }
    }

}

