using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPM_BUS;
using QLPM_DTO;
namespace QLDL
{
    public partial class DanhSachHoaDonfrm : Form
    {

        private List<PhieuKhamBenhDTO> listpkb = new List<PhieuKhamBenhDTO>();
        private PhieuKhamBenhBUS pkbBUS = new PhieuKhamBenhBUS();


        public DanhSachHoaDonfrm()
        {
            InitializeComponent();
        }

        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            listpkb = pkbBUS.select();
            load_data_ct();
        }

        private void load_data_ct()
        {
            datagrid.Columns.Clear();
            datagrid.DataSource = null;
            datagrid.AutoGenerateColumns = false;
            datagrid.AllowUserToAddRows = false;
            datagrid.DataSource = listpkb;

            DataGridViewTextBoxColumn clMaPKB = new DataGridViewTextBoxColumn();
            clMaPKB.Name = "clmaPKB";
            clMaPKB.HeaderText = "Mã Phiếu Khám";
            clMaPKB.DataPropertyName = "maPKB";
            datagrid.Columns.Add(clMaPKB);


            DataGridViewTextBoxColumn clMaBN = new DataGridViewTextBoxColumn();
            clMaBN.Name = "clmaBN";
            clMaBN.HeaderText = "Mã Bệnh Nhân";
            clMaBN.DataPropertyName = "maBN";
            datagrid.Columns.Add(clMaBN);



            DataGridViewTextBoxColumn clMaLB = new DataGridViewTextBoxColumn();
            clMaLB.Name = "clmaLB";
            clMaLB.HeaderText = "Mã Loại Bệnh";
            clMaLB.DataPropertyName = "maLB";
            datagrid.Columns.Add(clMaLB);

            DataGridViewTextBoxColumn clMaQLT = new DataGridViewTextBoxColumn();
            clMaQLT.Name = "clmaQLT";
            clMaQLT.HeaderText = "Mã Thuốc";
            clMaQLT.DataPropertyName = "maThuoc";
            datagrid.Columns.Add(clMaQLT);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[datagrid.DataSource];
            myCurrencyManager.Refresh();
        }

        private void DanhSachHoaDonfrm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDonfrm f = new HoaDonfrm(listpkb[e.RowIndex].maPKB);
            f.Show();
            this.Hide();
            f.FormClosed += F_FormClosed;
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
