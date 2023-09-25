using QLCuaHangBanhKeo.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanhKeo.GUI
{
    public partial class frmSanPham : Form
    {
        BLLGioHang bll = new BLLGioHang();
        private string username;
        public frmSanPham()
        {
            InitializeComponent();
            SlidePanel.Height = btnTrangChu.Height;
            giaoDienChinh1.BringToFront();
        }
        public frmSanPham(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            SlidePanel.Height = btnTrangChu.Height;
            giaoDienChinh1.BringToFront();
            lblDangNhap.Text = username;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            bll.RemoveALL();
            Application.Exit();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.ShowDialog();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnTrangChu.Height;
            SlidePanel.Top = btnTrangChu.Top;
            giaoDienChinh1.BringToFront();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnSanPham.Height;
            SlidePanel.Top = btnSanPham.Top;
            toanBoSP1.BringToFront();
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnGioHang.Height;
            SlidePanel.Top = btnGioHang.Top;
            gioHang1.BringToFront();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int n = 0;
            DataTable dt = new DataTable();
            dt = bll.KiemTraSP();
            n = dt.Rows.Count;
            if (n == 0)
            {
                MessageBox.Show("Giỏ hàng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SlidePanel.Height = btnThanhToan.Height;
                SlidePanel.Top = btnThanhToan.Top;
                thanhToan1.BringToFront();
            }
        }

        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnPhanHoi.Height;
            SlidePanel.Top = btnPhanHoi.Top;
            phanHoi1.BringToFront();
        }
    }
}
