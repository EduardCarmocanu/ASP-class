using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UclLib.Objects
{
    public class Person
    {
        public int CPR { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public Address Address { get; set; }
    }
}
