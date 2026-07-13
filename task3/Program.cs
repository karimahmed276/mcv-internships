using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Addition = " + (num1 + num2));
            Console.WriteLine("Subtraction = " + (num1 - num2));
            Console.WriteLine("Multiplication = " + (num1 * num2));

            if (num2 != 0)
            {
                Console.WriteLine("Division = " + (num1 / num2));
                Console.WriteLine("Modulus = " + (num1 % num2));
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
