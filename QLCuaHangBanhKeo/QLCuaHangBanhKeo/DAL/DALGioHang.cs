using QLCuaHangBanhKeo.BLL;
using QLCuaHangBanhKeo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangBanhKeo.DAL
{
    public class DALGioHang
    {
        DataHelper helper = new DataHelper();

        private CTGioHang GetSanPhamFromDataRow(DataRow row)
        {
            CTGioHang gh = new CTGioHang();

            gh.STT = int.Parse(row["STT"].ToString());
            gh.MaHang = row["MaHang"].ToString().Trim();
            gh.MaTaiKhoan = row["MaTaiKhoan"].ToString().Trim();
            gh.TenHang = row["TenHang"].ToString().Trim();
            gh.SoLuong = int.Parse(row["SoLuong"].ToString());
            gh.TongTien = row["TongTien"].ToString().Trim();

            return gh;
        }

        private string GetTextFromDataRow(DataRow row)
        {
            string text;
            text = row["TONGTIEN"].ToString().Trim();

            return text;
        }
        public CTGioHang[] GetList()
        {
            //MaTK = GetMaTK; // Cần lấy Mã tài khoản khi đăng nhập vào
            CTGioHang[] list = null;
            DataTable table = null;
            int n = 0;

            table = helper.ExecuteQuery("select * from GioHang");
            n = table.Rows.Count;

            if (n == 0)
            {
                return null;
            }

            list = new CTGioHang[n];
            for (int i = 0; i < n; i++)
            {
                CTGioHang s = GetSanPhamFromDataRow(table.Rows[i]);
                list[i] = s;
            }

            return list;
        }
        public DataTable KiemTraSP()
        {
            DataTable dt = new DataTable();
            dt = helper.ExecuteQuery("select * from GioHang");
            return dt;
        }

        public bool Add(string giohang)
        {
            //and kh.MATAIKHOAN Like '{1}'
            //string query = string.Format("INSERT INTO GioHang SELECT mh.MAHANG, kh.MaTaiKhoan, mh.TENHANG, mh.SOLUONG - (SOLUONG - 1), mh.GIA FROM MatHang mh, KhachHang kh  WHERE MAHANG = '{0}' and kh.MATAIKHOAN Like 'TK02'", giohang);
            string query = string.Format("INSERT INTO GioHang SELECT mh.MAHANG, kh.MaTaiKhoan, mh.TENHANG, mh.SOLUONG - (SOLUONG - 1), mh.GIA FROM MatHang mh, KhachHang kh  WHERE MAHANG = '{0}'", giohang);
            try
            {
                helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remove(int stt)
        {
            string query = string.Format("DELETE FROM GioHang WHERE STT = '{0}'", stt);

            try
            {
                helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveALL()
        {
            string query = string.Format("DELETE FROM GioHang");

            try
            {
                helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string SumTOTAL()
        {
            string total;
            string query = string.Format("SELECT SUM(CAST(TONGTIEN AS INT)) AS TONGTIEN FROM Giohang");

            DataTable dt = new DataTable();
            dt = helper.ExecuteQuery(query);
            total = GetTextFromDataRow(dt.Rows[0]);

            try
            {
                helper.ExecuteNonQuery(query);
                return total;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
