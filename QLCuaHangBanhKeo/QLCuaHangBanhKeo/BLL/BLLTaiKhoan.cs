using QLCuaHangBanhKeo.DAL;
using QLCuaHangBanhKeo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangBanhKeo.BLL
{
    public class BLLTaiKhoan
    {
        DALTaiKhoan dal = new DALTaiKhoan();
        public DataTable KiemTraTaiKhoan(CTTaiKhoan tk)
        {
            return dal.KiemTraTaiKhoan(tk);
        }

        public string GetTenTaiKhoan(CTTaiKhoan tk)
        {
            try
            {
                return dal.GetTenTaiKhoan(tk);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
