using QLPM_DTO;
using QLPM_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class TienKhamBUS
    {
        private TienKhamDAL TKDAL;
        public TienKhamBUS()
        {
            TKDAL = new TienKhamDAL();
        }
        public bool Them(TienKhamDTO hs)
        {
            bool re = TKDAL.Them(hs);
            return re;
        }
        public bool Sua(TienKhamDTO hs)
        {
            bool re = TKDAL.Sua(hs);
            return re;
        }

        public bool Xoa(TienKhamDTO hs)
        {
            bool re = TKDAL.Xoa(hs);
            return re;
        }
        public int selectsotienkham(int id)
        {
            return TKDAL.selectsotien(id);
        }
    }
}
