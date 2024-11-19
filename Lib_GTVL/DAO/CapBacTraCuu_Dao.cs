using Lib_GTVL.CustomModel;
using Lib_GTVL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.DAO
{
    public class CapBacTraCuu_Dao
    {
        GTVL_Model1 db = null;
        public CapBacTraCuu_Dao() {
            db = new GTVL_Model1();
        }
        public List<CustomCapBacTraCuu> ListAll()
        {
            var capbactracuu = db.Database.SqlQuery<CustomCapBacTraCuu>("TraCuuCapBac_SyPham").ToList();
            return capbactracuu;
        }
    }
}
