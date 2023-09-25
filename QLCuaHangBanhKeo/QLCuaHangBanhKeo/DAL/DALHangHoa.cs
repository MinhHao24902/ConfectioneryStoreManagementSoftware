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
    public class DALHangHoa
    {
        DataHelper helper = new DataHelper();
        SqlCommand cmd = new SqlCommand();

        private CTHangHoa GetHangHoaFromDataRow(DataRow row)
        {
            CTHangHoa hh = new CTHangHoa();
            //int.Parse(row["MaHang"].ToString());

            hh.MaHang = row["MaHang"].ToString().Trim();
            hh.TenHang = row["TenHang"].ToString().Trim();
            hh.NhaSX = row["NhaSX"].ToString().Trim();
            hh.SoLuong = int.Parse(row["SoLuong"].ToString());
            hh.NgaySX = DateTime.Parse(row["NgaySanXuat"].ToString());
            hh.NgayHH = DateTime.Parse(row["NgayHetHan"].ToString());
            hh.DVT = row["DonViTinh"].ToString().Trim();
            hh.Gia = row["Gia"].ToString().Trim();
            hh.MoTa = row["MoTa"].ToString().Trim();

            return hh;
        }


        public CTHangHoa[] GetList()
        {
            CTHangHoa[] list = null;
            DataTable table = null;
            int n = 0;

            table = helper.ExecuteQuery("select * from MatHang");
            n = table.Rows.Count;

            if (n == 0)
            {
                return null;
            }

            list = new CTHangHoa[n];
            for (int i = 0; i < n; i++)
            {
                CTHangHoa s = GetHangHoaFromDataRow(table.Rows[i]);
                list[i] = s;
            }

            return list;
        }
        public bool Add(CTHangHoa hh)
        {
            string query = string.Format("INSERT INTO MatHang(MAHANG, TENHANG, NHASX, SOLUONG, NGAYSANXUAT, NGAYHETHAN, DONVITINH, GIA, MOTA) VALUES (@MAHANG, @TENHANG, @NHASX, @SOLUONG, @NGAYSANXUAT, @NGAYHETHAN, @DONVITINH, @GIA, @MOTA)");
            SqlConnection con = helper.getConnect();


            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MAHANG", SqlDbType.NVarChar).Value = hh.MaHang;
                cmd.Parameters.Add("@TENHANG", SqlDbType.NVarChar).Value = hh.TenHang;
                cmd.Parameters.Add("@NHASX", SqlDbType.NVarChar).Value = hh.NhaSX;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = hh.SoLuong;
                cmd.Parameters.Add("@NGAYSANXUAT", SqlDbType.Date).Value = hh.NgaySX;
                cmd.Parameters.Add("@NGAYHETHAN", SqlDbType.Date).Value = hh.NgayHH;
                cmd.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = hh.DVT;
                cmd.Parameters.Add("@GIA", SqlDbType.NVarChar).Value = hh.Gia;
                cmd.Parameters.Add("@MOTA", SqlDbType.NVarChar).Value = hh.MoTa;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool Update(CTHangHoa hanghoa)
        {
            string query = string.Format("UPDATE MatHang SET MAHANG = @MAHANG, TENHANG = @TENHANG, NHASX = @NHASX, SOLUONG = @SOLUONG, NGAYSANXUAT = @NGAYSANXUAT, NGAYHETHAN = @NGAYHETHAN, DONVITINH = @DONVITINH, GIA = @GIA, MOTA = @MOTA WHERE MAHANG LIKE @MAHANG");
            SqlConnection con = helper.getConnect();


            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MAHANG", SqlDbType.NVarChar).Value = hanghoa.MaHang;
                cmd.Parameters.Add("@TENHANG", SqlDbType.NVarChar).Value = hanghoa.TenHang;
                cmd.Parameters.Add("@NHASX", SqlDbType.NVarChar).Value = hanghoa.NhaSX;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = hanghoa.SoLuong;
                cmd.Parameters.Add("@NGAYSANXUAT", SqlDbType.Date).Value = hanghoa.NgaySX;
                cmd.Parameters.Add("@NGAYHETHAN", SqlDbType.Date).Value = hanghoa.NgayHH;
                cmd.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = hanghoa.DVT;
                cmd.Parameters.Add("@GIA", SqlDbType.NVarChar).Value = hanghoa.Gia;
                cmd.Parameters.Add("@MOTA", SqlDbType.NVarChar).Value = hanghoa.MoTa;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Remove(string mh)
        {
            string query = string.Format("DELETE FROM MatHang WHERE MaHang like N'{0}'", mh);

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
    }
}
