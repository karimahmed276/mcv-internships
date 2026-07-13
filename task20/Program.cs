using System;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: You cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter numbers only.");
            }
            finally
            {
                Console.WriteLine("Program Finished.");
            }

            Console.ReadKey();
        }
    }
}
