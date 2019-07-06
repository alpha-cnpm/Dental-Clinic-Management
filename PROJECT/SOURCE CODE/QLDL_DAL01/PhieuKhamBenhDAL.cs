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
    public class PhieuKhamBenhDAL
    {
        private string connectionString;

        public PhieuKhamBenhDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool Them(PhieuKhamBenhDTO pkb)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblPhieuKhamBenh] ([maPKB], [maBN], [ngayKham], [trieuChung], [maLB],[maThuoc], [soLuong], [iDCD],[tienTong],[tienKham])";
            query += "VALUES (@maPKB, @maBN, @ngayKham, @trieuChung, @maLB,@maThuoc, @soLuong, @iDCD,@tienTong,@tienKham)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPKB", pkb.maPKB);
                    cmd.Parameters.AddWithValue("@maBN", pkb.maBN);
                    cmd.Parameters.AddWithValue("@ngayKham", pkb.ngayKham);
                    cmd.Parameters.AddWithValue("@trieuChung", pkb.trieuChung);
                    cmd.Parameters.AddWithValue("@maLB", pkb.maLB);
                    cmd.Parameters.AddWithValue("@tienTong", pkb.tienTong);
                    cmd.Parameters.AddWithValue("@tienKham", pkb.tienKham);

                    cmd.Parameters.AddWithValue("@maThuoc", pkb.maThuoc);
                    cmd.Parameters.AddWithValue("@soLuong", pkb.soLuong);
                    cmd.Parameters.AddWithValue("@iDCD", pkb.iDCD);


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
        public bool Sua(PhieuKhamBenhDTO pkb)
        {
            string query = string.Empty;
            query += "UPDATE [tblPhieuKhamBenh] SET[tienTong] = @tienTong, [maBN] = @maBN, [ngayKham] = @ngayKham, [trieuChung] = @trieuChung, [maLB] = @maLB,[maThuoc] = @maThuoc, [soLuong] = @soLuong, [iDCD] = @iDCD WHERE [maPKB] = @maPKB";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPKB", pkb.maPKB);
                    cmd.Parameters.AddWithValue("@maBN", pkb.maBN);
                    cmd.Parameters.AddWithValue("@ngayKham", pkb.ngayKham);
                    cmd.Parameters.AddWithValue("@trieuChung", pkb.trieuChung);
                    cmd.Parameters.AddWithValue("@maLB", pkb.maLB);
                    cmd.Parameters.AddWithValue("@maThuoc", pkb.maThuoc);
                    cmd.Parameters.AddWithValue("@soLuong", pkb.soLuong);
                    cmd.Parameters.AddWithValue("@iDCD", pkb.iDCD);
                    cmd.Parameters.AddWithValue("@tienTong", pkb.tienTong);
                    cmd.Parameters.AddWithValue("@tienKham", pkb.tienKham);




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
        public bool Xoa(PhieuKhamBenhDTO pkb)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblPhieuKhamBenh] WHERE [maPKB] = @maPKB";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPKB", pkb.maPKB);
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
        public List<PhieuKhamBenhDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [maPKB], [maBN], [ngayKham], [trieuChung], [maLB],[maThuoc], [soLuong], [iDCD],[tienTong],[tienKham]";
            query += "FROM [tblPhieuKhamBenh]";

            List<PhieuKhamBenhDTO> listPKB = new List<PhieuKhamBenhDTO>();

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
                                PhieuKhamBenhDTO pkb = new PhieuKhamBenhDTO();
                                pkb.maPKB = reader["maPKB"].ToString();
                                pkb.maBN = reader["maBN"].ToString();
                                pkb.ngayKham = Convert.ToDateTime(reader["ngayKham"].ToString());
                                pkb.trieuChung = reader["trieuChung"].ToString();
                                pkb.maLB = reader["maLB"].ToString();
                                pkb.maThuoc = reader["maThuoc"].ToString();
                                pkb.iDCD = reader["iDCD"].ToString();
                                pkb.soLuong = int.Parse(reader["soLuong"].ToString());
                                pkb.tienTong = int.Parse(reader["tienTong"].ToString());
                                pkb.tienKham = int.Parse(reader["tienKham"].ToString());

                                listPKB.Add(pkb);
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
            return listPKB;
        }
        public List<string> selectallname(string id)
        {
            string query = string.Empty;
            query += "SELECT [maBN]";
            query += "FROM [tblPhieuKhamBenh] WHERE [maPKB]=@maPKB";
            List<string> data = new List<string>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPKB", id);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string s;
                            s = reader["maBN"].ToString();
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
        public PhieuKhamBenhDTO selectdata(string id)
        {
            string query = string.Empty;
            query += "SELECT [maPKB], [maBN], [ngayKham], [trieuChung], [maLB],[maThuoc], [soLuong], [iDCD],[tienTong],[tienKham]";
            query += "FROM [tblPhieuKhamBenh] WHERE [maPKB]=@id";

            PhieuKhamBenhDTO dataPKB = new PhieuKhamBenhDTO();

            using (SqlConnection con = new SqlConnection(connectionString))
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
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            if (reader.Read())
                            {
                                dataPKB.maPKB = reader["maPKB"].ToString();
                                dataPKB.maBN = reader["maBN"].ToString();
                                dataPKB.ngayKham = Convert.ToDateTime(reader["ngayKham"].ToString());
                                dataPKB.trieuChung = reader["trieuChung"].ToString();
                                dataPKB.maLB = reader["maLB"].ToString();
                                dataPKB.maThuoc = reader["maThuoc"].ToString();
                                dataPKB.iDCD = reader["iDCD"].ToString();
                                dataPKB.soLuong = int.Parse(reader["soLuong"].ToString());
                                dataPKB.tienTong = int.Parse(reader["tienTong"].ToString());
                                dataPKB.tienKham = int.Parse(reader["tienKham"].ToString());
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
            return dataPKB;
        }
        public DataTable loadData(string id)
        { 
            DataTable data = new DataTable();
            data.Columns.Add("maThuoc");
            data.Columns.Add("tenThuoc");
            data.Columns.Add("donViTinh");
            data.Columns.Add("donGia");
            data.Columns.Add("soLuong");
            data.Columns.Add("tienKham");
            //lay dvt,dgia
            string query = string.Empty;
            query += "SELECT [maThuoc],[tenThuoc],[donViTinh], [donGia] FROM [tblThuoc] WHERE [maThuoc] = (SELECT [maThuoc] FROM [tblPhieuKhamBenh] WHERE [maPKB] =@id);";
            using (SqlConnection con = new SqlConnection(connectionString))
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
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        DataRow row = data.NewRow();
                        if (reader.Read())
                        {
                            row["maThuoc"] = reader["maThuoc"].ToString();
                            row["tenThuoc"] = reader["tenThuoc"].ToString();
                            row["donGia"] = reader["donGia"].ToString();
                            row["donViTinh"] = reader["donViTinh"].ToString();
               
                        }
                        //lay data pkb
                        PhieuKhamBenhDTO pkbSTO = new PhieuKhamBenhDTO();
                        TienKhamDAL tien = new TienKhamDAL();
                        pkbSTO = selectdata(id);
                        row["soLuong"] = pkbSTO.soLuong;
                        row["tienKham"] = tien.selectsotien(pkbSTO.tienKham);
                        data.Rows.Add(row);
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

