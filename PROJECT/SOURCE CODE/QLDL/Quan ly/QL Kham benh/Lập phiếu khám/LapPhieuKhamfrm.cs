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
    public partial class LapPhieuKhamfrm : Form
    {

        private List<ThuocDTO> listThuoc = new List<ThuocDTO>();
        private ThuocBUS thuocBUS = new ThuocBUS();
        private BenhBUS benhBUS = new BenhBUS();
        private CachDungBUS cachdungBUS = new CachDungBUS();
        private List<PhieuKhamBenhDTO> listpkb = new List<PhieuKhamBenhDTO>();
        private PhieuKhamBenhBUS pkbBUS = new PhieuKhamBenhBUS();
        private BenhNhanBUS bnBUS = new BenhNhanBUS();
        private TienKhamBUS tienKhamBus = new TienKhamBUS();
        public LapPhieuKhamfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          PhieuKhamBenhDTO ct = new PhieuKhamBenhDTO()
            {
                maPKB = mpkbox.Text,
                maBN = benhnhanbox.Text,
                trieuChung = trieuchungtxt.Text,
                maThuoc = thuocbox.SelectedValue.ToString(),
                ngayKham = ngaykhamdate.Value,
                maLB = loaibenhbox.SelectedValue.ToString(),
                soLuong = int.Parse(soluongtxt.Text),
                iDCD = cachdungbox.SelectedValue.ToString(),
                tienKham = 1,
                tienTong = tienKhamBus.selectsotienkham(1) + int.Parse(soluongtxt.Text) * thuocBUS.selectdongia(thuocbox.SelectedValue.ToString())//don gia

            };
            pkbBUS.Them(ct);
            listpkb.Add(ct);

            HoaDonfrm frmhoadon = new HoaDonfrm(mpkbox.Text);
            frmhoadon.Show();
        }

        private void LapPhieuKhamfrm_Load(object sender, EventArgs e)
        {
            listThuoc = thuocBUS.select();
            load_data_ct();
            listpkb = pkbBUS.select();

            thuocBUS = new ThuocBUS();
            thuocbox.DataSource = thuocBUS.select();
            thuocbox.ValueMember = "maThuoc";
            thuocbox.DisplayMember = "tenThuoc";

            donvibox.DataSource = thuocbox.DataSource;
            donvibox.DisplayMember = "donViTinh";

            loaibenhbox.DataSource = benhBUS.select();
            loaibenhbox.DisplayMember = "tenBenh";
            loaibenhbox.ValueMember = "maLB";


            cachdungbox.DataSource = cachdungBUS.select();
            cachdungbox.DisplayMember = "noiDungCD";
            cachdungbox.ValueMember = "iDCD";

            //cachdungbox.DataSource = thBUS.selectcachdung();
            //cachdungbox.DisplayMember = "cachDung";

            benhnhanbox.DataSource = bnBUS.selectten();

        }

        private void mabenhnhantxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void thuocbox_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewRow item in this.datagridview.SelectedRows)
            //{
            //    mabntxt.Text = item.Cells["clMaBN"].Value.ToString();
            //hotentxt.Text = item.Cells["clTenBN"].Value.ToString();

            //ngaysinhdate.Text = item.Cells["clNgaySBN"].Value.ToString();
            //ngaytiepnhandate.Text = item.Cells["clNgayTNBN"].Value.ToString();
            //diachitxt.Text = item.Cells["clDiaCBN"].Value.ToString();
            // }
        }
       
        private void load_data_ct() //show data vào datagridview
        {
           datagridview.Columns.Clear();
            //datagrid.DataSource = null;

            datagridview.AutoGenerateColumns = false;
            datagridview.AllowUserToAddRows = false;
            datagridview.DataSource = listThuoc;

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



            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[datagridview.DataSource];
            myCurrencyManager.Refresh();
        }

        private void xacnhanbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void loaibenhbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void soluongtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
