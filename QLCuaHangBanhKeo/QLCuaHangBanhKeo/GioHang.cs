namespace QLCuaHangBanhKeo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GioHang")]
    public partial class GioHang
    {
        [Key]
        public int STT { get; set; }

        [Required]
        [StringLength(50)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(50)]
        public string MATAIKHOAN { get; set; }

        [StringLength(50)]
        public string TENHANG { get; set; }

        public int? SOLUONG { get; set; }

        [StringLength(50)]
        public string TONGTIEN { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual MatHang MatHang { get; set; }
    }
}
