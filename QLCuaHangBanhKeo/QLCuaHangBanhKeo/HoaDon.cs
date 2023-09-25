namespace QLCuaHangBanhKeo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(50)]
        public string MAHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYLAP { get; set; }

        public int SOLUONG { get; set; }

        [StringLength(50)]
        public string TONGTIEN { get; set; }

        [StringLength(500)]
        public string MOTA { get; set; }

        [Required]
        [StringLength(50)]
        public string MAHANG { get; set; }

        public virtual MatHang MatHang { get; set; }
    }
}
