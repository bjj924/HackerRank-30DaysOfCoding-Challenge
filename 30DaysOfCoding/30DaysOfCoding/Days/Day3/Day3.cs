using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30DaysOfCoding.Days.Day3
{
    public class Day3
    {
        public static void ConditionalStaments()
        {
            Console.WriteLine("Inserte un numero por favor: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Solve(N);
        }

        private static void Solve(int N)
        {
            if (Enumerable.Range(1, 100).Contains(N))
            {
                if (Enumerable.Range(2, 5).Contains(N) && N % 2 == 0
                    || N > 20 && N % 2 == 0)
                {
                    Console.Write("Not Weird");
                }
                else
                {
                    Console.Write("Weird");
                }
            }

        }
    }
}
