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
using System.Data.SqlClient;
namespace QLDL.Quan_ly.Báo_Cáo
{
    public partial class BaoCaoDoanhThufrm : Form
    {
        public BaoCaoDoanhThufrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tinkiembtn_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            pDoanhThuBUS pDoanhThuBUS = new pDoanhThuBUS();
            data = pDoanhThuBUS.selectdata(textBox1.Text);
            //date.;




            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = data;

            DataGridViewTextBoxColumn clNgay = new DataGridViewTextBoxColumn();
            clNgay.Name = "clNgay";
            clNgay.HeaderText = "Ngày";
            clNgay.DataPropertyName = "ngay";
            dataGridView1.Columns.Add(clNgay);

            DataGridViewTextBoxColumn clSoBenhNhan = new DataGridViewTextBoxColumn();
            clSoBenhNhan.Name = "clsoLuongBenhNhan";
            clSoBenhNhan.HeaderText = "Số Bệnh Nhân";
            clSoBenhNhan.DataPropertyName = "soLuongBenhNhan";
            dataGridView1.Columns.Add(clSoBenhNhan);

            DataGridViewTextBoxColumn clDoanhThu = new DataGridViewTextBoxColumn();
            clDoanhThu.Name = "clDoanhThu";
            clDoanhThu.HeaderText = "Doanh Thu";
            clDoanhThu.DataPropertyName = "doanhThu";
            dataGridView1.Columns.Add(clDoanhThu);

            DataGridViewTextBoxColumn clTiLe = new DataGridViewTextBoxColumn();
            clTiLe.Name = "clTiLe";
            clTiLe.HeaderText = "Tỉ Lệ";
            clTiLe.DataPropertyName = "tiLe";
            dataGridView1.Columns.Add(clTiLe);
        }
    }
            
}
