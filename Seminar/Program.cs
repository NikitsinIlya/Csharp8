Console.Clear();
// Task 53
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
void InputAndPrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void TransponirMatrix(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0 && j < matrix.GetLength(1))
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[matrix.GetLength(0) - 1, j];
                matrix[matrix.GetLength(0) - 1, j] = temp;
            }

        }
    }
}
void PrintMatrix(int[,] matrix)
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

Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputAndPrintMatrix(matrix);
Console.WriteLine();
TransponirMatrix(matrix);
PrintMatrix(matrix);
*/

// Task 55
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)
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
void MatrixZamena(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
if (size[0] != size[1]) Console.WriteLine("Невозможно! Массив должен быть квадратным");
else
{
    InputMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    MatrixZamena(matrix);
    PrintMatrix(matrix);
}
*/

// task 57
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)
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
void MatrixPovtorElem(int[,] matrix)
{
    int count = 0, numb = 0;
    for (int k = 0; k < 11; k++)
    {
        count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(matrix[i, j] == k)
                {
                    count++;
                }
            }

        }
        if(count > 0) Console.WriteLine($"{k} Повторяется {count} раз.");
    }
}

Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
MatrixPovtorElem(matrix);
*/
// 2 способ через проверку уникального элемента.
/*
bool checkElement(int[] array, int number)
{
    foreach (int element in array)
    {
        if (number == element)
            return false;
    }
    return true;
}

int FillMatrix(int[,] matrix, int[] HelpArray)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int number = new Random().Next(1, 11);
            matrix[i, j] = number;
            if (checkElement(HelpArray, number) == true)
            {
                HelpArray[k] = number;
                k++;
            }
        }
    }
    return k;
}

void ScreenMatrix(int[,] matrix)
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

void ReleaseMatrix(int[,] matrix, int[] array, int count)
{
    for (int k = 0; k < count; k++)
    {
        int countUnieq = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (array[k] == matrix[i, j])
                    countUnieq++;
            }
        }
        Console.WriteLine($"Число {array[k]} встречается {count} раз"); 
    }
}

Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] HelpArray = new int[size[0]* size[1]];
int k = FillMatrix(matrix, HelpArray);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix, HelpArray, k);
*/

// Task 59
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)
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
void MinElement(int[,] matrix)
{
    int min = matrix[0, 0], mini = 0, minj = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= min)
            {
                min = matrix[i, j];
                mini = i;
                minj = j;
            }
        }
    }

    Console.WriteLine($"min = {min}; [{mini}, {minj}]");


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != mini)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != minj)
                    Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
MinElement(matrix);