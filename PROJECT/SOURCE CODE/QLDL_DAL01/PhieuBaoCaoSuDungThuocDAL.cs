using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLPM_DAL
{
    public class PhieuBaoCaoSuDungThuocDAL
    {
        private string connectionString;

        public PhieuBaoCaoSuDungThuocDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Them(PhieuBaoCaoSuDungThuocDTO SD)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblPhieuBaoCaoSuDungThuoc] ([thangSD], [maBCSD],[maPKB])";
            query += "VALUES (@thangSD, @maBCSD,@maHD)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@thangSD", SD.thangSD);
                    cmd.Parameters.AddWithValue("@maBCSD", SD.maBCSD);
                    cmd.Parameters.AddWithValue("@mPKB", SD.maPKB);
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
        public bool Sua(PhieuBaoCaoSuDungThuocDTO SD)
        {
            string query = string.Empty;
            query += "UPDATE [tblPhieuBaoCaoSuDungThuoc] SET [thangSD] = @thangSD,[maPKB]=@maPKB WHERE [maBCSD] = @maBCSD";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@thangSD", SD.thangSD);
                    cmd.Parameters.AddWithValue("@maBCSD", SD.maBCSD);
                    cmd.Parameters.AddWithValue("@maPKB", SD.maPKB);


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
        public bool Xoa(PhieuBaoCaoSuDungThuocDTO SD)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblPhieuBaoCaoSuDungThuoc] WHERE [maBCSD] = @maBCSD";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maBCSD", SD.maBCSD);
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

        public List<PhieuBaoCaoSuDungThuocDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [thangSD],[maBCSD],[maPKB]";
            query += "FROM [tblPhieuBaoCaoSuDungThuoc]";

            List<PhieuBaoCaoSuDungThuocDTO> listSD = new List<PhieuBaoCaoSuDungThuocDTO>();

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
                                PhieuBaoCaoSuDungThuocDTO SD = new PhieuBaoCaoSuDungThuocDTO();
                                SD.thangSD =int.Parse (reader["thangSD"].ToString());
                                SD.maBCSD = reader["maBCSD"].ToString();
                                SD.maPKB = reader["maPKB"].ToString();

                                listSD.Add(SD);
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
            return listSD;
        }
        int solandung(string id, string month)
        {
            int sl = 0;
            string query = string.Empty;
            query += "  SELECT SUM([maThuoc]) FROM [tblPhieuKhamBenh] WHERE ( MONTH([ngayKham])=@month) AND [maThuoc]=@id;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@month", month);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            sl = int.Parse(reader[0].ToString());
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
            return sl;
        }
        int soluong(string id, string month)
        {
            int sl = 0;
            string query = string.Empty;
            query += "  SELECT COUNT([maPKB]) FROM [tblPhieuKhamBenh] WHERE (MONTH([ngayKham])=@month) AND [maThuoc]=@id;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@month", month);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            sl = int.Parse(reader[0].ToString());
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
            return sl;
        }
        public DataTable baocaosudungthuoc(string month)
        {
            DataTable data = new DataTable();
            data.Columns.Add("tenThuoc");
            data.Columns.Add("donViTinh");
            data.Columns.Add("soLuong");
            data.Columns.Add("soLanDung");
            string query = string.Empty;
            query += "SELECT [maThuoc],[tenThuoc],[donViTinh]";
            query += "FROM [tblThuoc]";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@month", month);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            DataRow row = data.NewRow();
                            row["tenThuoc"] = reader["tenThuoc"].ToString();
                            row["donViTinh"] = reader["donViTinh"].ToString();
                            row["soLuong"] = soluong(reader["soLuong"].ToString(), month);
                         //  row["soLanDung"] = solandung(reader["tenThuoc"].ToString(), month);
                            data.Rows.Add(row);
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
