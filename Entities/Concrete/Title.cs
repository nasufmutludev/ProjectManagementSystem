using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.Concrete
{
    public class Title:IEntity
    {
        public int ID { get; set; }
        public int TitleName { get; set; }
    }
}
