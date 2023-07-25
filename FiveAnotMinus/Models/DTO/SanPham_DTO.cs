using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiveAnotMinus.Models.DTO
{
    public class SanPham_DTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string TenLoaiSP { get; set; }
        public float Gia { get; set; }
        public string DVT { get; set; }
        public double BaoHanh { get; set; }
        public string HinhAnh { get; set; }

    }
}