
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// оторая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// Задача 34. Решение

Console.WriteLine("Задача 34. Решение:");

int lengthArray = ReadNumber("Введите длину массива: ");
Console.WriteLine("Длина массива = " + lengthArray);
int[] array = CreateArray(lengthArray, 100, 999);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine("Количество четных чисел в массиве = " + FindEvenNumbersInArray(array));

// Задача 36. Решение
Console.WriteLine("Задача 36. Решение:");
int lengthArray1 = ReadNumber("Введите длину массива: ");
Console.WriteLine("Длина массива = " + lengthArray1);
int[] array1 = CreateArray(lengthArray1, -100, 100);
Console.WriteLine(string.Join(", ", array1));
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + GetSummElementsInOddPositions(array1));

// Задача 38. Решение
Console.WriteLine("Задача 38. Решение:");
int lengthArray2 = ReadNumber("Введите длину массива: ");
Console.WriteLine("Длина массива = " + lengthArray2);
int[] array2 = CreateArray(lengthArray2, -100, 100);
Console.WriteLine(string.Join(", ", array2));

// 1 Способ
Console.WriteLine("2 Способ. Решение:");
Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + GetDiffMaxMinElementsArray(array2));

// 2 Способ
Console.WriteLine("2 Способ. Решение:");
int minElArray;
int maxElArray;
GetMaxMinElementsArray(array2, out minElArray, out maxElArray);
Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + (maxElArray - minElArray));



int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int ReadNumber(string text)
{
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine() ?? "Nullable";
    if (int.TryParse(readNumber, out number)) { }
    else
    {
        Console.WriteLine("Ввод некорректный. Вводите только цифры");
        number = ReadNumber(text);
    }
    return number;
}

int FindEvenNumbersInArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int GetSummElementsInOddPositions(int[] array)
{
    int summ = 0;
    for(int i = 0; i < array.Length; i+=2)
    {
        summ += array[i];
    }
    return summ;
}

int GetDiffMaxMinElementsArray(int[] array)
{
    int min = array[0];
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"max={max}, min={min}");
    return max - min;
}

bool GetMaxMinElementsArray(int[] array, out int min, out int max)
{
    min = array[0];
    max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"max={max}, min={min}");
    return true;
}

