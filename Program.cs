﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        Random rand = new Random();

        Console.WriteLine("Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(101);
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        int trace = 0;
        Console.WriteLine("Main diagonal:");
        for (int i = 0; i < Math.Min(rows, cols); i++)
        {
            trace += matrix[i, i];
            Console.Write("*" + matrix[i, i] + "* ");
        }
        Console.WriteLine("\nTrace = " + trace);

        Console.WriteLine("Snail shell order:");
        int rowStart = 0, colStart = 0;
        while (rowStart < rows && colStart < cols)
        {
            for (int i = colStart; i < cols; i++)
            {
                Console.Write(matrix[rowStart, i] + " ");
            }
            rowStart++;

            for (int i = rowStart; i < rows; i++)
            {
                Console.Write(matrix[i, cols - 1] + " ");
            }
            cols--;

            if (rowStart < rows)
            {
                for (int i = cols - 1; i >= colStart; i--)
                {
                    Console.Write(matrix[rows - 1, i] + " ");
                }
                rows--;
            }

            if (colStart < cols)
            {
                for (int i = rows - 1; i >= rowStart; i--)
                {
                    Console.Write(matrix[i, colStart] + " ");
                }
                colStart++;
            }
        }

        Console.ReadLine();
    }
}


