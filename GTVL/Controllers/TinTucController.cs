using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GTVL.Controllers
{
    public class TinTucController : HomeController
    {
        // GET: TinTuc
        [ActionName("TinTucIndex")]
        public ActionResult Index()
        {
            return View();
        }
    }
}