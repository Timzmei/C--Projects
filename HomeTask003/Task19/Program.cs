// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int number = ReadNumber("Введите число");
Console.WriteLine("Введенное число: " + number);

Console.WriteLine(CheckPolyndrom(GetArray(number)));

int[] GetArray(int number) {
    int length = 0;
    int tempNumber = number;
    if (tempNumber > 0) {
        length++;
        tempNumber = tempNumber / 10;
    }

    int[] array = new int[length];

    for (int i = 0; i < length; i++) {
        array[i] = number % 10;
        number = number / 10;
    }

    return array;

}

bool CheckPolyndrom(int[] array) {
    for (int i = 0; i < array.Length / 2; i++) {
        if(array[i] != array[array.Length - 1 - i]) {
            return false;
        }
    }
    return true;
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
