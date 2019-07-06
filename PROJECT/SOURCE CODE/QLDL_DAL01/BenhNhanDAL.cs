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
    public class BenhNhanDAL
    {
        private string connectionString;
        
        public BenhNhanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Them(BenhNhanDTO BN)
        {
            string query = string.Empty; 
            query += "INSERT INTO [tblBenhNhan] ([maBN], [hoTenBN], [ngayTiepNhan], [gioiTinh], [namSinh], [diaChi])";
            query += "VALUES (@maBN, @hoTenBN, @ngayTiepNhan, @gioiTinh, @namSinh, @diaChi)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
 
                    cmd.Parameters.AddWithValue("@maBN", BN.maBN);
                    cmd.Parameters.AddWithValue("@hoTenBN", BN.hoTenBN);
                    cmd.Parameters.AddWithValue("@ngayTiepNhan", BN.ngayTiepNhan);
                    cmd.Parameters.AddWithValue("@gioiTinh", BN.gioiTinh);
                    cmd.Parameters.AddWithValue("@namSinh", BN.namSinh);
                    cmd.Parameters.AddWithValue("@diaChi", BN.diaChi);

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
        public bool Sua(BenhNhanDTO BN)
        {
            string query = string.Empty;
            query += "UPDATE [tblBenhNhan] SET [hoTenBN] = @hoTenBN,[ngayTiepNhan]= @ngayTiepNhan, [gioiTinh]=@gioiTinh,[namSinh]=@namSinh, [diaChi] = @diaChi WHERE [maBN] = @maBN";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maBN", BN.maBN);
                    cmd.Parameters.AddWithValue("@hoTenBN", BN.hoTenBN);
                    cmd.Parameters.AddWithValue("@ngayTiepNhan", BN.ngayTiepNhan);
                    cmd.Parameters.AddWithValue("@gioiTinh", BN.gioiTinh);
                    cmd.Parameters.AddWithValue("@namSinh", BN.namSinh);
                    cmd.Parameters.AddWithValue("@diaChi", BN.diaChi);

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
        public bool Xoa(BenhNhanDTO BN)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblBenhNhan] WHERE [maBN] = @maBN";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maBN", BN.maBN);

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

        public List<BenhNhanDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maBN],[hoTenBN],[ngayTiepNhan],[gioiTinh],[namSinh],[diaChi]";
            query += "FROM [tblBenhNhan]";

            List<BenhNhanDTO> listBN = new List<BenhNhanDTO>();

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
                                BenhNhanDTO BN = new BenhNhanDTO();
                                BN.maBN = reader["maBN"].ToString();
                                BN.hoTenBN = reader["hoTenBN"].ToString();
                                BN.ngayTiepNhan = Convert.ToDateTime(reader["ngayTiepNhan"].ToString());
                                BN.gioiTinh = reader["gioiTinh"].ToString();
                                BN.namSinh = Convert.ToDateTime(reader["namSinh"].ToString());
                                BN.diaChi = reader["diaChi"].ToString();



                                listBN.Add(BN);
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
            return listBN;
        }

        public string selectname(string id)
        {
            string query = string.Empty;
            query += "SELECT [hoTenBN]";
            query += "FROM [tblBenhNhan] WHERE [maBN]=@maBN";
            string data = null;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maBN", id);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            data = reader["hoTenBN"].ToString();
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

        public List<string> selectten()
        {
            string query = string.Empty;
            query += "SELECT [maBN]";
            query += "FROM [tblBenhNhan]";
            List<string> listten = new List<string>();
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
                                thuoc.maThuoc = reader["maBN"].ToString();
                                listten.Add(thuoc.maThuoc);
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
            return listten;
        }
    }

}