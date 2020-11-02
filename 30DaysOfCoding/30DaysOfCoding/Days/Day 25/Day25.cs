using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_25
{
    public class Day25
    {
        public static void PrimeOrNot()
        {
            int numberOfInputs = Convert.ToInt32(Console.ReadLine());
            int i, j, inputNumber;
            string output;
            for (i = 1; i <= numberOfInputs; i++)
            {
                inputNumber = Convert.ToInt32(Console.ReadLine());
                for (j = 2; j <= inputNumber / j; j++)
                {
                    if (inputNumber % j == 0)
                        inputNumber = 1;
                }
                output = inputNumber == 1 ? "Not prime" : "Prime";
                Console.WriteLine(output);
            }
        }
    }
}
