using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class CongViecTraCuu_Dao
    {
        GTVL_Model1 db = null;
        public CongViecTraCuu_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomCongViecTraCuu> ListAll()
        {
            var congviectracuu = db.Database.SqlQuery<CustomCongViecTraCuu>("TraCuuCongViec_SyPham").ToList();
            return congviectracuu;
        }
    }
}
