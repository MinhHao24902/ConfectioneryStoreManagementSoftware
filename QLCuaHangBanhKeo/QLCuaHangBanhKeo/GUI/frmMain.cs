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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuWeb_Click(object sender, EventArgs e)
        {
            frmWeb Add = new frmWeb();
            Add.ShowDialog();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            frmLogin Add = new frmLogin();
            Add.ShowDialog();
        }

        private void mnuCommodity_Click(object sender, EventArgs e)
        {
            frmHangHoa Add = new frmHangHoa();
            Add.ShowDialog();
        }

        private void mnuEmployee_Click(object sender, EventArgs e)
        {
            frmNhanVien Add = new frmNhanVien();
            Add.ShowDialog();
        }

        private void mnuGuest_Click(object sender, EventArgs e)
        {
            frmKhachHang Add = new frmKhachHang();
            Add.ShowDialog();
        }

        private void mnuSupplier_Click(object sender, EventArgs e)
        {
            frmNhaCungCap Add = new frmNhaCungCap();
            Add.ShowDialog();
        }

        private void mnuImport_Click(object sender, EventArgs e)
        {
            frmNhapHang Add = new frmNhapHang();
            Add.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            frmLogin Add = new frmLogin();
            Add.ShowDialog();
        }
    }
}
