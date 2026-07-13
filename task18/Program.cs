using System;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            student.Display();

            Console.ReadKey();
        }
    }
}