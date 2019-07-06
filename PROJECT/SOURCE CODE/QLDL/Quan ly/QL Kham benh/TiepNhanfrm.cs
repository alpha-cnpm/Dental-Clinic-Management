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
    public partial class TiepNhanfrm : Form
    {
        private List<BenhNhanDTO> listbn = new List<BenhNhanDTO>();
        private BenhNhanBUS bnBUS = new BenhNhanBUS();
        public TiepNhanfrm()
        {
            InitializeComponent();
        
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TiepNhanfrm_Load(object sender, EventArgs e)
        {
            listbn = bnBUS.select();
            load_data_ct();
        }

        private void clear_data_in_box()
        {
            mabntxt.Text = null;

            hotentxt.Text = null;

            diachitxt.Text = null;

            nambtn.Checked = false;

            nubtn.Checked = false;
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



            DataGridViewTextBoxColumn clNgayTN = new DataGridViewTextBoxColumn();
            clNgayTN.Name = "clNgayTNBN";
            clNgayTN.HeaderText = "Ngày Tiếp Nhận";
            clNgayTN.DataPropertyName = "ngayTiepNhan";
            datagrid.Columns.Add(clNgayTN);

            DataGridViewTextBoxColumn clNgS = new DataGridViewTextBoxColumn();
            clNgS.Name = "clNgaySBN";
            clNgS.HeaderText = "Ngày Sinh";
            clNgS.DataPropertyName = "namSinh";
            datagrid.Columns.Add(clNgS);


            DataGridViewTextBoxColumn clGioiT = new DataGridViewTextBoxColumn();
            clGioiT.Name = "clGioiTBN";
            clGioiT.HeaderText = "Giới Tính";
            clGioiT.DataPropertyName = "gioiTinh";
            datagrid.Columns.Add(clGioiT);

            DataGridViewTextBoxColumn clDiaC = new DataGridViewTextBoxColumn();
            clDiaC.Name = "clDiaCBN";
            clDiaC.HeaderText = "Địa Chỉ";
            clDiaC.DataPropertyName = "diaChi";
            datagrid.Columns.Add(clDiaC);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[datagrid.DataSource];
            myCurrencyManager.Refresh();
        }

        private void thembtn_Click(object sender, EventArgs e)
        {
            string checkgt;

            if (nambtn.Checked == true)
            {
                checkgt = "Nam";
            }
            else
                checkgt = "Nữ";
 

            BenhNhanDTO ct = new BenhNhanDTO()
            {
                maBN = mabntxt.Text,

                hoTenBN = hotentxt.Text,

                namSinh = ngaysinhdate.Value,

                diaChi = diachitxt.Text,

                ngayTiepNhan = ngaytiepnhandate.Value,

                gioiTinh = checkgt

            };
            bnBUS.Them(ct);
            listbn.Add(ct);
            load_data_ct();
            clear_data_in_box();

        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in this.datagrid.SelectedRows)
            {
                mabntxt.Text = item.Cells["clMaBN"].Value.ToString();
                hotentxt.Text = item.Cells["clTenBN"].Value.ToString();
                if (item.Cells["clGioiTBN"].Value.ToString() == "Nam")
                {
                    nambtn.Checked = true;
                    nubtn.Checked = false;
                }
                else
                {
                    nubtn.Checked = true;
                    nambtn.Checked = false;
                }
                ngaysinhdate.Text = item.Cells["clNgaySBN"].Value.ToString();
                ngaytiepnhandate.Text = item.Cells["clNgayTNBN"].Value.ToString();
                diachitxt.Text = item.Cells["clDiaCBN"].Value.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ngaytiepnhandate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mabntxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
           foreach (DataGridViewRow item in this.datagrid.SelectedRows)
           {
                for (int i = 0; i < listbn.Count; i++)
                {
                   
                    if (listbn[i].maBN == mabntxt.Text)
                    { 
                        if (mabntxt != null)
                        {
                            List<BenhNhanDTO> _listbn = bnBUS.select();
                            foreach (BenhNhanDTO bn in _listbn)
                            {
                                if (bn.maBN == mabntxt.Text)
                                {
                                    bnBUS.Xoa(bn);
                                }
                            }
                        }
                        listbn.RemoveAt(i);
                        break;
                    }

                }
            }
            load_data_ct();
            clear_data_in_box();

        }

        private void suabtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.datagrid.SelectedRows)
            {
                for (int i = 0; i < listbn.Count; i++)
                {
                    if (listbn[i].maBN == mabntxt.Text)
                    {
                        if (mabntxt != null)
                        {
                            listbn.RemoveAt(i);

                            List<BenhNhanDTO> _listbn = bnBUS.select();
                            foreach (BenhNhanDTO bn in _listbn)
                            {
                                string checkgt;

                                if (nambtn.Checked == true)
                                {
                                    checkgt = "Nam";
                                }
                                else
                                    checkgt = "Nữ";

                                if (bn.maBN == mabntxt.Text)
                                {
                                    bn.maBN = mabntxt.Text;

                                    bn.hoTenBN = hotentxt.Text;

                                    bn.namSinh = ngaysinhdate.Value;

                                    bn.diaChi = diachitxt.Text;

                                    bn.ngayTiepNhan = ngaytiepnhandate.Value;

                                    bn.gioiTinh = checkgt;
                                }
                                bnBUS.Sua(bn);
                                listbn.Add(bn);
                            }
                        }
                        break;
                    }

                }
                load_data_ct();
                clear_data_in_box();
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
