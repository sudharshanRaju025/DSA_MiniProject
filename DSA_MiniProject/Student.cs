using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_MiniProject
{
    public class Student
    {


        public int Id;
        public string Name;
        public float Marks;
        public int age;
        public double mob_no;

        public Student(int identity, string name, float marks,int Age,double Mob_No)
            {
                Id = identity;
                Name = name;
                Marks = marks;
                age = Age;
                mob_no= Mob_No;
        }
        

    }
}
