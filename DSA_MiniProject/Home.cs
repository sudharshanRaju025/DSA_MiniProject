using System;
using System.Collections.Generic;
using System.Linq;
using DSA_MiniProject;

class Program
{
    static LinkedList<Student> students = new LinkedList<Student>();
        //new[]
        //{
        //    new Student(08, "sudharshan raju", 98, "9392486441"),
        //    new Student(11, "sandy", 97, "9765486441"),
        //    new Student(07, "sunny", 95, "9395486441"),
        //    new Student(3, "samuel", 94, "9392489841"),
        //    new Student(10, "alice", 93, "9392678841"),
        //    new Student(01, "bob", 90, "9393459841"),
        //    new Student(05, "alex", 89, "9398489841"),
        //    new Student(33, "siri", 87, "9392439841"),
        //}
   

    static Stack<Student> removedStudents = new Stack<Student>();

    static void AddStudent()
    {
        Console.WriteLine("Enter the student id:");
        int identity = int.Parse(Console.ReadLine()!);

        if (identity <= 0)
        {
            Console.WriteLine("Enter a valid identity.");
            Methods.Identity();
        }

        Console.WriteLine("Enter the name of the student:");
        string name = Console.ReadLine()!;
        // Ideally should use Regex.IsMatch(name, pattern) instead of checking string equality
        Console.WriteLine("Enter the marks of the student:");
        float marks = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter the mobile number:");
        string number = Console.ReadLine()!;

        students.AddLast(new Student(identity, name, marks, number));
        Console.WriteLine("Student added.");
    }

    static void DeleteStudent()
    {
        Console.WriteLine("Enter the identity of the student:");
        int id = Convert.ToInt32(Console.ReadLine()!);

        var node = students.First;
        while (node != null)
        {
            if (node.Value.Id == id)
            {
                removedStudents.Push(node.Value);
                students.Remove(node);
                Console.WriteLine("Student removed.");
                return;
            }
            node = node.Next;
        }

        Console.WriteLine("Student not found.");
    }

    static void SearchStudent()
    {
        Console.WriteLine("Enter the student id:");
        int roll = int.Parse(Console.ReadLine()!);
        if (roll <= 0)
        {
            Console.WriteLine("Enter a valid identity.");
            Methods.Identity();
        }

        foreach (var s in students)
        {
            if (s.Id == roll)
            {
                Console.WriteLine($"Id:{s.Id}, Name:{s.Name}, Marks:{s.Marks}, Mobile:{s.mob_no}");
                return;
            }
        }

        Console.WriteLine("Student details not found.");
    }

    static void DisplayAll()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Id:{student.Id}, Name:{student.Name}, Marks:{student.Marks}, Mobile:{student.mob_no}");
        }
    }

    static void SortByMarks()
    {
        var sorted = students.OrderBy(s => s.Marks).ToList();
        foreach (var student in sorted)
        {
            Console.WriteLine($"{student.Name} - {student.Marks}");
        }
    }

    static void Average()
    {
        double avg = students.Average(s => s.Marks);
        Console.WriteLine($"Average marks of the students: {avg}");
    }

    static void removedstudents()
    {
        foreach (var student in removedStudents)
        {
            Console.WriteLine($"Id:{student.Id}, Name:{student.Name}, Marks:{student.Marks}, Mobile:{student.mob_no}");
        }
    }

    static void Exit()
    {
        Environment.Exit(0);
    }

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Display All");
            Console.WriteLine("5. Sort by Marks");
            Console.WriteLine("6. Average");
            Console.WriteLine("7. Removed Students");
            Console.WriteLine("8. Exit");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) AddStudent();
            else if (choice == 2) DeleteStudent();
            else if (choice == 3) SearchStudent();
            else if (choice == 4) DisplayAll();
            else if (choice == 5) SortByMarks();
            else if (choice == 6) Average();
            else if (choice == 7) removedstudents();
            else if (choice == 8) Exit();
            else Console.WriteLine("Enter a valid option.");
        } while (choice != 8);
    }
}
