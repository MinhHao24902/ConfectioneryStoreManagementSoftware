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
    public partial class ThanhToan : UserControl
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void btnTraOnline_Click(object sender, EventArgs e)
        {
            frmThanhToanOnline tt = new frmThanhToanOnline();
            tt.ShowDialog();
        }
    }
}
