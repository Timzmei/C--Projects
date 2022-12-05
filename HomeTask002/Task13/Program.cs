// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int firstNumber = ReadNumber("Введите число");

if(firstNumber / 100 > 0) {
    Console.WriteLine("Введеное число: " + firstNumber);

    Console.WriteLine("Третья цифра: " + GetThirdDitgit(firstNumber));


} else {
    Console.WriteLine("Третьей цифры нет");
}

int GetThirdDitgit(int number) {
    int result = number % 10;
    if (number / 1000 > 0) {
        result = GetThirdDitgit(number / 10);
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