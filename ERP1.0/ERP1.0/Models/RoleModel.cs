using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP1._0.Models
{
    public class RoleModel
    {
        public int MappingID { get; set; }
        public int UserID { get; set; }
        public int ModuleID { get; set; }
        public int SubmoduleID { get; set; }
        public int MenuID { get; set; }
        public int SubMenuID { get; set; }
        public string Url { get; set; }
    }
}