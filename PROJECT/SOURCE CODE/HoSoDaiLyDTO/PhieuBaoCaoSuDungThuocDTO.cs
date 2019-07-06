using QLPM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_DTO
{
    public class PhieuBaoCaoSuDungThuocDTO
    {
        private string MaBCSD;
        private int ThangSD;
        private string MaPKB;
   

        public string maBCSD { get => MaBCSD; set => MaBCSD = value; }
        public int thangSD { get => ThangSD; set => ThangSD = value; }
        
        public string maPKB { get => MaPKB; set => MaPKB = value; }
    }


}
