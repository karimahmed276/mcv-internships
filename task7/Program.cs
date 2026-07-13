using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;

            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Upper Case: " + fullName.ToUpper());
            Console.WriteLine("Lower Case: " + fullName.ToLower());
            Console.WriteLine("Number of Characters: " + fullName.Length);

            if (fullName.ToLower().Contains("a"))
            {
                Console.WriteLine("The name contains the letter a.");
            }
            else
            {
                Console.WriteLine("The name does not contain the letter a.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}