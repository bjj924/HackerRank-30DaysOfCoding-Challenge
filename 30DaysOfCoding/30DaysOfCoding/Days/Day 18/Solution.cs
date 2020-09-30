using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_18
{
    public class Solution
    {
        public Stack<char> charS = new Stack<char>();

        public Queue<char> charQ = new Queue<char>();
        public void pushCharacter(char c)
        {
            charS.Push(c);
        }

        public char popCharacter()
        {
            return charS.Pop();
        }
        public void enqueueCharacter(char c)
        {
            charQ.Enqueue(c);
        }

        public char dequeueCharacter()
        {
            return charQ.Dequeue();
        }
    }
}
