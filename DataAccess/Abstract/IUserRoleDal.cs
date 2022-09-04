﻿using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserRoleDal:IEntityRepository<UserRole>
    {        
        List<UserRoleDto> GetListRole(Expression<Func<UserRole, bool>> filter = null);
    }
}

