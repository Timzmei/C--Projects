// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Задача 54. Решение
Console.WriteLine("Задача 54");
int[,] matrix = Create2DMatrix(4, 5, 0, 10); // Создаем массив
Console.WriteLine("Массив:");
Print2DMatrix(matrix); //Печатаем в консоли массив
Console.WriteLine("\n");
Console.WriteLine("Отсортированный массив:");
Print2DMatrix(GetSortedMatrix(matrix)); //Сортруем массив и выводим отсортированный массив на печать


// Задача 56. Решение
Console.WriteLine("\n\nЗадача 56");
var minSumRow = GetMinSumRow(matrix);
Console.WriteLine($"\n\nМинимальная сумма {minSumRow.Item2} в строке {minSumRow.Item1}");

// Задача 58. Решение
Console.WriteLine("\n\nЗадача 58");
int[,] matrixA = Create2DMatrix(4, 5, 0, 10); // Создаем массив
Console.WriteLine("\nМассив A:");
Print2DMatrix(matrixA);
int[,] matrixB = Create2DMatrix(5, 4, 0, 10); // Создаем массив
Console.WriteLine("\nМассив B:");
Print2DMatrix(matrixB);
Console.WriteLine("\nМассив полученный в результате произведения матрицы А на матрицу В:");
Print2DMatrix(GetMultiplicationMatrix(matrixA, matrixB));

// Задача 60. Решение
Console.WriteLine("\n\nЗадача 60");
int[,,] matrix3D = Create3DMatrix(3, 3, 3, 10, 100);
Print3DMatrix(matrix3D);

// Задача 62. Решение
Console.WriteLine("\n\nЗадача 62");
int[,] matrixSpiral = Create2DSpiralMatrix(4,4,0,50);
Console.WriteLine("\nМассив заполненый по спирали:\n");
Print2DMatrix(matrixSpiral);


int[,] GetMultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowA = matrixA.GetLength(0);
    int columnA = matrixA.GetLength(1);
    int rowB = matrixB.GetLength(0);
    int columnB = matrixB.GetLength(1);

    int[,] matrixResult = new int[rowA, columnB];

    if(columnA != rowB)
    {
        return null;
    }

    for(int mA = 0; mA < rowA; mA++)
    {
        for(int nB = 0; nB < columnB; nB++)
        {
            int sum = 0;
            for(int mB = 0; mB < rowB; mB++)
            {
                sum += matrixA[mA, mB] * matrixB[mB, nB];   
            }
            matrixResult[mA, nB] = sum;
        }
    }
    return matrixResult;
}


(int row, int sum) GetMinSumRow(int[,] matrix)
{
    int sum = GetSumRow(matrix, 0);
    var result = (1, sum);
    for (int m = 1; m < matrix.GetLength(0); m++)
    {
        int nextSum = GetSumRow(matrix, m);
        if(sum > nextSum)
        {
            sum = nextSum;
            result = (m + 1,sum);
        }
    }
    return result;
}

int GetSumRow(int[,] matrix, int m)
{
    int sum = 0;
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        sum += matrix[m, n];
    }
    return sum;
}


// Сортировка массива построчно
int[,] GetSortedMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int[,] sortedMatrix = new int[row, column];
    for (int m = 0; m < row; m++)
    {
        int[] rowArray = new int[column];
        //Получение строки массива в переменную rowArray
        for (int n = 0; n < column; n++)
        {
            rowArray[n] = matrix[m,n];
        }
        var sortedRow = GetSortedRow(rowArray); //Сортировка массива(строки)
        for (int n = 0; n < sortedRow.Length; n++)
        {
            sortedMatrix[m,n] = sortedRow[n]; //Записываем в массив отсортированную строку
        }
    }
    return sortedMatrix;
}

//Сортировка одномерного массива (строки) "пузырьком"
int[] GetSortedRow(int[] array)
{
    for (int j = 0; j < array.Length; j++) 
    {
        for (int i = 0; i < array.Length - 1; i++) 
        {
            if (array[i] < array[i + 1]) 
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            } else 
            {
                array[i] = array[i];
                array[i + 1] = array[i + 1];
            }
        }
    }
    return array;
}

int[,] Create2DMatrix(int columnLength, int rowLength, int min, int max)
{
    int[,] matrix = new int[columnLength, rowLength];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);  
        }
        
    }
    return matrix;
}

int[,] Create2DSpiralMatrix(int columnLength, int rowLength, int min, int max)
{
    int[,] matrix = new int[columnLength, rowLength];
    int m = 0;
    int dm = 0;
    int mEnd = matrix.GetLength(0);
    int n = 0;
    int dn = 1;
    int nEnd = matrix.GetLength(1);
    Console.WriteLine("Координаты заполнения матрицы:");
    for (int i = 1; i <= columnLength * rowLength; i++)
    {
        int coner;
        Console.WriteLine($"m= {m}, n= {n}");
        matrix[m,n] = new Random().Next(min, max);
        if(Math.Abs(dn) == 1)
        {
            coner = n + dn;
        } else 
        {
            coner = m + dm;
        }
        if(coner < 0 || (dn == 1 && coner == nEnd) || (dm == 1 && coner == mEnd) || matrix[m + dm,n + dn] != 0)
        {
            int oldDn = dn;
            dn = dm * -1;
            dm = oldDn;
        }
        m += dm;
        n += dn;
    }
    return matrix;
}

int[,,] Create3DMatrix(int m, int n, int k, int min, int max)
{
    int[,,] matrix = new int[m, n, k];
    var dictionary = new Dictionary<int, (int, int, int)>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int f = 0; f < matrix.GetLength(2); f++)
            {
                int newElement;
                newElement = new Random().Next(min, max);
                while(dictionary.ContainsKey(newElement))
                {
                    newElement = new Random().Next(min, max);
                }
                dictionary[newElement] = (i, j, f);
                matrix[i, j, f] = newElement;
            }
        }
    }
    return matrix;
}


void Print2DMatrix(int[,] matrix)
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

void Print3DMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
            }
            Console.Write("\n");

        }
    }
}