using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lib_GTVL.CustomModel
{
    public class CustomViecLamMoiNhat
    {
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int? DN_ID { get; set; }
        public string DN_NganhKD { get; set; }
        public string DN_NgheKD { get; set; }
        public string Email { get; set; }
        public bool? HienThiWeb { get; set; }
        public bool? KichHoat { get; set; }
        public int? LuongDen { get; set; }
        public int? LuongTu { get; set; }
        public int? LuotGTVL { get; set; }
        public string MoTaCongViec { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayNhanHoSo { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiDaiDien { get; set; }
        public string NguoiDaiDien_DienThoai { get; set; }
        public bool? NoiBat { get; set; }
        [StringLength(1000)]
        public string NoiNopHoSo { get; set; }
        public string QuyenLoi { get; set; }
        public int? SoLuongTuyen { get; set; }
        public int? SoLuotXem { get; set; }
        public string KinhNghiem { get; set; }
        public string Ten_ChiNhanh { get; set; }
        public string Ten_ChucDanh { get; set; }
        public string Ten_ChucVu { get; set; }
        public string Ten_DN { get; set; }
        public string Ten_Huyen { get; set; }
        public string Ten_LoaiViecLamTrong { get; set; }
        public string Ten_NguoiCapNhat { get; set; }
        public string Ten_NguoiTao { get; set; }
        public string Ten_NoiLamViec_Tinh { get; set; }
        public string Ten_Tinh { get; set; }
        public string Ten_TinhTrangHoSo { get; set; }
        public string Ten_Xa { get; set; }
        public string Ten_YeuCauNganh { get; set; }
        public string Ten_YeuCauNghe { get; set; }
        public string Ten_YeuCauTrinhDo { get; set; }
        public int? ThoiGianLamViec { get; set; }
        [StringLength(2000)]
        public string TieuDeTuyenDung { get; set; }
        public int TuyenDungDu { get; set; }
        public int? TuyenDung_ID { get; set; }
        public bool? XoaHoSo { get; set; }
        public string YeuCauCongViec { get; set; }
        public int? YeuCauGioiTinh { get; set; }
        public int? YeuCauTuoiDen { get; set; }
        public int? YeuCauTuoiTu { get; set; }
        public string TenNgheNghiep34 { get; set; }
        public int? LoaiViecTrong_ID { get; set; }
        public int? Tinh_ID { get; set; }
        public int? NguoiTao { get; set; }
        public int? SoTrang { get; set; }
        public int? TongDong { get; set; }
        public int? MinRow { get; set; }
        public int? MaxRow { get; set; }
        public string Logo { get; set; }
        public string MucLuong { get; set; }
        public string GioiTinh { get; set; }
        public int? STrinhDo { get; set; }
        public int? SMucLuong { get; set; }
        public int? SKinhNghiem { get; set; }
        public string TrinhDo { get; set; }
    }
}

