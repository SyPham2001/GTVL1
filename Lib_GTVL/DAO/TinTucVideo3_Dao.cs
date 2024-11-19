using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_GTVL.EF;
using Lib_GTVL.CustomModel;


namespace Lib_GTVL.DAO
{
    public class TinTucVideo3_Dao
    {
        GTVL_Model1 db = null;
        public TinTucVideo3_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomBangTinThongTin> ListAll()
        {
            var tintucvideo3 = db.Database.SqlQuery<CustomBangTinThongTin>("TinTucVideo3_SyPham").ToList();
            return tintucvideo3;
        }
    }
}
