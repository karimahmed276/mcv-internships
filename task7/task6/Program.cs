using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            bool isValid = age >= 0;

            if (!isValid)
            {
                Console.WriteLine("Invalid Age");
            }
            else if (age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if (age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if (age <= 59)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}