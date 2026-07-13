using System;

namespace Task15
{
    class Student
    {
        private string name;
        private int age;
        private string department;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
            }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
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
