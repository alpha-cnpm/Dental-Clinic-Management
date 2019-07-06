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
    public partial class QLThuocfrm : Form
    {
        private List<ThuocDTO> listThuoc = new List<ThuocDTO>();
        private ThuocBUS thuocBUS = new ThuocBUS();
        public QLThuocfrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void QuanLyThuoc_Load(object sender, EventArgs e)
        {
            listThuoc = thuocBUS.select();
            load_data_ct();
        }
        private void clear_data_in_box()
        {
            maThuocBox.Text = null;

            tenThuocBox.Text = null;

            giaBox.Text = null;
            chaiRadioB.Checked = false;
            vienRadioB.Checked = false;

        }       
        private void themButton_Click(object sender, EventArgs e)
        {
            string checkDonVi;

            if (chaiRadioB.Checked == true)
            {
                checkDonVi = "Chai";
            }
            else
                checkDonVi = "Viên";
            ThuocDTO ct = new ThuocDTO()
            {
                maThuoc = maThuocBox.Text,
                tenThuoc = tenThuocBox.Text,
                donGia = int.Parse(giaBox.Text),
                donViTinh = checkDonVi



            };
            thuocBUS.Them(ct);
            listThuoc.Add(ct);
            load_data_ct();
            clear_data_in_box();
        }


        private void load_data_ct()
        {
            dataGridView1.Columns.Clear();
            //datagrid.DataSource = null;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = listThuoc;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "clMaThuoc";
            clMa.HeaderText = "Mã Thuốc";
            clMa.DataPropertyName = "maThuoc";
            dataGridView1.Columns.Add(clMa);


            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "clTenThuoc";
            clTen.HeaderText = "Tên Thuốc";
            clTen.DataPropertyName = "tenThuoc";
            dataGridView1.Columns.Add(clTen);



            DataGridViewTextBoxColumn clDonVi = new DataGridViewTextBoxColumn();
            clDonVi.Name = "clDonViTinh";
            clDonVi.HeaderText = "Đơn Vị Tính";
            clDonVi.DataPropertyName = "donViTinh";
            dataGridView1.Columns.Add(clDonVi);

            DataGridViewTextBoxColumn clGia = new DataGridViewTextBoxColumn();
            clGia.Name = "clDonGia";
            clGia.HeaderText = "Đơn Giá";
            clGia.DataPropertyName = "donGia";
            dataGridView1.Columns.Add(clGia);


            //DataGridViewTextBoxColumn clGioiTinh = new DataGridViewTextBoxColumn();
            //clGioiTinh.Name = "clGioiTBN";
            //clGioiTinh.HeaderText = "Giới Tính";
            //clGioiTinh.DataPropertyName = "gioiTinh";
            //dataGridView1.Columns.Add(clGioiTinh);

            //DataGridViewTextBoxColumn clDiaChi = new DataGridViewTextBoxColumn();
            //clDiaChi.Name = "clDiaCBN";
            //clDiaChi.HeaderText = "Địa Chỉ";
            //clDiaChi.DataPropertyName = "diaChi";
            //dataGridView1.Columns.Add(clDiaChi);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                for (int i = 0; i < listThuoc.Count; i++)
                {

                    if (listThuoc[i].maThuoc == maThuocBox.Text)
                    {
                        if (maThuocBox != null)
                        {
                            List<ThuocDTO> _listThuoc = thuocBUS.select();
                            foreach (ThuocDTO thuoc in _listThuoc)
                            {
                                if (thuoc.maThuoc == maThuocBox.Text)
                                {
                                    thuocBUS.Xoa(thuoc);
                                }
                            }
                        }
                        listThuoc.RemoveAt(i);
                        break;
                    }

                }
            }
            load_data_ct();
            clear_data_in_box();
        }

        private void suaButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                for (int i = 0; i < listThuoc.Count; i++)
                {
                    if (listThuoc[i].maThuoc == maThuocBox.Text)
                    {
                        if (maThuocBox != null)
                        {
                            listThuoc.RemoveAt(i);

                            List<ThuocDTO> _listThuoc = thuocBUS.select();
                            foreach (ThuocDTO thuoc in _listThuoc)
                            {
                                string checkDonVi;

                                if (chaiRadioB.Checked == true)
                                {
                                    checkDonVi = "Chai";
                                }
                                else
                                    checkDonVi = "Viên";

                                if (thuoc.maThuoc == maThuocBox.Text)
                                {
                                    thuoc.maThuoc = maThuocBox.Text;

                                    thuoc.tenThuoc = tenThuocBox.Text;

                                    thuoc.donGia = int.Parse(giaBox.Text);



                                    thuoc.donViTinh = checkDonVi;
                                }
                                thuocBUS.Sua(thuoc);
                                listThuoc.Add(thuoc);
                            }
                        }
                        break;
                    }

                }
                load_data_ct();
                clear_data_in_box();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    maThuocBox.Text = item.Cells["clMaThuoc"].Value.ToString();
                    tenThuocBox.Text = item.Cells["clTenThuoc"].Value.ToString();
                    if (item.Cells["clDonViTinh"].Value.ToString() == "Chai")
                    {
                        chaiRadioB.Checked = true;
                        vienRadioB.Checked = false;
                    }
                    else
                    {
                        chaiRadioB.Checked = false;
                        vienRadioB.Checked = true;

                    }
                   giaBox.Text = item.Cells[("clDonGia")].Value.ToString();

                }
            }
        }
  }
