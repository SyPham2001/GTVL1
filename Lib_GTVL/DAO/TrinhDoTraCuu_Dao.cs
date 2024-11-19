using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class TrinhDoTraCuu_Dao
    {
        GTVL_Model1 db = null;
        public TrinhDoTraCuu_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomTrinhDoTraCuu> LisAll()
        {
            var trinhdotracuu = db.Database.SqlQuery<CustomTrinhDoTraCuu>("TrinhDoTraCuu_SyPham").ToList();
            return trinhdotracuu;
        }
    }
}
