using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_19
{
    class Day19
    {
        public static void InterfaceExcersise()
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
