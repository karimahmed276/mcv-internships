using System;

namespace Task19
{
    class Student : IStudent
    {
        public string Name;
        public int Age;

        public void Display()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}