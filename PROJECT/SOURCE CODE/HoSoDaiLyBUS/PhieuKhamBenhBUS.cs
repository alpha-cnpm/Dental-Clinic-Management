using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPM_DAL;
using QLPM_DTO;
namespace QLPM_BUS
{
    public class PhieuKhamBenhBUS
    {
        private PhieuKhamBenhDAL pkbDAL= new PhieuKhamBenhDAL();
        public bool Them(PhieuKhamBenhDTO pkb)
        {
            bool re = pkbDAL.Them(pkb);
                return re;
        }
            public bool Sua(PhieuKhamBenhDTO pkb)
            {
                bool re = pkbDAL.Sua(pkb);
                return re;
            }

            public bool Xoa(PhieuKhamBenhDTO pkb)
            {
                bool re = pkbDAL.Xoa(pkb);
                return re;
            }
        public List<PhieuKhamBenhDTO> select()
        {
            return pkbDAL.select();
        }
        public List<string> selectnameall(string id)
        {
            return pkbDAL.selectallname(id);
        }
        public PhieuKhamBenhDTO selectdata(string id)
        {
            return pkbDAL.selectdata(id);
        }

        public DataTable loadData(string id)
        {
            return pkbDAL.loadData(id); 
        }
    }

    }

