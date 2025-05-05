using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_MiniProject
{
    public class Student
    {
        private int Id;
        private string Name = "";
        private double mob_no;
        private int age;
        private string Course = "";

        public int Student_Id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Student_Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public double Mob_NO
        {
            get { return mob_no; }
            set { mob_no = value; }
        }
        public int Student_Age
        {
            get { return age; }
            set
            {
                if (value >= 10 && value <= 16)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("this age persons will not considered into the schools");
                }
            }

        }
        public class student_manager
        {
           private LinkedList<Student> list=new LinkedList<Student>();

            public void AddStudent(Student student)
            {
                list.AddLast(student);
                Console.WriteLine("student got admission successfully.");
            }

            public void Allrecords()
            {
                foreach(var s in list)
                {
                    Console.WriteLine(s);
                }
            }
        }

    }
}
