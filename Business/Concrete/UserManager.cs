using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Security;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private IUserRoleDal _userRoleDal;

        public UserManager(IUserDal userDal, IUserRoleDal userRoleDal)
        {
            _userDal = userDal;
            _userRoleDal = userRoleDal;
        }

        public List<UserDetailDto> GetList()
        {
            return _userDal.UserDetail();
        }

        public User GetByID(int id)
        {
            return _userDal.Get(x => x.ID == id);
        }

        public void Insert(User user)
        {
            var hashPass = HashingHelper.Hashing(user.Password);
            var users = new User()
            {
                //ID=id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = hashPass,
                //DepartmentID = user.DepartmentID
            };
            _userDal.Add(users);
            //var sonKayit = _userDal.GetAll().Max(x => x.ID);
            var userRoles = new UserRole()
            {
                RoleID = 2,
                UserID = users.ID,
                Status = true
            };
            _userRoleDal.Add(userRoles);
        }

        public void Update(User user, int id)

        {
            var result = _userDal.Get(x => x.ID == id);
            if (user.Password != null)
            {
                var hashPass = HashingHelper.Hashing(user.Password);
                result.Password = hashPass;
                _userDal.Update(result);
            }
            else
            {
                result.ID = user.ID;
                result.UserName = user.UserName;    
                result.FirstName = user.FirstName;
                result.LastName = user.LastName;
                result.Email = user.Email;
                //result.DepartmentID = user.DepartmentID;
                //result.Password = user.Password; 
                _userDal.Update(result);
            }
        }

        public void Delete(int id)
        {
            var result = _userDal.Get(x => x.ID == id);
            if (result.Status == true)
            {
                result.Status = false;
            }
            _userDal.Update(result);
        }

        public void UserStatus(int id)
        {
            var result = _userDal.Get(x => x.ID == id);
            if (result.Status == true)
            {
                result.Status = false;
            }
            else
            {
                result.Status = true;
            }
            _userDal.Update(result);
        }

        public UserDetailDto Login(UserDetailDto user)
        {
            var pass = HashingHelper.Hashing(user.Password);
            return _userDal.UserDetail().FirstOrDefault(x => x.UserName == user.UserName && x.Password == pass && x.Status == true);
        }
    }
}
