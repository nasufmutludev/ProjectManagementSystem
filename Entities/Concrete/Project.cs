using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Project: IEntity
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string ProjectName { get; set; }
        public int UserID { get; set; }
        public int DepartmentID { get; set; }
        public DateTime ProjectFirstDeadline { get; set; }
        public DateTime ProjectLastDeadline { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public decimal? EstimatedBudget { get; set; }
        public decimal? AmountSpent { get; set; }
        public DateTime DateOfCreation { get; set; }= DateTime.Now;
        public bool ProjectStatus { get; set; } = true;
        public bool Status { get; set; } = true;
        public int TeamID { get; set; }
    }
}
