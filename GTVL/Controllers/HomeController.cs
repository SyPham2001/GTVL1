using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lib_GTVL.DAO;
using System.Data.Entity;
using Lib_GTVL.EF;
using Lib_GTVL.CustomModel;

namespace GTVL.Controllers
{
    public class HomeController : Controller
    {
        public News_Dao newsdao = new News_Dao();
        public Slide_TinTuc_Dao tintuc_8 = new Slide_TinTuc_Dao();
        public Slide_Tin_HotDao tinhot_4 = new Slide_Tin_HotDao();
        public Slides_Dao slidemain = new Slides_Dao();

        public ViecLamMoiNhat_Dao vieclammoi = new ViecLamMoiNhat_Dao();
        public HoSoUngVien_Dao hosoungvien = new HoSoUngVien_Dao();
        public QuangCaoTinTuc_Dao QuangCaoTinTuc = new QuangCaoTinTuc_Dao();
        public TuVanQuangCao_Dao TuVanQuangCao = new TuVanQuangCao_Dao();
        public TuVanQuangCao1_Dao TuVanQuangCao1 = new TuVanQuangCao1_Dao();
        public BangTinThongTin1_Dao BangTinThongTin1 = new BangTinThongTin1_Dao();
        public BangTinThongTin_Dao BangTinThongTin = new BangTinThongTin_Dao();
        public NganhNgheTraCuu_Dao NganhNgheTraCuu = new NganhNgheTraCuu_Dao();
        public DiaDiemTraCuu_Dao DiaDiemTraCuu = new DiaDiemTraCuu_Dao();
        public MucLuongTraCuu_Dao MucLuongTraCuu = new MucLuongTraCuu_Dao();
        public CapBacTraCuu_Dao CapBacTracuu = new CapBacTraCuu_Dao();
        public CongViecTraCuu_Dao CongViecTraCuu = new CongViecTraCuu_Dao();
        public KinhNghiemTraCuu_Dao KinhNghiemTraCuu = new KinhNghiemTraCuu_Dao();
        public TinTucNoiBat_Dao TinTucNoiBat = new TinTucNoiBat_Dao();
        public TinTucVideo3_Dao TinTucVideo = new TinTucVideo3_Dao();
        public CamNangViecLam_Dao CamNangViecLam = new CamNangViecLam_Dao();
        public TrinhDoTraCuu_Dao TrinhDoTraCuu = new TrinhDoTraCuu_Dao();

        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            var hosoungvien_12 = hosoungvien.ListAll(pageNumber, pageSize);
            ViewBag.hosoungvien = hosoungvien_12;

            //nganh nghe tra cuu    
            var nganhnghetracuu = NganhNgheTraCuu.ListAll();
            ViewBag.NganhNgheTraCuu = nganhnghetracuu;
            // dia điểm tra cứu
            var diadiemtracuu = DiaDiemTraCuu.ListAll();
            ViewBag.DiaDiemTraCuu = diadiemtracuu;

            //muc luong tra cuu
            var mucluongtracuu = MucLuongTraCuu.LisAll();
            ViewBag.MucLuongTraCuu = mucluongtracuu;

            // cap bac tra cuu
            var capbactracuu = CapBacTracuu.ListAll();
            ViewBag.CapBacTraCuu = capbactracuu;

            //loai hinh cong viec tra cuu
            var congviectracuu = CongViecTraCuu.ListAll();
            ViewBag.CongViecTraCuu = congviectracuu;


            // kinh nghiem tra cuu
            var kinhnghiemtracuu = KinhNghiemTraCuu.ListAll();
            ViewBag.KinhNghiemtraCuu = kinhnghiemtracuu;
            // trinh do tra cuu
            var trinhdotracuu = TrinhDoTraCuu.LisAll();
            ViewBag.TrinhDoTraCuu = trinhdotracuu;

            // TinTuc
            var newsList1 = newsdao.ListAll();    // Gọi method ListAll() từ DAO để lấy danh sách tin tức
            ViewBag.Tintuc = newsList1;          // Lưu dữ liệu vào ViewBag

            //TinHot_4
            var newSlide_4 = tinhot_4.ListAll_4();
            ViewBag.SlideTinHot = newSlide_4;

            //TinTuc_8
            var newSlide_8 = tintuc_8.ListAll();
            ViewBag.SlideTinTuc = newSlide_8;

            //Slide_Main
            var SlideMain = slidemain.ListAll_Slide();
            ViewBag.SlideMain = SlideMain;

            //QuangCaoTinTuc
            var quangcaotintuc = QuangCaoTinTuc.ListAll_Slide();
            ViewBag.QuangCaoTinTuc = quangcaotintuc;

            //TuVanQuangCao
            var tuvanquangcao = TuVanQuangCao.ListAll();
            ViewBag.TuVanQuangCao = tuvanquangcao;

            var tuvanquangcao1 = TuVanQuangCao1.ListAll();
            ViewBag.TuVanQuangCao1 = tuvanquangcao1;

            //BangTinThongTin
            var bangtinthongtin1 = BangTinThongTin1.ListAll();
            ViewBag.BangTinThongTin1 = bangtinthongtin1;

            var bangtinthongtin = BangTinThongTin.ListAll();
            ViewBag.BangTinThongTin = bangtinthongtin;


            //Viec Lam Moi 20
            var searchParameter = new DoanhNghiep_TuyenDung_SearchParameter
            {
                TieuDeTuyenDung = "",
                KhuVuc = "",
                MucLuong = "",
                TrinhDo = "",
                NgoaiNgu = "",
                TinHoc = "",
                GioiTinh = "",
                NganhNghe34 = "",
                SelectTop = 50 // Giới hạn số lượng kết quả
            };
            var vieclam_20 = vieclammoi.ListAll_20(searchParameter, pageNumber);
            ViewBag.vieclammoi = vieclam_20;

            //Ho so ung vien
            //var hosoungvien_12 = hosoungvien.ListAll();
            //ViewBag.hosoungvien = hosoungvien_12;

            // tin tuc noi bat
            var tintucnoibat = TinTucNoiBat.ListAll();
            ViewBag.tintucnoibat = tintucnoibat;
            //ho so ung vien kinh nghiem 
            // tin tuc video 3 
            var tintucvideo3 = TinTucVideo.ListAll();
            ViewBag.tintucvideo3 = tintucvideo3;
            //cam nang viec lam
            var camnangvieclam = CamNangViecLam.ListAll();
            ViewBag.camnangvieclam = camnangvieclam;

            return View(hosoungvien_12);  // Truyền dữ liệu vào View
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}