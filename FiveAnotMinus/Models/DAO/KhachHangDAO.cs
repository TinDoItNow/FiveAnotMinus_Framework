using FiveAnotMinus.Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FiveAnotMinus.Models.DAO
{
    public class KhachHangDAO
    {
        FiveAnotMinusDB db = null;
        public KhachHangDAO()
        {
            db = new FiveAnotMinusDB();
        }
        public int Insert(string username, string email, string sdt)
        {
            object[] para =
                {
                new SqlParameter("@UserName", username),
                new SqlParameter("@Email", email),
                new SqlParameter("@SDT",sdt)
            };
            db.Database.ExecuteSqlCommand("Sp_Insert_KhachHang @UserName, @Email, @SDT", para);
            return 1;
        }
        public KhachHang GetById(int mkh)
        {
            return db.KhachHang.SingleOrDefault(x => x.MaKH == mkh);
        }
    }
}