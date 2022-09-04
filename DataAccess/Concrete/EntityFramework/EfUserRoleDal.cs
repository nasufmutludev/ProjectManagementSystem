using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserRoleDal : EfEntityRepositoryBase<UserRole, ProjectManagementSystemContext>, IUserRoleDal
    {
        public List<UserRoleDto> GetListRole(Expression<Func<UserRole, bool>> filter = null)
        {
            using (ProjectManagementSystemContext context = new ProjectManagementSystemContext())
            {
                IQueryable<UserRoleDto> result =
                    from ur in filter is null ? context.UserRoles : context.UserRoles.Where(filter)
                    join us in context.Users on ur.UserID equals us.ID
                    join r in context.Roles on ur.RoleID equals r.ID
                    select new UserRoleDto()
                    {
                        ID = ur.ID,
                        UserName = us.UserName,
                        NameSurname = us.FirstName + " " + us.LastName,
                        FirstName = us.FirstName,
                        LastName = us.LastName,
                        Email = us.Email,
                        UserRole = r.Name,
                        RoleID = r.ID,
                        Status = ur.Status
                    };
                return result.ToList();
            }
        }
    }
}
