using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;


namespace Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetList();
        Department GetById(int id);
        void Insert(Department department);
        void Update(Department department);
        void Delete(int id);
    }
}
