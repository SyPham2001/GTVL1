using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class TuVanQuangCao_Dao
    {
        GTVL_Model1 db = null;

        public TuVanQuangCao_Dao()
        {
            db = new GTVL_Model1();
        }

        public List<CustomTuVanQuangCao> ListAll()
        {
            var tuvanquangcao = db.Database.SqlQuery<CustomTuVanQuangCao>("TuVanQuangCao_SyPham").ToList();

            return tuvanquangcao;
        }
    }
}
