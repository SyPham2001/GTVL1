using System;
using System.Web.Mvc;
using Lib_GTVL.DAO;
using Lib_GTVL.CustomModel;

namespace GTVL.Controllers
{
    public class TuyenDungController : HomeController
    {
        public ViecLamMoiNhat_Dao vlmn = new ViecLamMoiNhat_Dao();

        [ActionName("TuyenDungIndex")]
        public ActionResult Index(int? page)
        {
            
            //int pageNumber = page ?? 1;

           
            //var searchParameter = new DoanhNghiep_TuyenDung_SearchParameter
            //{
            //    TieuDeTuyenDung = "",
            //    KhuVuc = "",
            //    MucLuong = "",
            //    TrinhDo = "",
            //    NgoaiNgu = "",
            //    TinHoc = "",
            //    GioiTinh = "",
            //    NganhNghe34 = "",
            //    SelectTop = 20 // Giới hạn số lượng kết quả
            //};

      
            //var viecLamMoiNhat = vlmn.ListAll_20(searchParameter, pageNumber);

         
            //ViewBag.vlmn = viecLamMoiNhat;

            return View();
        }
    }
}
