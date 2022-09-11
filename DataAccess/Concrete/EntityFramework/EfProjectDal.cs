using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProjectDal : EfEntityRepositoryBase<Project, ProjectManagementSystemContext>, IProjectDal
    {
        public List<ProjectDetailDto> ProjectDetail(Expression<Func<Project, bool>> filter = null)
        {
            using (ProjectManagementSystemContext context = new ProjectManagementSystemContext())
            {
                IQueryable<ProjectDetailDto> result =
                    from pr in filter is null ? context.Projects : context.Projects.Where(filter)
                    //join us in context.Users on pr.UserID equals us.ID
                    //join dp in context.Departments on pr.DepartmentID equals dp.ID
                    //join tm in context.Teams on pr.ID equals tm.ProjectID
                    select new ProjectDetailDto()
                    {
                        ID = pr.ID,
                        ProjectName = pr.ProjectName,
                        //ProjeLead = us.FirstName + " " + us.LastName,
                        //Department = dp.DepartmentName,
                        ProjectFirstDeadline = pr.ProjectFirstDeadline,
                        ProjectLastDeadline = pr.ProjectLastDeadline,
                        Description = pr.Description,
                        EstimatedBudget = pr.EstimatedBudget,
                        AmountSpent = pr.AmountSpent,
                        DateOfCreation = pr.DateOfCreation,
                        ProjectStatus = pr.ProjectStatus,
                        Status = pr.Status,
                        //UserID = us.ID
                    };
                return result.ToList();
            }
        }
    }
}
