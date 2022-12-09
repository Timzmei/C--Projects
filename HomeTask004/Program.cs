// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Задача 25. Решение:
Console.WriteLine("Задача 25. Решение:");

int a = ReadNumber("Введите число a: ");
Console.WriteLine("a = " + a);
int b = ReadNumber("Введите степень числа b: ");
Console.WriteLine("b = " + b);

Console.WriteLine("a в степени b = " + GetExponential(a, b));

// Задача 27. Решение
Console.WriteLine("\n\nЗадача 27. Решение:");

int number = ReadNumber("Введите число N: ");
Console.WriteLine("N = " + number);
Console.WriteLine("Сумма чисел числа N = " + GetSumDitgitsOfNumber(number));

// Задача 29. Решение
Console.WriteLine("\n\nЗадача 29. Решение:");

PrintArray(GetArray(8));



string[] GetArray(int number) {
    string[] array = new string[number];

    for(int i = 0; i < array.Length; i++) {
        Console.WriteLine($"Введите {i + 1} элемент массива:");
        array[i] = Console.ReadLine();
    }

    return array;
}



int GetSumDitgitsOfNumber(int number) {
    int count = 0;
    while (number > 0) {
        count = count + number % 10;
        number = number / 10;
    }
    return count;
}


double GetExponential(int a, int b) {
    double result = 1;
    if(b == 0) {
        return 1;
    }

    for(int i = 0; i < Math.Abs(b); i++) {
        result = result * a;
    }

    if(b < 0) {
        return 1 / result;
    }

    return result;
}


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


void PrintArray(string[] array) {

    Console.Write("[");
    for(int i = 0; i < array.Length; i++) {
        if(i < array.Length -1) {
            Console.Write($"{array[i]}, ");
        } else {
            Console.WriteLine($"{array[i]}]");

        }
        
    }
}