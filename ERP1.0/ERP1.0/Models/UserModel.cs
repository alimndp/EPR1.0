using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP1._0.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
    }
}