namespace QLCuaHangBanhKeo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string MATAIKHOAN { get; set; }

        [Required]
        [StringLength(50)]
        public string TENTAIKHOAN { get; set; }

        [Required]
        [StringLength(50)]
        public string MATKHAU { get; set; }

        public int QUYEN { get; set; }

        [Required]
        [StringLength(50)]
        public string MOTAQUYEN { get; set; }
    }
}
