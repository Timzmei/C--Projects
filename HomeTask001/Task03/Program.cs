// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


int number = ReadNumber("Введите число");
Console.WriteLine("Введенное число: " + number);
CheckNumber(number);


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

void CheckNumber(int number) {
    if (number % 2 == 0) {
        Console.WriteLine("Введенное число четное");
    } else {
        Console.WriteLine("Введенное число нечетное");
    }
}
