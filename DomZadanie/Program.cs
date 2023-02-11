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

v
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
// Task 58
//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
void MatrixProizvedenie(int[,] matrixA , int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int[] StrokiAi = new int[matrixA.GetLength(0)], StolbBj = new int[matrixA.GetLength(0)];
    int ElementCi = 0;
    for (int ai = 0; ai < matrixA.GetLength(0); ai++)
    {
        
        for (int aj = 0; aj < matrixA.GetLength(1); aj++)
        {
            StrokiAi[aj] = matrixA[ai, aj];
        }
        for (int bj = 0; bj < matrixB.GetLength(1); bj++)
        {
            
            for (int bi = 0; bi < matrixB.GetLength(0); bi++)
            {
               StolbBj[bi] = matrixB[bi, bj];
            }
            ElementCi = 0;
            for (int ci = 0; ci < matrixC.GetLength(0); ci++)
            {
                ElementCi += StrokiAi[ci] * StolbBj[ci];
            }
            matrixC[ai, bj] = ElementCi ;
            Console.Write($"{matrixC[ai, bj]} \t");
        }
        Console.WriteLine();
    }

}

Console.Write("Введите размеры массива A через пробел: ");
int[] sizeA = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixA = new int[sizeA[0], sizeA[1]];
Console.Write("Введите размеры массива B через пробел: ");
int[] sizeB = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixB = new int[sizeB[0], sizeB[1]];
InputMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine();
InputMatrix(matrixB);
PrintMatrix(matrixB);
Console.WriteLine("Произведение матриц A и B: ");
MatrixProizvedenie(matrixA, matrixB);

*/
// Task 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
void InputMatrix3D(int[,,] matrix) // Ввод данных в массив
{
    int s = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = 10 + s;
                s++;
            }
        }
    }
}

void PrintMatrix3D(int[,,] matrix)  // печать массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
    }
}


Console.Write("Введите размеры трехмерного массива  через пробел: ");
int[] sizeA = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrixA = new int[sizeA[0], sizeA[1], sizeA[2]];
InputMatrix3D(matrixA);
PrintMatrix3D(matrixA);
Console.WriteLine();
*/

// Task 61 - без гугла не разобрался)
// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника
/*
Console.WriteLine("Введите номер строки N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int Sum = 1;
    for (int j = 0; j < n - i; j++)
    {
        Console.Write("   ");
    }

    for (int k = 0; k <= i; k++)
    {
        Console.Write("    {0:0} ", Sum);
        Sum = Sum * (i - k) / (k + 1);
    }
    Console.WriteLine();
   Console.WriteLine();
}
Console.WriteLine();
*/

// Task 62
// Заполните спирально массив 4 на 4.

void SpiralInputMatrix(int[,] matrix)
{
    int InputNumber = 1;
    int i = 0, j = 0, count = matrix.GetLength(0) + matrix.GetLength(1);
    for (int x = i; x < matrix.GetLength(1); x++)
    {
        matrix[i, x] = InputNumber;
        InputNumber++;
        j = x;
    }
    for (int x = i + 1; x < matrix.GetLength(0); x++)
    {
        matrix[x, j] = InputNumber;
        InputNumber++;
        i = x;
    }
    for (int x = j - 1; x >= 0; x--)
    {
        matrix[i, x] = InputNumber;
        InputNumber++;
        j = x;
    }
    for (int y = 1; y < count; y++)
    {
        for (int x = i - 1; x > 0; x--)
        {
            matrix[x, j] = InputNumber;
            InputNumber++;
            i = x;
            y++;
        }

        for (int x = j + 1; x < matrix.GetLength(1) - 1; x++)
        {
            matrix[i, x] = InputNumber;
            InputNumber++;
            j = x;
            y++;
        }
        for (int x = i + 1; x < matrix.GetLength(0) - 1; x++)
        {
            matrix[x, j] = InputNumber;
            InputNumber++;
            i = x;
            y++;
        }
        for (int x = j - 1; x > 0; x--)
        {
            matrix[i, x] = InputNumber;
            InputNumber++;
            j = x;
            y++;
        }

    }
}


Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
SpiralInputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
