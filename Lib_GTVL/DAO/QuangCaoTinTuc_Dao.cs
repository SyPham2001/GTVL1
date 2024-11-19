using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class QuangCaoTinTuc_Dao
    {
        GTVL_Model1 db = null;
        public QuangCaoTinTuc_Dao()
        {
            db = new GTVL_Model1();
        }

        public List<CustomQuangCaoTinTuc> ListAll_Slide()
        {
            var QuangCaoTinTuc = db.Database.SqlQuery<CustomQuangCaoTinTuc>("TinTucQuangCao10_SyPham").ToList();
            return QuangCaoTinTuc;
        }
    }
}
