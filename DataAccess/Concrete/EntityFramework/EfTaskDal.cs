using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal:EfEntityRepositoryBase<TaskList, ProjectManagementSystemContext>,ITaskDal
    {
    }
}
