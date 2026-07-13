using System;

namespace Task18
{
    class Student : Person
    {
        public override void Display()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}