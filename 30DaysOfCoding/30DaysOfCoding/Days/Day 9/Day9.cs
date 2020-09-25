using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _30DaysOfCoding.Days.Day9
{
    public class Day9
    {
        public static void FactorialNumber()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = ReturnFactorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        private static int ReturnFactorial(int n)
        {
            if (n >= 1)
            {
                return n * ReturnFactorial(n - 1);

            }
            return 1;
        }
    }
}
