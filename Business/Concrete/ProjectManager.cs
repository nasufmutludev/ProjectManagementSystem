using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void Delete(int id)
        {
            var result = _projectDal.Get(x => x.ID == id);
            if (result.Status==true)
            {
                result.Status = false;
            }
            _projectDal.Update(result);
        }

        public void ProjectStatus(int id)
        {
            var result = _projectDal.Get(x => x.ID == id);
            if (result.Status==true)
            {
                result.Status = false;
            }
            else
            {
                result.Status = true;
            }
            _projectDal.Update(result);
        }

        public List<ProjectDetailDto> GetList()
        {
            return _projectDal.ProjectDetail();
        }

        public Project GetById(int id)
        {
            return _projectDal.Get(x => x.ID == id);
        }

        public List<ProjectDetailDto> GetListId(int id)
        {
            return _projectDal.ProjectDetail(x => x.ID == id);
        }

        public void Insert(Project project)
        {
            _projectDal.Add(project);
        }

        public void Update(Project project)
        {
            _projectDal.Update(project);
        }
    }
}
