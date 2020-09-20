using _30DaysOfCoding.Days.Day0;
using _30DaysOfCoding.Days.Day1;
using _30DaysOfCoding.Days.Day2;
using _30DaysOfCoding.Days.Day3;
using _30DaysOfCoding.Days.Day4;
using _30DaysOfCoding.Days.Day5;
using _30DaysOfCoding.Days.Day6;
using _30DaysOfCoding.Days.Day7;
using System;

namespace _30DaysOfCoding
{
    public class DaySwitch
    {
        public static void ProcessInputDay(int dayValue)
        {
            switch (dayValue)
            {
                case 0:
                    Day0.CallGreet();
                    break;
                case 1:
                    Day1.ReturnSumByType();
                    break;
                case 2:
                    Day2.InputValues();
                    break;
                case 3:
                    Day3.ConditionalStaments();
                    break;
                case 4:
                    Day4.PersonAge();
                    break;
                case 5:
                    Day5.MultiplicationTable();
                    break;
                case 6:
                    Day6.Review();
                    break;
                case 7:
                    Day7.ArrayNumber();
                    break;
                default:
                    Console.WriteLine("Coming soon...");
                    break;
            }
        }
    }
}
