using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.DataAccess;

namespace ERP.Repository.Interface
{
    interface IUserRepository
    {
        bool CreateUser(string Name,string Gender,string Address, string Email,string Password);
        bool UpadateUser(int ID);
        bool DeleteUser(int ID);
        IEnumerable<User> GetAllUsers();
        User GetUserByID(int ID);
        void Save();
    }
}
