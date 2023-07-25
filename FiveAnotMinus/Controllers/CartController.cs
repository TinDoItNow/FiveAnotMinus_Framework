using FiveAnotMinus.Models;
using FiveAnotMinus.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiveAnotMinus.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        private string CartSession = "CartSession";
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if(cart != null)
            {
                list = (List<CartItem>)cart;

            }    
            return View(list);
        }

        public ActionResult AddItem(string spID, int sl)
        {
            var sp = new SanPhamDAO().ViewDetail(spID);
            var cart = Session[CartSession];
            if(cart != null)
            {
                var list = (List<CartItem>)cart;
                if(list.Exists(x=>x.SanPham.MaSP==spID))
                {
                    foreach (var item in list)
                    {
                        if (item.SanPham.MaSP == spID)
                        {
                            item.SoLuongSP += sl;
                        }
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.SanPham = sp;
                    item.SoLuongSP = sl;
                    list.Add(item);
                }
                Session[CartSession] = list;
            }
            else
            {
                var item = new CartItem();
                item.SanPham = sp;
                item.SoLuongSP = sl;
                var list = new List<CartItem>();
                list.Add(item);
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }    
    }
}