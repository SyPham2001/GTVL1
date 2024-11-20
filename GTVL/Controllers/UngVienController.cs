
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lib_GTVL.DAO;
using System.Data.Entity;
using Lib_GTVL.EF;
using PagedList;

namespace GTVL.Controllers
{
    public class UngVienController : HomeController
    {
        public HoSoUngVien_Dao hsuv = new HoSoUngVien_Dao();
        [ActionName("UngVienIndex")]
        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            var hsuv_1 = hsuv.ListAll(pageNumber, pageSize);
            
            return View(hsuv_1);
        }
    }
}