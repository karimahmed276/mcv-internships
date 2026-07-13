using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("===== Calculator Menu =====");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Modulus");
                Console.WriteLine("6. Exit");

                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                {
                    Console.WriteLine("Program Closed.");
                    break;
                }

                Console.Write("Enter First Number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result = " + (num1 + num2));
                        break;

                    case 2:
                        Console.WriteLine("Result = " + (num1 - num2));
                        break;

                    case 3:
                        Console.WriteLine("Result = " + (num1 * num2));
                        break;

                    case 4:
                        if (num2 != 0)
                            Console.WriteLine("Result = " + (num1 / num2));
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;

                    case 5:
                        if (num2 != 0)
                            Console.WriteLine("Result = " + (num1 % num2));
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

                Console.WriteLine();

            } while (true);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}