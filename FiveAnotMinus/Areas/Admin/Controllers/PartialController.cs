using FiveAnotMinus.Models.DTO;
using FiveAnotMinus.Models.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiveAnotMinus.Areas.Admin.Controllers
{
    public class PartialController : Controller
    {
        private FiveAnotMinusDB db = new FiveAnotMinusDB();

        // GET: Admin/Partial
        public PartialViewResult getDanhSachDonHang(string name = "", string status = "NONE")
        {
            string sql = "select donhang.MaDH, ThoiGianGiao, TinhTrangDon,SoLuong * Gia as Tien, MaNV from DonHang left join CTDonHang on DonHang.MaDH= CTDonHang.MaDH join SanPham on SanPham.MaSP = CTDonHang.MaSP join TinhTrangDon on DonHang.MaTTD = TinhTrangDon.MaTTD";
            List<DonHang_DTO> lstDonHang = db.Database.SqlQuery<DonHang_DTO>(sql).ToList();
            return PartialView("~/Areas/Admin/Views/Partial/DSdonhang.cshtml", lstDonHang);
        }

        public PartialViewResult getDanhSachSanPham(int? page, string name = "", string status = "NONE")
        {
            int pageNum = page ?? 1;
            int pageSize = 5;
            string sql = "select MaSP, TenSP, TenLoaiSP, Gia, DVT, BaoHanh, HinhAnh " +
                        "from SanPham as SP join LoaiSP as LSP on SP.MaLoaiSP =  LSP.MaLoaiSP ";
            var lstSanPham = db.Database.SqlQuery<SanPham_DTO>(sql).ToPagedList(pageNum,pageSize);
            return PartialView("~/Areas/Admin/Views/Partial/DSsanpham.cshtml", lstSanPham);
        }
    }
}