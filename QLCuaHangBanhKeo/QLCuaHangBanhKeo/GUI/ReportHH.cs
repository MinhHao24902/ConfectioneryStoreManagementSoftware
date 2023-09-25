using Microsoft.Reporting.WinForms;
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
    public partial class ReportHH : Form
    {
        public ReportHH()
        {
            InitializeComponent();
        }

        private void ReportHH_Load(object sender, EventArgs e)
        {
            QuanLyCuaHangBanhKeo manageCuaHang = new QuanLyCuaHangBanhKeo();
            List<MatHang> listhh = manageCuaHang.MatHangs.ToList(); //Bên trong database mà mình đã thêm vào
            List<CTHangHoa> listreport = new List<CTHangHoa>();
            foreach (MatHang hh in listhh)
            {
                CTHangHoa temp = new CTHangHoa(); //DTO (class của đối tượng)
                temp.MaHang = hh.MAHANG;
                temp.TenHang = hh.TENHANG;
                temp.SoLuong = hh.SOLUONG;
                temp.NhaSX = hh.NHASX;
                temp.NgaySX = DateTime.Parse(hh.NGAYSANXUAT.ToString());
                temp.NgayHH = DateTime.Parse(hh.NGAYHETHAN.ToString());
                temp.Gia = hh.GIA;
                temp.MoTa = hh.MOTA;

                listreport.Add(temp);
            }
            reportViewer1.LocalReport.ReportPath = "D:/DaiHoc/QuanLyCuaHangBanhKeo/QLCuaHangBanhKeo/QLCuaHangBanhKeo/Report/ReportHangHoa.rdlc"; //file rdlc Report
            var source = new ReportDataSource("DataSet1", listreport); // phải đúng tên DataSet (Phân biệt chữ hoa và thường)
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}
