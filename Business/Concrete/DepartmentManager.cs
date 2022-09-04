using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class DepartmentManager:IDepartmentService
    {
        private IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public List<Department> GetList()
        {
            return _departmentDal.GetAll();
        }

        public Department GetById(int id)
        {
            return _departmentDal.Get(x => x.ID == id);
        }

        public void Insert(Department department)
        {
            _departmentDal.Add(department);
        }

        public void Update(Department department)
        {
            _departmentDal.Update(department);
        }

        public void Delete(int id)
        {
            var result = _departmentDal.Get(x => x.ID == id);
            if (result.Status==true)
            {
                result.Status = false;
            }
            _departmentDal.Update(result);
        }
    }
}
