// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int number = ReadNumber("Введите число");
Console.WriteLine("Введенное число: " + number);
PrintEvenNumbers(number);


int ReadNumber(string text) {
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine() ?? "Nullable";
    if (int.TryParse(readNumber, out number)) {} 
    else {
        Console.WriteLine("Введена какая-то фигня. Попытайтесь еще раз. Аккуратнее давите клаву");
        number = ReadNumber(text);
    }
    return number;
}

void PrintEvenNumbers(int number) {
    Console.WriteLine("Четные числа от 0 до " + number + ":");

    for (int i = 0; i < number; i++)
    if (i % 2 == 0) {
        Console.WriteLine(i);
    } 
}
