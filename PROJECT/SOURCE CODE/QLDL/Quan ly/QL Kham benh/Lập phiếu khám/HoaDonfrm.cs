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
    public partial class HoaDonfrm : Form
    { 
        private string maphieukham;
        PhieuKhamBenhDTO pkbSTO = new PhieuKhamBenhDTO();
        private PhieuKhamBenhBUS pkbBUS = new PhieuKhamBenhBUS();
        private ThuocBUS thuocBUS = new ThuocBUS();
        DataTable a = new DataTable();
        public HoaDonfrm(string id)
        {
            maphieukham = id;
            InitializeComponent();
        }
        private void HoaDonfrm_Load(object sender, EventArgs e)
        {

            
            a = pkbBUS.loadData(maphieukham);
            load_data_ct();
            pkbSTO = pkbBUS.selectdata(maphieukham);
            mpkbox.Text = pkbSTO.maPKB;
            trieuchungbox.Text = pkbSTO.trieuChung;
            mabnbox.Text = pkbSTO.maBN;
            ngaykhamdate.Value = pkbSTO.ngayKham;
            thanhtientxt.Text = pkbSTO.tienTong.ToString();
        }

        private void load_data_ct() //show data vào datagridview
        {
            datagridview.Columns.Clear();
            //datagrid.DataSource = null;

            datagridview.AutoGenerateColumns = false;
            datagridview.AllowUserToAddRows = false;
            datagridview.DataSource = a;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "clMaThuoc";
            clMa.HeaderText = "Mã Thuốc";
            clMa.DataPropertyName = "maThuoc";
            datagridview.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "clTenThuoc";
            clTen.HeaderText = "Tên Thuốc";
            clTen.DataPropertyName = "tenThuoc";
            datagridview.Columns.Add(clTen);
            
            DataGridViewTextBoxColumn clDonVi = new DataGridViewTextBoxColumn();
            clDonVi.Name = "clDonViTinh";
            clDonVi.HeaderText = "Đơn Vị Tính";
            clDonVi.DataPropertyName = "donViTinh";
            datagridview.Columns.Add(clDonVi);

            DataGridViewTextBoxColumn clGia = new DataGridViewTextBoxColumn();
            clGia.Name = "clDonGia";
            clGia.HeaderText = "Đơn Giá";
            clGia.DataPropertyName = "donGia";
            datagridview.Columns.Add(clGia);

            DataGridViewTextBoxColumn clSL = new DataGridViewTextBoxColumn();
            clSL.Name = "clSoLuong";
            clSL.HeaderText = "Số lượng";
            clSL.DataPropertyName = "soLuong";
            datagridview.Columns.Add(clSL);

            DataGridViewTextBoxColumn clTienKham = new DataGridViewTextBoxColumn();
            clTienKham.Name = "clTienKham";
            clTienKham.HeaderText = "Tiền Khám";
            clTienKham.DataPropertyName = "tienKham";
            datagridview.Columns.Add(clTienKham);



            //            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[datagridview.DataSource];
            //            myCurrencyManager.Refresh();
        }
    }
}
