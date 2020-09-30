using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_18
{
    public class Day18
    {
        public static void Palindrome()
        {
            string s = Console.ReadLine();

            Solution obj = new Solution();

            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
