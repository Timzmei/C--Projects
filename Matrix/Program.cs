
int[,] matrix = CreateArray(4, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine($"columnLengt = {matrix.GetLength(0)}");
Console.WriteLine($"rowLength = {matrix.GetLength(1)}");
int[,] matrixNew = RotateMatrixAnticlockwise(matrix);
PrintMatrix(matrixNew);
Console.WriteLine($"columnLengt = {matrixNew.GetLength(0)}");
Console.WriteLine($"rowLength = {matrixNew.GetLength(1)}");
int[,] matrixNew2 = RotateMatrixClockwise(matrix);
PrintMatrix(matrixNew2);


int[,] CreateArray(int columnLength, int rowLength, int min, int max)
{
    int[,] matrix = new int[columnLength, rowLength];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(min, max);
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("");

    }
}

int[,] RotateMatrixAnticlockwise(int[,] oldMatrix)
{
    int oldColumnLengt = oldMatrix.GetLength(0);
    int oldRowLength = oldMatrix.GetLength(1);
    int[,] newMatrix = new int[oldRowLength, oldColumnLengt];

    for (int i = 0; i < oldRowLength; i++)
    {
        for (int j = 0; j < oldColumnLengt; j++)
            newMatrix[i, j] = oldMatrix[j, oldRowLength - 1 - i];
    }
    return newMatrix;
}

int[,] RotateMatrixClockwise(int[,] oldMatrix)
{
    int oldColumnLengt = oldMatrix.GetLength(0);
    int oldRowLength = oldMatrix.GetLength(1);
    int[,] newMatrix = new int[oldRowLength, oldColumnLengt];

    for (int i = 0; i < oldRowLength; i++)
    {
        for (int j = 0; j < oldColumnLengt; j++)
            newMatrix[i, j] = oldMatrix[oldColumnLengt - 1 - j, i];
    }
    return newMatrix;
}