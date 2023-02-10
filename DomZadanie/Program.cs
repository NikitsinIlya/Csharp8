Console.Clear();

// Часто используемые методы. 

void InputMatrix(int[,] matrix) // Ввод данных в массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)  // печать массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// Task 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void MatrixSortStrok(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                int temp = 0;
                if (matrix[i, j] < matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
MatrixSortStrok(matrix);
PrintMatrix(matrix);
*/
// Task 56
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
/*
void SummaMinSroki(int[,] matrix)
{
    int SumElement = 0, MinSummElement = 1000, IndexMini = 0;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    SumElement = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        SumElement += matrix[i, j];
    }
    if(SumElement < MinSummElement) 
    {
        MinSummElement = SumElement;
        IndexMini = i;
    }
   } 
   Console.WriteLine($" Номер строки с минимальной суммой элементов : {IndexMini + 1}");
}
Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SummaMinSroki(matrix);
*/
