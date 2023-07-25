using FiveAnotMinus.Areas.Admin.Models;
using FiveAnotMinus.Common;
using FiveAnotMinus.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiveAnotMinus.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new TaiKhoanDAO();
                var result = dao.Login(model.UserName, model.Password);
                if (result == 1)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new TaiKhoanLogin();
                    userSession.UserName = user.UserName;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "AdminHome");

                }
                else
                {

                }
            }
            //return new EmptyResult();

            return View("Index");
        }
    }
}