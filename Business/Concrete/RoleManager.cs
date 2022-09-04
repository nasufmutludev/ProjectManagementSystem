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
    public class RoleManager:IRoleService
    {
        private IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public List<Role> GetList()
        {
            return _roleDal.GetAll();
        }

        public Role GetById(int id)
        {
            return _roleDal.Get(x => x.ID == id);
        }

        public void Insert(Role role)
        {
            _roleDal.Add(role);
        }

        public void Update(Role role)
        {
            _roleDal.Update(role);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
