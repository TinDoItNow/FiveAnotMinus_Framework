using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FiveAnotMinus.Models.EF
{
    public partial class FiveAnotMinusDB : DbContext
    {
        public FiveAnotMinusDB()
            : base("name=FiveAnotMinusDB")
        {
        }

        public virtual DbSet<CTDonHang> CTDonHang { get; set; }
        public virtual DbSet<DonHang> DonHang { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LoaiSP> LoaiSP { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<TinhTrangDon> TinhTrangDon { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTDonHang>()
                .Property(e => e.MaDH)
                .IsUnicode(false);

            modelBuilder.Entity<CTDonHang>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaTTD)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.DienThoaiNguoiNhan)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSP>()
                .Property(e => e.MaLoaiSP)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Mota)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaLoaiSP)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Passwordd)
                .IsUnicode(false);

            modelBuilder.Entity<TinhTrangDon>()
                .Property(e => e.MaTTD)
                .IsUnicode(false);
        }
    }
}
