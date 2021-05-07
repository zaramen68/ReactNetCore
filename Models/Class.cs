using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetCore.Models
{
    public class User
    {
        public int id { get; set; }
        public DateTime dateRagistration { get; set; }
        public DateTime dataLastActivity { get; set; }

    }
}
