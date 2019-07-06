using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class PhieuKhamBenhDTO
    {
        private string MaPKB;
        private string MaBN;
        private string MaLB;
        private int TienKham;
        private string TrieuChung;
        private DateTime NgayKham;
        private int TienTong;
        private string IDCD;
        private string MaThuoc;
        private int SoLuong;



        public string maPKB { get => MaPKB; set => MaPKB = value; }
        public string maBN { get => MaBN; set => MaBN = value; }
        public string maLB { get => MaLB; set => MaLB = value; }
        public int tienKham { get => TienKham; set => TienKham = value; }
        public string trieuChung { get => TrieuChung; set => TrieuChung = value; }
        public int tienTong {get =>TienTong; set=>TienTong=value;}
        public string maThuoc { get => MaThuoc; set => MaThuoc = value; }
        public DateTime ngayKham { get => NgayKham; set => NgayKham = value; }
        public string iDCD { get => IDCD; set => IDCD = value; } 
        public int soLuong { get => SoLuong; set => SoLuong = value; }

    }
}
