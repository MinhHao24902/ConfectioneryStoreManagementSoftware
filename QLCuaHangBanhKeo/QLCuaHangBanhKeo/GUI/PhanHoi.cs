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
    public partial class PhanHoi : UserControl
    {
        BLLPhanHoi bll = new BLLPhanHoi();
        public PhanHoi()
        {
            InitializeComponent();
        }

        CTPhanHoi GetPhanHoiInfo()
        {
            CTPhanHoi ph = new CTPhanHoi();

            ph.HoTen = txtHoTen.Text.Trim();
            ph.Email = txtEmail.Text.Trim();
            ph.NoiDung = txtNoiDung.Text.Trim();

            return ph;
        }

        private void btnTraSau_Click(object sender, EventArgs e)
        {
            CTPhanHoi ph = GetPhanHoiInfo(); // get info from controls

            try
            {
                if (bll.Add(ph))
                {

                    txtHoTen.Clear();
                    txtEmail.Clear();
                    txtNoiDung.Clear();
                    MessageBox.Show("Phản hồi thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
