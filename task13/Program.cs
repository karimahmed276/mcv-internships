using System;

namespace Task13
{
    class Student
    {
        public string Name;
        public int Age;
        public string Department;

        public void Display()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
        }
    }
}
