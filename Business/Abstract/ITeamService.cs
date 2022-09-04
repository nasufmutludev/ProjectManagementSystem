using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Abstract
{
    public interface ITeamService
    {
        List<TeamDto> GetList();
        List<TeamDto> TeamDetail(int id);
        Team GetById(int id);
        void Insert(Team team);
        void TeamStatus(int id);
        void Update(Team team);
        void Delete(int id);
       }
}
