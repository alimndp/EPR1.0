//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.DataAccess
{
    using System;
    
    public partial class Usp_GetUserPermissions_Result
    {
        public long UserID { get; set; }
        public long ModuleID { get; set; }
        public string ModuleName { get; set; }
        public long MenuID { get; set; }
        public string MenuName { get; set; }
        public long SubMenuID { get; set; }
        public string SubMenuName { get; set; }
        public string Url { get; set; }
    }
}
