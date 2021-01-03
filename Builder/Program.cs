using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentBuilder studentBuilder = new StudentConcreteBuilder()
                .SetFirstName("Nguyen")
                .SetLastName("Tien Dung");
            Console.WriteLine(studentBuilder.Build());
        }
    }
}
