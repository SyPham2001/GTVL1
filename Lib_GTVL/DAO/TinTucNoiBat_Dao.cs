using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_GTVL.EF;
using Lib_GTVL.CustomModel;

namespace Lib_GTVL.DAO
{
    public class TinTucNoiBat_Dao
    {
        GTVL_Model1 db = null;
         public TinTucNoiBat_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomSlideTinHot4Model> ListAll()
        {
            var tintucnoibat = db.Database.SqlQuery<CustomSlideTinHot4Model>("TinTucNoiBat_Sy").ToList();
            return tintucnoibat;
        }
    }
}
