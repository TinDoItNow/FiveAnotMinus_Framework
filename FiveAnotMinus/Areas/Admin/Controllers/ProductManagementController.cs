using FiveAnotMinus.Models.DAO;
using FiveAnotMinus.Models.DTO;
using FiveAnotMinus.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiveAnotMinus.Areas.Admin.Controllers
{
    public class ProductManagementController : Controller
    {
        private FiveAnotMinusDB db = new FiveAnotMinusDB();

        // GET: Admin/ProductManagement
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult DeleteRecord(int masp)
        {
            var sanpham = db.SanPham.Find(masp);
            db.SanPham.Remove(sanpham);
            var res = db.SaveChanges();
            if (res > 0)
            {
                return Json(new { Success = true });
            }
            return Json(new { Success = false });
        }

        [HttpPost]
        public JsonResult CreateProduct(SanPham_DTO sanPham)
        {
            try
            {
                //db.SanPham.Add(sanPham);

            } catch (Exception ex)
            {
                return Json(new {msg = ex.Message});
            }
            return Json(new { sanPham });
        }
    }
}