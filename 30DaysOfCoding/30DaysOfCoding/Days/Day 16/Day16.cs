using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_16
{
    public class Day16
    {
        public static void ExceptionStringToInt()
        {
            string S = Console.ReadLine();

            try
            {
                var intResult = Int32.Parse(S);
                Console.WriteLine(intResult);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
