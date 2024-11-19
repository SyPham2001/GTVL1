using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lib_GTVL.DAO;
using System.Data.Entity;
using Lib_GTVL.EF;


namespace GTVL.Controllers
{

    public class TuyenDungController : HomeController
    {
        [ActionName("TuyenDungIndex")]
        public ActionResult Index()
        {
            return View();
        }
    }
}