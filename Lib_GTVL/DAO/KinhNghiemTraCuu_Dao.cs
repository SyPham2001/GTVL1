using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class KinhNghiemTraCuu_Dao
    {
        GTVL_Model1 db = null;
        public KinhNghiemTraCuu_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomKinhNghiemTraCuu> ListAll()
        {
            var kinhnghiemtracuu = db.Database.SqlQuery<CustomKinhNghiemTraCuu>("TraCuuKinhNghiem_SyPham").ToList();
            return kinhnghiemtracuu;
        }
    }
}
