using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day20
{
    public class Day20
    {
        public static void SortingValue()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int numberOfSwaps = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        Array.Reverse(a, j, 2);
                        numberOfSwaps++;
                    }
                }

                if (numberOfSwaps == 0) break;
            }

            int firstPosition = a[0];
            int lastPosition = a[a.Length - 1];

            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            Console.WriteLine($"First Element: {firstPosition}");
            Console.WriteLine($"Last Element: {lastPosition}");
        }
    }
}
