using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Department:IEntity
    {
        public int ID { get; set; }
        
        public string DepartmentName { get; set; }

        public bool Status { get; set; } = true;
    }
}
