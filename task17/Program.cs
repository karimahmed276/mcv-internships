using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Display();

            Student student = new Student();
            student.Display();

            Console.ReadKey();
        }
    }
}
