using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Abstract
{
    public interface ITeamDal:IEntityRepository<Team>
    {
        List<TeamDto> TeamDetail(Expression<Func<Team, bool>> filter = null);
        List<TeamDto> GetTeamDetail(Expression<Func<Team, bool>> filter = null);
    }
}
