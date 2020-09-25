using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day7
{
    public class Day7
    {
        public static void ArrayNumber()
        {
            Console.WriteLine("Write a number");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] arr2 = arr;
            Array.Reverse(arr2);
            foreach (int i in arr2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
