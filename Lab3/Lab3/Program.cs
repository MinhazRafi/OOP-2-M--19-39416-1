using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n=10;
            for (int i = 1; i <= n; i++ )
            {
                if(i%2==0)
                {
                    Console.WriteLine("Even numbers from 1 to n is :"+i);
                }
            }
            double  Physics=78.9, Chemistry=85, Biology=90, Mathematics=88 ,Computer=90;
            double total = Physics+Chemistry+ Biology+ Mathematics+Computer;
            total = (total * 100) / 500;
            if(total>=90)
            {
                Console.WriteLine("Grade A+");
            }
            else if(total>= 85 && total < 89)
            {
                Console.WriteLine("Grade A");
            }
            else if (total >= 80 && total < 85)
            {
                Console.WriteLine("Grade B+");
            }
            else if (total >= 75 && total < 79)
            {
                Console.WriteLine("Grade B");
            }
            else if (total >= 50 && total < 75)
            {
                Console.WriteLine("Grade C+");
            }
            else if (total<50)
            {
                Console.WriteLine("Grade F");
            }
            else
            {
                Console.WriteLine("");
            }


        }
    }
}
