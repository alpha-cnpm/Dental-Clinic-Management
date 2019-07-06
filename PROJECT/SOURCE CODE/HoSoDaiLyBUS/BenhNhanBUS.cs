using QLPM_DTO;
using QLPM_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM_BUS
{
    public class BenhNhanBUS
    {
        private BenhNhanDAL BNDAL;
        public BenhNhanBUS()
        {
            BNDAL = new BenhNhanDAL();
        }
        public bool Them(BenhNhanDTO hs)
        {
            bool re = BNDAL.Them(hs);
            return re;
        }
        public bool Sua(BenhNhanDTO hs)
        {
            bool re = BNDAL.Sua(hs);
            return re;
        }

        public bool Xoa(BenhNhanDTO hs)
        {
            bool re = BNDAL.Xoa(hs);
            return re;
        }
        public List<BenhNhanDTO> select()
        {
            return BNDAL.select();
        }

        public string selectname(string id)
        {
            return BNDAL.selectname(id);
        }

        public List<string> selectten()
        {
            return BNDAL.selectten();
        }
    }
}