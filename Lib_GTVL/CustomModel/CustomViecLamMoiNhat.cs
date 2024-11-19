using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.CustomModel
{
    public class CustomViecLamMoiNhat
    {
        // Dùng 5 table trong csdl => DOANHNGHIEP | DOANHNGHIEP_TUYENDUNG | DM_DIACHI | DM_GIOITINH| DM_KINHNGHIEM
        public string TieuDeTuyenDung { get; set; } //1 Tiêu đề tuyển dụng x
        public string TenDoanhNghiep { get; set; } //2 Tên doanh nghiệp x
        public string SoLuongTuyen { get; set; } //3 Số lượng x => mày là kiểu số nguyên là int nhưng case chuyển đổi kiểu dữ liệu qua thành tring để có thể có số lượng empty
        public string Tinh { get; set; } //4 Địa điểm Tỉnh      (DNTD.NoiLamViec_HuyenID)
        public string Huyen { get; set; } //4 Địa điểm Huyện    (DNTD.NoiLamViec_HuyenID)
        public string DiaChi_Tinh_Huyen { get; set; } // Lây tỉnh Huyện proc x
        public string NgayHetHan { get; set; } //5 ngày hết hạn 
        public string Gioi_Tinh { get; set; } // 6 Giới Tính x 
        public int YeuCauTuoiTu { get; set; } //7 Tuổi 
        public string TenKinhNghiem { get; set; } //8 kinh nghiệm x
        public string Logo { get; set; } //9 Logo  x
        public string DO_TUOI { get; set; } // 10 Độ tuổi x
        public bool NoiBat { get; set; }
        public int LuongTu { get; set; }
       
    }
}

