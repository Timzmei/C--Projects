using System.Reflection;
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// int[] array = new int[] { 1, -2, 3, -4, 5, -6, 7, -8 };

// //Задача 33
// Console.WriteLine(SearchNumberInArray(12, array));
// Console.WriteLine(SearchNumberInArray(1, array));


// //Задача 32

// Console.WriteLine(string.Join(",", ChangeArray(array)));

// int[] array1 = CreateArray(123);
// Console.WriteLine(string.Join(",", array1));
// Console.WriteLine(SearchCountNumberInArray(array1, 10, 99));





// int[] ChangeArray(int[] array)
// {
//     int[] newArray = new int[array.Length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i] * -1;
//     }
//     return newArray;
// }


// string SearchNumberInArray(int number, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return "да";
//         }
//     }
//     return "нет";
// }

// // Задача 35
int[] CreateArray(int size) 
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

// int SearchCountNumberInArray(int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= min && array[i] <= max) {
//             count++;
//         }
//     }
//     return count;
// }

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array2 = CreateArray(5);
Console.WriteLine(string.Join(",", array2));

int[] pairs = GetPairsInArray(array2);
Console.WriteLine(string.Join(",", pairs));


int[] GetPairsInArray (int[] array) 
{
    int lengthPairs; //длина массива "произведение пар"
    bool count;
    // Поиск этой длины
    if (array.Length % 2 == 0)
    {
        lengthPairs = array.Length / 2;
        count = true;
    } else{
        lengthPairs = array.Length / 2 + 1;
        count = false;
    }

    int[] pairs = new int[lengthPairs];

    for (int i =0; i < pairs.Length - 1; i++) 
    {
        pairs[i] = array[i] * array[array.Length - 1 - i];
    }

    if(count)
    {
        pairs[pairs.Length - 1] = array[array.Length / 2] * array[array.Length/2 - 1];
    } else {
        pairs[pairs.Length - 1] = array[array.Length / 2];
    }

    return pairs;
}




