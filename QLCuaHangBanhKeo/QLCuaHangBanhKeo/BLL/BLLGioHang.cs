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
    public class BLLGioHang
    {
        DALGioHang dal = new DALGioHang();

        public CTGioHang[] GetList()
        {
            return dal.GetList();
        }
        public bool Add(string giohang)
        {
            try
            {
                return dal.Add(giohang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Remove(int stt)
        {
            try
            {
                return dal.Remove(stt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveALL()
        {
            try
            {
                return dal.RemoveALL();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string SumTOTAL()
        {
            try
            {
                return dal.SumTOTAL();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable KiemTraSP()
        {
            try
            {
                return dal.KiemTraSP();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
