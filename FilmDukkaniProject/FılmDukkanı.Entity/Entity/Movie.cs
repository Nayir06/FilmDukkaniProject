using FılmDukkanı.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.Entity.Entity
{
    public class Movie:BaseEntity
    {
        public string FılmAdı { get; set; }
        public string OrjinalFılmAdı { get; set; }
        public string Descpription { get; set; }    
        public TimeSpan Duration { get; set; }
        public string  MyProperty { get; set; }
        public  string ImagePath { get; set; }
        


        // mapping ilişkilendirnme


    }
}
