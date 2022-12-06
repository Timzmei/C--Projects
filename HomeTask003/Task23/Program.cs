// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int number = ReadNumber("Введите число");
Console.WriteLine("Введенное число: " + number);
int[] cubeNumbers = GetCubeNumbers(number);
Console.WriteLine("Квадраты числа от 1 до " + number + ":");
PrintArray(cubeNumbers);



int[] GetCubeNumbers(int number) {
    int[] cubeNumbers = new int[number];
    for (int i = 0; i < cubeNumbers.Length; i++) {
        cubeNumbers[i] = (i+1) * (i+1) * (i+1);
    }
    return cubeNumbers;
}

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        if (i < array.Length - 1) {
            Console.Write(array[i] + ", ");
        } else {
            Console.WriteLine(array[i]);
        }
    }
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