using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class MucLuongTraCuu_Dao
    {
        GTVL_Model1 db = null;
        public MucLuongTraCuu_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomMucLuongTraCuu> LisAll()
        {
            var mucluongtracuu = db.Database.SqlQuery<CustomMucLuongTraCuu>("MucLuongTraCuu_SyPham").ToList();
            return mucluongtracuu;
        }
    }
}
