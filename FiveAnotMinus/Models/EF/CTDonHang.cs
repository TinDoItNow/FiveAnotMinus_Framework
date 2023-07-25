namespace FiveAnotMinus.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDonHang")]
    public partial class CTDonHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaDH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaSP { get; set; }

        public int? SoLuong { get; set; }
    }
}
