int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Для перемножения матриц A и B: ");

Console.WriteLine("Введите количество строк в матрице A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в матрице A (оно равно количеству строк в матрице B):");
int columnsArowsB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в матрице B: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

int[,] A = GetMatrix(rowsA, columnsArowsB, 0, 10);
Console.WriteLine();
Console.WriteLine("Матрица A: ");
PrintMatrix(A);

int[,] B = GetMatrix(columnsArowsB, columnsB, 0, 10);
Console.WriteLine();
Console.WriteLine("Матрица B: ");
PrintMatrix(B);
Console.WriteLine();

int[,] AxB = new int[rowsA, columnsB];
int result;
for (int i = 0; i < AxB.GetLength(0); i++)
{
    for (int j = 0; j < AxB.GetLength(1); j++)
    {
        result = 0;
        for (int k = 0; k < columnsArowsB; k++)
        {
            result += A[i, k] * B[k, j];
        }
        AxB[i, j] = result;
    }
}

Console.WriteLine();
Console.WriteLine("AxB:");
PrintMatrix(AxB);




