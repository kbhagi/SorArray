using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortArrayAscendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n Unsorted array: ");
            foreach (int i in arr)
            {
                Console.Write("\t{0}", i);
            }
            Array.Sort(arr);
            Console.Write("\nSorted array: ");
            foreach (int i in arr)
            {
                Console.Write("\t{0}", i);
            }
            Console.ReadLine();

        }
    }
}
