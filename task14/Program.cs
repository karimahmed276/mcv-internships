using System;

namespace Task14
{
    class Student
    {
        public string Name;
        public int Age;
        public string Department;

        public Student(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department;
        }

        public void Display()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
        }
    }
}
