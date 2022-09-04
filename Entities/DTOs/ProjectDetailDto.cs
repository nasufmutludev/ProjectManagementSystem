using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class ProjectDetailDto : IDto
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjeLead { get; set; }
        //public string Department { get; set; }
        public DateTime ProjectFirstDeadline { get; set; }
        public DateTime ProjectLastDeadline { get; set; }
        public string Description { get; set; }
        public decimal? EstimatedBudget { get; set; }
        public decimal? AmountSpent { get; set; }
        public DateTime DateOfCreation { get; set; } = DateTime.Now;
        public bool ProjectStatus { get; set; } = true;
        public bool Status { get; set; } = true;
        public int TeamProjeID { get; set; }
        public int UserID { get; set; }
    }
}
