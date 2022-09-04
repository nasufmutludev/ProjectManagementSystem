using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.DTOs
{
    public class TeamDto : IDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Member { get; set; }
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public bool Status { get; set; }
    }
}
