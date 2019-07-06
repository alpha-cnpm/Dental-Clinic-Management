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
    public partial class KhamBenhfrm : Form
    {
        public KhamBenhfrm()
        {
            InitializeComponent();
        }

        private void tiepnhanstrip_Click(object sender, EventArgs e)
        {
            TiepNhanfrm frmtiepnhan = new TiepNhanfrm();
            frmtiepnhan.FormClosed += new FormClosedEventHandler(frmtiepnhan_FormClosed);
            frmtiepnhan.Show();
            this.Hide();
        }

        private void frmtiepnhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void khambenhstrip_Click(object sender, EventArgs e)
        {
            LapPhieuKhamfrm frmlapphieu = new LapPhieuKhamfrm();
            frmlapphieu.FormClosed += new FormClosedEventHandler(frmlapphieu_FormClosed);
            frmlapphieu.Show();
            this.Hide();
        }
        private void frmlapphieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void KhamBenhfrm_Load(object sender, EventArgs e)
        {
           
        }

        private void frmdanhsach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void danhsachstrip_Click(object sender, EventArgs e)
        {
            DanhSachfrm frmdanhsach = new DanhSachfrm();
            frmdanhsach.FormClosed += new FormClosedEventHandler(frmdanhsach_FormClosed);
            frmdanhsach.Show();
            this.Hide();
        }

        private void hoadonstrip_Click(object sender, EventArgs e)
        {
            DanhSachHoaDonfrm frmdanhsachhoadon = new DanhSachHoaDonfrm();
            frmdanhsachhoadon.FormClosed += new FormClosedEventHandler(frmdanhsach_FormClosed);
            frmdanhsachhoadon.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
