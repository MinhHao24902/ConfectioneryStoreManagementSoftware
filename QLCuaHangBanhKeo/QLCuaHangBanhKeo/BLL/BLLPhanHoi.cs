using QLCuaHangBanhKeo.DAL;
using QLCuaHangBanhKeo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangBanhKeo.BLL
{
    public class BLLPhanHoi
    {
        DALPhanHoi dal = new DALPhanHoi();
        public bool Add(CTPhanHoi ph)
        {
            try
            {
                return dal.Add(ph);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
