using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.DTOs
{
    public class UserDetailDto:IDto
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }      
        public string Email { get; set; }
        //public string RoleName { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public bool UserRoleStatus { get; set; }
        public string Role { get; set; }        
    }
}
