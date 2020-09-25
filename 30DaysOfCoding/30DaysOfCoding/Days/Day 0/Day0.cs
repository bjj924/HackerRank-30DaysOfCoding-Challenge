using System;

namespace _30DaysOfCoding.Days.Day0
{
    public class Day0
    {
        public static void CallGreet()
        {
            string inputString;

            Console.WriteLine("\nPlease write here and then press enter: ");

            inputString = Console.ReadLine();

            Console.WriteLine("Hello, World!");
         
            Console.WriteLine(Greet(inputString));
        }

        public static string Greet(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return "Sin Input";
            }

            return inputString;
        }
    }
}
