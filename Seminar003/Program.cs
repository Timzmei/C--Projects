// using Internal;
// using Internal;
// using System;
// Задача No18. Общее обсуждение
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Задача No21. Работа в группах
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

// Задача No22. Работа в группах
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

// int number = ReadNumber("Введите номер четверти");

// switch (number)
// {
//     case 1: 
//         WriteNumber("Диапазон: x>0, y>0");
//         break;
//     case 2: 
//         WriteNumber("Диапазон: x>0, y<0");
//         break;
//     case 3: 
//         WriteNumber("Диапазон: x<0, y<0");
//         break;
//     case 4: 
//         WriteNumber("Диапазон: x<0, y>0");
//         break;
// }


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

// void WriteNumber(string text) {
// Console.WriteLine(text);
// }


// //Задача №2
// int[] coordinateA = new int[2];
// coordinateA = ReadCoordinate("Введите координаты точки A\n");
// int[] coordinateB = new int[2];
// coordinateB = ReadCoordinate("Введите координаты точки B\n");

// Console.WriteLine("Расстояние между точками А и В = " + GetLength(coordinateA, coordinateB));



// int[] ReadCoordinate(string text) {
//     Console.WriteLine(text);
//     int[] number = new int[2];

//     int x = ReadNumber("Введите координату x");
//     int y = ReadNumber("Введите координату y");
//     number[0] = x;
//     number[1] = y;

//     return number;
// }

double GetLength(int[] a, int[] b) {
    int lengthX = Math.Abs(a[0] - b[0]);
    int lengthY = Math.Abs(a[1] - b[1]);

    double lengthZ = Math.Sqrt(lengthX * lengthX + lengthY * lengthY);

    return lengthZ;
}


// //Задача №3

// int number = ReadNumber("Введите число");
// Console.WriteLine("Введенное число: " + number);
// PrintEvenNumbers(number);

// void PrintEvenNumbers(int number) {
//     Console.WriteLine("Квадраты числа от 0 до " + number + ":");

//     for (int i = 1; i <= number; i++)
//         Console.WriteLine(i * i);

// }



// void TestGetLength() {
//     int[][] a = new int[][] {
//         new int[] {3,6},
//         new int[] {7,-5}};
//     int[][] b = new int[][] {
//         new int[]{2,1},
//         new int[] {1,-1}};
//     double[] c = new double[] {5.1, 7.21};

//     for (int i = 0; i < c.Length; i++) {
//         double result = Math.Round(GetLength(a[i], b[i]), 2);
//         Console.WriteLine(result);
//         Console.WriteLine(c[i]);
//         if (result == c[i]) {
//             Console.WriteLine("Все ОК");
//         } else {
//             Console.WriteLine("Bad result");
//         }
//     }
// }

// TestGetLength();