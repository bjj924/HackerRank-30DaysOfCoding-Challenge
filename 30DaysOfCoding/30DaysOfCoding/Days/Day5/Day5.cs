using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day5
{
    public class Day5
    {
        public static void MultiplicationTable()
        {
            Console.WriteLine("Ingrese el numero al cual quiere revisar sus resultados");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                var value = 0;
                value = n * i;
                Console.WriteLine("{0} x {1} = {2}", n, i, value);

            }
        }
    }
}
