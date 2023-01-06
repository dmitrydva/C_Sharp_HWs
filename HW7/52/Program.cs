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

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(rows, columns, 0, 10);
PrintMatrix(result);

double[] AvgColumn = new double[result.GetLength(1)];
double sum = 0;

for (int j = 0; j < result.GetLength(1); j++)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        sum += result[i, j];
    }
    AvgColumn[j] = sum / result.GetLength(0);
    sum = 0;
}
Console.Write("Среднее арифметическое каждого столбца: ");
Console.WriteLine(String.Join("; ", AvgColumn) + ".");



