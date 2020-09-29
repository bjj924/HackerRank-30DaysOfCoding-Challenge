using System;

namespace _30DaysOfCoding
{
    public class Program
    {
        static void Main(string[] args)
        {
            string challengeDay;

            Console.WriteLine("Enter the day you want to access (from 0 to 30)");
            Console.WriteLine("If you want to exit the program enter 'exit'");

            while ((challengeDay = Console.ReadLine()) != "exit")
            {
                int dayValue;
                int.TryParse(challengeDay, out dayValue);

                DaySwitch.ProcessInputDay(dayValue);

                Console.WriteLine("\nIf you want to check another exercise enter the day or enter 'exit' to quit: ");
            }

            Console.ReadKey();
        }
    }
}
