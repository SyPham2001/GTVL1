using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_GTVL.EF;
using Lib_GTVL.CustomModel;


namespace Lib_GTVL.DAO
{
    public class CamNangViecLam_Dao
    {
        GTVL_Model1 db = null;
        public CamNangViecLam_Dao()
        {
            db = new GTVL_Model1();
        }
        public List<CustomSlideTinHot4Model> ListAll()
        {
            var camnangvieclam = db.Database.SqlQuery<CustomSlideTinHot4Model>("CamNangViecLam_Sy").ToList();
            return camnangvieclam;
        }
    }
}
