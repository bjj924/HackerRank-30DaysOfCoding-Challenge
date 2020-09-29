using _30DaysOfCoding.Days.Day_12;
using _30DaysOfCoding.Days.Day_13;
using _30DaysOfCoding.Days.Day_14;
using _30DaysOfCoding.Days.Day_15;
using _30DaysOfCoding.Days.Day_16;
using _30DaysOfCoding.Days.Day_17;
using _30DaysOfCoding.Days.Day0;
using _30DaysOfCoding.Days.Day1;
using _30DaysOfCoding.Days.Day10;
using _30DaysOfCoding.Days.Day11;
using _30DaysOfCoding.Days.Day2;
using _30DaysOfCoding.Days.Day3;
using _30DaysOfCoding.Days.Day4;
using _30DaysOfCoding.Days.Day5;
using _30DaysOfCoding.Days.Day6;
using _30DaysOfCoding.Days.Day7;
using _30DaysOfCoding.Days.Day8;
using _30DaysOfCoding.Days.Day9;
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
                case 8:
                    Day8.PhoneDirectory();
                    break;
                case 9:
                    Day9.FactorialNumber();
                    break;
                case 10:
                    Day10.ConvertNumber();
                    break;
                case 11:
                    Day11.HourGlass2DArray();
                    break;
                case 12:
                    Day12.InharenceExercise();
                    break;
                case 13:
                    Day13.AbstractClassExercise();
                    break;
                case 14:
                    Day14.AbsoluteNumber();
                    break;
                case 15:
                    Day15.LinkedList();
                    break;
                case 16:
                    Day16.ExceptionStringToInt();
                    break;
                case 17:
                    Day17.NonNegativesNumbers();
                    break;
                default:
                    Console.WriteLine("Coming soon...");
                    break;
            }
        }
    }
}
