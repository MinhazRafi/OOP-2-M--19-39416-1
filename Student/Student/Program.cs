using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=45;
            a = 40;
            const int course = 4;

            Console.WriteLine("hello world");
            Console.WriteLine("a is "+a);
            Console.WriteLine("course name is " +course);

            Student s=new Student();
            s.showInfo();
        }
    }
}
