using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        private ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public List<TeamDto> GetList()
        {
            return _teamDal.GetTeamDetail();
        }

        public List<TeamDto> TeamDetail(int id)
        {
            return _teamDal.TeamDetail(x => x.ProjectID == id);
        }

        public Team GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Team team)
        {
            _teamDal.Add(team);
        }

        public void TeamStatus(int id)
        {
            var result = _teamDal.Get(x => x.ID == id);
            if (result.Status == true)
            {
                result.Status = false;
            }
            else
            {
                result.Status = true;
            }
            _teamDal.Update(result);
        }

        public void Update(Team team)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var result = _teamDal.Get(x => x.ID == id);
            _teamDal.Delete(result);
        }
    }
}
