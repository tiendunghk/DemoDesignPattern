using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
