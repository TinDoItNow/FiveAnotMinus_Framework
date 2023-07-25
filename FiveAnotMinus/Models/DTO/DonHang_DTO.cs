using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiveAnotMinus.Models.DTO
{
    public class DonHang_DTO
    {
        public int MaDH { get; set; }
        public int MaNV { get; set; }
        public string TinhTrangDon { get; set; }
        public float Tien { get; set; }
        public DateTime ThoiGianGiao { get; set; }
    }
}