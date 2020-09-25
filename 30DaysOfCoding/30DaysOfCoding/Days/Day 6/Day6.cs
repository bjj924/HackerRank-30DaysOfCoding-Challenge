using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day6
{
    public class Day6
    {
        public static void Review()
        {
            Console.WriteLine("Ingrese un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese una palabra: ");
                var input = Console.ReadLine();
                var odd = String.Empty;
                var even = String.Empty;
                for (int x = 0; x < input.Length; x++)
                {
                    if (x % 2 == 0)
                    {
                        even += input[x];
                    }
                    else
                    {
                        odd += input[x];
                    }
                }

                Console.WriteLine("{0} {1}", even, odd);
            }
        }
    }
}
