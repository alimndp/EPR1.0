using ERP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.Interface
{
   public interface IRole
    {
        bool CreateRole(ModuleMenuMapping mapping);
        bool UpadateRole(ModuleMenuMapping mapping);
        bool DeleteRole(ModuleMenuMapping mapping);
        IEnumerable<ModuleMenuMapping> GetAllRoles();
        object GetRoleByUserID(int ID);
        void Save();
    }
}
