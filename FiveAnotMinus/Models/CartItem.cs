using FiveAnotMinus.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiveAnotMinus.Models
{
    [Serializable]
    public class CartItem
    {
        public SanPham SanPham { get; set; }
        public int SoLuongSP { get; set; }
    }
}