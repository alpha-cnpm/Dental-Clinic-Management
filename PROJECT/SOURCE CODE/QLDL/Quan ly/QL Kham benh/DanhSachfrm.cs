using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPM_DTO;
using QLPM_BUS;
namespace QLDL
{
    public partial class DanhSachfrm : Form
    {
        private List<BenhNhanDTO> listbn = new List<BenhNhanDTO>();
        private BenhNhanBUS bnBUS = new BenhNhanBUS();

        public DanhSachfrm()
        {
            InitializeComponent();
        }



        private void timkiembtn_Click(object sender, EventArgs e)
        {
            listbn = new List<BenhNhanDTO>();
            List<BenhNhanDTO> listsearch = bnBUS.select();
            if (comboBox1.Text == "Mã bệnh nhân")
            {
                foreach (BenhNhanDTO bn in listsearch)
                {
                    if (bn.maBN == tracuutxt.Text)
                        listbn.Add(bn);
                }
            }
            else if (comboBox1.Text == "Tên bệnh nhân")
            {
                foreach (BenhNhanDTO bn in listsearch)
                {
                    if (bn.hoTenBN == tracuutxt.Text)
                        listbn.Add(bn);
                }
            }


            load_data_ct();
        }

        private void load_data_ct()
        {
            datagrid.Columns.Clear();
            //datagrid.DataSource = null;

            datagrid.AutoGenerateColumns = false;
            datagrid.AllowUserToAddRows = false;
            datagrid.DataSource = listbn;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "clMaBN";
            clMa.HeaderText = "Mã Bệnh Nhân";
            clMa.DataPropertyName = "maBN";
            datagrid.Columns.Add(clMa);


            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "clTenBN";
            clTen.HeaderText = "Tên Bệnh Nhân";
            clTen.DataPropertyName = "hoTenBN";
            datagrid.Columns.Add(clTen);

            DataGridViewTextBoxColumn clLoaiBenh = new DataGridViewTextBoxColumn();
            clLoaiBenh.Name = "LoaiBenh";
            clLoaiBenh.HeaderText = "Loại Bệnh";
            clLoaiBenh.DataPropertyName = "loaiBenh";
            datagrid.Columns.Add(clLoaiBenh);

            DataGridViewTextBoxColumn clTrieuChung = new DataGridViewTextBoxColumn();
            clTrieuChung.Name = "TrieuChung";
            clTrieuChung.HeaderText = "Triệu Chứng";
            clTrieuChung.DataPropertyName = "trieuchung";
            datagrid.Columns.Add(clTrieuChung);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[datagrid.DataSource];
            myCurrencyManager.Refresh();
        }


            private void DanhSachfrm_Load(object sender, EventArgs e)
            {

            }

            private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
    }
 
}
