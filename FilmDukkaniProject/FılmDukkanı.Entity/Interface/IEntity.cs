using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.Entity.Interface
{
    internal interface IEntity<Guid>
    {
        public int Id { get; set; }
        public Guid MasterId { get; set; }


        public bool IsActive { get; set; }
        public string status { get; set; }


    }
}
