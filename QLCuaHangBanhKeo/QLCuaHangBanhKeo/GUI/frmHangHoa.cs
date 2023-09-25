using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLCuaHangBanhKeo.BLL;
using QLCuaHangBanhKeo.DTO;
using QLCuaHangBanhKeo.GUI;

namespace QLCuaHangBanhKeo
{
    public partial class frmHangHoa : Form
    {
        BLLHangHoa bll = new BLLHangHoa();
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dateNgaySX.Value = DateTime.Today;
            dateNgayHH.Value = DateTime.Today;
            LoadHangHoa();
        }

        private void LoadHangHoa()
        {
            dgvMatHang.DataSource = bll.GetList();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc là bạn muốn đóng ứng dụng ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Application.Exit();
        }
        CTHangHoa GetHangHoaInfo()
        {
            CTHangHoa hh = new CTHangHoa();

            hh.MaHang = txtMaHang.Text.Trim();
            hh.TenHang = txtTenHang.Text.Trim();
            hh.NhaSX = txtNhaSX.Text.Trim();
            hh.SoLuong = Convert.ToInt32(txtSoLuong.Text.Trim());
            hh.NgaySX = dateNgaySX.Value;
            hh.NgayHH = dateNgayHH.Value;
            hh.DVT = txtDVT.Text.Trim();
            hh.Gia = txtGia.Text.Trim();
            hh.MoTa = txtMota.Text.Trim();

            return hh;
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaHang.Text = dgvMatHang.Rows[index].Cells["ColMaHang"].Value.ToString();
                txtTenHang.Text = dgvMatHang.Rows[index].Cells["ColTenHang"].Value.ToString();
                txtNhaSX.Text = dgvMatHang.Rows[index].Cells["ColNhaSX"].Value.ToString();
                txtSoLuong.Text = dgvMatHang.Rows[index].Cells["ColSoLuong"].Value.ToString();
                dateNgaySX.Value = DateTime.Parse(dgvMatHang.Rows[index].Cells["ColNgaySX"].Value.ToString());
                dateNgayHH.Value = DateTime.Parse(dgvMatHang.Rows[index].Cells["ColNgayHH"].Value.ToString());
                txtDVT.Text = dgvMatHang.Rows[index].Cells["ColDVT"].Value.ToString();
                txtGia.Text = dgvMatHang.Rows[index].Cells["ColGia"].Value.ToString();
                txtMota.Text = dgvMatHang.Rows[index].Cells["ColMota"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CTHangHoa hh = GetHangHoaInfo(); // get info from controls

            if (CheckData())
            {
                try
                {
                    if (bll.Add(hh))
                    {
                        LoadHangHoa();

                        txtMaHang.Clear();    // clear text
                        txtTenHang.Clear();
                        txtNhaSX.Clear();
                        txtSoLuong.Clear();
                        dateNgaySX.Value = DateTime.Today;
                        dateNgayHH.Value = DateTime.Today;
                        txtDVT.Clear();
                        txtGia.Clear();
                        txtMota.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    // show error if failed
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                try
                {
                    CTHangHoa hh = new CTHangHoa();
                    hh.MaHang = txtMaHang.Text;
                    hh.TenHang = txtTenHang.Text;
                    hh.NhaSX = txtNhaSX.Text;
                    hh.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    hh.NgaySX = dateNgaySX.Value;
                    hh.NgayHH = dateNgayHH.Value;
                    hh.DVT = txtDVT.Text;
                    hh.Gia = txtGia.Text;
                    hh.MoTa = txtMota.Text;

                    if (bll.Update(hh))
                        LoadHangHoa();
                    else
                        MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    // show error if failed
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            CTHangHoa hh = new CTHangHoa(); // get info from controls

            hh.MaHang = txtMaHang.Text;
            //MessageBox.Show(hh.MaHang);   
            if (CheckData())
            {
                try
                {
                    if (bll.Remove(hh.MaHang))
                    {
                        LoadHangHoa();

                        txtMaHang.Clear();    // clear text
                        txtTenHang.Clear();
                        txtNhaSX.Clear();
                        txtSoLuong.Clear();
                        dateNgaySX.Value = DateTime.Today;
                        dateNgayHH.Value = DateTime.Today;
                        txtDVT.Clear();
                        txtGia.Clear();
                        txtMota.Clear();
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    // show error if failed
                }
            }   
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMaHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNhaSX.Text))
            {
                MessageBox.Show("Bạn chưa nhập nhà sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhaSX.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dateNgaySX.Text))
            {
                MessageBox.Show("Bạn chưa nhập đến giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgaySX.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dateNgayHH.Text))
            {
                MessageBox.Show("Bạn chưa nhập người đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgayHH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDVT.Text))
            {
                MessageBox.Show("Bạn chưa nhập lý do!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDVT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập lý do!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMota.Text))
            {
                MessageBox.Show("Bạn chưa nhập lý do!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMota.Focus();
                return false;
            }
            return true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ReportHH rp = new ReportHH();
            rp.ShowDialog();
        }
    }
}
