using System.Text;
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Задача 47. Решение
Console.WriteLine("Программа, которая задает двумерный массив размером mхn, заполненный случайными вещественными числами");

double[,] array = CreateArray(3, 4, -10, 10);
PrintMatrix(array);


// Задача 50. Решение
Console.WriteLine("\n\nПрограмма, которая на вход принимает позиции элемента в двумерном массиве,\n и возвращает значение этого элемента или же указание, что такого элемента нет.");

Console.WriteLine("Введите позиции элемента в двумерном массиве через пробел или запятую");
StringBuilder readNumbers = new StringBuilder(Console.ReadLine());
string[] position = readNumbers.Replace(",", " ").ToString().Split(" ",StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine(GetElementOfArray(int.Parse(position[0]), int.Parse(position[1]), array));


// Задача 52. Решение
Console.WriteLine("\n\nПрограмма, которая задает двумерный массив из целых чисел и находит среднее арифметическое элементов в каждом столбце двумерного массива");

int[,] arrayOfInt = CreateArrayOfIntElement(3, 4, -10, 10);
PrintMatrixInt(arrayOfInt);

Console.WriteLine("среднее арифметическое элементов в каждом столбце: " + string.Join("; ", GetAverageOnColumn(arrayOfInt)));


double[] GetAverageOnColumn(int[,] array)
{
    int sizeColumn = array.GetLength(1);
    double[] result = new double[sizeColumn];
    for(int i = 0; i < sizeColumn; i++)
    {
        double average = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            average += array[j, i];
        }
        result[i] = (double) average/sizeColumn;
    }
    return result;
}

    

string GetElementOfArray(int m, int n, double[,] array)
{
    try 
    {
        double elemet = array[m,n];
        return "Элемент с указанной позицией найден: " + elemet.ToString();
    } catch (Exception ex) 
    {
        return "Такого элемента нет";
    }
}



double[,] CreateArray(int columnLength, int rowLength, int min, int max)
{
    double[,] array = new double[columnLength, rowLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(min, max), 1);
    }
    return array;
}

int[,] CreateArrayOfIntElement(int columnLength, int rowLength, int min, int max)
{
    int[,] array = new int[columnLength, rowLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max);
    }
    return array;
}


void PrintMatrix(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}

void PrintMatrixInt(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}