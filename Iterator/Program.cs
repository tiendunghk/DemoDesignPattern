using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeList objEmpList = new EmployeeList();
            IEnumerator objEnumEmp = objEmpList.GetEnumerator();

            while (objEnumEmp.MoveNext())
            {
                Employee objEmployee = (Employee)objEnumEmp.Current;
                Console.WriteLine(objEmployee);
            }
        }
    }
}
