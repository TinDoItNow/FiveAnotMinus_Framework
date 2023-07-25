namespace FiveAnotMinus.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(20)]
        public string MaSP { get; set; }

        [StringLength(250)]
        public string TenSP { get; set; }

        public float? Gia { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        public double? BaoHanh { get; set; }

        public double? KhuyenMai { get; set; }

        [Column(TypeName = "text")]
        public string HinhAnh { get; set; }

        [Column(TypeName = "text")]
        public string Mota { get; set; }

        [StringLength(20)]
        public string MaLoaiSP { get; set; }
    }
}
