using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_29
{
    public class Day29
    {
        public static void BitwiseAND()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);

                if (((k - 1) | k) > n && k % 2 == 0)
                    Console.WriteLine(k - 2);
                else
                    Console.WriteLine(k - 1);
            }
        }
    }
}
