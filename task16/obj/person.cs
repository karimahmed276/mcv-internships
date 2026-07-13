using System;

namespace Task16
{
    class Person
    {
        public string Name;
        public int Age;

        public void DisplayPerson()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}