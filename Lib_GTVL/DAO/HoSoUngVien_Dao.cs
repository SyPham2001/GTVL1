using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_GTVL.EF;
using Lib_GTVL.CustomModel;
using PagedList;
namespace Lib_GTVL.DAO
{
    public class HoSoUngVien_Dao
    {
        GTVL_Model1 db = null;

        public HoSoUngVien_Dao()
        {
            db = new GTVL_Model1();
        }

        public IPagedList<CustomHoSoUngVien> ListAll(int page = 1, int pageSize = 10)
        {
            db.Database.CommandTimeout = 180;
            var hoSoUngVien = db.Database.SqlQuery<CustomHoSoUngVien>("HoSoUngVien_MinhHung");

            // Kiểm tra null
            if (hoSoUngVien == null)
            {
                return new StaticPagedList<CustomHoSoUngVien>(new List<CustomHoSoUngVien>(), page, pageSize, 0);
            }

            return hoSoUngVien.ToPagedList(page, pageSize);
        }


    }
}
