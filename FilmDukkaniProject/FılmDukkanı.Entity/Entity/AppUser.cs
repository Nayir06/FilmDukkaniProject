using FılmDukkanı.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.Entity.Entity
{
    public class AppUser:BaseEntity 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public  string Password { get; set; }
        public DateTime BirtDate { get; set; }
        public string Adress { get; set; }
    }
}
