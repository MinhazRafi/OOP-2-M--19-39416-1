using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5]{1,2,3,4,5};
            int sum = 0;
            
            for(int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
                Console.WriteLine("sum of the array elements is : "+sum);
                Console.WriteLine();
            }
            for(int i=arr.Length;i>0;i--)
            {
                Console.WriteLine("Reverse array elements:");
                Console.WriteLine(arr[i-1]);
            }

            int[] arr1 = new int[5];
            Console.WriteLine("Array elements :");
            for (int i = 0; i < arr1.Length;i++ )
            {
                arr1[i] = i;
                Console.WriteLine(" " + arr[i]);
            }
            Console.WriteLine("Copied elements :");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = arr1[i];
                
                Console.WriteLine(" " + arr1[i]);
            }
        }
    }
}
