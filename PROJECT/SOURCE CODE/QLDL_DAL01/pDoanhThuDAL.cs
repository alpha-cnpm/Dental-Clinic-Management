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
    public class pDoanhThuDAL
    {
        private string connectionString;

        public pDoanhThuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Them(pDoanhThuDTO SD)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblPhieuBaoCaoDoanhThu] ([thangDT], [maBCDT],[maHD])";
            query += "VALUES (@thangDT, @maBCDT,@maHD)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@thangDT", SD.thangDT);
                    cmd.Parameters.AddWithValue("@maBCDT", SD.maBCDT);
                    cmd.Parameters.AddWithValue("@maHD", SD.maHD);
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
        public bool Sua(pDoanhThuDTO SD)
        {
            string query = string.Empty;
            query += "UPDATE [tblPhieuBaoCaoDoanhThu] SET [thangDT] = @thangDT, [maHD] = @maHD WHERE [maBCDT] = @maBCDT";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@thangDT", SD.thangDT);
                    cmd.Parameters.AddWithValue("@maBCDT", SD.maBCDT);
                    cmd.Parameters.AddWithValue("@maHD", SD.maHD);

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
        public bool Xoa(pDoanhThuDTO SD)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblPhieuBaoCaoDoanhThu] WHERE [maBCDT] = @maBCDT";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maBCDT", SD.thangDT);
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
        public List<pDoanhThuDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [thangDT],[maBCDT],[maHD]";
            query += "FROM [tblPhieuBaoCaoDoanhThu]";
            List<pDoanhThuDTO> listSD = new List<pDoanhThuDTO>();
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
                                pDoanhThuDTO SD = new pDoanhThuDTO();
                                SD.thangDT = int.Parse(reader["thangDT"].ToString());
                                SD.maBCDT = reader["maBCDT"].ToString();
                                SD.maHD = reader["maHD"].ToString();

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
        public int soBenhNhan(string day,string month)
        {
            int sl = 0;
            string query = string.Empty;
            query += "SELECT COUNT([maPKB]) FROM [tblPhieuKhamBenh] WHERE DAY([ngayKham])=@day AND MONTH([ngayKham])=@month;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@day", day);
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
        public int tongSotien(string day, string month)
        {
            int tongtien = 0;
            string query = string.Empty;
            query += "SELECT SUM([tienTong]) FROM [tblPhieuKhamBenh] WHERE DAY([ngayKham])=@day AND MONTH([ngayKham])=@month;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@day", day);
                    cmd.Parameters.AddWithValue("@month", month);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            tongtien = int.Parse(reader[0].ToString());
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
            return tongtien;
        }
        public DataTable selectdata(string month)
        {
            DataTable data = new DataTable();
            data.Columns.Add("ngay");
            data.Columns.Add("soLuongBenhNhan");
            data.Columns.Add("doanhThu");
            data.Columns.Add("tiLe");
            string query = string.Empty;
            query += "SELECT [ngayKham],Day([ngayKham])";
            query += "FROM [tblPhieuKhamBenh] WHERE MONTH([ngayKham])=@month;";
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
                        while(reader.Read())
                        {
                            DataRow row = data.NewRow();
                            row["ngay"] = (reader["ngayKham"].ToString());
                            row["soLuongBenhNhan"] = soBenhNhan(reader[1].ToString(), month);
                            row["doanhThu"] =   tongSotien(reader[1].ToString(), month);
                            row["tiLe"] = (int)tongSotien(reader[1].ToString(),month) / soBenhNhan(reader[1].ToString(),month);
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
