using QLPM_DTO;
using QLPM_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLPM_BUS
{
    public class PhieuBaoCacSuDungThuocBUS
    {
        private PhieuBaoCaoSuDungThuocDAL SDDAL;
        public PhieuBaoCacSuDungThuocBUS()
        {
            SDDAL = new PhieuBaoCaoSuDungThuocDAL();
        }
        public bool Them(PhieuBaoCaoSuDungThuocDTO hs)
        {
            bool re = SDDAL.Them(hs);
            return re;
        }
        public bool Sua(PhieuBaoCaoSuDungThuocDTO hs)
        {
            bool re = SDDAL.Sua(hs);
            return re;
        }

        public bool Xoa(PhieuBaoCaoSuDungThuocDTO hs)
        {
            bool re = SDDAL.Xoa(hs);
            return re;
        }
        public List<PhieuBaoCaoSuDungThuocDTO> select()
        {
            return SDDAL.select();
        }
        public DataTable baocaosudungthuoc(string id)
        {
            return SDDAL.baocaosudungthuoc(id);
        }
    }
}
