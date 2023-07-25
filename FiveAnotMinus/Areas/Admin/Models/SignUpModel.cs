using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiveAnotMinus.Areas.Admin.Models
{
    public class SignUpModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
    }
}