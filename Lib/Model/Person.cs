using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Model
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public int CPF { get; set; }
        public string RG { get; set; }
        public string Phone { get; set; }
        public string CEP { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
    }
}
