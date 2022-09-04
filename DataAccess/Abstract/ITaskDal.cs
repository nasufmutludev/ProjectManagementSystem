using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface ITaskDal: IEntityRepository<TaskList>
    {
    }
}
