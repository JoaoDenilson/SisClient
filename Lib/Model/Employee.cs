using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Model
{
    public sealed class Employee : Person
    {
        public string Occupation { get; set; }
        public double Wage { get; set; }
        public DateTime DateHiring { get; set; }

    }
}
