using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_MiniProject
{
    class Methods
    {
        public static void Identity()
        {
            Console.WriteLine("enter the id of the student:");
            int identity=int.Parse(Console.ReadLine()!);
        }

        public static void naming()
        {
            Console.WriteLine("enter the name of the student:");
            string name=Console.ReadLine()!;
        }

        public static void Num()
        {
            Console.WriteLine("enter the student number");
            string num=Console.ReadLine()!;
        }

      
    }
}
