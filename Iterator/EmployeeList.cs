using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class EmployeeList : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new EnumerateEmployee();
        }
    }
}
