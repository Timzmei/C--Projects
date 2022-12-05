// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int firstNumber = ReadNumber("Введите 1-ое число");
int secondNumber = ReadNumber("Введите 2-ое число");

Console.WriteLine("Первое введенное число: " + firstNumber);
Console.WriteLine("Второе введенное число: " + secondNumber);

CompareNumbers(firstNumber, secondNumber);

int ReadNumber(string text) {
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine() ?? "Nullable";
    if (int.TryParse(readNumber, out number)) {} 
    else {
        Console.WriteLine("Введена какая-то фигня");
        number = ReadNumber(text);
    }
    return number;
}

void CompareNumbers(int number1, int number2) {
    if (number1 < number2) {
        Console.WriteLine("Первое введенное число " + number1 + " меньше второго " + number2);
    } else if (number1 == number2) {
        Console.WriteLine("Первое введенное число " + number1 + " равно второму " + number2);
    } else {
        Console.WriteLine("Первое введенное число " + number1 + " больше второго " + number2);
    }
}





