﻿using _30DaysOfCoding.Days.Day0;
using _30DaysOfCoding.Days.Day1;
using _30DaysOfCoding.Days.Day2;
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

                ProcessInputDay(dayValue);

                Console.WriteLine("\nIf you want to check another exercise enter the day: ");
            }

            Console.ReadKey();
        }

        private static void ProcessInputDay(int dayValue)
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
                default:
                    Console.WriteLine("Coming soon...");
                    break;
            }
        }
    }
}
