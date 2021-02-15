using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPassValRef
{
    class Program
    {
        static void Main(string[]args)
        {
            Student s1 = new Student("Tanvir", "1234");
            Student s2 = new Student("Sanvir", "3456");
            Student s3 = new Student("Sanvir", "3456");
            Student s4 = new Student("Sanvir", "3456");
            Console.WriteLine(s1.Name + " " +s2.Name+"\n");
            Console.WriteLine(Student.count);
        }
    }
}
