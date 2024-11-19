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

        [ActionName("UngVienIndex")]
        public ActionResult Index(int? page)
        {

           
            return View();
        }
    }
}