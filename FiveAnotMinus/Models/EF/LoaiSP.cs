namespace FiveAnotMinus.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSP")]
    public partial class LoaiSP
    {
        [Key]
        [StringLength(20)]
        public string MaLoaiSP { get; set; }

        [StringLength(250)]
        public string TenLoaiSP { get; set; }
    }
}
