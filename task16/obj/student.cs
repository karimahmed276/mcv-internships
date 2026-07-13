using System;

namespace Task16
{
    class Student : Person
    {
        public string Department;

        public void DisplayStudent()
        {
            DisplayPerson();
            Console.WriteLine("Department: " + Department);
        }
    }
}