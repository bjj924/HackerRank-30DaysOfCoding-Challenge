using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day1
{
    public class Day1
    {
        static int i = 4;
        static double d = 4.0;
        static string s = "HackerRank ";
        
        public static void ReturnSumByType()
        {
            int x;
            double y;
            string z;

            Console.WriteLine("Ingrese un numero entero por favor: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero del tipo double por favor: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese una cadena de texto por favor: ");
            z = Console.ReadLine();

            ConcatenateAndShowResults(x, y, z);
        }

        private static void ConcatenateAndShowResults(int x, double y, string z)
        {
            Console.WriteLine(i + x);
            Console.WriteLine(d + y);
            Console.WriteLine(s + z);
        }
    }
}
