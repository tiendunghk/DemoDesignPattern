using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class StudentConcreteBuilder : IStudentBuilder
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _dayOfBirth;
        private string _currentClass;
        private string _phone;
        public Student Build()
        {
            return new Student(_id, _firstName, _lastName, _dayOfBirth, _currentClass, _phone);
        }

        public IStudentBuilder SetCurrentClass(string currentClass)
        {
            this._currentClass = currentClass;
            return this;
        }

        public IStudentBuilder SetDayOfBirth(DateTime dayOfBirth)
        {
            this._dayOfBirth = dayOfBirth;
            return this;
        }

        public IStudentBuilder SetFirstName(string firstName)
        {
            this._firstName = firstName;
            return this;
        }

        public IStudentBuilder SetId(int id)
        {
            this._id = id;
            return this;
        }

        public IStudentBuilder SetLastName(string lastName)
        {
            this._lastName = lastName;
            return this;
        }

        public IStudentBuilder SetPhone(string phone)
        {
            this._phone = phone;
            return this;
        }
    }
}
