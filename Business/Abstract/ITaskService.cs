using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity.Concrete;


namespace Business.Abstract
{
    public interface ITaskService
    {
        List<TaskList> GetList();
        void Add(TaskList task);
        void Update(TaskList task);
        void Delete(TaskList task);

    }
}
