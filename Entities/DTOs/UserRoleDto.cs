using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class UserRoleDto:IDto
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserRole { get; set; }
        public int RoleID { get; set; }
        public bool Status { get; set; }
    }
}
