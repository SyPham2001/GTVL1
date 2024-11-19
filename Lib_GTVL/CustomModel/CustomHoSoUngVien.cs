using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_GTVL.CustomModel
{
    public class CustomHoSoUngVien
    {
        public int KH_ID { get; set; }
        public string HoTen { get; set; }
        public int? NamSinh { get; set; }
        public string Hinh { get; set; }
        public string TenHoSo { get; set; }
        public string MucLuong { get; set; }
        public int GioiTinh { get; set; }
        public string TenChuyenMon { get; set; }
        public string KhoangThoiGian { get; set; }
        public string NgayCapNhat { get; set; }
       public int? MucLuong_ID { get; set; }
        public int? KinhNghiem_ID { get; set; }
        public int? TrinhDoChuyenMon_ID { get; set; }

       
    }
}
