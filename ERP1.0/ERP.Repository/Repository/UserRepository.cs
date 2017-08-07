using ERP.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.DataAccess;

namespace ERP.Repository.Repository
{
   public class UserRepository : IUserRepository
    {
        private IEnumerable<User> Roles;
        private ERPEntities DataContext;
        public UserRepository(ERPEntities DataContext)
        {
            this.DataContext = DataContext;
        }
        public bool CreateUser(User user)
        {
            try
            {
                this.DataContext.User.Add(user);
                Save();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool DeleteUser(User user)
        {
            try
            {
                this.DataContext.User.Remove(user);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserByID(int ID)
        {
            try
            {
                User _user = this.DataContext.User.Where(p => p.UserID == ID).SingleOrDefault();
                return _user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User Login(string UserName,string password)
        {
            try
            {
                User _user = this.DataContext.User.Where(p => p.EmailID == UserName && p.Password == password).SingleOrDefault();
                if (_user!=null)
                {
                    return _user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public void Save()
        {
            try
            {
                this.DataContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpadateUser(User user)
        {
            try
            {
                this.DataContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
               
            }
        }
    }
}
