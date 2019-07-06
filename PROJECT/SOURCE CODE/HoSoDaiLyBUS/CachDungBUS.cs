using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPM_DAL;
using QLPM_DTO;

namespace QLPM_BUS
{
    public class CachDungBUS
    {
        private CachDungDAL cdDAL = new CachDungDAL();
        public bool Them(CachDungDTO cd)
        {
            bool re = cdDAL.Them(cd);
            return re;
        }
        public bool Sua(CachDungDTO cd)
        {
            bool re = cdDAL.Sua(cd);
            return re;
        }

        public bool Xoa(CachDungDTO cd)
        {
            bool re = cdDAL.Xoa(cd);
            return re;
        }
        public List<CachDungDTO> select()
        {
            return cdDAL.select();
        }
        public List<string> selectnameall(string id)
        {
            return cdDAL.selectallname(id);
        }
        public List<CachDungDTO> selectten()
        {
            return cdDAL.selectten();
        }
       
    }

}

