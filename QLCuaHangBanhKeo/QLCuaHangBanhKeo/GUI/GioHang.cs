using QLCuaHangBanhKeo.BLL;
using QLCuaHangBanhKeo.DTO;
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
    public partial class GioHang : UserControl
    {
        BLLGioHang bll = new BLLGioHang();
        int stt;
        public GioHang()
        {
            InitializeComponent();
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while loading data",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        void LoadData()
        {
            dgvGioHang.DataSource = bll.GetList();
            txtTongTien.Text = bll.SumTOTAL();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                stt = Int32.Parse(dgvGioHang.Rows[index].Cells["ColSTT"].Value.ToString());
            }
        }

        private void btnXoaDaChon_Click(object sender, EventArgs e)
        {
            CTGioHang gh = new CTGioHang();

            gh.STT = stt;
            try
            {
                if (bll.Remove(gh.STT))
                {
                    LoadData();
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // show error if failed
            }
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (bll.RemoveALL())
                {
                    LoadData();
                    MessageBox.Show("Đã xoá toàn bộ sản phẩm", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // show error if failed
            }
        }
    }
}
