using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserRoleService
    {
        List<UserRoleDto> GetList();
        UserRole GetById(string id);
        void Insert(UserRole userRole, int id);
        void Update(UserRole userRole,int id);
        void Delete(string id);
    }
}
