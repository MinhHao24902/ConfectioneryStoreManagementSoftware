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
    public class DALTaiKhoan
    {
        DataHelper helper = new DataHelper();

        public DataTable KiemTraTaiKhoan(CTTaiKhoan tk)
        {
            string query = string.Format("SELECT * FROM TaiKhoan WHERE TENTAIKHOAN LIKE N'{0}' and MATKHAU LIKE N'{1}' and QUYEN LIKE N'{2}'", tk.TenTaiKhoan, tk.MatKhau, tk.MaQuyen);
            DataTable tb = helper.ExecuteQuery(query);
            try
            {
                return tb;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GetMaTaiKhoanFromDataRow(DataRow row)
        {
            string text;
            text = row["MATAIKHOAN"].ToString().Trim();

            return text;
        }
        public string GetTenTaiKhoan(CTTaiKhoan tk)
        {
            string MaTK;
            string query = string.Format("SELECT MATAIKHOAN FROM TAIKHOAN WHERE TENTAIKHOAN LIKE '{0}'", tk.TenTaiKhoan);

            DataTable dt = new DataTable();
            dt = helper.ExecuteQuery(query);
            MaTK = GetMaTaiKhoanFromDataRow(dt.Rows[0]);

            try
            {
                helper.ExecuteNonQuery(query);
                return MaTK;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
