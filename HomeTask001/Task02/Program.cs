// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


int firstNumber = ReadNumber("Введите 1-ое число");
int secondNumber = ReadNumber("Введите 2-ое число");
int thirdNumber = ReadNumber("Введите 3-ое число");

Console.WriteLine("Первое введенное число: " + firstNumber);
Console.WriteLine("Второе введенное число: " + secondNumber);
Console.WriteLine("Третье введенное число: " + thirdNumber);

int[] numbers = new int[] {firstNumber, secondNumber, thirdNumber};

CompareNumbers(numbers);

int ReadNumber(string text) {
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine();
    if (int.TryParse(readNumber, out number)) {} 
    else {
        Console.WriteLine("Введена какая-то фигня. Попытайтесь еще раз. Аккуратнее давите клаву");
        number = ReadNumber(text);
    }
    return number;
}

void CompareNumbers(int[] numbers) {
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++) {
        if (numbers[i] > max) {
            max = numbers[i];
        }
    }
    Console.WriteLine("Максимальное число: " + max);
   
}
