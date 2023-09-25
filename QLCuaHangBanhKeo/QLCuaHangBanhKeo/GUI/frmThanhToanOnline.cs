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
    public partial class frmThanhToanOnline : Form
    {
        public frmThanhToanOnline()
        {
            InitializeComponent();
        }

        private void btnMOMO_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMomo momo = new frmMomo();
            momo.ShowDialog();
        }
    }
}
