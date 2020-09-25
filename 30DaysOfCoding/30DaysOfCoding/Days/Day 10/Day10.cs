using System;
using System.Linq;

namespace _30DaysOfCoding.Days.Day10
{
    public class Day10
    {
        public static void ConvertNumber()
        {
            Console.WriteLine("Ingrese un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToString(n, 2);
            string[] arr = b.Split('0').ToArray();
            int c = arr.Select(x => x.Length).Max();
            Console.WriteLine(c);
        }
    }
}
