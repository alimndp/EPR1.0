using ERP.DataAccess;
using ERP.Repository.Interface;
using ERP.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP1._0.Business
{
    public class ClsBusiness
    {
        private IUserRepository _userRepository;
        private IRole _RoleRepository;
        private ERPEntities DataContext;
        public ClsBusiness()
        {
            this.DataContext = new ERPEntities();
        }
        public long Login(string UserName , string Password)
        {
            try
            {
                _userRepository = new UserRepository(DataContext);
                if (_userRepository.Login(UserName, Password) != null)
                {
                    return _userRepository.Login(UserName, Password).UserID;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {

                return 0;
            }
        }

    }
}