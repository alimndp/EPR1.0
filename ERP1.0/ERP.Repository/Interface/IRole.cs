using ERP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.Interface
{
    interface IRole
    {
        bool CreateRole(string Name, string Gender, string Address, string Email, string Password);
        bool UpadateRole(int ID);
        bool DeleteRole(int ID);
        IEnumerable<User> GetAllRoles();
        User GetRoleByUserID(int ID);
        void Save();
    }
}
