using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_GTVL.EF;
using Lib_GTVL.CustomModel;
namespace Lib_GTVL.DAO
{
    public class HoSoUngVienKinhNghiem_Dao
    {
        GTVL_Model1 db = null;

        public HoSoUngVienKinhNghiem_Dao()
        {
            db = new GTVL_Model1();
        }

        public List<CustomHoSoUngVien> ListAll()
        {
            db.Database.CommandTimeout = 180;
            var hoSoUngVienKinhNghiem = db.Database.SqlQuery<CustomHoSoUngVien>("HoSoUngVienKinhNghiem_Sy").ToList();
            return hoSoUngVienKinhNghiem;
        }
    }
}
