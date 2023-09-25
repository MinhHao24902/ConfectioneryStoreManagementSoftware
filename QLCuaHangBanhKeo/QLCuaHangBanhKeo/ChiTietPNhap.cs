namespace QLCuaHangBanhKeo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPNhap")]
    public partial class ChiTietPNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MAPN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MAHANG { get; set; }

        public int SLNHAP { get; set; }

        public double? THUE { get; set; }

        public double DONGIANHAP { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual PNhap PNhap { get; set; }
    }
}
