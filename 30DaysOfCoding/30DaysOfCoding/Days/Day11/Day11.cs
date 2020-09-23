using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day11
{
    public class Day11
    {
        public static void HourGlass2DArray()
        {
            int[][] arr = new int[6][];
            int result = -100;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese un numero para la matriz: ");
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int rowCount = arr.Length;
            int columnCount = arr[0].Length;

            for (int c = 0; c < columnCount - 2; c++)
            {
                for (int r = 0; r < rowCount - 2; r++)
                {
                    int firstRowSum = arr[r][c] + arr[r][c + 1] + arr[r][c + 2];
                    int secondRowSum = arr[r + 1][c + 1];
                    int thirdRowSum = arr[r + 2][c] + arr[r + 2][c + 1] + arr[r + 2][c + 2];
                    int totalHourGlass = firstRowSum + secondRowSum + thirdRowSum;

                    result = Math.Max(result, totalHourGlass);
                }
            }

            Console.WriteLine(result);
        }
    }
}
