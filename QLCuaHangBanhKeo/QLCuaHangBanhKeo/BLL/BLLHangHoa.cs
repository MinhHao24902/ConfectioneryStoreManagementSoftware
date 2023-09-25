using QLCuaHangBanhKeo.DAL;
using QLCuaHangBanhKeo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangBanhKeo.BLL
{
    public class BLLHangHoa
    {
        DALHangHoa dal = new DALHangHoa();

        public CTHangHoa[] GetList()
        {
            return dal.GetList();
        }
        public bool Add(CTHangHoa hanghoa)
        {
            try
            {
                return dal.Add(hanghoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Remove(string mh)
        {
            try
            {
                return dal.Remove(mh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(CTHangHoa hanghoa)
        {
            try
            {
                return dal.Update(hanghoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
