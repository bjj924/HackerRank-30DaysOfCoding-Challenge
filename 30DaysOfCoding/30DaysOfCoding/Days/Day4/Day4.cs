using System;

namespace _30DaysOfCoding.Days.Day4
{
    public class Day4
    {
        public static void PersonAge()
        {
            Console.WriteLine("Insert the number of you want to evaluate: ");
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("Insert the age: ");
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }
}
