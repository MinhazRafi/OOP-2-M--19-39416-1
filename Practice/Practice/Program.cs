using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Print1DArray(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }
            Console.WriteLine("");
            foreach (int n in arr)
            {
                Console.WriteLine(n+"");
            }
            Console.WriteLine("");
        }
        static void Print2DArray(String [,] arr)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine(arr[i,j]+"");
                }
            }
            Console.WriteLine("");
        }
        static void PrintJaggedArray(int [][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j]+"");
                }
                Console.WriteLine("");
                
            }
            foreach (int[] j in arr)
            {
                foreach(int num in j)
                {
                    Console.WriteLine(num + "");
                }
                Console.WriteLine("");
            }

        }
        static int Sum (params int[] a)
        {
            int sum = 0;
            foreach(int x in a)
            {
                sum = sum + x;
                
            }
            
            return sum;
            
            
        }
        

        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4 };
            Print1DArray(arr);
            string[,] arr2 = { {"Rafi","lamisha"},
                               {"Radia","Rusli"},
                               {"Monjila","Hafez"}, };
            Print2DArray(arr2);
            int[][] jagged = { new int []  {1,2,3,4},
                               new int []  {11,22,33,44},
                               new int []  {111,222,333,444,555},
                             };
            PrintJaggedArray(jagged);
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(1,2,3,5));
            Console.WriteLine(Sum(arr));
            Console.WriteLine(Sum(4,60));
            Console.WriteLine("");

        }
    }
}
