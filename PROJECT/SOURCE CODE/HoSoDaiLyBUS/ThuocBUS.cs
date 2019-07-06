using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPM_DAL;
using QLPM_DTO;

namespace QLPM_BUS
{
    public class ThuocBUS
    {
        private ThuocDAL thDAL = new ThuocDAL();
        public bool Them(ThuocDTO th)
        {
            bool re = thDAL.Them(th);
            return re;
        }
        public bool Sua(ThuocDTO th)
        {
            bool re = thDAL.Sua(th);
            return re;
        }

        public bool Xoa(ThuocDTO th)
        {
            bool re = thDAL.Xoa(th);
            return re;
        }
        public List<ThuocDTO> select()
        {
            return thDAL.select();
        }
        public List<string> selectnameall(string id)
        {
            return thDAL.selectallname(id);
        }
        public List<ThuocDTO> selectten()
        {
            return thDAL.selectten();
        }
        public string sellectenforThuoc(string dm)
        {
            return thDAL.selecttenforThuoc(dm);
        }
        public int selectdongia(string id)
        {
            return thDAL.selectdongia(id);
        }
    }

}

