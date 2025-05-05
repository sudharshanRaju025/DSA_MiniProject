using System;
using System.Buffers;
using System.Collections.Generic;
using DSA_MiniProject;

class Program
{
    /// <summary>
    /// student management system
    /// </summary>
    static List<Student> students = new List<Student> //list created for the students.
    {
        new Student(08,"sudharshan raju",98,"9392486441"),
        new Student(11,"sandy",97,"9765486441"),
        new Student(07,"sunny",95,"9395486441"),
        new Student(3,"samuel",94,"9392489841"),
        new Student(10,"alice",93,"9392678841"),
        new Student(01,"bob",90,"9393459841"),
        new Student(05,"alex",89,"9398489841"),
        new Student(33,"siri",87,"9392439841"),
    };

    //declaring one stack for removed students

    static Stack<Student> removedStudents = new Stack<Student>();


    //"it is the method which is used fro adding of the new student."
    static void AddStudent()
    {
        Console.WriteLine("enter the student id:");
        int identity=int.Parse(Console.ReadLine()!);

        if(identity < 0 || identity==0)//if any values entered like menetioned values.

        {
            Console.WriteLine("enter the valid identity.");
            Methods.Identity();    //calling the identity method from methods class.
        }

        Console.WriteLine("enter the name of the student:");
        string name = Console.ReadLine()!;

        if(name== @"[1-9]" || name == @"[@#$%]")// using regex we can enter the clean name of the student.
         {
            Console.WriteLine("enter the alphabetical name only...");
            Methods.naming();
         }

        Console.WriteLine("enter the marks of the student:");
        float marks = float.Parse(Console.ReadLine()!);
        Console.WriteLine("enter the mobile number:");
        string number = Console.ReadLine()!;
        if (number == @"[a-z]")  //using the regex we can enter the clean number of student.
        {
            Console.WriteLine("enter the valid numbers: ");
            Methods.Num();
        }

        students.Add(new Student(identity, name, marks, number));//adding of new studn=ent to the list.
        Console.WriteLine("student added.");
    }


    static void DeleteStudent()//deletion using refference of id.
    {
        Console.WriteLine("enter the identity of the student:");
        int id = Convert.ToInt32(Console.ReadLine()!);
        var roll_no = students.Find(s => s.Id == id);//here linq is used
        if (roll_no != null)//using of conditional
            {
            removedStudents.Push(roll_no);//pushing of the removing students into stack
            students.Remove(roll_no);
           
            Console.WriteLine("student removed.");
            }
            else if (roll_no == null)
            {
                Console.WriteLine("enter the student roll.");
            }
            else
            {
                Console.WriteLine("student not found.");
            }
        
    }

    static void SearchStudent()//searching using by id.
    {
        Console.WriteLine("enter the student id:");
        int roll = int.Parse(Console.ReadLine()!);
        if (roll <= 0)
        {
            Console.WriteLine("enter the valid identity");
            Methods.Identity();
        }

        var id = students.Find(s => s.Id == roll);//here linq is used
        if (id != null)
        {
            Console.WriteLine($"identity:{id.Id},Name:{id.Name},Marks:{id.Marks}");
        }
        else
        {
            Console.WriteLine("student details not found");
        }
    }

    static void DisplayAll()//displaying of all students in list.
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Roll_no:{student.Id},Name:{student.Name},Marks:{student.Marks},Mob_no:{student.mob_no}");
        }
    }

    static void SortByMarks()//sorting of the students by using marks.
    {

        students.Sort((x, y) => x.Marks.CompareTo(y.Marks));//here linq is used
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} - {student.Marks}");
        }
    }
    static void Average()//getting average of the allo students.
    {
        double Avg=students.Average(s=>s.Marks);
        Console.WriteLine($"average marks of the students:{Avg}");
    }

    static void Exit()
    {
        Environment.Exit(0);// exit from the home page.
    }

    static void removedstudents()//method for getting of removed students
    {
        foreach(var student in removedStudents)
        {
            Console.WriteLine($"id:{student.Id},Name:{student.Name},Marks:{student.Marks},mob_no:{student.mob_no}");
        }
    }

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student ");
            Console.WriteLine("3. Search Student ");
            Console.WriteLine("4. Display All");
            Console.WriteLine("5. Sort by Marks ");
            Console.WriteLine("6. Average");
            Console.WriteLine("7. Removedstudents");
            Console.WriteLine("8. Exit");
          
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)//using  if - elseif - else we can choose the choice.
                AddStudent();
            else if (choice == 2)
                DeleteStudent();
            else if (choice == 3)
                SearchStudent();
            else if (choice == 4)
                DisplayAll();
            else if (choice == 5)
                SortByMarks();
            else if (choice == 6)
                Average();
            else if (choice == 7)
                removedstudents();
            else if (choice == 8)
                Exit();
            else
            {
                Console.WriteLine("enter the valid option");
            }
        }
        while (choice!=8);
    } 
}
