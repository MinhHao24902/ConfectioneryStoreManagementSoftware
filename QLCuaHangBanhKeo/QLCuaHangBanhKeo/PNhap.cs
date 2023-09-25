namespace QLCuaHangBanhKeo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PNhap")]
    public partial class PNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PNhap()
        {
            ChiTietPNhaps = new HashSet<ChiTietPNhap>();
        }

        [Key]
        [StringLength(50)]
        public string MAPN { get; set; }

        [Required]
        [StringLength(50)]
        public string MANHACUNGCAP { get; set; }

        [Required]
        [StringLength(50)]
        public string MANHANVIEN { get; set; }

        public DateTime NGAYNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPNhap> ChiTietPNhaps { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
