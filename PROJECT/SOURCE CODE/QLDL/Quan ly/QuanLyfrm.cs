using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDL
{
    public partial class QuanLyfrm : Form
    {
        public QuanLyfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void frmdanhsach1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void khambenhbtn_Click(object sender, EventArgs e)
        {
            KhamBenhfrm f1 = new KhamBenhfrm();
            f1.FormClosed += new FormClosedEventHandler(frmdanhsach1_FormClosed);
            f1.Show();
            this.Hide();
        }

        private void thuocbtn_Click(object sender, EventArgs e)
        {
            QLThuocfrm quanly1 = new QLThuocfrm();
            quanly1.FormClosed += new FormClosedEventHandler(frmdanhsach1_FormClosed);
            quanly1.Show();
            this.Hide();
        }

        private void QuanLyfrm_Load(object sender, EventArgs e)
        {

        }

        private void Quanly_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void baocaobtn_Click(object sender, EventArgs e)
        {
            QLDL.Quan_ly.Báo_Cáo.BaoCaoDoanhThufrm f = new QLDL.Quan_ly.Báo_Cáo.BaoCaoDoanhThufrm();
            f.Show();
            this.Hide();
            f.FormClosed += F_FormClosed;
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            QLDL.Quan_ly.Báo_Cáo.BaoCaoSuDungThuocfrm quanly = new Quan_ly.Báo_Cáo.BaoCaoSuDungThuocfrm();
            quanly.Show();
            this.Hide();
            quanly.FormClosed += Quanly_FormClosed;
        }


        //private void F_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    this.Show();
        //}

    }
}
