namespace FiveAnotMinus.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDH { get; set; }

        public int? MaKH { get; set; }

        public int? MaNV { get; set; }

        [StringLength(20)]
        public string MaTTD { get; set; }

        public DateTime? NgayLapDon { get; set; }

        [StringLength(250)]
        public string TenNguoiNhan { get; set; }

        [StringLength(250)]
        public string DiaChiGiao { get; set; }

        [StringLength(20)]
        public string DienThoaiNguoiNhan { get; set; }

        public DateTime? ThoiGianGiao { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual TinhTrangDon TinhTrangDon { get; set; }
    }
}
