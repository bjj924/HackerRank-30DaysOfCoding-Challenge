using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_19
{
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) sum += i;
            }
            return sum;
        }
    }
}
