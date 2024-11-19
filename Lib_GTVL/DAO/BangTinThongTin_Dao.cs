using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class BangTinThongTin_Dao
    {
        GTVL_Model1 db = null;

        public BangTinThongTin_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomBangTinThongTin> ListAll()
        {
            var bangtinthongtin = db.Database.SqlQuery<CustomBangTinThongTin>("BangTinThongTin_SyPham").ToList();
            return bangtinthongtin;
        }
    }
}
