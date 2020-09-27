using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30DaysOfCoding.Days.Day_14
{
    public class Day14
    {
        public static void AbsoluteNumber()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
