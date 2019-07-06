using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class pDoanhThuDTO
    {
        private string MaBCDT;
        private int ThangDT;
        private string MaHD;



        public string maBCDT { get => MaBCDT; set => MaBCDT = value; }
        public int thangDT { get => ThangDT; set => ThangDT = value; }

        public string maHD { get => MaHD; set => MaHD = value; }
    }


}

