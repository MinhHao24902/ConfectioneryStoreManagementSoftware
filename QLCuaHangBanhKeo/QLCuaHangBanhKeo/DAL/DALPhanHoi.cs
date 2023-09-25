using QLCuaHangBanhKeo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangBanhKeo.DAL
{
    public class DALPhanHoi
    {
        DataHelper helper = new DataHelper();
        public bool Add(CTPhanHoi ph)
        {
            string query = string.Format("INSERT INTO PhanHoi Values (N'{0}',N'{1}',N'{2}')", ph.HoTen, ph.Email, ph.NoiDung);

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
