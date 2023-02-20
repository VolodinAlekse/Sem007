// Задача 49: Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols);

void PrintMatrix(int[,] matrix);

void ZamenaNechet(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 !=0 && j % 2 !=0)
            {
                matr[i, j] - matr[i, j] * matr[i, j];
            }
        }
    }
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы:");

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
ZamenaNechet(myMatrix);
System.Console.WriteLine();
PrintMatrix(myMatrix);