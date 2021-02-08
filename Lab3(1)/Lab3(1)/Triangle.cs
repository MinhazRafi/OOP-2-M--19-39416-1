using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1_
{
    public class Triangle
    {
        int x;
        int y;
        int z;

         public Triangle( int x,int y,int z)
       {
           this.x=x;
           this.y=y;
           this.z=z;
           
       }
        public int X
        {
            set { this.x = value; }
            get { return x; }
        }
        public int Y
        {
            set { this.y = value; }
            get { return y; }
        }
        public int Z
        {
            set { this.z = value; }
            get { return z; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("\nx is : " + x);
            Console.WriteLine("y is : " + y);
            Console.WriteLine("z is : " + z);
           
        }
        public void TestTriangle()
        {
          if(x==y && y==z && x==z)
          {
              Console.WriteLine("triangle is equilateral");
          }
          else if(x==y && y==z)
          {
              Console.WriteLine("triangle is isosceles");
          }
          else
          {
              Console.WriteLine("triangle is scalene");
          }


        }
    }
}
