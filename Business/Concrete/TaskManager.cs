using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class TaskManager:ITaskService
    {
        private ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public List<TaskList> GetList()
        {
            return _taskDal.GetAll();
        }

        public void Add(TaskList task)
        {
            _taskDal.Add(task);
        }

        public void Update(TaskList task)
        {
            _taskDal.Update(task);
        }

        public void Delete(TaskList task)
        {
            _taskDal.Delete(task);
        }
    }
}
