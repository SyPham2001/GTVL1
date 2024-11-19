using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class TuVanQuangCao1_Dao
    {
        GTVL_Model1 db = null;

        public TuVanQuangCao1_Dao()
        {
            db = new GTVL_Model1();
        }

        public List<CustomTuVanQuangCao1> ListAll()
        {
            var tuvanquangcao1 = db.Database.SqlQuery<CustomTuVanQuangCao1>("TuVanQuangCao1_SyPham").ToList();

            return tuvanquangcao1;
        }
    }
}
