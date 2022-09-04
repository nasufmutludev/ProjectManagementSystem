using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ProjectManagementSystemContext>, IUserDal
    {

        public List<UserDetailDto> UserDetail(Expression<Func<User, bool>> filter = null)
        {
            using (ProjectManagementSystemContext context = new ProjectManagementSystemContext())
            {
                IQueryable<UserDetailDto> result =
                    from user in filter is null ? context.Users : context.Users.Where(filter)
                    //join ur in context.UserRoles on user.ID equals ur.UserID
                    //join r in context.Roles on ur.RoleID equals r.ID
                    //join dpm in context.Departments on user.DepartmentID equals dpm.ID
                    join ur in context.UserRoles on user.ID equals ur.UserID
                    join r in context.Roles on ur.RoleID equals r.ID
                    select new UserDetailDto()
                    {
                        ID = user.ID,
                        UserName = user.UserName,
                        Name = user.FirstName+" "+user.LastName,
                        Email = user.Email,
                        Password=user.Password,
                        Status = user.Status,
                        //RoleName = r.Name,
                        //DepartmentName = dpm.DepartmentName,
                        UserRoleStatus=ur.Status,
                        Role=r.Name,
                        
                    };
                return result.ToList();
            }
        }
    }
}
