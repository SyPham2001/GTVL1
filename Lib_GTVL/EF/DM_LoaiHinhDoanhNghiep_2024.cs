namespace Lib_GTVL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiHinhDoanhNghiep_2024
    {
        [Key]
        [Column(Order = 0)]
        public int LoaiHinhDoanhNghiep_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2000)]
        public string TenLoaiHinhDoanhNghiep { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        public bool? KichHoat { get; set; }
    }
}
