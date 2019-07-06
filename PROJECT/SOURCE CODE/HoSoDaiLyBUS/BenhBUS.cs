using QLPM_DTO;
using QLPM_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class BenhBUS
    {
        private BenhDAL BDAL;
        public BenhBUS()
        {
            BDAL = new BenhDAL();
        }
        public bool Them(BenhDTO hs)
        {
            bool re = BDAL.Them(hs);
            return re;
        }
        public bool Sua(BenhDTO hs)
        {
            bool re = BDAL.Sua(hs);
            return re;
        }

        public bool Xoa(BenhDTO hs)
        {
            bool re = BDAL.Xoa(hs);
            return re;
        }
        public List<BenhDTO> select()
        {
            return BDAL.select();
        }
    }
}
