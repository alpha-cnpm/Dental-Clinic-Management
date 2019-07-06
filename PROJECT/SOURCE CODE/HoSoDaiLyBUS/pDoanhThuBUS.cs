using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPM_DAL;
using QLPM_DTO;
namespace QLPM_BUS
{
    public class pDoanhThuBUS
    {
  
        private pDoanhThuDAL pdoanhthuDAL;
        public pDoanhThuBUS()
        {
            pdoanhthuDAL = new pDoanhThuDAL();
        }
        public bool Them(pDoanhThuDTO hs)
        {
            bool re = pdoanhthuDAL.Them(hs);
            return re;
        }
        public bool Sua(pDoanhThuDTO hs)
        {
            bool re = pdoanhthuDAL.Sua(hs);
            return re;
        }

        public bool Xoa(pDoanhThuDTO hs)
        {
            bool re = pdoanhthuDAL.Xoa(hs);
            return re;
        }
        public List<pDoanhThuDTO> select()
        {
            return pdoanhthuDAL.select();
        }
        public DataTable selectdata(string day)
        {
            return pdoanhthuDAL.selectdata(day);
        }
    }

}

