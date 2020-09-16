using System;

namespace _30DaysOfCoding.Days.Day4
{
    public class Person
    {
        public int age { get; set; }

        public Person(int initialAge)
        {
            age = initialAge;
        }

        public void amIOld()
        {
            if (age <= 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
                Console.WriteLine("You are young.");
            }
            else if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }

        }

        public void yearPasses()
        {
            age = age + 1;
        }
    }
}
