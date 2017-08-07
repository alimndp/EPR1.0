using ERP.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.DataAccess;

namespace ERP.Repository.Repository
{
    public class Role : IRole
    {
        private ERPEntities DataContext;
        public Role(ERPEntities DataContext)
        {           
            this.DataContext = DataContext;
        }

        public bool CreateRole(ModuleMenuMapping mapping)
        {
            try
            {

                DataContext.ModuleMenuMapping.Add(mapping);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
           
        }

        public bool DeleteRole(ModuleMenuMapping mapping)
        {
            try
            {
                DataContext.ModuleMenuMapping.Remove(mapping);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<ModuleMenuMapping> GetAllRoles()
        {
            try
            {
                IEnumerable<ModuleMenuMapping> roles = this.DataContext.ModuleMenuMapping.ToList();
                return roles;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        public object GetRoleByUserID(int ID)
        {
            try
            {
               var _userRoles = this.DataContext.Usp_GetUserPermissions(ID).ToList();
               return _userRoles;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 

        public bool UpadateRole(ModuleMenuMapping mapping)
        {
            try
            {
                this.DataContext.Entry(mapping).State = System.Data.Entity.EntityState.Modified;
                Save();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public void Save()
        {

            try
            {
                this.DataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
