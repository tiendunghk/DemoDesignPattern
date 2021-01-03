using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DayOfBirth { get; set; }
        public string CurrentClass { get; set; }
        public string Phone { get; set; }
        public Student(int id, string firstName, string lastName, DateTime dayOfBirth, string currentClass, string phone)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DayOfBirth = dayOfBirth;
            this.CurrentClass = currentClass;
            this.Phone = phone;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
