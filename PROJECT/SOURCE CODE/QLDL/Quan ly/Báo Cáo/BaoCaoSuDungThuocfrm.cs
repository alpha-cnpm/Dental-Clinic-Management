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
namespace QLDL.Quan_ly.Báo_Cáo
{
    public partial class BaoCaoSuDungThuocfrm : Form
    {
        private PhieuBaoCacSuDungThuocBUS bcBUS = new PhieuBaoCacSuDungThuocBUS();
        public BaoCaoSuDungThuocfrm()
        {
            InitializeComponent();
        }

        private void tinkiembtn_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            
            data = bcBUS.baocaosudungthuoc(textBox1.Text);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = data;

            DataGridViewTextBoxColumn clThuoc = new DataGridViewTextBoxColumn();
            clThuoc.Name = "clThuoc";
            clThuoc.HeaderText = "Tên Thuốc";
            clThuoc.DataPropertyName = "tenThuoc";
            dataGridView1.Columns.Add(clThuoc);

            DataGridViewTextBoxColumn clDonViTinh = new DataGridViewTextBoxColumn();
            clDonViTinh.Name = "clclDonViTinh";
            clDonViTinh.HeaderText = "Dơn Vi Tính";
            clDonViTinh.DataPropertyName = "donViTinh";
            dataGridView1.Columns.Add(clDonViTinh);

            DataGridViewTextBoxColumn clsoLuong = new DataGridViewTextBoxColumn();
            clsoLuong.Name = "clDoanhThu";
            clsoLuong.HeaderText = "Số Lượng";
            clsoLuong.DataPropertyName = "soLuong";
            dataGridView1.Columns.Add(clsoLuong);

            DataGridViewTextBoxColumn clsoLanDung = new DataGridViewTextBoxColumn();
            clsoLanDung.Name = "clsoLanDung";
            clsoLanDung.HeaderText = "Số Lần Dùng";
            clsoLanDung.DataPropertyName = "soLanDung";
            dataGridView1.Columns.Add(clsoLanDung);
        }
    }
}
