using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IStudentBuilder
    {

        IStudentBuilder SetId(int id);

        IStudentBuilder SetFirstName(string firstName);

        IStudentBuilder SetLastName(string lastName);

        IStudentBuilder SetDayOfBirth(DateTime dayOfBirth);

        IStudentBuilder SetCurrentClass(string currentClass);

        IStudentBuilder SetPhone(string phone);

        Student Build();
    }
}
