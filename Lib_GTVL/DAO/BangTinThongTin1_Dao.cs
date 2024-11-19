using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class BangTinThongTin1_Dao
    {
        GTVL_Model1 db = null;
        public BangTinThongTin1_Dao()
        {
            db = new GTVL_Model1();
        }

        public List <CustomBangTinThongTin1> ListAll()
        {
            var bangtinthongtin1 = db.Database.SqlQuery<CustomBangTinThongTin1>("BangTinThongTin1_SyPham").ToList();
            return bangtinthongtin1;
        }
    }
}
