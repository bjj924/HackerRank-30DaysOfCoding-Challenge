using System.Linq;

namespace _30DaysOfCoding.Days.Day_12
{
    public class Student: Person
    {
        protected int[] scores;

        public Student() { }

        public Student(string firstName, string lastName, int id, int[] scores) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.scores = scores;
        }

        public char Calculate() 
        {
            var sum = scores.Sum() / scores.Length;

            if (90 <= sum && sum <= 100)
            {
                return 'O';
            }
            else if (80 <= sum  && sum < 90)
            {
                return 'E';
            }
            else if (70 <= sum && sum < 80)
            {
                return 'A';
            }
            else if (55 <= sum && sum < 70)
            {
                return 'P';
            }
            else if (40 <= sum && sum < 55)
            {
                return 'D';
            }
 
            return 'T';   
        }
    }
}
