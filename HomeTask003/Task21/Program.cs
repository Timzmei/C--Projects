// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int[] coordinateA = new int[3];
coordinateA = ReadCoordinate("Введите координаты точки A\n");
int[] coordinateB = new int[3];
coordinateB = ReadCoordinate("Введите координаты точки B\n");

Console.WriteLine("Расстояние между точками А и В = " + GetLength(coordinateA, coordinateB));

TestGetLength();



int[] ReadCoordinate(string text) {
    Console.WriteLine(text);
    int[] number = new int[3];

    int x = ReadNumber("Введите координату x");
    int y = ReadNumber("Введите координату y");
    int z = ReadNumber("Введите координату z");

    number[0] = x;
    number[1] = y;
    number[2] = z;


    return number;
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

double GetLength(int[] a, int[] b) {
    int lengthX = Math.Abs(a[0] - b[0]);
    int lengthY = Math.Abs(a[1] - b[1]);
    int lengthZ = Math.Abs(a[2] - b[2]);


    double lengthXY = Math.Sqrt(lengthX * lengthX + lengthY * lengthY);
    double lengthXYZ = Math.Sqrt(lengthXY * lengthXY + lengthZ * lengthZ);

    return Math.Abs(lengthXYZ);
}

void TestGetLength() {
    int[][] a = new int[][] {
        new int[] {3, 6, 8},
        new int[] {7,-5, 0}};
    int[][] b = new int[][] {
        new int[]{2, 1, -7},
        new int[] {1, -1, 9}};
    double[] c = new double[] {15.84, 11.53};

    for (int i = 0; i < c.Length; i++) {
        double result = Math.Round(GetLength(a[i], b[i]), 2);
        Console.WriteLine(result);
        Console.WriteLine(c[i]);
        if (result == c[i]) {
            Console.WriteLine("Все ОК" + result + " = " + c[i]);
        } else {
            Console.WriteLine("Bad result" + result + " != " + c[i]);
        }
    }
}