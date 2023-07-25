using FiveAnotMinus.Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FiveAnotMinus.Models.DAO
{
    public class SanPhamDAO
    {
        FiveAnotMinusDB db = null;
        public SanPhamDAO()
        {
            db = new FiveAnotMinusDB();
        }
        public List<SanPham> ListAll()
        {
            var list = db.Database.SqlQuery<SanPham>("Sp_SanPham_ListAll").ToList();
            return list;
        }

        public List<SanPham> ListFlashSale()
        {
            var list = db.Database.SqlQuery<SanPham>("Sp_SanPham_FlashSale").ToList();
            return list;
        }
        public SanPham ViewDetail(string spID)
        {
            SanPham pham = new SanPham();
            object[] para =
                {
                new SqlParameter("@SPID", spID)
            };
            pham = db.Database.SqlQuery<SanPham>("select * from SanPham where MaSP = @SPID").ToList()[0];
            return pham;
        }
        public SanPham Insert(string spID, string ten)
        {
            SanPham pham = new SanPham();
            object[] para =
                {
                new SqlParameter("@SPID", spID)
            };
            pham = db.Database.SqlQuery<SanPham>("select * from SanPham where MaSP = @SPID").ToList()[0];
            return pham;
        }

    }
}