using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserRoleManager : IUserRoleService
    {
        private IUserRoleDal _userRoleDal;

        public UserRoleManager(IUserRoleDal userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public UserRole GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<UserRoleDto> GetList()
        {
            return _userRoleDal.GetListRole();
        }

        public void Insert(UserRole userRole, int id)
        {
            _userRoleDal.Add(userRole);
        }


        public void Update(UserRole userRole, int id)
        {
            var result = _userRoleDal.Get(x => x.UserID == id);
            if (userRole.UserID == id)
            {
                result.RoleID = userRole.RoleID;
                result.Status = true;
                _userRoleDal.Update(result);
            }            
        }
    }
}

