using FiveAnotMinus.Areas.Admin.Models;
using FiveAnotMinus.Models.DAO;
using FiveAnotMinus.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiveAnotMinus.Areas.Admin.Controllers
{
    public class SignUpController : Controller
    {
        // GET: Admin/SignUp
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                var daotk = new TaiKhoanDAO();
                var daokh = new KhachHangDAO();
                var instk = daotk.Insert(model.UserName, model.Password);
                if (instk == 1)
                {
                    int inskh = daokh.Insert(model.UserName, model.Email, model.SDT);
                    if (inskh > 0)
                    {
                        return RedirectToAction("Index", "AdminHome");
                    }
                    else
                    {

                    }
                }
                else
                {
                    ModelState.AddModelError("", "Don't insert user");
                }
            }
            return View("Index");
        }
    }
}