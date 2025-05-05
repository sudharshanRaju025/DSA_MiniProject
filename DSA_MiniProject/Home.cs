using System;
using System.Collections.Generic;
using DSA_MiniProject;

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student ");
            Console.WriteLine("3. Delete Student ");
            Console.WriteLine("4. Search Student ");
            Console.WriteLine("5. Search Student ");
            Console.WriteLine("6. Display All");
            Console.WriteLine("7. Sort by Marks ");
            Console.WriteLine("8. Sort by Marks ");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                AddStudent();
            else if (choice == 2)
                DeleteStudent();
            else if (choice == 3)
                DeleteStudent();
            else if (choice == 4)
                SearchStudent();
            else if (choice == 5)
                SearchStudent();
            else if (choice == 6)
                DisplayAll();
            else if (choice == 7)
                SortByMarks();
            else if (choice == 8)
                SortByMarks();
            else
                Console.WriteLine("Invalid choice.");

        }
        while (choice!=6);

     
    }

    static void AddStudent()
    {

    }
}
