using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class EnumerateEmployee : IEnumerator
    {
        private int c_position;
        private Employee[] employees;
        public EnumerateEmployee()
        {
            c_position = -1;
            employees = new Employee[]
            {
                new Employee { Id = "nv1", Name = "Kamsa" },
                new Employee { Id = "nv2", Name = "Rama" },
                new Employee { Id = "nv3", Name = "Sita" },
                new Employee { Id = "nv4", Name = "Gopala" }
            };
        }
        public object Current => employees[c_position];

        public bool MoveNext()
        {
            bool b_return = false;
            ++c_position;
            if (c_position < employees.Length)
                b_return = true;
            return b_return;
        }

        public void Reset()
        {
            c_position = -1;
        }
    }
}
