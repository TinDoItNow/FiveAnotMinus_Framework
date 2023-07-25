using FiveAnotMinus.Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FiveAnotMinus.Models.DAO
{
    public class TaiKhoanDAO
    {
        FiveAnotMinusDB db = null;
        public TaiKhoanDAO()
        {
            db = new FiveAnotMinusDB();
        }
        public int Insert(string username, string password)
        {
            object[] para =
                {
                new SqlParameter("@UserName", username),
                new SqlParameter("@PassWord", password)
            };
            int a = db.Database.SqlQuery<int>("Sp_Insert_TaiKhoan @UserName, @PassWord", para).SingleOrDefault();
            return a;
        }
        public bool Update(string username, string password)
        {
            object[] para =
                {
                new SqlParameter("@UserName", username),
                new SqlParameter("@PassWord", password)
            };
            var a = db.Database.SqlQuery<bool>("Sp_Update_TaiKhoan @UserName, @PassWord", para).SingleOrDefault();
            return a;
        }
        public TaiKhoan GetById(string userName)
        {
            return db.TaiKhoan.SingleOrDefault(x => x.UserName == userName);
        }
        public int Login(string username, string password)
        {
            var result = db.TaiKhoan.Count(x => x.UserName == username && x.Passwordd == password);
            var resultNV = db.NhanVien.Count(x => x.UserName == username);
            var resultKH = db.KhachHang.Count(x => x.UserName == username);
            if (result > 0 && resultNV > 0)
            {
                return 1;
            }
            else if (result > 0 && resultKH > 0)
            {
                return 2;
            }
            return 0;
        }
    }
}