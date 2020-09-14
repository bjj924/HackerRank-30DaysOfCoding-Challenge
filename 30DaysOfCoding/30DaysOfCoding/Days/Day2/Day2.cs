using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day2
{
    public class Day2
    {
        public static void InputValues() 
        {
            Console.WriteLine("Ingrese el valor de la comida: ");
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la propina: ");
            int tip_percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de impuesto que aplica: ");
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            Solve(meal_cost, tip_percent, tax_percent);
        }

        private static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tip = (meal_cost * tip_percent) / 100;
            var tax = (meal_cost * tax_percent) / 100;
            var totalCost = meal_cost + tip + tax;

            Console.Write("{0:0}", totalCost);
        }
    }
}
