using FiveAnotMinus.Common;
using FiveAnotMinus.Models;
using FiveAnotMinus.Models.DAO;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiveAnotMinus.Controllers
{
    public class LoginKHController : Controller
    {
        // GET: LoginKH
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
                if (result == 2)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new TaiKhoanKHLogin();
                    userSession.UserName = user.UserName;
                    Session.Add(CommonConstants.USERKH_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    
                }
            }
            return View("Index");
        }
    }
}