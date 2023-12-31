namespace QLCuaHangBanhKeo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            PNhaps = new HashSet<PNhap>();
        }

        [Key]
        [StringLength(50)]
        public string MANHACUNGCAP { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNHACUNGCAP { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string DIENTHOAI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PNhap> PNhaps { get; set; }
    }
}
