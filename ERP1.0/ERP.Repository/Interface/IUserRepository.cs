using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.DataAccess;

namespace ERP.Repository.Interface
{
   public interface IUserRepository
    {
        bool CreateUser(User user);
        bool UpadateUser(User user);
        bool DeleteUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUserByID(int ID);
        User Login(string UserName, string password);
        void Save();
    }
}
