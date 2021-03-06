﻿using System;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/573#3
/// Find the maximal sum of 3x3 matrix in matrix.
/// </summary>

namespace _4._Maximal_Sum
{
    class Program
    {
        static void Main()
        {

            int[] args = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = args[0];
            int cols = args[1];
            int[][] matrix = new int[rows][];
            string bestArgs=string.Empty;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            }

            int maxThreeByThreeSum=int.MinValue;
            int threeBythreeSum=0;
            int[][]best=new int[3][];

            for (int row = 0; row <= matrix.Length - 3; row++)
            {
                for (int col = 0; col <= cols - 3; col++)
                {
                   threeBythreeSum = matrix[row][col]+matrix[row][col+1]+matrix[row][col+2]+matrix[row+1][col]+matrix[row+1][col+1]+matrix[row+1][col+2]+matrix[row+2][col]+matrix[row+2][col+1]+matrix[row+2][col+2];

                    if (maxThreeByThreeSum<threeBythreeSum)
                    {
                        maxThreeByThreeSum=threeBythreeSum;
                        bestArgs=(matrix[row][col]+ " "+matrix[row][col+1]+ " "+matrix[row][col+2]+ Environment.NewLine+matrix[row+1][col]+" "+matrix[row+1][col+1]+" "+matrix[row+1][col+2]+Environment.NewLine+matrix[row+2][col]+" "+matrix[row+2][col+1]+" "+matrix[row+2][col+2]).ToString();
                    }
                }
            }

            Console.WriteLine($"Sum = {maxThreeByThreeSum}");
            Console.WriteLine(bestArgs);
        }
    }
}
