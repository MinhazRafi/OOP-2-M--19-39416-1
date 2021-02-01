using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace start
{
    class Program
    {
        static void Main(string[] args)
        {
           double x = 36, y = 4;
           Console.WriteLine("Input please");
           String name= Console.ReadLine();
           Console.Write("My name is "+name);
            
            Console.WriteLine("\nAddition of {0} and {1} is " +(x+y));
            Console.WriteLine("Subtraction of x and y is " +(x - y));
            Console.WriteLine("Multiple of x and y is " +(x*y));
            Console.WriteLine("division of x and y is " +(x/ y));
            Console.ReadKey();
        }
    }
}
