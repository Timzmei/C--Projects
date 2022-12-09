using System;
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int number = ReadNumber("Введите число N");
Console.WriteLine("количество цифр в числе: " + GetCountDitgitNumber(number));
Console.WriteLine("произведение чисел от 1 до N: " + GetMultiplicationNumber(number));
PrintArray(GetArray(8));



int ReadNumber(string text) {
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine() ?? "Nullable";
    if (int.TryParse(readNumber, out number)) {}
    else {
        Console.WriteLine("Ввод некорректный. Вводите только цифры");
        number = ReadNumber(text);
    }
    return number;
}


int GetCountDitgitNumber(int number) {
    int count = 0;
    while (number > 0) {
        number = number / 10;
        count++;
    }
    return count;
}

long GetMultiplicationNumber(int number) {
    if(number == 0) {
        Console.WriteLine("Нулик");
        return 0;
    }
    long result = 1;
    for(int i = 1; i <= number; i++) {
        result = result * i;
    }
    return result;
}

int[] GetArray(int n) {
    int[] array = new int[n];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array) {

    Console.Write("массив из 8 элементов, заполненный нулями и единицами в случайном порядке: [");
    for(int i = 0; i < array.Length; i++) {
        if(i < array.Length -1) {
            Console.Write($"{array[i]}, ");
        } else {
            Console.WriteLine($"{array[i]}]");

        }
        
    }
}