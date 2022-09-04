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
    public class EfTeamDal : EfEntityRepositoryBase<Team, ProjectManagementSystemContext>, ITeamDal
    {
        public List<TeamDto> TeamDetail(Expression<Func<Team, bool>> filter = null)
        {
            using (ProjectManagementSystemContext context = new ProjectManagementSystemContext())
            {
                IQueryable<TeamDto> result = from team in filter is null ? context.Teams : context.Teams.Where(filter)
                                             join us in context.Users on team.UserID equals us.ID
                                             join pr in context.Projects on team.ProjectID equals pr.ID
                                             select new TeamDto()
                                             {
                                                 ID = team.ID,
                                                 ProjectID = pr.ID,
                                                 ProjectName = pr.ProjectName,
                                                 Member = us.FirstName+" "+us.LastName,
                                                 Status = team.Status
                                             };
                return result.ToList();
            }
        }
        public List<TeamDto> GetTeamDetail(Expression<Func<Team, bool>> filter = null)
        {
            using (ProjectManagementSystemContext context = new ProjectManagementSystemContext())
            {
                IQueryable<TeamDto> result = from team in filter is null ? context.Teams : context.Teams.Where(filter)
                    join us in context.Users on team.UserID equals us.ID
                    join pr in context.Projects on team.ProjectID equals pr.ID
                    select new TeamDto()
                    {
                        ID = team.ID,
                        ProjectName = pr.ProjectName,
                        UserID = us.ID,
                        Member = us.FirstName + " " + us.LastName,
                        Status = team.Status,
                        ProjectID = pr.ID
                    };
                return result.ToList();
            }
        }
    }
}
