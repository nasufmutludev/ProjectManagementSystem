using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProjectService
    {
        List<ProjectDetailDto> GetList();
        Project GetById(int id);
        List<ProjectDetailDto> GetListId(int id);
        void Insert(Project project);
        void Update(Project project);
        void Delete(int id);
        void ProjectStatus(int id);
    }
}
