using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class NganhNgheTraCuu_Dao
    {
        GTVL_Model1 db = null;
        public NganhNgheTraCuu_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomNganhNgheTraCuu> ListAll()
        {
            var nganhnghetracuu = db.Database.SqlQuery<CustomNganhNgheTraCuu>("NganhNgheTraCuu_SyPham").ToList();
            return nganhnghetracuu;
        }
    }
}
