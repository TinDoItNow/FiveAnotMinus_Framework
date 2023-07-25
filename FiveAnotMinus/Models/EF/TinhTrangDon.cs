namespace FiveAnotMinus.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinhTrangDon")]
    public partial class TinhTrangDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinhTrangDon()
        {
            DonHang = new HashSet<DonHang>();
        }

        [Key]
        [StringLength(20)]
        public string MaTTD { get; set; }

        [Column("TinhTrangDon")]
        [StringLength(250)]
        public string TinhTrangDon1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHang { get; set; }
    }
}
