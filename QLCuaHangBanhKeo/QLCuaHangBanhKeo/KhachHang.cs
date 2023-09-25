namespace QLCuaHangBanhKeo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            GioHangs = new HashSet<GioHang>();
        }

        [Key]
        [StringLength(50)]
        public string MATAIKHOAN { get; set; }

        [Required]
        [StringLength(50)]
        public string TENKHACHHANG { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string DIENTHOAI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NAMSINH { get; set; }

        [StringLength(20)]
        public string GIOITINH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHangs { get; set; }
    }
}
