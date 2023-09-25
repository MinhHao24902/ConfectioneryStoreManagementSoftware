using QLCuaHangBanhKeo.BLL;
using QLCuaHangBanhKeo.DTO;
using QLCuaHangBanhKeo.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanhKeo
{
    public partial class frmLogin : Form
    {
        BLLTaiKhoan bll = new BLLTaiKhoan();
        BLLGioHang bllGH = new BLLGioHang();
        CTGioHang ct = new CTGioHang();
        public frmLogin()
        {
            InitializeComponent();
        }

        CTTaiKhoan GetTaiKhoanInfo()
        {
            CTTaiKhoan tk = new CTTaiKhoan();

            tk.TenTaiKhoan = txtTaiKhoan.Text.Trim();
            tk.MatKhau = txtMatKhau.Text.Trim();
            if (chkKhach.Checked)
                tk.MaQuyen = 0;
            else
                tk.MaQuyen = 1;

            return tk;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.KiemTraTaiKhoan(GetTaiKhoanInfo());
            CTTaiKhoan tk = GetTaiKhoanInfo();

            int count = dt.Rows.Count;

            if (count > 0 && chkKhach.Checked)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bll.GetTenTaiKhoan(tk);
                //MessageBox.Show(ct.MaTaiKhoan = bll.GetTenTaiKhoan(tk));
                ct.MaTaiKhoan = bll.GetTenTaiKhoan(tk);
                bllGH.RemoveALL();
                this.Hide();
                frmSanPham sp = new frmSanPham(txtTaiKhoan.Text);
                sp.ShowDialog();
            }
            else if (count > 0 && chkQuanTri.Checked)
            {
                MessageBox.Show("Chào mừng quản trị viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMain main = new frmMain();
                main.ShowDialog();
            }
            else if (count == 0 && chkKhach.Checked || count == 0 && chkQuanTri.Checked)
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (chkQuanTri.Checked == false && chkKhach.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn quyền và thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void KiemTraCheck()
        {
            if (chkQuanTri.Checked && chkKhach.Checked)
            {
                MessageBox.Show("Vui lòng chỉ chọn 1 quyền thôi ạ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkKhach.Checked = false;
                chkQuanTri.Checked = false;
            }
        }
        private void chkKhach_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraCheck();
        }

        private void chkQuanTri_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraCheck();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            this.txtMatKhau.PasswordChar = '*';
        }
    }
}
