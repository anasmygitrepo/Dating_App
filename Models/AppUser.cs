using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Date.Models
{
    public class AppUser
    {
        public int Id{get;set;}
        public string UserName { get; set; }

        public byte[] PassWordHash{get;set;}
        public byte[] PassWordSalt{get;set;}
    }
}