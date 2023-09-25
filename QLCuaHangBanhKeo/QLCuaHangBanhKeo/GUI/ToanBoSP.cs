using QLCuaHangBanhKeo.BLL;
using QLCuaHangBanhKeo.DAL;
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
    public partial class ToanBoSP : UserControl
    {
        BLLGioHang bll = new BLLGioHang();
        string mh;
        public ToanBoSP()
        {
            InitializeComponent();
        }

        private void MH01_Click(object sender, EventArgs e)
        {
            mh = MH01.Name;

            try
            {
                bll.Add(mh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // show error if failed
            }
        }

        private void MH02_Click_1(object sender, EventArgs e)
        {
            mh = MH02.Name;

            try
            {
                bll.Add(mh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // show error if failed
            }
        }

        private void MH03_Click(object sender, EventArgs e)
        {
            mh = MH03.Name;

            try
            {
                bll.Add(mh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // show error if failed
            }
        }

        private void MH04_Click(object sender, EventArgs e)
        {
            mh = MH04.Name;

            try
            {
                bll.Add(mh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // show error if failed
            }
        }

        private void MH05_Click(object sender, EventArgs e)
        {
            mh = MH05.Name;

            try
            {
                bll.Add(mh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // show error if failed
            }
        }

        private void MH06_Click(object sender, EventArgs e)
        {
            mh = MH06.Name;

            try
            {
                bll.Add(mh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // show error if failed
            }
        }
    }
}
