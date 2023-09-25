namespace QLCuaHangBanhKeo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            PNhaps = new HashSet<PNhap>();
        }

        [Key]
        [StringLength(50)]
        public string MANHANVIEN { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNHANVIEN { get; set; }

        public int NAMSINH { get; set; }

        [Required]
        [StringLength(10)]
        public string GIOITINH { get; set; }

        [StringLength(50)]
        public string DIENTHOAI { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(50)]
        public string CHUCVU { get; set; }

        [StringLength(50)]
        public string LUONGCOBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PNhap> PNhaps { get; set; }
    }
}
