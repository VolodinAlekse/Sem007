//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System;

namespace task47
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество строк матрицы:");
            int linesVol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы:");
            int columnsVol = Convert.ToInt32(Console.ReadLine());
            double[,] numbers = new double[linesVol, columnsVol];
            FillArrayRandomNumbers(numbers);
            PrintArray(numbers);

            void FillArrayRandomNumbers(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                    }
                }
            }

            void PrintArray(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
        }
    }
}