using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public int Id;
    public string Name;
    public int Age;
    public string Department;
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        LoadStudents();

        AddStudent();

        SaveStudents();

        Console.WriteLine("Students Saved Successfully.");

        Console.ReadKey();
    }

    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter Id: ");
        s.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        s.Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Department: ");
        s.Department = Console.ReadLine();

        students.Add(s);
    }

    static void SaveStudents()
    {
        StreamWriter writer = new StreamWriter("students.txt");

        foreach (Student s in students)
        {
            writer.WriteLine(s.Id + "|" + s.Name + "|" + s.Age + "|" + s.Department);
        }

        writer.Close();
    }

    static void LoadStudents()
    {
        if (!File.Exists("students.txt"))
            return;

        string[] lines = File.ReadAllLines("students.txt");

        foreach (string line in lines)
        {
            string[] data = line.Split('|');

            Student s = new Student();

            s.Id = Convert.ToInt32(data[0]);
            s.Name = data[1];
            s.Age = Convert.ToInt32(data[2]);
            s.Department = data[3];

            students.Add(s);
        }
    }
}
