using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_14
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference() { }

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference() 
        {
            Array.Sort(elements);

            maximumDifference = Math.Abs(elements[elements.Length - 1]) - Math.Abs(elements[0]);

        }
    }
}
