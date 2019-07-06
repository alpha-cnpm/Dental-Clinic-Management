using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class BenhNhanDTO
    {
        private string MaBN;
        private string HotenBN;
        private DateTime NgayTiepNhan;
        private string GioiTinh;
        private DateTime NamSinh;
        private string DiaChi;


        public string maBN { get => MaBN; set => MaBN = value; }
        public string hoTenBN { get => HotenBN; set => HotenBN = value; }
        public DateTime ngayTiepNhan { get => NgayTiepNhan; set => NgayTiepNhan = value; }

        public string gioiTinh { get => GioiTinh; set => GioiTinh = value; }
        public DateTime namSinh { get => NamSinh; set => NamSinh = value; }
        public string diaChi { get => DiaChi; set => DiaChi = value; }

    }


}