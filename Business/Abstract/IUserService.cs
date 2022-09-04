using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<UserDetailDto> GetList();
        User GetByID(int id);
        void Insert(User user);
        void Update(User user, int id);
        void Delete(int id);
        void UserStatus(int id);
        UserDetailDto Login(UserDetailDto user);
    }
}
