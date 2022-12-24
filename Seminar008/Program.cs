// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3 4, 6, 1 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


// Задача 55
int[,] matrix = CreateArray(4, 5, 0, 10);
PrintMatrix(matrix);
// Console.WriteLine($"columnLengt = {matrix.GetLength(0)}");
// Console.WriteLine($"rowLength = {matrix.GetLength(1)}");

// Console.WriteLine("\n\nПеревернутый массив:");
// PrintMatrix(RotateMatrix(matrix));


// // Задача 57
// Console.WriteLine("\n\nКоличество вхождений элементов массива: ");
// PrintDictionary(GetDictionary(matrix));

// Задача 59
Console.WriteLine("\n\nНовый массив: ");

PrintMatrix(GetNewMatrix(matrix, GetIndexMinElement(matrix)));

int[,] GetNewMatrix(int[,] matrix, (int, int) tuple)
{
    int m = tuple.Item1;
    int n = tuple.Item2;
    int row = matrix.GetLength(0) - 1;
    int column = matrix.GetLength(1) - 1;

    int[,] newMatrix = new int[row, column];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(i != m || j != n)
            {
                int newRow = i;
                int newColumn = j;
                if (i > m)
                {
                    newRow = i - 1;
                }
                if (j > n)
                {
                    newColumn = j - 1;
                }
                newMatrix[newRow,newColumn] = matrix[i,j];
            } 
    }
    return newMatrix;
}


(int m, int n) GetIndexMinElement(int[,] matrix)
{
    var result = (0,0);
    int min = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(min > matrix[i,j])
            {
                min = matrix[i,j];
                result = (i, j);
            } 
    }
    return result;
}


Dictionary<int, int> GetDictionary(int[,] matrix)
{
    var dictionary = new Dictionary<int, int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(dictionary.ContainsKey(matrix[i, j]))
            {
                dictionary[matrix[i, j]] = dictionary[matrix[i, j]] + 1;
            } else 
            {
                dictionary[matrix[i, j]] = 1;
            }
    }

    return dictionary;
}

void PrintDictionary(Dictionary<int,int> dictionary) 
{
    foreach(var d in dictionary)
    {
        Console.WriteLine($"el: {d.Key}  count: {d.Value}");
    }
}


int[,] CreateArray(int columnLength, int rowLength, int min, int max)
{
    int[,] matrix = new int[columnLength, rowLength];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(min, max);
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int[,] RotateMatrix(int[,] oldMatrix)
{
    int oldColumnLengt = oldMatrix.GetLength(0);
    int oldRowLength = oldMatrix.GetLength(1);
    int[,] newMatrix = new int[oldRowLength, oldColumnLengt];

    for (int i = 0; i < oldRowLength; i++)
    {
        for (int j = 0; j < oldColumnLengt; j++)
            newMatrix[i, j] = oldMatrix[j, i];
    }
    return newMatrix;
}