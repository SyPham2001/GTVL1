using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class DiaDiemTraCuu_Dao
    {
        GTVL_Model1 db = null;
        public DiaDiemTraCuu_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomDiaDiemTraCuu> ListAll()
        {
            var diadiemtracuu = db.Database.SqlQuery<CustomDiaDiemTraCuu>("DiaDiemTraCuu_SyPham").ToList();
            return diadiemtracuu;
        }
    }
}
