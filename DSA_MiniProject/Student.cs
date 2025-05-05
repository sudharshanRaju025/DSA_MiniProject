using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_MiniProject
{
    public class Student//we can access this student class anywhere.
    {
        //proeperties
        public int Id; 
        public string Name;
        public float Marks;
        public string mob_no;

        public Student(int identity, string name, float marks,string Mob_no)//constructor for the student.
            {
                Id = identity;
                Name = name;
                Marks = marks;
                mob_no= Mob_no;
        }

        
        

    }
}
