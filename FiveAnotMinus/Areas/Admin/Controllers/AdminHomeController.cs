using FiveAnotMinus.Models.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiveAnotMinus.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        private FiveAnotMinusDB db = new FiveAnotMinusDB();

        // GET: Admin/AdminHome
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public JsonResult DeleteRecord(int madh)
        {
            var donhang = db.DonHang.Find(madh);
            db.DonHang.Remove(donhang);
            var res = db.SaveChanges();
            if (res > 0)
            {
                return Json(new { Success = true });
            }
            return Json(new { Success = false });
        }

    }
}