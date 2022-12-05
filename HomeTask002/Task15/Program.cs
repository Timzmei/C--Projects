// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int number = ReadNumber("Введите цифру, обозначающую день недели (от 1 до 7)");

if(number == 7 || number == 6) {
    Console.WriteLine("да");
} else {
    Console.WriteLine("нет");
}


int ReadNumber(string text) {
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine() ?? "Nullable";
    if (int.TryParse(readNumber, out number)) {
        if (number < 1 || number > 7) {
            Console.WriteLine("Ввод некорректный. Вводите цифру от 1 до 7");
            number = ReadNumber(text);        
        }
    } 
    else {
        Console.WriteLine("Ввод некорректный. Вводите только цифру");
        number = ReadNumber(text);
    }
    return number;
}