using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IRoleService
    {
        List<Role> GetList();
        Role GetById(int id);
        void Insert(Role role);
        void Update(Role role);
        void Delete(int id);
    }
}
