// Задача 1 Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет

// Random rand = new Random();


// Console.Write("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());


// int[,] matrix = new int[rows, cols];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = rand.Next(10);
//     }
// }


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         System.Console.Write(matrix[i, j] + "\t");
//     }
//     System.Console.WriteLine();
// }


// Console.Write("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int col = Convert.ToInt32(Console.ReadLine());



// static int GetElement(int[,] matrix, int row, int col)
// {
//     if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
//     {
//         return matrix[row, col];
//     }
//     else
//     {
//         return int.MinValue;    
//     }
// }

// int element = GetElement(matrix, row, col);

// if (element == int.MinValue)
// {
//     Console.WriteLine("Значения не существует");
// }
// else
// {
//     Console.WriteLine("Значение элемента -> " + element);
// }


// Задача 2: Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и 
// последнюю строку массива.

// Random rand = new Random();


// Console.Write("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());


// int[,] matrix = new int[rows, cols];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = rand.Next(10);
//     }
// }


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         System.Console.Write(matrix[i, j] + "\t");
//     }
//     System.Console.WriteLine();
// }


// static void ChangeRows(int[,] matrix, int row1, int row2)
// {
//      int numCols = matrix.GetLength(1);

//      for (int col = 0; col < numCols; col++)
//      {
//         int temp = matrix[row1, col];
//         matrix[row1, col] = matrix[row2, col];
//         matrix[row2, col] = temp;
//     }
// }

// static void PrintMatrix(int[,] matrix)
// {
//     int numRows = matrix.GetLength(0);
//     int numCols = matrix.GetLength(1);

//     for (int row = 0; row < numRows; row++)
//     {
//         for (int col = 0; col < numCols; col++)
//         {
//             Console.Write(matrix[row, col] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// ChangeRows(matrix, 0, matrix.GetLength(0) - 1);

// Console.WriteLine("\nМассив после обмена строк:");
// PrintMatrix(matrix);


// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

Random rand = new Random();


Console.Write("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[rows, cols];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rand.Next(10);
    }
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write(matrix[i, j] + "\t");
    }
    System.Console.WriteLine();
}

static int RowMinSum(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int row = 0; row < numRows; row++)
        {

            int currentSum = 0;
            for (int col = 0; col < numCols; col++)
            {
                currentSum += matrix[row, col];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRowIndex = row;
            }
        }

        return minSumRowIndex;
    }

int minSumRowIndex = RowMinSum(matrix);

Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {minSumRowIndex}");